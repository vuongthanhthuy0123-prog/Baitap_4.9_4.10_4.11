using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Bai3
{
    public partial class Form1 : Form
    {
        private readonly CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");

        // Danh sách gốc chứa TẤT CẢ đơn sửa chữa
        private readonly BindingList<DonSuaChua> dsDon = new BindingList<DonSuaChua>();

        // Danh sách đang hiển thị trên bảng (kết quả sau khi tìm kiếm / lọc)
        private readonly BindingList<DonSuaChua> dsHienThi = new BindingList<DonSuaChua>();

        // Đường dẫn ảnh đang hiện trên PictureBox ("" = chưa có ảnh)
        private string anhDangChon = "";

        // Bật lên khi đang nạp lại bảng, để không tự đổ dữ liệu lên ô nhập
        private bool dangNapBang = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDon.AutoGenerateColumns = false;               // chỉ dùng các cột tự định nghĩa
            colChiPhi.DefaultCellStyle.FormatProvider = vi;   // "N0" kiểu Việt Nam: 1.500.000
            bsDon.DataSource = dsHienThi;
            dgvDon.DataSource = bsDon;

            cboLocTrangThai.SelectedIndex = 0;                // "Tất cả"
            LamMoiONhap();
            ApDungLoc();
        }

        // ===================== TÌM KIẾM & LỌC =====================

        private void ApDungLoc()
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            string trangThaiLoc = cboLocTrangThai.SelectedIndex > 0 ? cboLocTrangThai.Text : "";

            List<DonSuaChua> ketQua = dsDon.Where(d =>
                    (tuKhoa == "" || d.MaDon.ToLower().Contains(tuKhoa)
                                  || d.TenKhachHang.ToLower().Contains(tuKhoa)
                                  || d.SoDienThoai.Contains(tuKhoa))
                    && (trangThaiLoc == "" || d.TrangThai == trangThaiLoc))
                .ToList();

            dangNapBang = true;
            dgvDon.CurrentCell = null;
            dsHienThi.RaiseListChangedEvents = false;
            dsHienThi.Clear();
            foreach (DonSuaChua x in ketQua) dsHienThi.Add(x);
            dsHienThi.RaiseListChangedEvents = true;
            bsDon.ResetBindings(false);
            dgvDon.ClearSelection();
            dangNapBang = false;

            // StatusStrip: số đơn theo bộ lọc + tổng chi phí các đơn chưa hoàn tất
            decimal tong = ketQua.Where(d => d.ChuaHoanTat).Sum(d => d.ChiPhiDuKien);
            lblSoDon.Text = "Số đơn: " + ketQua.Count + " / " + dsDon.Count;
            lblTongChiPhi.Text = "Tổng chi phí dự kiến (chưa hoàn tất): " + tong.ToString("N0", vi) + " đ";
        }

        private void BoLoc_Changed(object sender, EventArgs e)
        {
            ApDungLoc();
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cboLocTrangThai.SelectedIndex = 0;
            ApDungLoc();
        }

        // ===================== CHỌN DÒNG -> ĐƯA LÊN Ô NHẬP =====================

        private DonSuaChua DongDangChon()
        {
            if (dgvDon.SelectedRows.Count == 0) return null;
            return dgvDon.SelectedRows[0].DataBoundItem as DonSuaChua;
        }

        private void dgvDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dangNapBang) return;
            DonSuaChua d = DongDangChon();
            if (d == null) return;

            errorProvider1.Clear();
            txtMaDon.Text = d.MaDon;
            txtTenKH.Text = d.TenKhachHang;
            txtSDT.Text = d.SoDienThoai;
            cboLoai.SelectedItem = d.LoaiThietBi;
            txtMoTa.Text = d.MoTaLoi;
            dtpNgayTiepNhan.Value = d.NgayTiepNhan;
            txtChiPhi.Text = d.ChiPhiDuKien.ToString("N0", vi);
            cboTrangThai.SelectedItem = d.TrangThai;
            HienAnh(d.DuongDanAnh);
        }

        private void ChonDong(DonSuaChua d)
        {
            foreach (DataGridViewRow row in dgvDon.Rows)
            {
                if (row.DataBoundItem == d)
                {
                    dgvDon.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    return;
                }
            }
        }

        // ===================== ẢNH THIẾT BỊ =====================

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            HienAnh(openFileDialog1.FileName);
        }

        private void btnBoAnh_Click(object sender, EventArgs e)
        {
            HienAnh("");
        }

        // Hiện ảnh lên PictureBox (SizeMode = Zoom nên ảnh không bị méo)
        private void HienAnh(string duongDan)
        {
            Image cu = picAnh.Image;
            picAnh.Image = null;
            if (cu != null) cu.Dispose();
            anhDangChon = "";

            if (string.IsNullOrEmpty(duongDan) || !File.Exists(duongDan)) return;
            try
            {
                // Đọc qua MemoryStream để không bị khóa file ảnh
                byte[] bytes = File.ReadAllBytes(duongDan);
                using (MemoryStream ms = new MemoryStream(bytes))
                using (Image tam = Image.FromStream(ms))
                {
                    picAnh.Image = new Bitmap(tam);
                }
                anhDangChon = duongDan;
            }
            catch (Exception)
            {
                MessageBox.Show("File đã chọn không phải ảnh hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ===================== KIỂM TRA DỮ LIỆU =====================

        // dangSua = đơn đang sửa (null nếu thêm mới). Trả về null nếu có lỗi.
        private DonSuaChua DocONhap(DonSuaChua dangSua)
        {
            errorProvider1.Clear();
            List<string> loi = new List<string>();

            string ma = txtMaDon.Text.Trim();
            string ten = txtTenKH.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            decimal chiPhi = 0;

            if (ma == "")
                BaoLoi(txtMaDon, "Mã đơn không được để trống.", loi);
            else if (dsDon.Any(x => x != dangSua && string.Equals(x.MaDon, ma, StringComparison.OrdinalIgnoreCase)))
                BaoLoi(txtMaDon, "Mã đơn \"" + ma + "\" đã tồn tại.", loi);

            if (ten == "")
                BaoLoi(txtTenKH, "Tên khách hàng không được để trống.", loi);

            if (sdt == "")
                BaoLoi(txtSDT, "Số điện thoại không được để trống.", loi);
            else if (!Regex.IsMatch(sdt, @"^[0-9 .+]+$"))
                BaoLoi(txtSDT, "Số điện thoại chỉ được chứa chữ số.", loi);

            if (cboLoai.SelectedIndex < 0)
                BaoLoi(cboLoai, "Vui lòng chọn loại thiết bị.", loi);

            if (txtChiPhi.Text.Trim() == "")
                BaoLoi(txtChiPhi, "Chi phí dự kiến không được để trống.", loi);
            else if (!DocSoLinhHoat(txtChiPhi.Text, out chiPhi))
                BaoLoi(txtChiPhi, "Chi phí dự kiến phải là số.", loi);
            else if (chiPhi < 0)
                BaoLoi(txtChiPhi, "Chi phí dự kiến không được âm.", loi);

            if (cboTrangThai.SelectedIndex < 0)
                BaoLoi(cboTrangThai, "Vui lòng chọn trạng thái.", loi);

            if (moTa == "")
                BaoLoi(txtMoTa, "Mô tả lỗi không được để trống.", loi);

            if (loi.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n\n• " + string.Join("\n• ", loi), "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new DonSuaChua
            {
                MaDon = ma,
                TenKhachHang = ten,
                SoDienThoai = sdt,
                LoaiThietBi = cboLoai.Text,
                MoTaLoi = moTa,
                NgayTiepNhan = dtpNgayTiepNhan.Value.Date,
                ChiPhiDuKien = chiPhi,
                TrangThai = cboTrangThai.Text,
                DuongDanAnh = anhDangChon
            };
        }

        private void BaoLoi(Control c, string thongBao, List<string> loi)
        {
            errorProvider1.SetError(c, thongBao);
            loi.Add(thongBao);
        }

        // Đọc số linh hoạt: chấp nhận 1500000, 1.500.000, 1,500,000
        private static bool DocSoLinhHoat(string s, out decimal ketQua)
        {
            ketQua = 0;
            s = (s ?? "").Trim().Replace(" ", "").Replace("đ", "");
            if (s == "") return false;

            CultureInfo vi = CultureInfo.GetCultureInfo("vi-VN");
            CultureInfo en = CultureInfo.InvariantCulture;
            bool coCham = s.IndexOf('.') >= 0;
            bool coPhay = s.IndexOf(',') >= 0;

            if (coCham && coPhay)
                return decimal.TryParse(s, NumberStyles.Number, s.LastIndexOf(',') > s.LastIndexOf('.') ? vi : en, out ketQua);
            if (coPhay && Regex.IsMatch(s, @"^-?\d{1,3}(,\d{3})+$"))
                return decimal.TryParse(s, NumberStyles.Number, en, out ketQua);    // 1,500,000
            if (coPhay)
                return decimal.TryParse(s, NumberStyles.Number, vi, out ketQua);    // 12,5
            if (coCham && Regex.IsMatch(s, @"^-?\d{1,3}(\.\d{3})+$"))
                return decimal.TryParse(s, NumberStyles.Number, vi, out ketQua);    // 1.500.000
            return decimal.TryParse(s, NumberStyles.Number, en, out ketQua);
        }

        // ===================== THÊM / CẬP NHẬT / XÓA =====================

        private void btnThem_Click(object sender, EventArgs e)
        {
            DonSuaChua moi = DocONhap(null);
            if (moi == null) return;

            if (MessageBox.Show("Thêm đơn " + moi.MaDon + " - " + moi.TenKhachHang + "?", "Xác nhận thêm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            dsDon.Add(moi);
            ApDungLoc();
            ChonDong(moi);
            lblThongBao.Text = "Đã thêm đơn " + moi.MaDon;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            DonSuaChua cu = DongDangChon();
            if (cu == null)
            {
                MessageBox.Show("Hãy chọn 1 đơn trong bảng để cập nhật.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DonSuaChua moi = DocONhap(cu);
            if (moi == null) return;

            if (MessageBox.Show("Lưu thay đổi cho đơn " + cu.MaDon + "?", "Xác nhận cập nhật",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            cu.MaDon = moi.MaDon;
            cu.TenKhachHang = moi.TenKhachHang;
            cu.SoDienThoai = moi.SoDienThoai;
            cu.LoaiThietBi = moi.LoaiThietBi;
            cu.MoTaLoi = moi.MoTaLoi;
            cu.NgayTiepNhan = moi.NgayTiepNhan;
            cu.ChiPhiDuKien = moi.ChiPhiDuKien;
            cu.TrangThai = moi.TrangThai;
            cu.DuongDanAnh = moi.DuongDanAnh;

            ApDungLoc();
            ChonDong(cu);
            lblThongBao.Text = "Đã cập nhật đơn " + cu.MaDon + " (" + cu.TrangThai + ")";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DonSuaChua d = DongDangChon();
            if (d == null)
            {
                MessageBox.Show("Hãy chọn 1 đơn trong bảng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa đơn " + d.MaDon + " - " + d.TenKhachHang + "?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            dsDon.Remove(d);
            ApDungLoc();
            LamMoiONhap();
            lblThongBao.Text = "Đã xóa đơn " + d.MaDon;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiONhap();
        }

        private void LamMoiONhap()
        {
            errorProvider1.Clear();
            dgvDon.ClearSelection();
            txtMaDon.Clear();
            txtTenKH.Clear();
            txtSDT.Clear();
            txtMoTa.Clear();
            txtChiPhi.Clear();
            cboLoai.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            dtpNgayTiepNhan.Value = DateTime.Today;
            HienAnh("");
            txtMaDon.Focus();
        }

        // ===================== MENU =====================

        private void mnuXuatCsv_Click(object sender, EventArgs e)
        {
            List<DonSuaChua> dangHienThi = dsHienThi.ToList();
            if (dangHienThi.Count == 0)
            {
                MessageBox.Show("Không có đơn nào đang hiển thị để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            saveFileDialog1.FileName = "DonSuaChua_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mã đơn;Khách hàng;Số điện thoại;Loại thiết bị;Mô tả lỗi;Ngày tiếp nhận;Chi phí dự kiến;Trạng thái");
            foreach (DonSuaChua d in dangHienThi)
            {
                sb.AppendLine(string.Join(";", new[]
                {
                    Csv(d.MaDon), Csv(d.TenKhachHang), Csv(d.SoDienThoai), Csv(d.LoaiThietBi), Csv(d.MoTaLoi),
                    d.NgayTiepNhan.ToString("dd/MM/yyyy"), d.ChiPhiDuKien.ToString("0"), Csv(d.TrangThai)
                }));
            }

            try
            {
                File.WriteAllText(saveFileDialog1.FileName, sb.ToString(), new UTF8Encoding(true));
                lblThongBao.Text = "Đã xuất " + dangHienThi.Count + " đơn ra " + Path.GetFileName(saveFileDialog1.FileName);
                MessageBox.Show("Đã xuất " + dangHienThi.Count + " đơn ra file:\n" + saveFileDialog1.FileName, "Xuất CSV",
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
            if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thoát",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
