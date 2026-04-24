using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.Data
{
    public class ThanhToan
    {
        public int ID { get; set; }

        public String HoaDonID { get; set; }
        [ForeignKey("HoaDonID")]
        public virtual HoaDonBan? HoaDonBan { get; set; }
        public string TenKhachHang { get; set; }
        public string TenNhanVien { get; set; }

        // 2. Thông tin tiền bạc (Dùng decimal cho chính xác)
        public decimal TongTien { get; set; }
        public decimal KhachDua { get; set; }
        [NotMapped]
        public decimal TienThua => KhachDua - TongTien; // Tự động tính toán

        // 3. Hình thức và trạng thái
        public string PhuongThuc { get; set; } // "Tiền mặt", "Chuyển khoản", "Quẹt thẻ"
        public DateTime NgayThanhToan { get; set; } = DateTime.Now;

        // 4. Ghi chú thêm (Ví dụ: Mã giao dịch ngân hàng)
        public string GhiChu { get; set; }

    }
    [NotMapped]
    public class MayCanQuetIMEI
    {
        public int SanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public decimal DonGiaBan { get; set; }
        public string SoIMEI { get; set; }
    }

}

      
    
