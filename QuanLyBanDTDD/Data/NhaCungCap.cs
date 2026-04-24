using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.Data
{
    public class NhaCungCap
    {      
        public int ID { get; set; }

        // 2. THÔNG TIN NHÀ CUNG CẤP
        [Required]
        [StringLength(100)]
        public string TenNhaCungCap { get; set; } = null!; // Bắt buộc phải có tên

        [StringLength(255)]
        public string? DiaChi { get; set; }

        [StringLength(15)]
        public string? SoDienThoai { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        [StringLength(255)]
        public string? GhiChu { get; set; }

        // 3. QUAN HỆ CSDL
        // Danh sách các hóa đơn đã nhập từ nhà cung cấp này
        public virtual ObservableCollectionListSource<HoaDonMua> HoaDonMua { get; } = new();
    
    }
}

