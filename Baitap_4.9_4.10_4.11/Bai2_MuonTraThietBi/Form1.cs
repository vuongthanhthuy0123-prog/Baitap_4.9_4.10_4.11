using System.ComponentModel;
using System.Text;

namespace Bai2
{
    public partial class Form1 : Form
    {
        // Danh sách gốc chứa TẤT CẢ phiếu mượn
        private readonly BindingList<PhieuMuon> dsPhieu = new BindingList<PhieuMuon>();

        // Danh sách đang hiển thị trên bảng (kết quả sau khi tìm kiếm / lọc)
        private readonly BindingList<PhieuMuon> dsHienThi = new BindingList<PhieuMuon>();

        // Bật lên khi đang nạp lại bảng, để không tự đổ dữ liệu lên ô nhập
        private bool dangNapBang = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPhieu.AutoGenerateColumns = false;       // chỉ dùng các cột tự cấu hình
            bsPhieu.DataSource = dsHienThi;
            dgvPhieu.DataSource = bsPhieu;

            cboLocTinhTrang.SelectedIndex = 0;          // "Tất cả"
            LamMoiONhap();
            ApDungLoc();
        }

        // ===================== TÌM KIẾM & LỌC =====================

        private void ApDungLoc()
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            string tinhTrangLoc = cboLocTinhTrang.SelectedIndex > 0 ? cboLocTinhTrang.Text : "";

            List<PhieuMuon> ketQua = dsPhieu.Where(p =>
                    (tuKhoa == "" || p.MaSV.ToLower().Contains(tuKhoa) || p.ThietBi.ToLower().Contains(tuKhoa))
                    && (tinhTrangLoc == "" || p.TinhTrang == tinhTrangLoc))
                .ToList();

            dangNapBang = true;
            dgvPhieu.CurrentCell = null;
            dsHienThi.RaiseListChangedEvents = false;
            dsHienThi.Clear();
            foreach (PhieuMuon x in ketQua) dsHienThi.Add(x);
            dsHienThi.RaiseListChangedEvents = true;
            bsPhieu.ResetBindings(false);
            dgvPhieu.ClearSelection();
            dangNapBang = false;

