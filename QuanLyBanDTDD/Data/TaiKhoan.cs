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
    public class TaiKhoan
    {

        // Thiết lập quan hệ 1-1: ID của Tài khoản cũng chính là ID của Nhân viên
        [Key]
        [ForeignKey("NhanVien")]
        public int NhanVienID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenDangNhap { get; set; } = null!;

        [Required]
        [StringLength(100)]
        public string MatKhau { get; set; } = null!;// Trong thực tế nên mã hóa, đồ án thì để text thường cũng được

        [StringLength(20)]
        public string QuyenHan { get; set; } = null!;// "Admin" hoặc "NhanVien"

        // --- CÁC MỐI QUAN HỆ ---

        // 1. Liên kết ngược về Nhân viên (1-1)
        public virtual NhanVien NhanVien { get; set; } = null!;

      
        
    }
   
}
