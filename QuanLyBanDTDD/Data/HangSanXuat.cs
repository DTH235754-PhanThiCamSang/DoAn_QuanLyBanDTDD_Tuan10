using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.Data
{
    public class HangSanXuat
    {
        [Key]
        public int ID { get; set; } // Khóa chính

        public string? TenHangSanXuat { get; set; } // VD: Samsung, Apple

        public string? QuocGia { get; set; } // VD: Hàn Quốc, Mỹ


        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();

        
        
    }
}

