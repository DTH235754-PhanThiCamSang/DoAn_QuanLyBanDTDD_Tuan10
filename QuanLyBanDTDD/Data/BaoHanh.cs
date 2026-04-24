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
    // Tạo Index cho số IMEI
    [Index(nameof(SoIMEI))]
    public class BaoHanh
    {
        [Key]
        public int ID { get; set; }

        public int ChiTietHoaDonBanID { get; set; }
        [ForeignKey("ChiTietHoaDonBanID")]
        public virtual ChiTietHoaDonBan? ChiTietHoaDonBan { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")] // IMEI toàn số, dùng varchar cho nhẹ
        [StringLength(50)]

        public string? SoIMEI { get; set; }

        public DateTime NgayNhan { get; set; } = DateTime.Now;

        public DateTime? NgayTraDuKien { get; set; }

        public DateTime? NgayTraThucTe { get; set; }

        [Required]
        public string? LoiKhachBao { get; set; }

        public string? KetQuaXuLy { get; set; }

        
        public bool LoiDoKhach { get; set; } = false;

        // Chi phí sửa chữa
        public decimal ChiPhi { get; set; } = 0;

        [StringLength(50)]
        public string TrangThai { get; set; } = "Đang kiểm tra";
    }
}

