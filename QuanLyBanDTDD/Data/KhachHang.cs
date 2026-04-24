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
    // Dòng này bảo SQL: "Tạo mục lục cho cột SDT đi, để tìm cho nhanh"
    [Index(nameof(SDT), IsUnique = true)]
    public class KhachHang
    {
        
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string? HoTen { get; set; }
        [Column(TypeName = "varchar(15)")]
        [StringLength(15)]
        public string? SDT { get; set; }

        [StringLength(255)]
        public string? DiaChi { get; set; }
        [Column(TypeName = "varchar(100)")]
        [StringLength(100)]
        public string? Email { get; set; }

        // Điểm tích lũy (Mua nhiều được cộng điểm)
        public int DiemTichLuy { get; set; } = 0;

        // Quan hệ: Một khách hàng có nhiều hóa đơn mua hàng
        public virtual ObservableCollectionListSource<HoaDonBan> HoaDonBans { get; } = new();
    }
}
