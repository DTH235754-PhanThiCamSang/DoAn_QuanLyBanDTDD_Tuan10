using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyBanDTDD.Data;
using QuanLyBanDTDD.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDTDD.Reports
{
    public partial class frmThongKeSanPham : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        public frmThongKeSanPham()
        {
            InitializeComponent();
        }
        // ==========================================
        // 1. SỰ KIỆN LOAD FORM: ĐỔ DỮ LIỆU VÀO COMBOBOX
        // ==========================================
        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
           
            var dsHang = context.HangSanXuat.ToList();
           
            dsHang.Insert(0, new HangSanXuat { ID = 0, TenHangSanXuat = "-- Tất cả các hãng --" });

          
            cboHangSanXuat.DataSource = dsHang;
            cboHangSanXuat.DisplayMember = "TenHangSanXuat";
            cboHangSanXuat.ValueMember = "ID";               

            // 4. Chọn dòng "-- Tất cả các hãng --" làm mặc định
            cboHangSanXuat.SelectedIndex = 0;

          
            btnLocKetQua_Click(sender, e);
            

        }


        // XỬ LÝ 2 NÚT CHECKBOX KHÔNG BỊ ĐỤNG NHAU



        private void chkMaxSoLuongBan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaxSoLuongBan.Checked) chkMinSoLuongBan.Checked = false;
        }
        private void chkMinSoLuongBan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMinSoLuongBan.Checked) chkMaxSoLuongBan.Checked = false;
        }


        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            string hangSanXuat = "Tất cả các hãng";
            var queryGoc = context.PhienBanSanPham.Include(pb => pb.SanPham).AsQueryable();

            string tenHangDuocChon = cboHangSanXuat.Text;
            if (tenHangDuocChon != "-- Tất cả các hãng --" && !string.IsNullOrEmpty(tenHangDuocChon))
            {
                queryGoc = queryGoc.Where(pb => pb.SanPham.HangSanXuat == tenHangDuocChon);
                hangSanXuat = "Hãng sản xuất: " + tenHangDuocChon;
            }

            if (chkSoLuongTonBeHon5.Checked)
            {
                queryGoc = queryGoc.Where(sp => sp.SoLuongTon < 5);
                hangSanXuat += " (Hàng sắp hết)";
            }

           
            // TÍNH TOÁN DỮ LIỆU 
           
            var danhSachSanPham = queryGoc.Select(pb => new
            {
                TenSP = pb.SanPham.TenSP + " (" + pb.BoNho + " " + pb.MauSac + ")",
                TonKho = pb.SoLuongTon,
                HangSX = pb.SanPham.HangSanXuat,

                DaBan = context.ChiTietHoaDonBan
                       .Where(ct => ct.PhienBanSanPhamID == pb.IDPhienBan && ct.TrangThai != "Đã trả hàng")
                       .Sum(ct => (int?)ct.SoLuong) ?? 0,

                BiTra = context.DoiTra
                       .Count(dt => dt.ChiTiet_HoaDonBan.PhienBanSanPhamID == pb.IDPhienBan),

               
                DoanhThu = context.ChiTietHoaDonBan
                          .Where(ct => ct.PhienBanSanPhamID == pb.IDPhienBan && ct.TrangThai != "Đã trả hàng")
                          .Sum(ct => (decimal?)ct.ThanhTien) ?? 0
            }).ToList();

            // Sắp xếp theo CheckBox 
            if (chkMaxSoLuongBan.Checked)
                danhSachSanPham = danhSachSanPham.OrderByDescending(x => x.DaBan).ToList();
            else if (chkMinSoLuongBan.Checked)
                danhSachSanPham = danhSachSanPham.OrderBy(x => x.DaBan).ToList();
            else
                danhSachSanPham = danhSachSanPham.OrderByDescending(x => x.DoanhThu).ToList();


            // ĐỔ VÀO DATASET 

            dsHoaDon.dtThongKeSanPhamDataTable danhSachSanPhamDataTable = new dsHoaDon.dtThongKeSanPhamDataTable();

            danhSachSanPhamDataTable.Clear();

            foreach (var row in danhSachSanPham)
            {
                danhSachSanPhamDataTable.AdddtThongKeSanPhamRow(
                    row.TenSP,
                    row.TonKho,
                    row.DaBan,
                    row.BiTra,
                    row.HangSX,
                    row.DoanhThu);
            }


        

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "ThongKeSanPham";
            reportDataSource.Value = danhSachSanPhamDataTable;

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
           
            reportViewer1.LocalReport.ReportPath = System.IO.Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc");

          
            ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", "(" + hangSanXuat + ")");
            reportViewer1.LocalReport.SetParameters(reportParameter);

            // Cấu hình khung nhìn hiển thị
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            reportViewer1.ZoomPercent = 100;
            reportViewer1.RefreshReport();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
           chkMaxSoLuongBan.Checked = false;
            chkMinSoLuongBan.Checked = false;
            chkSoLuongTonBeHon5.Checked = false;
            frmThongKeSanPham_Load(sender, e);
        }
    }

}
