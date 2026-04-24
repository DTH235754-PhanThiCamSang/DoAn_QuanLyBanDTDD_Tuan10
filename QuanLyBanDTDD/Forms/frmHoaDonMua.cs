using ClosedXML.Excel; // Thư viện Excel
using Microsoft.EntityFrameworkCore;
using QuanLyBanDTDD.Data;
using QuanLyBanDTDD.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static QuanLyBanDTDD.Data.HoaDonMua;

namespace QuanLyBanDTDD.Forms
{
    public partial class frmHoaDonMua : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext();
        bool xuLyThem = false;
        int id;

        int idThuKhoDangTruc;
        string tenThuKhoDangTruc;

        public frmHoaDonMua(int idNV, string tenNV)
        {
            InitializeComponent();
            this.idThuKhoDangTruc = idNV;
            this.tenThuKhoDangTruc = tenNV;
        }

        private void HieuUngNutBam(PictureBox pic, bool duocPhepBam)
        {
            if (pic == null) return;
            pic.Enabled = duocPhepBam;
            pic.BackColor = duocPhepBam ? Color.Transparent : Color.Silver;
            pic.Cursor = duocPhepBam ? Cursors.Hand : Cursors.Default;
        }

        private void BatTatChucNang(bool dangThaoTac)
        {
            datNgayNhap.Enabled = dangThaoTac;
            cboNhaCungCap.Enabled = dangThaoTac;
            txtGhiChu.Enabled = dangThaoTac;

            HieuUngNutBam(picThem, !dangThaoTac);
            HieuUngNutBam(picSua, !dangThaoTac);
            HieuUngNutBam(picXoa, !dangThaoTac);
            HieuUngNutBam(picXem, !dangThaoTac);

            HieuUngNutBam(picLuu, dangThaoTac);
            HieuUngNutBam(picHuyBo, dangThaoTac);
        }

        private void LoadComboBox()
        {
            cboNhaCungCap.DataSource = context.NhaCungCap.ToList();
            cboNhaCungCap.DisplayMember = "TenNhaCungCap";
            cboNhaCungCap.ValueMember = "ID";
        }

        // Tách hàm AutoComplete ra riêng để tối ưu hiệu năng
        private void SetupAutoComplete()
        {
            try
            {
                AutoCompleteStringCollection danhSachGoiY = new AutoCompleteStringCollection();

                var listNCC = context.NhaCungCap
                                     .Where(n => !string.IsNullOrEmpty(n.TenNhaCungCap))
                                     .Select(n => n.TenNhaCungCap).ToList();

                var listTenNV = context.NhanVien
                                       .Where(n => !string.IsNullOrEmpty(n.HoTen))
                                       .Select(n => n.HoTen).ToList();

                danhSachGoiY.AddRange(listNCC.ToArray());
                danhSachGoiY.AddRange(listTenNV.ToArray());

                txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTimKiem.AutoCompleteCustomSource = danhSachGoiY;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo gợi ý tìm kiếm: " + ex.Message);
            }
        }

        private void LoadData(string tuKhoa = "", DateTime? ngayLoc = null)
        {
            tuKhoa = tuKhoa.Trim().ToLower();

            var query = context.HoaDonMua
                               .Include(h => h.NhanVien)
                               .Include(h => h.NhaCungCap)
                               .AsQueryable();

            if (ngayLoc.HasValue)
            {
                query = query.Where(h => h.NgayNhap.Date == ngayLoc.Value.Date);
            }

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(h => h.ID.ToString() == tuKhoa ||
                                        (h.NhaCungCap != null && h.NhaCungCap.TenNhaCungCap.ToLower().Contains(tuKhoa)) ||
                                        (h.NhanVien != null && h.NhanVien.HoTen.ToLower().Contains(tuKhoa)));
            }

