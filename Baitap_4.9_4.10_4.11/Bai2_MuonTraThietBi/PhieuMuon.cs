namespace Bai2
{
    // Một phiếu mượn thiết bị
    public class PhieuMuon
    {
        public string MaPhieu { get; set; }
        public string MaSV { get; set; }
        public string HoTenSV { get; set; }
        public string ThietBi { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra { get; set; }
        public DateTime? NgayTraThucTe { get; set; }   // null = chưa trả

        // Tình trạng tự xác định, không cần nhập tay
        public string TinhTrang
        {
            get { return XacDinhTinhTrang(HanTra, NgayTraThucTe); }
        }

        public static string XacDinhTinhTrang(DateTime hanTra, DateTime? ngayTra)
        {
            if (ngayTra.HasValue) return "Đã trả";
            if (hanTra.Date < DateTime.Today) return "Quá hạn";   // chưa trả mà đã qua hạn
            return "Đang mượn";
        }
    }
}
