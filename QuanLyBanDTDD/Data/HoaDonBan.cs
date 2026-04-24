using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.Data
{
    public class HoaDonBan
    {
       
        public String ID { get; set; }

        public DateTime NgayBan { get; set; } = DateTime.Now;

        // 1. TỔNG TIỀN HÀNG (Cộng dồn từ chi tiết hóa đơn)
        public decimal TongTien { get; set; }

        // 2. CHIẾT KHẤU (MỚI THÊM)
        // Ví dụ: Giảm 100.000đ hoặc giảm theo % (Lưu số tiền cụ thể)
        public decimal GiamGia { get; set; } = 0;

        // 3. KHÁCH CẦN TRẢ (MỚI THÊM)
        // Công thức: TongTien - GiamGia = TongThanhToan
        public decimal TongThanhToan { get; set; }

        [StringLength(255)]
        public string? GhiChu { get; set; }

        // Nếu hóa đơn này được tạo ra do khách đổi hàng, hãy lưu ID của phiếu đổi trả vào đây
        public int? DoiTraID { get; set; }


        public string? TrangThai { get; set; } = "Chưa thanh toán";

        public string? PhuongThucThanhToan { get; set; } // Ví dụ: Tiền mặt, Chuyển khoản

        public decimal KhachDua { get; set; } = 0;

        // Nếu bạn muốn tích điểm, hãy thêm luôn ở đây:
        public int DiemTichLuy { get; set; } = 0;

        // --- CÁC MỐI QUAN HỆ ---
        public int NhanVienID { get; set; }
        [ForeignKey("NhanVienID")]
        public virtual NhanVien? NhanVien { get; set; }

        public int KhachHangID { get; set; }
        [ForeignKey("KhachHangID")]
        public virtual KhachHang? KhachHang { get; set; }

        public virtual ObservableCollectionListSource<ChiTietHoaDonBan> ChiTietHoaDonBans { get; } = new();
    }
    [NotMapped]
    public class DanhSachHoaDonBan
    {
        public String? ID { get; set; }
        public DateTime NgayBan { get; set; }
        public decimal TongTien { get; set; }
        public string? GhiChu { get; set; }
        public int KhachHangID { get; set; }
        public string? TenNhanVien { get; set; }
        public string? TenKhachHang { get; set; }
        public string? TrangThai { get; set; }
    }
}