            // Thống kê trên StatusStrip
            lblTongPhieu.Text = "Tổng số phiếu: " + dsPhieu.Count;
            lblQuaHan.Text = "Quá hạn: " + dsPhieu.Count(p => p.TinhTrang == "Quá hạn");
            lblDangHienThi.Text = "Đang hiển thị: " + ketQua.Count;
        }

        private void BoLoc_Changed(object sender, EventArgs e)
        {
            ApDungLoc();
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocTinhTrang.SelectedIndex = 0;
            ApDungLoc();
        }

        // Tô màu theo tình trạng cho dễ nhìn
        private void dgvPhieu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || dgvPhieu.Columns[e.ColumnIndex] != colTinhTrang) return;
            string tt = e.Value as string;
            if (tt == "Quá hạn") e.CellStyle.ForeColor = Color.Firebrick;
            else if (tt == "Đã trả") e.CellStyle.ForeColor = Color.SeaGreen;
            else e.CellStyle.ForeColor = Color.RoyalBlue;
        }

        // ===================== CHỌN DÒNG -> ĐƯA LÊN Ô NHẬP =====================

        private PhieuMuon DongDangChon()
        {
            if (dgvPhieu.SelectedRows.Count == 0) return null;
            return dgvPhieu.SelectedRows[0].DataBoundItem as PhieuMuon;
        }

        private void dgvPhieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dangNapBang) return;
            PhieuMuon p = DongDangChon();
            if (p == null) return;

            errorProvider1.Clear();
            txtMaPhieu.Text = p.MaPhieu;
            txtMaSV.Text = p.MaSV;
            txtHoTen.Text = p.HoTenSV;
            cboThietBi.SelectedItem = p.ThietBi;
            numSoLuong.Value = p.SoLuong;
            dtpNgayMuon.Value = p.NgayMuon;
            dtpHanTra.Value = p.HanTra;
            dtpNgayTra.Value = p.NgayTraThucTe ?? DateTime.Today;
            dtpNgayTra.Checked = p.NgayTraThucTe.HasValue;
            CapNhatOTinhTrang();
        }

        private void ChonDong(PhieuMuon p)
        {
            foreach (DataGridViewRow row in dgvPhieu.Rows)
            {
                if (row.DataBoundItem == p)
                {
                    dgvPhieu.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    return;
                }
            }
        }

        // Đổi ngày nào thì ô "Tình trạng" tự tính lại ngay
        private void NgayThayDoi(object sender, EventArgs e)
        {
            CapNhatOTinhTrang();
        }

        private void CapNhatOTinhTrang()
        {
            DateTime? ngayTra = dtpNgayTra.Checked ? dtpNgayTra.Value.Date : (DateTime?)null;
            string tt = PhieuMuon.XacDinhTinhTrang(dtpHanTra.Value.Date, ngayTra);
            txtTinhTrang.Text = tt;
            txtTinhTrang.ForeColor = tt == "Quá hạn" ? Color.Firebrick : tt == "Đã trả" ? Color.SeaGreen : Color.RoyalBlue;
        }

        // ===================== KIỂM TRA DỮ LIỆU =====================

        // dangSua = phiếu đang sửa (null nếu thêm mới). Trả về null nếu có lỗi.
        private PhieuMuon DocONhap(PhieuMuon dangSua)
        {
            errorProvider1.Clear();
            List<string> loi = new List<string>();

            string ma = txtMaPhieu.Text.Trim();
            string maSV = txtMaSV.Text.Trim();
            DateTime ngayMuon = dtpNgayMuon.Value.Date;
            DateTime hanTra = dtpHanTra.Value.Date;
            DateTime? ngayTra = dtpNgayTra.Checked ? dtpNgayTra.Value.Date : (DateTime?)null;

            if (ma == "")
                BaoLoi(txtMaPhieu, "Mã phiếu không được để trống.", loi);
            else if (dsPhieu.Any(x => x != dangSua && string.Equals(x.MaPhieu, ma, StringComparison.OrdinalIgnoreCase)))
                BaoLoi(txtMaPhieu, "Mã phiếu \"" + ma + "\" đã tồn tại.", loi);

            if (maSV == "")
                BaoLoi(txtMaSV, "Mã sinh viên không được để trống.", loi);

            if (cboThietBi.SelectedIndex < 0)
                BaoLoi(cboThietBi, "Vui lòng chọn thiết bị.", loi);

            if (numSoLuong.Value <= 0)
                BaoLoi(numSoLuong, "Số lượng phải lớn hơn 0.", loi);

            if (hanTra < ngayMuon)
                BaoLoi(dtpHanTra, "Hạn trả không được trước ngày mượn.", loi);

            if (ngayTra.HasValue && ngayTra.Value < ngayMuon)
                BaoLoi(dtpNgayTra, "Ngày trả thực tế không được trước ngày mượn.", loi);

            if (loi.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n\n• " + string.Join("\n• ", loi), "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new PhieuMuon
            {
                MaPhieu = ma,
                MaSV = maSV,
                HoTenSV = txtHoTen.Text.Trim(),
                ThietBi = cboThietBi.Text,
                SoLuong = (int)numSoLuong.Value,
                NgayMuon = ngayMuon,
                HanTra = hanTra,
                NgayTraThucTe = ngayTra
            };
        }

        private void BaoLoi(Control c, string thongBao, List<string> loi)
        {
            errorProvider1.SetError(c, thongBao);
            loi.Add(thongBao);
        }

        // ===================== THÊM / CẬP NHẬT / XÓA =====================

        private void btnThem_Click(object sender, EventArgs e)
        {
            PhieuMuon moi = DocONhap(null);
            if (moi == null) return;

            if (MessageBox.Show("Thêm phiếu mượn " + moi.MaPhieu + " (" + moi.MaSV + " mượn " + moi.SoLuong + " " + moi.ThietBi + ")?",
                    "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            dsPhieu.Add(moi);
            ApDungLoc();
            ChonDong(moi);
            lblThongBao.Text = "Đã thêm phiếu " + moi.MaPhieu + " - " + moi.TinhTrang;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            PhieuMuon cu = DongDangChon();
            if (cu == null)
            {
                MessageBox.Show("Hãy chọn 1 phiếu trong bảng để cập nhật.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PhieuMuon moi = DocONhap(cu);
            if (moi == null) return;

            if (MessageBox.Show("Lưu thay đổi cho phiếu " + cu.MaPhieu + "?", "Xác nhận cập nhật",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            cu.MaPhieu = moi.MaPhieu;
            cu.MaSV = moi.MaSV;
            cu.HoTenSV = moi.HoTenSV;
            cu.ThietBi = moi.ThietBi;
            cu.SoLuong = moi.SoLuong;
            cu.NgayMuon = moi.NgayMuon;
            cu.HanTra = moi.HanTra;
            cu.NgayTraThucTe = moi.NgayTraThucTe;

            ApDungLoc();
            ChonDong(cu);
            lblThongBao.Text = "Đã cập nhật phiếu " + cu.MaPhieu + " - " + cu.TinhTrang;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuMuon p = DongDangChon();
            if (p == null)
            {
                MessageBox.Show("Hãy chọn 1 phiếu trong bảng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phiếu " + p.MaPhieu + "?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            dsPhieu.Remove(p);
            ApDungLoc();
            LamMoiONhap();
            lblThongBao.Text = "Đã xóa phiếu " + p.MaPhieu;
        }

        // Đánh dấu đã trả: ngày trả thực tế = hôm nay, tình trạng -> "Đã trả"
        private void btnDaTra_Click(object sender, EventArgs e)
        {
            PhieuMuon p = DongDangChon();
            if (p == null)
            {
                MessageBox.Show("Hãy chọn 1 phiếu trong bảng để đánh dấu đã trả.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (p.NgayTraThucTe.HasValue)
            {
                MessageBox.Show("Phiếu " + p.MaPhieu + " đã được trả ngày " + p.NgayTraThucTe.Value.ToString("dd/MM/yyyy") + ".",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DateTime.Today < p.NgayMuon.Date)
            {
                MessageBox.Show("Ngày trả thực tế (hôm nay) không được trước ngày mượn " + p.NgayMuon.ToString("dd/MM/yyyy") + ".",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Xác nhận phiếu " + p.MaPhieu + " đã trả hôm nay (" + DateTime.Today.ToString("dd/MM/yyyy") + ")?",
                    "Đánh dấu đã trả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            p.NgayTraThucTe = DateTime.Today;
            ApDungLoc();
            ChonDong(p);
            lblThongBao.Text = "Phiếu " + p.MaPhieu + " đã trả ngày " + DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiONhap();
        }

        private void LamMoiONhap()
        {
            errorProvider1.Clear();
            dgvPhieu.ClearSelection();
            txtMaPhieu.Clear();
            txtMaSV.Clear();
            txtHoTen.Clear();
            cboThietBi.SelectedIndex = -1;
            numSoLuong.Value = 0;
            dtpNgayMuon.Value = DateTime.Today;
            dtpHanTra.Value = DateTime.Today;
            dtpNgayTra.Value = DateTime.Today;
            dtpNgayTra.Checked = false;
            CapNhatOTinhTrang();
            txtMaPhieu.Focus();
        }

        // ===================== MENU =====================

        private void mnuXuatCsv_Click(object sender, EventArgs e)
        {
            List<PhieuMuon> dangLoc = dsHienThi.ToList();
            if (dangLoc.Count == 0)
            {
                MessageBox.Show("Không có phiếu nào đang hiển thị để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            saveFileDialog1.FileName = "PhieuMuon_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mã phiếu;Mã SV;Họ tên SV;Thiết bị;Số lượng;Ngày mượn;Hạn trả;Ngày trả thực tế;Tình trạng");
            foreach (PhieuMuon p in dangLoc)
            {
                sb.AppendLine(string.Join(";", new[]
                {
                    Csv(p.MaPhieu), Csv(p.MaSV), Csv(p.HoTenSV), Csv(p.ThietBi), p.SoLuong.ToString(),
                    p.NgayMuon.ToString("dd/MM/yyyy"), p.HanTra.ToString("dd/MM/yyyy"),
                    p.NgayTraThucTe.HasValue ? p.NgayTraThucTe.Value.ToString("dd/MM/yyyy") : "",
                    Csv(p.TinhTrang)
                }));
            }

            try
            {
                File.WriteAllText(saveFileDialog1.FileName, sb.ToString(), new UTF8Encoding(true));
                lblThongBao.Text = "Đã xuất " + dangLoc.Count + " phiếu ra " + Path.GetFileName(saveFileDialog1.FileName);
                MessageBox.Show("Đã xuất " + dangLoc.Count + " phiếu ra file:\n" + saveFileDialog1.FileName, "Xuất CSV",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không ghi được file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string Csv(string s)
        {
            s = s ?? "";
            if (s.Contains(';') || s.Contains('"') || s.Contains('\n') || s.Contains('\r'))
                return "\"" + s.Replace("\"", "\"\"") + "\"";
            return s;
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thoát",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
