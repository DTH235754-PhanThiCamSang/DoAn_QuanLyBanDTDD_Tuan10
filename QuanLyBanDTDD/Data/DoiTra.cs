using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.Data
{
    public class DoiTra
    {
        [Key]
        public int ID { get; set; }

        // ==========================================
        // 1. LIÊN KẾT: Máy nào đang được đổi trả?
        // ==========================================
        [Required]
        public int ChiTietHoaDonBanID { get; set; }
        [ForeignKey("ChiTietHoaDonBanID")]
        public virtual ChiTietHoaDonBan? ChiTiet_HoaDonBan { get; set; }

        // Bổ sung: Lưu lại IMEI để truy xuất và tìm kiếm cực nhanh
        [Required]
        [StringLength(20)]
        public string SoIMEI { get; set; } = string.Empty;

        // ==========================================
        // 2. THÔNG TIN GIAO DỊCH
        // ==========================================
        public DateTime NgayDoiTra { get; set; } = DateTime.Now;

        // Bổ sung: "Trả hàng theo nhu cầu" hay "Đổi trả do lỗi NSX"
        [Required]
        [StringLength(100)]
        public string HinhThuc { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string LyDo { get; set; } = string.Empty;
        public bool ConSeal { get; set; }

        public string? HuongXuLy { get; set; }

 
      

        // ==========================================
        // 4. XỬ LÝ TÀI CHÍNH (Theo chính sách 10 ngày - 15%)
        // ==========================================
        // Số tiền phạt/hao mòn thu của khách (Ví dụ: 15% giá trị nếu quá 10 ngày)
        [Column(TypeName = "decimal(18,2)")]
        public decimal PhuPhi { get; set; }

        // Số tiền thực tế cửa hàng trả lại khách (Tiền Hoàn Lại = Giá Lúc Mua - Phụ Phí)
        [Column(TypeName = "decimal(18,2)")]
        public decimal SoTienHoanLai { get; set; }

        [StringLength(255)]
        public string? GhiChu { get; set; }

        // ==========================================
        // 5. LIÊN KẾT KẾ TOÁN (Giữ nguyên của bạn)
        // ==========================================
        // Nếu bạn có làm phân hệ Kế Toán/Sổ Quỹ, một phiếu Đổi Trả sẽ đẻ ra một Phiếu Chi
        
    }
}

