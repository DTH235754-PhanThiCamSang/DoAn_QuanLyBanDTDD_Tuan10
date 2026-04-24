using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.Data
{
    public class ChiTietHoaDonMua
    {
        [Key]
        public int ID { get; set; }

        public int SoLuong { get; set; }

        public decimal DonGia { get; set; } // Giá nhập vào (Giá vốn)



        // --- QUAN HỆ ---

        // 1. Thuộc hóa đơn nhập nào?
        public int HoaDonMuaID { get; set; }
        [ForeignKey("HoaDonMuaID")]
        public virtual HoaDonMua? HoaDonMua { get; set; }

       

        public int? PhienBanSanPhamID { get; set; }
        [ForeignKey("PhienBanSanPhamID")]
        public virtual PhienBanSanPham? PhienBanSanPham { get; set; }
    }
        [NotMapped]
        public class DanhSachHoaDonMua_ChiTiet
        {
            public int ID { get; set; }
            public int HoaDonMuaID { get; set; }
        public int PhienBanSanPhamID { get; set; }
        public string? TenSanPham { get; set; } // Thêm cột này để hiện chữ thay vì hiện ID

       
        // --- THÊM 2 DÒNG NÀY ĐỂ HIỂN THỊ LÊN LƯỚI ---
        public string? MauSac { get; set; }
        public string? BoNho { get; set; }

        public int SoLuong { get; set; }
            public decimal DonGia { get; set; }
            public decimal ThanhTien { get; set; }  
        }
    
    
}


