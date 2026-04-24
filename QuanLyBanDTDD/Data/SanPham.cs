using Microsoft.EntityFrameworkCore;
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
    // Tạo Index cho Tên Sản Phẩm
    [Index(nameof(TenSP))]
    public class SanPham
    {
        // 1. KHÓA CHÍNH
        [Key]
        public int ID { get; set; }

        // 2. THÔNG TIN CƠ BẢN
        [Required]
        [StringLength(100)]
        public string? TenSP { get; set; } 

        [StringLength(50)]
        public string? HangSanXuat { get; set; } 

       
        // Quy định thời gian bảo hành (tính bằng Tháng). 
        public string? ThoiGianBaoHanh { get; set; }

             

        // 4. GIÁ VÀ KHO
        [Column(TypeName = "decimal(18,2)")]
        public decimal GiaNhap { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal GiaBan { get; set; }

        public int SoLuongTon { get; set; } // Số lượng đang có trong kho

        

        // 5. HÌNH ẢNH & MÔ TẢ
        [StringLength(255)]
        public string? HinhAnh { get; set; } // Lưu đường dẫn file ảnh (vd: img/ip15.jpg)

        public string? MoTa { get; set; } // Bài viết giới thiệu sản phẩm

        // 6. TRẠNG THÁI
        public bool NgungKinhDoanh { get; set; } = false; // Check vào đây nếu không bán nữa

        // --- QUAN HỆ ---


     
        public virtual ObservableCollectionListSource<PhienBanSanPham> PhienBanSanPham { get; } = new();
    }
}

