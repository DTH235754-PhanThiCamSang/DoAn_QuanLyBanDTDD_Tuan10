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
    public class NhanVien
    {
        // 1. KHÓA CHÍNH
        [Key]
        public int ID { get; set; } // Đổi từ MaNhanVien -> ID cho chuẩn EF Core

        // 2. THÔNG TIN CÁ NHÂN
        [Required]
        [StringLength(100)]
        public string HoTen { get; set; } = null!;// Đổi TenNhanVien -> HoTen cho gọn

        [StringLength(10)]
        public string? GioiTinh { get; set; } // Nam/Nữ

        public DateTime? NgaySinh { get; set; } // Có thể để trống

        [StringLength(15)]
        public string? SDT { get; set; } // Số điện thoại

        [StringLength(255)]
        public string? DiaChi { get; set; }

        // 3. CÔNG VIỆC
        [StringLength(50)]
        public string? ChucVu { get; set; }
        // Lưu thẳng: "Quản lý", "Thu ngân"... (Không cần tạo bảng ChucVu riêng cho phức tạp)

        [StringLength(20)]
        public string TrangThai { get; set; } = "Đang làm việc";
        // Ví dụ: "Đang làm việc", "Đã nghỉ"

        // 4. CÁC MỐI QUAN HỆ (Navigation Properties)

        // Quan hệ 1-1 với Tài Khoản
        public virtual TaiKhoan? TaiKhoan { get; set; }

        // Quan hệ 1-Nhiều với Hóa Đơn Bán (Nhân viên này bán những đơn nào)
        public virtual ObservableCollectionListSource<HoaDonBan> HoaDonBans { get; } = new();

        // Quan hệ 1-Nhiều với Hóa Đơn Mua (Nhân viên này nhập những đơn hàng nào)
        public virtual ObservableCollectionListSource<HoaDonMua> HoaDonMuas { get; } = new();
    }

    [NotMapped] // Báo cho Entity Framework biết đây chỉ là class ảo để hiển thị lên lưới, không tạo bảng trong SQL
    public class DanhSachNhanVien
    {
        public int ID { get; set; }
        public string? HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        public string? DiaChi { get; set; }
        public string? SDT { get; set; }
        public string? ChucVu { get; set; }
        public string? TrangThai { get; set; }

        // Gộp thêm 2 cột của bảng Tài Khoản sang đây
        public string? TenDangNhap { get; set; }
        public string? QuyenHan { get; set; }
    }



}
