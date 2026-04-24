using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Microsoft.EntityFrameworkCore;
using System.IO;

using QuanLyBanDTDD.Data;
namespace QuanLyBanDTDD.Reports
{
    public partial class frmInHoaDon : Form
    {

        QLBDTDTDbContext context = new QLBDTDTDbContext();
        int maHoaDonCanIn;
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        public frmInHoaDon(int maHD)
        {
            InitializeComponent();
            maHoaDonCanIn = maHD;
        }

        private void frmInHoaDon_Load(object sender, EventArgs e)
        {
            var hoaDon = context.HoaDonMua
                .Include(h => h.NhaCungCap) 
                .Include(h => h.NhanVien)
                .FirstOrDefault(h => h.ID == maHoaDonCanIn);

            if (hoaDon == null)
            {
                MessageBox.Show("Không tìm thấy thông tin hóa đơn!", "Thông báo");
                return;
            }
            // sẽ tự động nối sang các bảng Hóa Đơn, Nhân Viên, Sản Phẩm
            var danhSachChiTiet = context.ChiTietHoaDonMua
                .Where(ct => ct.HoaDonMuaID == maHoaDonCanIn)
                .Select(ct => new
                {
                    MaHoaDon = ct.HoaDonMuaID,
                    NgayNhap = ct.HoaDonMua!.NgayNhap,
                    TenNhanVien = ct.HoaDonMua.NhanVien != null ? ct.HoaDonMua.NhanVien.HoTen : "Trống",
                    TenNhaCungCap = ct.HoaDonMua.NhaCungCap != null ? ct.HoaDonMua.NhaCungCap.TenNhaCungCap : "Trống",
                    TenSP = ct.PhienBanSanPham != null ? ct.PhienBanSanPham.SanPham.TenSP + " (" + ct.PhienBanSanPham.BoNho + " " + ct.PhienBanSanPham.MauSac + ")" : "SP Lỗi",
                    SoLuong = ct.SoLuong,
                    DonGia = ct.DonGia,
                    ThanhTien = ct.SoLuong * ct.DonGia,
                    TongTien = ct.HoaDonMua.TongTien
                }).ToList();

            //  Kiểm tra xem có dữ liệu không
            if (danhSachChiTiet.Count > 0)
            {
                dsHoaDon.dtChiTietHoaDonDataTable dt = new dsHoaDon.dtChiTietHoaDonDataTable();

                // Đổ dữ liệu vào DataTable (Khuôn RDLC)
                foreach (var item in danhSachChiTiet)
                {
                    dt.Rows.Add(
                        item.MaHoaDon,
                        item.NgayNhap.ToString("dd/MM/yyyy HH:mm"),
                        item.TenNhanVien,
                        item.TenNhaCungCap,
                        item.TenSP,
                        item.SoLuong,
                        item.DonGia,
                        item.ThanhTien,
                        item.TongTien
                    );
                }

                // Khai báo nguồn dữ liệu và đẩy lên ReportViewer
                ReportDataSource rds = new ReportDataSource("DataSetHDM", (DataTable)dt);

                reportViewer1.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptHoaDonMua.rdlc"); reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                // Khai báo danh sách tham số để truyền vào Report
                IList<ReportParameter> param = new List<ReportParameter>
            {
                new ReportParameter("NCC_MaSoThue", ""),
                new ReportParameter("NCC_SoDienThoai", hoaDon.NhaCungCap?.SoDienThoai ?? ""),
                new ReportParameter("NCC_DiaChi",  hoaDon.NhaCungCap ?.DiaChi ?? ""),
                new ReportParameter("NCC_Email",  hoaDon.NhaCungCap ?.Email ?? ""),
                
               
            };

                    reportViewer1.LocalReport.SetParameters(param);

                // 5. Cấu hình hiển thị chuẩn trang A4
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Hóa đơn này trống hoặc không tìm thấy dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
 