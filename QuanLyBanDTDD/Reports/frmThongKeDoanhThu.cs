using Microsoft.Reporting.WinForms;
using QuanLyBanDTDD.Data;
using Microsoft.EntityFrameworkCore;
using QuanLyBanDTDD.Reports;
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
    public partial class frmThongKeDoanhThu : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net9.0-windows", "Reports");
        
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "Reports/rptThongKeDoanhThu.rdlc";

            // Mặc định chọn từ đầu tháng đến ngày hiện tại cho tiện
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
            btnLocKetQua_Click(sender, e);
            
            this.reportViewer1.RefreshReport();
        }
        // SỰ KIỆN NÚT LỌC KẾT QUẢ
        private void btnLocKetQua_Click(object sender, EventArgs e)
        {
            // 1. THIẾT LẬP THỜI GIAN
            DateTime tuNgay;
            DateTime denNgayEnd;

            if (chkNgay.Checked)
            {
                // Lấy từ 00:00:00 đến 23:59:59 cùng ngày
                tuNgay = DateTime.Now.Date;
                denNgayEnd = tuNgay.AddDays(1).AddTicks(-1);

                dtpTuNgay.Value = tuNgay;
                dtpDenNgay.Value = DateTime.Now;
            }
            else if (chkTuan.Checked)
            {
                tuNgay = DateTime.Now.AddDays(-7).Date;
                denNgayEnd = DateTime.Now;
                dtpTuNgay.Value = tuNgay;
                dtpDenNgay.Value = DateTime.Now;
            }
            else
            {
                tuNgay = dtpTuNgay.Value.Date;
                denNgayEnd = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);
            }
            var danhSachDoanhThu = context.HoaDonBan
                .Where(h => h.NgayBan >= tuNgay && h.NgayBan <= denNgayEnd)
                .Select(h => new
                {
                    ID = h.ID,
                    NgayLap = h.NgayBan,
                    HoVaTenNhanVien = h.NhanVien.HoTen,

                    // Tính số máy (loại trừ máy trả)
                    SoMayBanRa = h.ChiTietHoaDonBans.Where(ct => ct.TrangThai != "Đã trả hàng").Sum(ct => (int?)ct.SoLuong) ?? 0,
                    TongTienHoaDonBan = h.TongTien,

                    // Tiền sửa chữa (lỗi do khách)
                    TienSuaChua = context.BaoHanh.Where(b => b.ChiTietHoaDonBan.HoaDonBanID == h.ID && b.LoiDoKhach == true).Sum(b => (decimal?)b.ChiPhi) ?? 0,

                    // Tiền hoàn trả khi đổi trả
                    TienHoanTra = context.DoiTra.Where(d => d.ChiTiet_HoaDonBan.HoaDonBanID == h.ID).Sum(d => (decimal?)d.SoTienHoanLai) ?? 0,

                    // Giá vốn để tính lợi nhuận
                    TongTienGiaVon = h.ChiTietHoaDonBans
                        .Where(ct => ct.TrangThai != "Đã trả hàng")
                        .Sum(ct => (decimal?)ct.PhienBanSanPham.GiaNhap * ct.SoLuong) ?? 0,
                }).ToList();

            // ĐỔ VÀO DATASET CỨNG 
            dsHoaDon.dtThongKeDoanhThuDataTable dtDoanhThu = new dsHoaDon.dtThongKeDoanhThuDataTable();
                dtDoanhThu.Clear();

                foreach (var row in danhSachDoanhThu)
                {
                    // Tính toán 2 cột cuối cùng
                    decimal doanhThuThuan = (row.TongTienHoaDonBan + row.TienSuaChua) - row.TienHoanTra;
                    decimal loiNhuan = doanhThuThuan - row.TongTienGiaVon;

                    // Thêm dòng mới vào Dataset

                    dtDoanhThu.AdddtThongKeDoanhThuRow(
                        row.ID,
                        row.NgayLap.ToString("dd/MM/yyyy"),
                        row.SoMayBanRa,
                        row.TongTienHoaDonBan,
                        row.TienSuaChua,
                        row.TienHoanTra,
                        doanhThuThuan,
                        row.TongTienGiaVon,
                        loiNhuan,
                        row.HoVaTenNhanVien
                    );
                }

            
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "ThongKeDoanhThu";
                reportDataSource.Value = dtDoanhThu;

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = System.IO.Path.Combine(reportsFolder, "rptThongKeDoanhThu.rdlc");

                // Gửi tham số ngày tháng lên báo cáo
                string moTa = "Từ ngày: " + dtpTuNgay.Text + " - Đến ngày: " + dtpDenNgay.Text;
                ReportParameter reportParameter = new ReportParameter("MoTaKetQuaHienThi", moTa);
                reportViewer1.LocalReport.SetParameters(reportParameter);

                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }




        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {

            dtpTuNgay.Value = new DateTime(2000, 1, 1);
            dtpDenNgay.Value = DateTime.Now;
            btnLocKetQua_Click(sender, e);
        }

        private void chkNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNgay.Checked) chkTuan.Checked = false;
        }

        private void chkTuan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTuan.Checked) chkNgay.Checked = false;
        }
    }

}
