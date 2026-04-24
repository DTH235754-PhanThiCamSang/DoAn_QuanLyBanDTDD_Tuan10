using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.Data
{
    public class PhienBanSanPham
    {
        [Key]
        public int IDPhienBan { get; set; }

        
        public int SanPhamID { get; set; }

        [ForeignKey("SanPhamID")]
        public virtual SanPham? SanPham { get; set; }

        // 3. THÔNG TIN PHÂN BIỆT BIẾN THỂ
        [StringLength(50)]
        public string? MauSac { get; set; } // Ví dụ: Titan Tự nhiên, Đen, Xanh

        [StringLength(50)]
        public string? BoNho { get; set; } // Ví dụ: 128GB, 256GB, 1TB

        // 4. GIÁ CẢ (Mỗi phiên bản có giá riêng)
        [Column(TypeName = "decimal(18,2)")]
        public decimal GiaNhap { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal GiaBan { get; set; }

        // 5. TỒN KHO THỰC TẾ
        public int SoLuongTon { get; set; } // Tồn kho chính xác của đúng màu/dung lượng này

       
        public virtual ObservableCollectionListSource<ChiTietHoaDonBan> ChiTietHoaDonBans { get; } = new();
         public virtual ObservableCollectionListSource<ChiTietHoaDonMua> ChiTietHoaDonMuas { get; } = new();
    }
}
