using ClosedXML.Excel;  // Thư viện xuất nhập Excel
using Microsoft.EntityFrameworkCore;
using QuanLyBanDTDD.Data;
using QuanLyBanDTDD.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanDTDD.Forms
{
    public partial class frmHoaDonBan : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext();
        bool xuLyThem = false;
        string id;

        // Nhận dữ liệu nhân viên đăng nhập từ frmMain
        int idNhanVienDangTruc;
        string tenNhanVienDangTruc;

        public frmHoaDonBan(int idNV, string tenNV)
        {
            InitializeComponent();
            this.idNhanVienDangTruc = idNV;
            this.tenNhanVienDangTruc = tenNV;
        }

        
        // 1. CÁC HÀM TIỆN ÍCH
        private void HieuUngNutBam(PictureBox pic, bool duocPhepBam)
        {
            if (pic != null)
            {
                pic.Enabled = duocPhepBam;
                pic.BackColor = duocPhepBam ? Color.Transparent : Color.Silver;
                pic.Cursor = duocPhepBam ? Cursors.Hand : Cursors.Default;
            }
        }

        private void BatTatChucNang(bool dangThaoTac)
        {
            datNgayBan.Enabled = dangThaoTac;
            cboKhachHang.Enabled = dangThaoTac;
            txtGhiChu.Enabled = dangThaoTac;

            HieuUngNutBam(picThem, !dangThaoTac);
            HieuUngNutBam(picSua, !dangThaoTac);
            HieuUngNutBam(picXoa, !dangThaoTac);
            HieuUngNutBam(picXem, !dangThaoTac);
            
            HieuUngNutBam(picInHoaDon, !dangThaoTac); 

            HieuUngNutBam(picLuu, dangThaoTac);
            HieuUngNutBam(picHuyBo, dangThaoTac);
        }

        private void LoadComboBox()
        {
            cboKhachHang.DataSource = context.KhachHang.ToList();
            cboKhachHang.DisplayMember = "HoTen";
            cboKhachHang.ValueMember = "ID";
            cboKhachHang.SelectedIndex = -1;
        }

        //  hàm tạo gợi ý tìm kiếm
        private void SetupAutoComplete()
        {
            try
            {
                AutoCompleteStringCollection danhSachGoiY = new AutoCompleteStringCollection();

                var listTenKH = context.KhachHang
                                       .Where(n => !string.IsNullOrEmpty(n.HoTen))
                                       .Select(n => n.HoTen).ToList();

                var listSDT = context.KhachHang
                                     .Where(n => !string.IsNullOrEmpty(n.SDT))
                                     .Select(n => n.SDT).ToList();

                danhSachGoiY.AddRange(listTenKH.ToArray());
                danhSachGoiY.AddRange(listSDT.ToArray());

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
            if (tuKhoa == "nhập tên hoặc sđt để tìm kiếm...") tuKhoa = "";

            var query = context.HoaDonBan
                               .Include(h => h.NhanVien)
                               .Include(h => h.KhachHang)
                               .AsQueryable();

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(h => h.ID.ToString() == tuKhoa ||
                                        (h.KhachHang != null && h.KhachHang.HoTen.ToLower().Contains(tuKhoa)) ||
                                        (h.KhachHang != null && h.KhachHang.SDT.Contains(tuKhoa)));
            }

            if (ngayLoc.HasValue)
            {
                query = query.Where(h => h.NgayBan.Date == ngayLoc.Value.Date);
            }

            List<DanhSachHoaDonBan> dsHoaDon = query.Select(h => new DanhSachHoaDonBan
            {
                ID = h.ID,
                NgayBan = h.NgayBan,
                TongTien = h.TongTien,
                GhiChu = h.GhiChu,
                KhachHangID = h.KhachHangID,
                TenNhanVien = h.NhanVien != null ? h.NhanVien.HoTen : "",
                TenKhachHang = h.KhachHang != null ? h.KhachHang.HoTen : "",
                TrangThai = h.TrangThai
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dsHoaDon;

            txtID.DataBindings.Clear();
            datNgayBan.DataBindings.Clear();
            txtTongTien.DataBindings.Clear();
            txtNhanVienNhap.DataBindings.Clear();
            cboKhachHang.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();

            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);
            datNgayBan.DataBindings.Add("Value", bindingSource, "NgayBan", true, DataSourceUpdateMode.Never);
            txtTongTien.DataBindings.Add("Text", bindingSource, "TongTien", true, DataSourceUpdateMode.Never, 0, "#,##0");
            txtNhanVienNhap.DataBindings.Add("Text", bindingSource, "TenNhanVien", false, DataSourceUpdateMode.Never);
            cboKhachHang.DataBindings.Add("SelectedValue", bindingSource, "KhachHangID", false, DataSourceUpdateMode.Never);
            txtGhiChu.DataBindings.Add("Text", bindingSource, "GhiChu", false, DataSourceUpdateMode.Never);

            dgvHoaDonBan.DataSource = bindingSource;
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            dgvHoaDonBan.AutoGenerateColumns = false;
            BatTatChucNang(false);
            LoadComboBox();
            SetupAutoComplete(); // Gọi khởi tạo gợi ý
            LoadData();
        }

       
        // 2. XỬ LÝ CÁC NÚT THAO TÁC (CRUD)
       
        private void picThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtID.Clear();
            cboKhachHang.SelectedIndex = -1;
            datNgayBan.Value = DateTime.Now;
            txtGhiChu.Clear();
            txtTongTien.Text = "0";

            txtNhanVienNhap.Text = tenNhanVienDangTruc;
        }

        private void picSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonBan.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);
            id = dgvHoaDonBan.CurrentRow.Cells["colID"].Value?.ToString();
        }

        private void picHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void picLuu_Click(object sender, EventArgs e)
        {


            if (cboKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng hoặc thêm khách hàng mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               
                context.ChangeTracker.Clear();
                if (xuLyThem) 
                {
                    HoaDonBan hdb = new HoaDonBan();

                    //Lấy tiền tố ngày hiện tại (Ví dụ: 260326)
                    string ngayPrefix = datNgayBan.Value.ToString("ddMMyy");

                    //Tìm mã hóa đơn lớn nhất trong ngày hôm nay bắt đầu bằng ngayPrefix
                    var maLonNhatTrongNgay = context.HoaDonBan
                        .Where(h => h.ID.StartsWith(ngayPrefix))
                        .OrderByDescending(h => h.ID)
                        .Select(h => h.ID)
                        .FirstOrDefault();

                    int soThuTuMoi = 1;

                    if (maLonNhatTrongNgay != null)
                    {
                        // Cắt 2 ký tự cuối của mã lớn nhất và cộng thêm 1
                        
                        string sttHienTai = maLonNhatTrongNgay.Substring(maLonNhatTrongNgay.Length - 2);
                        soThuTuMoi = int.Parse(sttHienTai) + 1;
                    }

                    // Lấy mã khách hàng (2 số)
                    int idKH = Convert.ToInt32(cboKhachHang.SelectedValue);
                    string maKH = idKH.ToString("00");

                    //Ghép lại thành ID mới: Ngày(6) + MãKH(2) + STT(2) = 10 ký tự
                    hdb.ID = ngayPrefix + maKH + soThuTuMoi.ToString("00");


                    // ====================================================

                    hdb.KhachHangID = idKH;
                    hdb.NhanVienID = idNhanVienDangTruc;
                    hdb.NgayBan = datNgayBan.Value;
                    hdb.GhiChu = txtGhiChu.Text;
                    hdb.TongTien = 0;
                   
                    
                   
                    hdb.TrangThai = "Chưa thanh toán";

                    context.HoaDonBan.Add(hdb);
                    context.SaveChanges();
                    MessageBox.Show("Tạo hóa đơn bán thành công! Mã HĐ: " + hdb.ID + "\nHãy bấm 'Xem chi tiết' để chọn mặt hàng bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    HoaDonBan? hdb = context.HoaDonBan.Find(id); 
                    if (hdb != null)
                    {
                        hdb.KhachHangID = Convert.ToInt32(cboKhachHang.SelectedValue);
                        hdb.NgayBan = datNgayBan.Value;
                        hdb.GhiChu = txtGhiChu.Text;

                        context.HoaDonBan.Update(hdb);
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật hóa đơn bán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                BatTatChucNang(false);
                LoadData();
                SetupAutoComplete();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi chi tiết: " + msg, "Lỗi hệ thống");
            }
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonBan.CurrentRow == null) return;
            string? idXoa = dgvHoaDonBan.CurrentRow.Cells["colID"].Value?.ToString();

            if (MessageBox.Show("Xóa hóa đơn bán này sẽ hoàn trả lại số lượng tồn kho. Bạn có chắc chắn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var hdb = context.HoaDonBan.Include(h => h.ChiTietHoaDonBans).FirstOrDefault(h => h.ID == idXoa);
                    if (hdb != null)
                    {
                        if (hdb.ChiTietHoaDonBans != null && hdb.ChiTietHoaDonBans.Count > 0)
                        {
                            foreach (var ct in hdb.ChiTietHoaDonBans)
                            {
                                var sp = context.SanPham.Find(ct.PhienBanSanPhamID);
                                
                            }
                            context.ChiTietHoaDonBan.RemoveRange(hdb.ChiTietHoaDonBans);
                        }

                        context.HoaDonBan.Remove(hdb);
                        context.SaveChanges();

                        MessageBox.Show("Xóa hóa đơn bán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BatTatChucNang(false);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // 3. XỬ LÝ TÌM KIẾM, XEM CHI TIẾT & IN ẤN



        private void picTimKiem_Click(object sender, EventArgs e)
        {
            DateTime? ngay = datTimKiem.Checked ? datTimKiem.Value : (DateTime?)null;
            LoadData(txtTimKiem.Text, ngay);
        }

        private void datTimKiem_ValueChanged(object sender, EventArgs e)
        {
            DateTime? ngay = datTimKiem.Checked ? datTimKiem.Value : (DateTime?)null;
            LoadData(txtTimKiem.Text, ngay);
        }

        private void picXem_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonBan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xem chi tiết bán hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maHoaDon = dgvHoaDonBan.CurrentRow.Cells["colID"].Value?.ToString() ?? "";

            // Sau khi bạn tạo form frmChiTietHoaDonBan, hãy mở khóa 2 dòng dưới
            frmChiTietHoaDonBan frmCT = new frmChiTietHoaDonBan(maHoaDon);
            frmCT.ShowDialog();

            LoadData();
        }

        private void picThemKH_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang("");
            frm.ShowDialog();
            LoadComboBox();
            SetupAutoComplete(); // Nạp lại Khách hàng mới vào gợi ý
        }

        // Giả định bạn có nút In hóa đơn tên là picInHoaDon
        private void picInHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonBan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string? maHoaDon = dgvHoaDonBan.CurrentRow.Cells["colID"].Value?.ToString();


            try
            {
               
                string? maHDB = dgvHoaDonBan.CurrentRow.Cells["colID"].Value?.ToString();
               
                frmInHoaDonBan frmIn = new frmInHoaDonBan(maHDB);


                frmIn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in: " + ex.Message);
            }
        }

       
        // 4. NHẬP / XUẤT EXCEL
    
        private void picXuatDuLieu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách Hóa Đơn Bán ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DS_HoaDonBan_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //  Tạo bảng cấu trúc cho Sheet 1 (Thông tin chung)
                    DataTable tableHoaDon = new DataTable();
                    tableHoaDon.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID Hóa Đơn", typeof(string)),
                new DataColumn("Ngày Bán", typeof(string)),
                new DataColumn("Tên Khách Hàng", typeof(string)),
                new DataColumn("Tên Nhân Viên", typeof(string)),
                new DataColumn("Tổng Tiền", typeof(double)),
                new DataColumn("Ghi Chú", typeof(string))
            });

                   
                    //Tạo bảng cấu trúc cho Sheet 2 (Chi tiết mặt hàng)
                    DataTable tableChiTiet = new DataTable();
                    tableChiTiet.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID Hóa Đơn", typeof(string)), 
                new DataColumn("Tên Sản Phẩm", typeof(string)),
                new DataColumn("Số Lượng Bán", typeof(int)),
                new DataColumn("Đơn Giá Bán", typeof(double)),
                new DataColumn("Thành Tiền", typeof(double))
            });

                    //  Lấy dữ liệu từ Database ( cả Khách, Nhân Viên, Chi Tiết và Sản Phẩm)
                    var dsHDB = context.HoaDonBan
                                       .Include(h => h.KhachHang)
                                       .Include(h => h.NhanVien)
                                       .Include(h => h.ChiTietHoaDonBans) 
                                           .ThenInclude(c => c.PhienBanSanPham).ThenInclude(pb => pb.SanPham)   
                                       .ToList();

                    // Đổ dữ liệu vào 2 bảng ảo
                    foreach (var hdb in dsHDB)
                    {
                        // Thêm dòng vào bảng Hóa Đơn
                        tableHoaDon.Rows.Add(
                            hdb.ID,
                            hdb.NgayBan.ToString("dd/MM/yyyy HH:mm"),
                            hdb.KhachHang?.HoTen,
                            hdb.NhanVien?.HoTen,
                            hdb.TongTien,
                            hdb.GhiChu
                        );

                        // Duyệt qua các chi tiết của hóa đơn này và thêm nhiều dòng vào bảng Chi Tiết
                        if (hdb.ChiTietHoaDonBans != null)
                        {
                            foreach (var ct in hdb.ChiTietHoaDonBans)
                            {
                                tableChiTiet.Rows.Add(
                                    hdb.ID, // Mã HĐ
                                    ct.PhienBanSanPham != null ? ct.PhienBanSanPham.SanPham.TenSP : "SP Lỗi",
                                    ct.SoLuong,
                                    ct.DonGia,
                                    ct.SoLuong * ct.DonGia 
                                );
                            }
                        }
                    }

                    
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        // Thêm Sheet 1
                        var sheetHD = wb.Worksheets.Add(tableHoaDon, "HoaDonBan");
                        sheetHD.Columns().AdjustToContents(); // Tự căn độ rộng cột

                        // Thêm Sheet 2
                        var sheetCT = wb.Worksheets.Add(tableChiTiet, "ChiTietHoaDonBan");
                        sheetCT.Columns().AdjustToContents();

                        
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu Hóa Đơn và Chi Tiết ra 2 Sheet của tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picNhapDuLieu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập danh sách Hóa Đơn Bán từ Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        int soHoaDonThem = 0;
                        int soChiTietThem = 0;

                        //SHEET1 thông tin chung về Hóa Đơn
                        var sheet1 = workbook.Worksheet(1);
                        foreach (var row in sheet1.RowsUsed().Skip(1))
                        {
                            string idHoaDon = row.Cell(1).Value.ToString().Trim();
                            if (string.IsNullOrWhiteSpace(idHoaDon)) continue;

                            if (context.HoaDonBan.Any(h => h.ID == idHoaDon)) continue; //bỏ qua nếu đã tồn tại mã HĐ này trong DB

                            HoaDonBan hdb = new HoaDonBan();
                            hdb.ID = idHoaDon;

                            if (DateTime.TryParse(row.Cell(2).Value.ToString(), out DateTime ngayBan))
                                hdb.NgayBan = ngayBan;
                            else
                                hdb.NgayBan = DateTime.Now;

                            string tenKH = row.Cell(3).Value.ToString().Trim().ToLower();
                            var khach = context.KhachHang.FirstOrDefault(k => k.HoTen.ToLower() == tenKH);
                            hdb.KhachHangID = khach != null ? khach.ID : 1;

                            string tenNV = row.Cell(4).Value.ToString().Trim().ToLower();
                            var nhanVien = context.NhanVien.FirstOrDefault(nv => nv.HoTen.ToLower() == tenNV);
                            hdb.NhanVienID = nhanVien != null ? nhanVien.ID : 1;

                            hdb.TongTien = 0;
                            hdb.GhiChu = row.Cell(6).Value.ToString();
                            hdb.TrangThai = "Chưa thanh toán";

                            context.HoaDonBan.Add(hdb);
                            soHoaDonThem++;
                        }

                        context.SaveChanges();

                        //sheet2 chứa chi tiết sản phẩm của từng hóa đơn, dựa vào ID Hóa Đơn để liên kết
                        if (workbook.Worksheets.Count > 1)
                        {
                            var sheet2 = workbook.Worksheet(2);
                            foreach (var row in sheet2.RowsUsed().Skip(1))
                            {
                                string idHoaDon = row.Cell(1).Value.ToString().Trim();
                                string tenSP = row.Cell(2).Value.ToString().Trim().ToLower(); //  chữ thường 

                                if (string.IsNullOrWhiteSpace(idHoaDon) || string.IsNullOrWhiteSpace(tenSP)) continue;

                                
                                var sp = context.SanPham.FirstOrDefault(s => s.TenSP.ToLower() == tenSP);
                                if (sp != null)
                                {
                                    var phienBan = context.PhienBanSanPham.FirstOrDefault(pb => pb.SanPhamID == sp.ID);
                                    if (phienBan != null)
                                    {
                                        ChiTietHoaDonBan ct = new ChiTietHoaDonBan();
                                        ct.HoaDonBanID = idHoaDon;
                                        ct.PhienBanSanPhamID = phienBan.IDPhienBan;

                                        if (int.TryParse(row.Cell(3).Value.ToString(), out int soLuong)) ct.SoLuong = soLuong;
                                        else ct.SoLuong = 1;

                                        if (decimal.TryParse(row.Cell(4).Value.ToString(), out decimal donGia)) ct.DonGia = donGia;
                                        else ct.DonGia = phienBan.GiaBan;

                                        context.ChiTietHoaDonBan.Add(ct);
                                        soChiTietThem++;

                                        // Cập nhật tổng tiền cho Hóa Đơn gốc
                                        var hdGoc = context.HoaDonBan.Find(idHoaDon);
                                        if (hdGoc != null)
                                        {
                                            hdGoc.TongTien += (ct.SoLuong * ct.DonGia);
                                            context.HoaDonBan.Update(hdGoc); 
                                        }
                                    }
                                }
                            }
                            context.SaveChanges();
                        }

                        MessageBox.Show($"Nhập dữ liệu thành công!\n- Số Hóa Đơn: {soHoaDonThem}\n- Số Chi Tiết (Sản Phẩm): {soChiTietThem}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        context.ChangeTracker.Clear();
                        LoadData();
                        SetupAutoComplete();
                    }
                }
                catch (Exception ex)
                {
                    var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    MessageBox.Show("Lỗi nhập Excel: " + msg, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
       

        private void picThanhToan_Click(object sender, EventArgs e)
        {
          
            if (dgvHoaDonBan.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
          
            string? trangThai = dgvHoaDonBan.CurrentRow.Cells["colTrangThai"].Value?.ToString();

            // đã thanh toán rồi thì báo lỗi và DỪNG LẠI
            if (trangThai == "Đã thanh toán")
            {
                MessageBox.Show("Hóa đơn này đã được thanh toán hoàn tất! Bạn không thể thanh toán lại.", "Chặn thao tác", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

           
            string idCanThanhToan = txtID.Text;
            frmThanhToan frm = new frmThanhToan(idCanThanhToan);

            if (frm.ShowDialog() == DialogResult.OK)
            {
         
                LoadData();
            }
        }
    }
}
