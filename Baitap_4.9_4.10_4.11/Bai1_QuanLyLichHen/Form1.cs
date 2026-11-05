using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;

namespace Bai1
{
    public partial class Form1 : Form
    {
        // Danh sách gốc chứa TẤT CẢ lịch hẹn
        private readonly BindingList<LichHen> dsLichHen = new BindingList<LichHen>();

        // Danh sách đang hiển thị trên bảng (kết quả sau khi tìm kiếm / lọc)
        private readonly BindingList<LichHen> dsHienThi = new BindingList<LichHen>();

        // Bật lên khi đang nạp lại bảng, để không tự đổ dữ liệu lên ô nhập
        private bool dangNapBang = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvLichHen.AutoGenerateColumns = false;      // chỉ dùng các cột tự định nghĩa
            bsLichHen.DataSource = dsHienThi;
            dgvLichHen.DataSource = bsLichHen;

            cboLocTrangThai.SelectedIndex = 0;           // "Tất cả"
            LamMoiONhap();
            ApDungLoc();
        }

        // ===================== TÌM KIẾM & LỌC =====================

        // Lọc danh sách gốc theo ô tìm kiếm, ngày hẹn, trạng thái rồi đưa ra bảng
        private void ApDungLoc()
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            bool locNgay = dtpLocNgay.Checked;
            DateTime ngayLoc = dtpLocNgay.Value.Date;
            string trangThaiLoc = cboLocTrangThai.SelectedIndex > 0 ? cboLocTrangThai.Text : "";

            List<LichHen> ketQua = dsLichHen.Where(lh =>
                    (tuKhoa == "" || lh.HoTen.ToLower().Contains(tuKhoa) || lh.SoDienThoai.Contains(tuKhoa))
                    && (!locNgay || lh.NgayGioHen.Date == ngayLoc)
                    && (trangThaiLoc == "" || lh.TrangThai == trangThaiLoc))
                .OrderBy(lh => lh.NgayGioHen)
                .ToList();

            dangNapBang = true;
            dgvLichHen.CurrentCell = null;
            dsHienThi.RaiseListChangedEvents = false;
            dsHienThi.Clear();
            foreach (LichHen x in ketQua) dsHienThi.Add(x);
            dsHienThi.RaiseListChangedEvents = true;
            bsLichHen.ResetBindings(false);
            dgvLichHen.ClearSelection();
            dangNapBang = false;

