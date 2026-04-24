using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Drawing.Printing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDTDD.Data
{
    public class HoaDonMua
    {

        [Key]
        public int ID { get; set; }

        public DateTime NgayNhap { get; set; } = DateTime.Now;

        public decimal TongTien { get; set; } // Tổng tiền phải trả cho nhà cung cấp

        [StringLength(255)]
        public string? GhiChu { get; set; }

        // --- QUAN HỆ ---

        // 1. Nhân viên nào nhập hàng?
        public int NhanVienID { get; set; }
        [ForeignKey("NhanVienID")]
        public virtual NhanVien? NhanVien { get; set; }

        // 2. Nhập của Nhà cung cấp nào?
        public int NhaCungCapID { get; set; }
        [ForeignKey("NhaCungCapID")]
        public virtual NhaCungCap? NhaCungCap { get; set; }

        // 3. Danh sách chi tiết hàng nhập
        public virtual ObservableCollectionListSource<ChiTietHoaDonMua> ChiTietHoaDonMuas { get; } = new();
        [NotMapped]
        public class DanhSachHoaDonMua
        {
            public int ID { get; set; }
            public System.DateTime NgayNhap { get; set; }
            public decimal TongTien { get; set; }
            public string? GhiChu { get; set; }
            public int NhaCungCapID { get; set; }
            public string? TenNhanVien { get; set; }
            public string? TenNhaCungCap { get; set; }
        }
    }

}
