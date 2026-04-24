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
    public class ChiTietHoaDonBan
    {

        [Key]
        public int ID { get; set; }
        public string? SoIMEI { get; set; } 
       
        public int SoLuong { get; set; }

        public decimal DonGia { get; set; }
        

        public decimal ThanhTien { get; set; }
       

       
        public DateTime NgayKichHoat { get; set; } = DateTime.Now;

       
        public DateTime NgayHetHan { get; set; }
        // cho frm đổi trả
        public string TrangThai { get; set; } = "Bình thường"; 

        [StringLength(255)]
        public string? GhiChu { get; set; }

        // 2. LIÊN KẾT (KHÓA NGOẠI)

        // Thuộc về Hóa đơn nào?
        public string? HoaDonBanID { get; set; }
        [ForeignKey("HoaDonBanID")]
        public virtual HoaDonBan? HoaDonBan { get; set; }

        
        public int? PhienBanSanPhamID { get; set; }
        [ForeignKey("PhienBanSanPhamID")]
        public virtual PhienBanSanPham? PhienBanSanPham { get; set; }
    }
    [NotMapped]
    public class DanhSachHoaDonBan_ChiTiet
    {
        public int ID { get; set; }
        public string? HoaDonBanID { get; set; }
        public int PhienBanSanPhamID { get; set; }
        public string? TenSanPham { get; set; }

        public string? MauSac { get; set; }
        public string? BoNho { get; set; }

        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public DateTime NgayKichHoat { get; set; }
        public DateTime NgayHetHan { get; set; }
        public string? SoIMEI { get; set; }
    }
}