            lblSoLichHen.Text = "Số lịch hẹn: " + ketQua.Count + " / " + dsLichHen.Count;
        }

        private void BoLoc_Changed(object sender, EventArgs e)
        {
            ApDungLoc();
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            dtpLocNgay.Checked = false;
            cboLocTrangThai.SelectedIndex = 0;
            ApDungLoc();
        }

        // ===================== CHỌN DÒNG -> ĐƯA LÊN Ô NHẬP =====================

        private LichHen DongDangChon()
        {
            if (dgvLichHen.SelectedRows.Count == 0) return null;
            return dgvLichHen.SelectedRows[0].DataBoundItem as LichHen;
        }

        private void dgvLichHen_SelectionChanged(object sender, EventArgs e)
        {
            if (dangNapBang) return;
            LichHen lh = DongDangChon();
            if (lh == null) return;

            errorProvider1.Clear();
            txtMaLH.Text = lh.MaLH;
            txtHoTen.Text = lh.HoTen;
            txtSDT.Text = lh.SoDienThoai;
            dtpNgayHen.Value = lh.NgayGioHen;
            cboBacSi.SelectedItem = lh.BacSi;
            txtLyDo.Text = lh.LyDo;
            cboTrangThai.SelectedItem = lh.TrangThai;
        }

        private void ChonDong(LichHen lh)
        {
            foreach (DataGridViewRow row in dgvLichHen.Rows)
            {
                if (row.DataBoundItem == lh)
                {
                    dgvLichHen.CurrentCell = row.Cells[0];
                    row.Selected = true;
                    return;
                }
            }
        }

        // ===================== KIỂM TRA DỮ LIỆU =====================

        // Đọc ô nhập và kiểm tra. dangSua = lịch hẹn đang được sửa (null nếu đang thêm mới).
        // Trả về null nếu có lỗi.
        private LichHen DocONhap(LichHen dangSua)
        {
            errorProvider1.Clear();
            List<string> loi = new List<string>();

            string ma = txtMaLH.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim().Replace(" ", "").Replace(".", "");
            string lyDo = txtLyDo.Text.Trim();
            DateTime ngayHen = CatGiay(dtpNgayHen.Value);

            if (ma == "")
                BaoLoi(txtMaLH, "Mã lịch hẹn không được để trống.", loi);
            else if (dsLichHen.Any(x => x != dangSua && string.Equals(x.MaLH, ma, StringComparison.OrdinalIgnoreCase)))
                BaoLoi(txtMaLH, "Mã lịch hẹn \"" + ma + "\" đã tồn tại.", loi);

            if (ten == "")
                BaoLoi(txtHoTen, "Họ tên bệnh nhân không được để trống.", loi);

            if (sdt == "")
                BaoLoi(txtSDT, "Số điện thoại không được để trống.", loi);
            else if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
                BaoLoi(txtSDT, "Số điện thoại không hợp lệ (phải gồm 10 chữ số, bắt đầu bằng 0).", loi);

            // Ngày hẹn không được ở quá khứ (khi sửa mà không đổi ngày thì bỏ qua)
            bool doiNgay = dangSua == null || CatGiay(dangSua.NgayGioHen) != ngayHen;
            if (doiNgay && ngayHen < CatGiay(DateTime.Now))
                BaoLoi(dtpNgayHen, "Ngày giờ hẹn không được nằm trong quá khứ.", loi);

            if (cboBacSi.SelectedIndex < 0)
                BaoLoi(cboBacSi, "Vui lòng chọn bác sĩ.", loi);

            if (lyDo == "")
                BaoLoi(txtLyDo, "Lý do khám không được để trống.", loi);

            if (cboTrangThai.SelectedIndex < 0)
                BaoLoi(cboTrangThai, "Vui lòng chọn trạng thái.", loi);

            if (loi.Count > 0)
            {
                MessageBox.Show("Dữ liệu chưa hợp lệ:\n\n• " + string.Join("\n• ", loi), "Lỗi nhập liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            return new LichHen
            {
                MaLH = ma,
                HoTen = ten,
                SoDienThoai = sdt,
                NgayGioHen = ngayHen,
                BacSi = cboBacSi.Text,
                LyDo = lyDo,
                TrangThai = cboTrangThai.Text
            };
        }

        private void BaoLoi(Control c, string thongBao, List<string> loi)
        {
            errorProvider1.SetError(c, thongBao);
            loi.Add(thongBao);
        }

        private static DateTime CatGiay(DateTime d)
        {
            return new DateTime(d.Year, d.Month, d.Day, d.Hour, d.Minute, 0);
        }

        // ===================== THÊM / CẬP NHẬT / XÓA =====================

        private void btnThem_Click(object sender, EventArgs e)
        {
            LichHen moi = DocONhap(null);
            if (moi == null) return;

            if (MessageBox.Show("Thêm lịch hẹn " + moi.MaLH + " - " + moi.HoTen + "?", "Xác nhận thêm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            dsLichHen.Add(moi);
            ApDungLoc();
            ChonDong(moi);
            lblThongBao.Text = "Đã thêm lịch hẹn " + moi.MaLH;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LichHen cu = DongDangChon();
            if (cu == null)
            {
                MessageBox.Show("Hãy chọn 1 lịch hẹn trong bảng để cập nhật.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LichHen moi = DocONhap(cu);
            if (moi == null) return;

            if (MessageBox.Show("Lưu thay đổi cho lịch hẹn " + cu.MaLH + "?", "Xác nhận cập nhật",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            cu.MaLH = moi.MaLH;
            cu.HoTen = moi.HoTen;
            cu.SoDienThoai = moi.SoDienThoai;
            cu.NgayGioHen = moi.NgayGioHen;
            cu.BacSi = moi.BacSi;
            cu.LyDo = moi.LyDo;
            cu.TrangThai = moi.TrangThai;

            ApDungLoc();
            ChonDong(cu);
            lblThongBao.Text = "Đã cập nhật lịch hẹn " + cu.MaLH;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LichHen lh = DongDangChon();
            if (lh == null)
            {
                MessageBox.Show("Hãy chọn 1 lịch hẹn trong bảng để xóa.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa lịch hẹn " + lh.MaLH + " - " + lh.HoTen + "?", "Xác nhận xóa",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            dsLichHen.Remove(lh);
            ApDungLoc();
            LamMoiONhap();
            lblThongBao.Text = "Đã xóa lịch hẹn " + lh.MaLH;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiONhap();
        }

        private void LamMoiONhap()
        {
            errorProvider1.Clear();
            dgvLichHen.ClearSelection();
            txtMaLH.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtLyDo.Clear();
            cboBacSi.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            // Giờ hẹn mặc định: mốc 30 phút kế tiếp
            DateTime bayGio = DateTime.Now;
            DateTime moc = CatGiay(bayGio).AddMinutes(30 - bayGio.Minute % 30);
            dtpNgayHen.Value = moc;
            txtMaLH.Focus();
        }

        // ===================== MENU =====================

        private void mnuXuatCsv_Click(object sender, EventArgs e)
        {
            List<LichHen> dangHienThi = dsHienThi.ToList();
            if (dangHienThi.Count == 0)
            {
                MessageBox.Show("Không có lịch hẹn nào đang hiển thị để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            saveFileDialog1.FileName = "LichHen_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".csv";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mã lịch hẹn;Họ tên;Số điện thoại;Ngày giờ hẹn;Bác sĩ;Lý do khám;Trạng thái");
            foreach (LichHen lh in dangHienThi)
            {
                sb.AppendLine(string.Join(";", new[]
                {
                    Csv(lh.MaLH), Csv(lh.HoTen), Csv(lh.SoDienThoai), Csv(lh.NgayGioHen.ToString("dd/MM/yyyy HH:mm")),
                    Csv(lh.BacSi), Csv(lh.LyDo), Csv(lh.TrangThai)
                }));
            }

            try
            {
                File.WriteAllText(saveFileDialog1.FileName, sb.ToString(), new UTF8Encoding(true));
                lblThongBao.Text = "Đã xuất " + dangHienThi.Count + " lịch hẹn ra " + Path.GetFileName(saveFileDialog1.FileName);
                MessageBox.Show("Đã xuất " + dangHienThi.Count + " lịch hẹn ra file:\n" + saveFileDialog1.FileName, "Xuất CSV",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không ghi được file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Bọc giá trị trong dấu "" nếu có ký tự đặc biệt
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