            var dsHoaDon = query.Select(h => new DanhSachHoaDonMua
            {
                ID = h.ID,
                NgayNhap = h.NgayNhap,
                TongTien = h.TongTien,
                GhiChu = h.GhiChu,
                NhaCungCapID = h.NhaCungCapID,
                TenNhanVien = h.NhanVien != null ? h.NhanVien.HoTen : "",
                TenNhaCungCap = h.NhaCungCap != null ? h.NhaCungCap.TenNhaCungCap : ""
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dsHoaDon;

            txtID.DataBindings.Clear();
            datNgayNhap.DataBindings.Clear();
            txtTongTien.DataBindings.Clear();
            txtNhanVienNhap.DataBindings.Clear();
            cboNhaCungCap.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();

            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);
            datNgayNhap.DataBindings.Add("Value", bindingSource, "NgayNhap", true, DataSourceUpdateMode.Never);
            txtTongTien.DataBindings.Add("Text", bindingSource, "TongTien", true, DataSourceUpdateMode.Never, 0, "#,##0");
            txtNhanVienNhap.DataBindings.Add("Text", bindingSource, "TenNhanVien", false, DataSourceUpdateMode.Never);
            cboNhaCungCap.DataBindings.Add("SelectedValue", bindingSource, "NhaCungCapID", false, DataSourceUpdateMode.Never);
            txtGhiChu.DataBindings.Add("Text", bindingSource, "GhiChu", false, DataSourceUpdateMode.Never);

            dgvHoaDonMua.DataSource = bindingSource;
        }

        private void frmHoaDonMua_Load(object sender, EventArgs e)
        {
            dgvHoaDonMua.AutoGenerateColumns = false;
            BatTatChucNang(false);
            LoadComboBox();
            SetupAutoComplete(); // Gọi 1 lần khi load Form
            LoadData();
        }

        private void picThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtID.Clear();
            cboNhaCungCap.SelectedIndex = -1;
            datNgayNhap.Value = DateTime.Now;
            txtGhiChu.Clear();
            txtTongTien.Text = "0";

