namespace Bai3
{
    // Một đơn đăng ký sửa chữa thiết bị
    public class DonSuaChua
    {
        public string MaDon { get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string LoaiThietBi { get; set; }
        public string MoTaLoi { get; set; }
        public DateTime NgayTiepNhan { get; set; }
        public decimal ChiPhiDuKien { get; set; }
        public string TrangThai { get; set; }
        public string DuongDanAnh { get; set; }     // rỗng = không có ảnh

        // Đơn còn đang xử lý: chưa "Hoàn tất" và không bị "Đã hủy"
        public bool ChuaHoanTat
        {
            get { return TrangThai != "Hoàn tất" && TrangThai != "Đã hủy"; }
        }
    }
}
