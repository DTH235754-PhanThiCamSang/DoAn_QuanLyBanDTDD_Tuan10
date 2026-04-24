using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyBanDTDD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDTDD.Reports
{
    public partial class frmInHoaDonBan : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext();
        string maHoaDonCanIn;
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        public frmInHoaDonBan(string maHD)
        {
            InitializeComponent();
            maHoaDonCanIn = maHD;
        }

        private void frmInHoaDonBan_Load(object sender, EventArgs e)
        {

            var hoaDon = context.HoaDonBan
                .Include(h => h.KhachHang)
                .Include(h => h.NhanVien)
                .FirstOrDefault(h => h.ID == maHoaDonCanIn); 

            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn!", "Thông báo");
                return;
            }
            // Kéo dữ liệu từ bảng ChiTietHoaDonBan
            var danhSachChiTiet = context.ChiTietHoaDonBan
                .Where(ct => ct.HoaDonBanID == maHoaDonCanIn)
                .Select(ct => new
                {
                    MaHoaDon = ct.HoaDonBanID,
                    NgayBan = ct.HoaDonBan!.NgayBan, 
                    TenNhanVien = ct.HoaDonBan!.NhanVien != null ? ct.HoaDonBan.NhanVien.HoTen : "Trống",
                    TenKhachHang = ct.HoaDonBan!.KhachHang != null ? ct.HoaDonBan.KhachHang.HoTen : "Khách lẻ",
                    TenSP = ct.PhienBanSanPham != null ? ct.PhienBanSanPham.SanPham.TenSP + " (" + ct.PhienBanSanPham.BoNho + " " + ct.PhienBanSanPham.MauSac + ")" : "SP Lỗi",
                    SoLuong = ct.SoLuong,
                    DonGia = ct.DonGia,
                    ThanhTien = ct.SoLuong * ct.DonGia,
                    TongTien = ct.HoaDonBan!.TongTien,
                    SoIMEI = ct.SoIMEI
                }).ToList();

            if (danhSachChiTiet.Count > 0)
            {
                // Gọi cái bảng ảo dtChiTietHoaDonBan
                dsHoaDon.dtChiTietHoaDonBanDataTable dt = new dsHoaDon.dtChiTietHoaDonBanDataTable();

                foreach (var item in danhSachChiTiet)
                {
                    dt.Rows.Add(
                        item.MaHoaDon.ToString(),
                        item.NgayBan.ToString("dd/MM/yyyy HH:mm"),
                        item.TenNhanVien,
                        item.TenKhachHang,
                        item.TenSP,
                        item.SoLuong,
                        item.DonGia,
                        item.ThanhTien,
                        item.TongTien,
                        item.SoIMEI
                    );
                }

                //Đổ lên Report
                ReportDataSource rds = new ReportDataSource("DataSetHDB", (DataTable)dt);

               
                reportViewer1.LocalReport.ReportPath =Path.Combine(reportsFolder, "rptHoaDonBan.rdlc");
                reportViewer1.LocalReport.DataSources.Clear();
               
                reportViewer1.LocalReport.DataSources.Add(rds);


                // Khai báo danh sách tham số để truyền vào Report
            IList<ReportParameter> param = new List<ReportParameter>
            {
                new ReportParameter("NguoiBan_Ten", "SPhone Store"),
                new ReportParameter("NguoiBan_DiaChi", "23. Phường Long Xuyên, An Giang"),
                new ReportParameter("NguoiBan_MaSoThue", "892050097"),
                
                new ReportParameter("KhachHang_DiaChi", hoaDon.KhachHang.DiaChi),
                new ReportParameter("KhachHang_MaSoThue", ""),
               
            };

                reportViewer1.LocalReport.SetParameters(param);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;


               

              
                var hd = context.HoaDonBan.Find(maHoaDonCanIn); 
                string? trangThaiThucTe = hd != null ? hd.TrangThai : "";

                // Đóng gói trạng thái đó thành Parameter và ném sang file RDLC
                ReportParameter paramTrangThai = new ReportParameter("pTrangThai", trangThaiThucTe);
                reportViewer1.LocalReport.SetParameters(paramTrangThai);
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Hóa đơn này trống hoặc không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
    