            txtNhanVienNhap.Text = tenThuKhoDangTruc;
        }

        private void picSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonMua.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dgvHoaDonMua.CurrentRow.Cells["colID"].Value?.ToString());
        }

        private void picHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void picLuu_Click(object sender, EventArgs e)
        {
            if (cboNhaCungCap.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 2. CHỐT CHẶN BẢO MẬT: Kiểm tra xem ID nhân viên truyền vào có hợp lệ không
            if (idThuKhoDangTruc <= 0)
            {
                MessageBox.Show("Lỗi phân quyền: Hệ thống không xác định được danh tính nhân viên đang lập phiếu! Vui lòng đăng nhập lại.", "Lỗi bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return; // Chặn đứng, không cho chạy lệnh SaveChanges() gây sập DB
            }
            try
            {
                if (xuLyThem)
                {
                    HoaDonMua hdm = new HoaDonMua();
                    hdm.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                    hdm.NhanVienID = idThuKhoDangTruc; // Đã sửa lỗi: Gán đúng ID nhân viên đăng nhập
                    hdm.NgayNhap = datNgayNhap.Value;
                    hdm.GhiChu = txtGhiChu.Text;
                    hdm.TongTien = 0;

                    context.HoaDonMua.Add(hdm);
                    context.SaveChanges();
                    MessageBox.Show("Tạo hóa đơn mua thành công! Hãy chọn hóa đơn và bấm Xem Chi Tiết để nhập hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    HoaDonMua? hdm = context.HoaDonMua.Find(id);
                    if (hdm != null)
                    {
                        hdm.NhaCungCapID = Convert.ToInt32(cboNhaCungCap.SelectedValue);
                        hdm.NgayNhap = datNgayNhap.Value;
                        hdm.GhiChu = txtGhiChu.Text;

                        context.HoaDonMua.Update(hdm);
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thông tin hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                BatTatChucNang(false);
                LoadData();
                SetupAutoComplete();
            }
            catch (Exception ex)
            {
                string loiChiTiet = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi chi tiết từ Database:\n" + loiChiTiet, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonMua.CurrentRow == null) return;

            int idXoa = Convert.ToInt32(dgvHoaDonMua.CurrentRow.Cells["colID"].Value?.ToString());

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập kho này không? Mọi chi tiết nhập hàng bên trong sẽ bị xóa theo!", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var hdm = context.HoaDonMua.Include(h => h.ChiTietHoaDonMuas).FirstOrDefault(h => h.ID == idXoa);

                    if (hdm != null)
                    {
                        if (hdm.ChiTietHoaDonMuas != null && hdm.ChiTietHoaDonMuas.Count > 0)
                        {
                            context.ChiTietHoaDonMua.RemoveRange(hdm.ChiTietHoaDonMuas);
                        }

                        context.HoaDonMua.Remove(hdm);
                        context.SaveChanges();

                        MessageBox.Show("Xóa hóa đơn mua thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BatTatChucNang(false);
                        LoadData();
                        SetupAutoComplete();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picXem_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonMua.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maHoaDon = Convert.ToInt32(dgvHoaDonMua.CurrentRow.Cells["colID"].Value?.ToString());

            frmChiTietHoaDonMua frmCT = new frmChiTietHoaDonMua(maHoaDon);
            frmCT.ShowDialog();

            LoadData();
        }

        private void picThemNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap("");
            frm.ShowDialog();
            LoadComboBox();
            SetupAutoComplete();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InHoaDon_Click(object sender, EventArgs e)
        {
            

            // 1. Kiểm tra xem người dùng đã chọn dòng hóa đơn nào trên lưới chưa
            if (dgvHoaDonMua.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn từ danh sách để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Lấy Mã Hóa Đơn (ID) từ cột của dòng đang chọn
               
                int maHoaDon = Convert.ToInt32(dgvHoaDonMua.CurrentRow.Cells["colID"].Value?.ToString());

                // 3. Khởi tạo Form In và truyền mã hóa đơn sang
                frmInHoaDon frmIn = new frmInHoaDon(maHoaDon);

                // Mở Form In lên 
                frmIn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form in: " + ex.Message, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            //lọc ngày 
            DateTime? ngay = datTimKiem.Checked ? datTimKiem.Value : (DateTime?)null;
            LoadData(txtTimKiem.Text, ngay);
        }

        private void datTimKiem_ValueChanged(object sender, EventArgs e)
        {
            DateTime? ngay = datTimKiem.Checked ? datTimKiem.Value : (DateTime?)null;
            LoadData(txtTimKiem.Text, ngay);
        }

        // ==========================================
        // CHỨC NĂNG XUẤT EXCEL TỔNG QUAN HÓA ĐƠN
        // ==========================================
        private void picXuatDuLieu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách Hóa Đơn Mua ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DS_HoaDonMua_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 1. Tạo bảng cấu trúc cho Sheet 1 (Thông tin chung của Phiếu Nhập)
                    DataTable tableHoaDon = new DataTable();
                    tableHoaDon.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID Hóa Đơn", typeof(int)),
                new DataColumn("Ngày Nhập", typeof(string)),
                new DataColumn("Tên Nhà Cung Cấp", typeof(string)),
                new DataColumn("Tên Nhân Viên", typeof(string)),
                new DataColumn("Tổng Tiền", typeof(double)),
                new DataColumn("Ghi Chú", typeof(string))
            });

                    // 2. Tạo bảng cấu trúc cho Sheet 2 (Chi tiết mặt hàng nhập)
                    DataTable tableChiTiet = new DataTable();
                    tableChiTiet.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID Hóa Đơn", typeof(int)), // Cột liên kết để biết chi tiết thuộc HĐ nào
                new DataColumn("Tên Sản Phẩm", typeof(string)),
                new DataColumn("Số Lượng Nhập", typeof(int)),
                new DataColumn("Đơn Giá Nhập", typeof(double)),
                new DataColumn("Thành Tiền", typeof(double))
            });

                    // 3. Lấy dữ liệu từ Database (Móc cả Nhà Cung Cấp, Nhân Viên, Chi Tiết và Sản Phẩm)
                    var dsHDM = context.HoaDonMua
                                       .Include(h => h.NhaCungCap)
                                       .Include(h => h.NhanVien)
                                       .Include(h => h.ChiTietHoaDonMuas) // Móc danh sách chi tiết
                                           .ThenInclude(c => c.PhienBanSanPham).ThenInclude(pb => pb.SanPham)   // Từ chi tiết móc ra tên Sản Phẩm
                                       .ToList();

                    // 4. Đổ dữ liệu vào 2 bảng ảo
                    foreach (var hdm in dsHDM)
                    {
                        // Thêm 1 dòng vào bảng Hóa Đơn
                        tableHoaDon.Rows.Add(
                            hdm.ID,
                            hdm.NgayNhap.ToString("dd/MM/yyyy HH:mm"),
                            hdm.NhaCungCap != null ? hdm.NhaCungCap.TenNhaCungCap : "",
                            hdm.NhanVien != null ? hdm.NhanVien.HoTen : "",
                            hdm.TongTien,
                            hdm.GhiChu
                        );

                        // Duyệt qua các chi tiết của hóa đơn này và thêm nhiều dòng vào bảng Chi Tiết
                        if (hdm.ChiTietHoaDonMuas != null && hdm.ChiTietHoaDonMuas.Count > 0)
                        {
                            foreach (var ct in hdm.ChiTietHoaDonMuas)
                            {
                                tableChiTiet.Rows.Add(
                                    hdm.ID, // Mã Hóa Đơn
                                    ct.PhienBanSanPham != null ? ct.PhienBanSanPham.SanPham.TenSP + " (" + ct.PhienBanSanPham.BoNho + " " + ct.PhienBanSanPham.MauSac + ")" : "SP Lỗi", ct.SoLuong,
                                    ct.DonGia,  // Lấy đơn giá nhập
                                    ct.SoLuong * ct.DonGia // Tính thành tiền
                                );
                            }
                        }
                    }

                    // 5. Sử dụng ClosedXML để ghi 2 bảng ra 2 Sheet trong file Excel
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        // Thêm Sheet 1 (Hóa Đơn Mua)
                        var sheetHD = wb.Worksheets.Add(tableHoaDon, "HoaDonMua");
                        sheetHD.Columns().AdjustToContents(); // Tự căn lề cho đẹp

                        // Thêm Sheet 2 (Chi Tiết Hóa Đơn Mua)
                        var sheetCT = wb.Worksheets.Add(tableChiTiet, "ChiTietHoaDonMua");
                        sheetCT.Columns().AdjustToContents();

                        // Lưu file Excel
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu Hóa Đơn Mua và Chi Tiết ra 2 Sheet của tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================
        // CHỨC NĂNG NHẬP EXCEL (Nhập danh sách Hóa đơn trống)
        // ==========================================
        private void picNhapDuLieu_Click(object sender, EventArgs e)
        {
            // Lưu ý: Tính năng này chỉ nhập vỏ Hóa Đơn (không có sản phẩm bên trong). 
            // Thường dùng để khởi tạo nhanh sổ sách ngày cũ.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập danh sách Hóa Đơn Nhập từ Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        int countSuccess = 0;

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                firstRow = false; // Bỏ qua dòng tiêu đề
                                continue;
                            }

                            HoaDonMua hdm = new HoaDonMua();

                            // Lấy thông tin từ các cột (Cần định dạng cột chuẩn: 1-Ngày Nhập, 2-ID Nhà Cung Cấp, 3-ID Nhân Viên, 4-Ghi chú)
                            DateTime ngayNhap;
                            if (DateTime.TryParse(row.Cell(1).Value.ToString(), out ngayNhap))
                                hdm.NgayNhap = ngayNhap;
                            else hdm.NgayNhap = DateTime.Now;

                            hdm.NhaCungCapID = Convert.ToInt32(row.Cell(2).Value.ToString());
                            hdm.NhanVienID = Convert.ToInt32(row.Cell(3).Value.ToString());
                            hdm.GhiChu = row.Cell(4).Value.ToString();
                            hdm.TongTien = 0; // Hóa đơn nhập từ excel chưa có chi tiết

                            context.HoaDonMua.Add(hdm);
                            countSuccess++;
                        }

                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {countSuccess} hóa đơn mới. Hãy mở xem chi tiết để nhập số lượng sản phẩm.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        SetupAutoComplete();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi định dạng file hoặc dữ liệu. Yêu cầu 4 cột: NgàyNhập, IDNhàCungCấp, IDNhânViên, GhiChú.\nChi tiết lỗi: " + ex.Message, "Lỗi nhập Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
