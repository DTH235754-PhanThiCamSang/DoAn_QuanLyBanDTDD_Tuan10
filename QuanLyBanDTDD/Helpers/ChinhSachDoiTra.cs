using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanDTDD.Helpers
{
    internal class ChinhSachDoiTra
    {
        /// <summary>
        /// Hàm tính số tiền hoàn lại dựa trên chính sách bảo hành
        /// </summary>
        /// <param name="ngayMua">Ngày khách mua trên hóa đơn</param>
        /// <param name="giaMua">Giá tại thời điểm mua</param>
        /// <param name="loiNhaSanXuat">True = Lỗi NSX, False = Khách không thích</param>
        /// <returns>Số tiền cần hoàn lại cho khách</returns>
        public static decimal TinhTienHoanLai(DateTime ngayMua, decimal giaMua, bool loiNhaSanXuat)
        {
            // 1. Tính số ngày khách đã giữ máy
            // Lấy ngày hiện tại trừ đi ngày mua
            TimeSpan thoiGianSuDung = DateTime.Now.Date - ngayMua.Date;
            int soNgay = thoiGianSuDung.Days;

            // Nếu trả ngay trong ngày (soNgay = 0) thì coi như 1 ngày hoặc 0 tùy bạn (ở đây để 0 vẫn tính đúng logic)
            if (soNgay < 0) soNgay = 0;

            decimal phanTramHoanTien = 0;

            // --- TRƯỜNG HỢP 1: MÁY BỊ LỖI DO NHÀ SẢN XUẤT ---
            if (loiNhaSanXuat)
            {
                if (soNgay <= 30) // 30 ngày đầu
                {
                    phanTramHoanTien = 1.0m; // Hoàn 100% (Miễn phí)
                }
                else if (soNgay <= 37) // 7 ngày tiếp theo (30 + 7)
                {
                    phanTramHoanTien = 0.9m; // Hoàn 90% (Trừ 10%)
                }
                else if (soNgay <= 44) // 7 ngày tiếp theo nữa (37 + 7)
                {
                    phanTramHoanTien = 0.8m; // Hoàn 80% (Trừ tiếp 10%)
                }
                else if (soNgay <= 58) // 14 ngày tiếp theo (44 + 14)
                {
                    phanTramHoanTien = 0.7m; // Hoàn 70% (Trừ tiếp 10%)
                }
                else // Quá 58 ngày
                {
                    // Từ ngày thứ 59 trở đi, cứ thêm 1 ngày trừ 0.15%
                    int soNgayVuot = soNgay - 58;
                    decimal phanTramTruThem = soNgayVuot * 0.0015m; // 0.15% = 0.0015

                    phanTramHoanTien = 0.7m - phanTramTruThem;
                }
            }
            // --- TRƯỜNG HỢP 2: MÁY KHÔNG LỖI (KHÁCH MUỐN ĐỔI/TRẢ) ---
            else
            {
                if (soNgay <= 7) // 7 ngày đầu
                {
                    phanTramHoanTien = 0.9m; // Hoàn 90% (Trừ 10%)
                }
                else if (soNgay <= 14) // 7 ngày tiếp theo (7 + 7)
                {
                    phanTramHoanTien = 0.8m; // Hoàn 80% (Trừ tiếp 10%)
                }
                else if (soNgay <= 28) // 14 ngày tiếp theo (14 + 14)
                {
                    phanTramHoanTien = 0.7m; // Hoàn 70% (Trừ tiếp 10%)
                }
                else // Quá 28 ngày
                {
                    // Từ ngày thứ 29 trở đi, cứ thêm 1 ngày trừ 0.15%
                    int soNgayVuot = soNgay - 28;
                    decimal phanTramTruThem = soNgayVuot * 0.0015m; // 0.15%

                    phanTramHoanTien = 0.7m - phanTramTruThem;
                }
            }

            // Đảm bảo không bị âm tiền (trường hợp khách giữ máy quá lâu đến mức trừ hết tiền)
            if (phanTramHoanTien < 0) phanTramHoanTien = 0;

            // Tính ra số tiền cụ thể
            return giaMua * phanTramHoanTien;
        }
    }
}

