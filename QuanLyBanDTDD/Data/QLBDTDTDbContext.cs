using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace QuanLyBanDTDD.Data
{
    public class QLBDTDTDbContext : DbContext
    {
        public QLBDTDTDbContext(DbContextOptions<QLBDTDTDbContext> options)
            : base(options)
        {
        }

        // Constructor cho design-time
        public QLBDTDTDbContext()
        {
        }


       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // LƯU Ý: Chuỗi này phải giống hệt tên trong file App.config
                // Lúc nãy mình hướng dẫn là "QLBDTDTConnection", nếu bạn đổi thì nhớ đổi cả 2 bên cho khớp
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["QLBDTDTConnection"].ConnectionString);
            }
        }



        // --- CÁC BẢNG DỮ LIỆU ---
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<HangSanXuat> HangSanXuat { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<PhienBanSanPham> PhienBanSanPham { get; set; }
       
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDonMua> HoaDonMua { get; set; }
        public DbSet<BaoHanh> BaoHanh { get; set; }

        public DbSet<HoaDonBan> HoaDonBan { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<ChiTietHoaDonBan> ChiTietHoaDonBan { get; set; }
        public DbSet<ChiTietHoaDonMua> ChiTietHoaDonMua { get; set; }
       public DbSet<DoiTra> DoiTra { get; set; }

        public DbSet<ThanhToan> ThanhToan { get; set; }
    }
}