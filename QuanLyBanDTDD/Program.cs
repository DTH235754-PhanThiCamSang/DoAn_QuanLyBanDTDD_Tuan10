using QuanLyBanDTDD.Forms;

namespace QuanLyBanDTDD
{
    internal static class Program
    {
        // BIẾN TOÀN CỤC: Lưu ID nhân viên sau khi đăng nhập thành công
        public static int TaiKhoanDangNhapID = 0;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
            //// Dùng Math.Round (Làm tròn chuẩn)
            //numPhuPhi.Value = Math.Round(phuPhiTinhToan / 10000) * 10000;
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

           Application.Run(new Forms.frmDangNhap());



            //  Application.Run(new Forms.frmNhanVien());

            // Application.Run(new Forms.frmKhachHang());

            //Application.Run(new Forms.frmHoaDonMua());

            // Application.Run(new Forms.frmNhaCungCap());

            //   Application.Run(new Forms.frmSanPham());
            // Application.Run(new Forms.frmMain());
            //  Application.Run(new Forms.frmMain(2, "Quanly", "CS"));
            //Application.Run(new Forms.frmLichSuHoatDong());
            //    Application.Run(new Forms.frmHoaDonBan());
            // Application.Run(new frmBaoHanh(1));


        }
    }
}