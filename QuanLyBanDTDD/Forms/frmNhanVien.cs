using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using QuanLyBanDTDD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using ClosedXML.Excel;
using System.IO;

namespace QuanLyBanDTDD.Forms
{
    public partial class frmNhanVien : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lưu ID của nhân viên khi bấm Sửa hoặc Xóa
        bool daCoTaiKhoanCu = false;
        public frmNhanVien()
        {
            InitializeComponent();
            datNgaySinh.Value = new DateTime(2008, 1, 1);
            datNgaySinh.MaxDate = DateTime.Now.AddYears(-18); 
            datNgaySinh.MinDate = DateTime.Now.AddYears(-39);
        }

        private void HieuUngNutBam(PictureBox pic, bool duocPhepBam)
        {
            pic.Enabled = duocPhepBam; // Khóa/Mở chức năng click

            if (duocPhepBam)
            {
                // Nếu ĐƯỢC bấm: Nền trong suốt tệp với màu xanh của Form, chuột biến thành hình bàn tay
                pic.BackColor = Color.Transparent;
                pic.Cursor = Cursors.Hand;
            }
            else
            {
                // Nếu BỊ KHÓA: Nền chuyển màu xám bạc, chuột trở lại bình thường
                pic.BackColor = Color.Silver;
                pic.Cursor = Cursors.Default;
            }
        }
        private void BatTatChucNang(bool dangThaoTac)
        {

            // Bật/tắt ô nhập liệu
            txtHoTen.Enabled = dangThaoTac;
            cboGioiTinh.Enabled = dangThaoTac;
            datNgaySinh.Enabled = dangThaoTac;
            txtSDT.Enabled = dangThaoTac;
            txtDiaChi.Enabled = dangThaoTac;
            cboChucVu.Enabled = dangThaoTac;
            cboTrangThai.Enabled = dangThaoTac;
            txtTenDN.Enabled = dangThaoTac;
            txtMatKhau.Enabled = dangThaoTac;
            cboQuyenHan.Enabled = dangThaoTac;

            // Gọi hàm tạo hiệu ứng ---
            HieuUngNutBam(picThem, !dangThaoTac);
            HieuUngNutBam(picSua, !dangThaoTac);
            HieuUngNutBam(picXoa, !dangThaoTac);

            HieuUngNutBam(picLuu, dangThaoTac);
            HieuUngNutBam(picHuyBo, dangThaoTac);
        }

        private void LoadData(string tuKhoa = "")
        {
            // Chuẩn hóa từ khóa: Xóa khoảng trắng 2 đầu và chuyển thành chữ thường để dễ tìm
            tuKhoa = tuKhoa.Trim().ToLower();

            // 1. Lấy dữ liệu từ Database (Chưa Select vội)
            var query = context.NhanVien.Include(nv => nv.TaiKhoan).AsQueryable();

            // 2. NẾU CÓ GÕ TÌM KIẾM -> TIẾN HÀNH LỌC DỮ LIỆU
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                // Lọc: Nếu Tên chứa từ khóa HOẶC SĐT chứa từ khóa thì mới giữ lại
                query = query.Where(nv => nv.HoTen.ToLower().Contains(tuKhoa) || nv.SDT.Contains(tuKhoa));
            }

            // 3. Đổ dữ liệu (đã lọc hoặc chưa lọc) vào Class ảo để hiển thị
            var dsNhanVien = query.Select(nv => new DanhSachNhanVien
            {
                ID = nv.ID,
                HoTen = nv.HoTen,
                NgaySinh = nv.NgaySinh ?? new DateTime(2005, 1, 1),
                GioiTinh = nv.GioiTinh,
                DiaChi = nv.DiaChi,
                SDT = nv.SDT,
                ChucVu = nv.ChucVu,
                TrangThai = nv.TrangThai,
                TenDangNhap = nv.TaiKhoan != null ? nv.TaiKhoan.TenDangNhap : "",
                QuyenHan = nv.TaiKhoan != null ? nv.TaiKhoan.QuyenHan : ""
            }).ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dsNhanVien;

            // XÓA BINDING CŨ
            txtID.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtTenDN.DataBindings.Clear();
            datNgaySinh.DataBindings.Clear();
            cboGioiTinh.DataBindings.Clear();
            cboChucVu.DataBindings.Clear();
            cboTrangThai.DataBindings.Clear();
            cboQuyenHan.DataBindings.Clear();

            // GÁN BINDING MỚI
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);
            txtHoTen.DataBindings.Add("Text", bindingSource, "HoTen", false, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Add("Text", bindingSource, "SDT", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtTenDN.DataBindings.Add("Text", bindingSource, "TenDangNhap", false, DataSourceUpdateMode.Never);
            datNgaySinh.DataBindings.Add("Value", bindingSource, "NgaySinh", true, DataSourceUpdateMode.Never);

            cboGioiTinh.DataBindings.Add("Text", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);
            cboChucVu.DataBindings.Add("Text", bindingSource, "ChucVu", false, DataSourceUpdateMode.Never);
            cboTrangThai.DataBindings.Add("Text", bindingSource, "TrangThai", false, DataSourceUpdateMode.Never);
            cboQuyenHan.DataBindings.Add("Text", bindingSource, "QuyenHan", false, DataSourceUpdateMode.Never);

            // Mỗi khi nhảy dòng, xóa trắng ô mật khẩu cho an toàn
            bindingSource.CurrentChanged += (s, e) => { txtMatKhau.Clear(); };

            dgvNhanVien.DataSource = bindingSource;
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            
        
        BatTatChucNang(false);
            dgvNhanVien.AutoGenerateColumns = false;
            LoadData();
        }


        private void picThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            // Xóa các ô nhập liệu
            txtID.Clear();
            txtHoTen.Clear();
            cboGioiTinh.SelectedIndex = -1;
            datNgaySinh.Value = new DateTime(2008, 1, 1);            
            txtSDT.Clear();
            txtDiaChi.Clear();
            cboChucVu.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            txtTenDN.Clear();
            txtMatKhau.Clear();
            cboQuyenHan.SelectedIndex = -1;

            txtHoTen.Focus();


        }

        private void picSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;
            xuLyThem = false;
            daCoTaiKhoanCu = !string.IsNullOrWhiteSpace(txtTenDN.Text);
            BatTatChucNang(true);

            // Lấy ID từ dòng hiện tại trên lưới (Dùng đúng cột colID như đã đặt Name)
            id = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["colID"].Value?.ToString());
        }

        private void picLuu_Click(object sender, EventArgs e)
        {
            string SDT = txtSDT.Text.Trim();
            string tenDN = txtTenDN.Text.Trim();

            // ==========================================
            // 1. KIỂM TRA BẮT BUỘC NHẬP VÀ TÍNH HỢP LỆ BẰNG IF... ELSE IF
            // ==========================================
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên nhân viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }
            if (datNgaySinh.Value > DateTime.Now.AddYears(-18))
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!", "Lỗi dữ liệu",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                datNgaySinh.Focus();
                return;

            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            // kiểm tra định dạng SĐT: 10 số, bắt đầu bằng 0, không chứa chữ cái 
            if (SDT.Length != 10 || !SDT.StartsWith("0") || !SDT.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải là 10 số, bắt đầu từ 0 và không chứa chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            //  Kiểm tra trùng SĐT trong Database
            if (context.NhanVien.Any(nv => nv.SDT == SDT && (xuLyThem || nv.ID != id)))
            {
                MessageBox.Show("Số điện thoại này đã được đăng ký cho nhân viên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
             if (string.IsNullOrWhiteSpace(cboChucVu.Text))
            {
                MessageBox.Show("Chức vụ không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboChucVu.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cboTrangThai.Text))
            {
                MessageBox.Show("Trạng thái không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTrangThai.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenDN.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập cho nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDN.Focus();
                return;
            }
            // (CODE MỚI): Kiểm tra trùng Tên đăng nhập trong Database
            if (context.NhanVien.Any(nv => nv.TaiKhoan != null && nv.TaiKhoan.TenDangNhap == tenDN && (xuLyThem || nv.ID != id)))
            {
                MessageBox.Show("Tên đăng nhập này đã có người sử dụng. Vui lòng chọn tên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDN.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cboQuyenHan.Text))
            {
                MessageBox.Show("Vui lòng chọn Quyền hạn cho người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboQuyenHan.Focus();
                return;
            }
            
            else
            {
                // ==========================================
                // 2. NẾU VƯỢT QUA HẾT LỖI -> TIẾN HÀNH LƯU
                // ==========================================
                try
                {
                    if (xuLyThem)
                    {
                        // Thêm mới: Bắt buộc phải có Mật khẩu
                        if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
                            MessageBox.Show("Vui lòng nhập Mật khẩu cho tài khoản mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            NhanVien nv = new NhanVien();
                            nv.HoTen = txtHoTen.Text;
                            nv.NgaySinh = datNgaySinh.Value;
                            nv.GioiTinh = cboGioiTinh.Text;
                            nv.SDT = txtSDT.Text;
                            nv.DiaChi = txtDiaChi.Text;
                            nv.ChucVu = cboChucVu.Text;
                            nv.TrangThai = cboTrangThai.Text;

                            nv.TaiKhoan = new TaiKhoan();
                            nv.TaiKhoan.TenDangNhap = txtTenDN.Text;
                            nv.TaiKhoan.QuyenHan = cboQuyenHan.Text;
                            nv.TaiKhoan.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text); // Mã hóa mật khẩu

                            context.NhanVien.Add(nv);
                            context.SaveChanges();

                            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BatTatChucNang(false);
                            LoadData(); // Gọi hàm LoadData thay vì Load Form
                        }
                    }
                    else
                    {
                        // Sửa: Lấy dữ liệu cũ lên để cập nhật
                        NhanVien? nv = context.NhanVien.Include(x => x.TaiKhoan).FirstOrDefault(x => x.ID == id);
                        if (nv != null)
                        {
                            nv.HoTen = txtHoTen.Text;
                            nv.NgaySinh = datNgaySinh.Value;
                            nv.GioiTinh = cboGioiTinh.Text;
                            nv.SDT = txtSDT.Text;
                            nv.DiaChi = txtDiaChi.Text;
                            nv.ChucVu = cboChucVu.Text;
                            nv.TrangThai = cboTrangThai.Text;

                            if (nv.TaiKhoan == null) nv.TaiKhoan = new TaiKhoan();
                            nv.TaiKhoan.TenDangNhap = txtTenDN.Text;
                            nv.TaiKhoan.QuyenHan = cboQuyenHan.Text;

                            context.NhanVien.Update(nv);

                            // Xử lý mật khẩu đúng chuẩn tài liệu của trường
                            if (string.IsNullOrEmpty(txtMatKhau.Text))
                                context.Entry(nv.TaiKhoan).Property(x => x.MatKhau).IsModified = false; 
                            else
                                nv.TaiKhoan.MatKhau = BCrypt.Net.BCrypt.HashPassword(txtMatKhau.Text); 

                            context.SaveChanges();

                            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BatTatChucNang(false);
                            LoadData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void picXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null) return;

            try
            {
                // 1. Lấy ID người cần xóa
                int idXoa = Convert.ToInt32(dgvNhanVien.CurrentRow.Cells["colID"].Value?.ToString());

                // 2. Lấy toàn bộ thông tin: Nhân viên + Tài Khoản + Hóa Đơn Bán + Hóa Đơn Nhập
                var nv = context.NhanVien
                                .Include(x => x.TaiKhoan)
                                .Include(x => x.HoaDonBans)
                                .Include(x => x.HoaDonMuas)
                                .FirstOrDefault(x => x.ID == idXoa);

                if (nv != null)
                {
                    // KIỂM TRA: NẾU NGƯỜI NÀY ĐÃ CÓ HÓA ĐƠN
                    if (nv.HoaDonBans.Count > 0 || nv.HoaDonMuas.Count > 0)
                    {
                        // Khuyên đổi trạng thai thay vì xóa để bảo toàn dữ liệu doanh thu
                        DialogResult khuyenCao = MessageBox.Show(
                            "Nhân viên này đã từng lập hóa đơn. Để bảo toàn sổ sách doanh thu, khuyên bạn KHÔNG NÊN XÓA mà hãy dùng chức năng Sửa để đổi trạng thái thành 'Đã nghỉ'.\n\nBạn có muốn HỦY thao tác xóa này không?",
                            "Lời khuyên an toàn",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                        if (khuyenCao == DialogResult.Yes) return; // Chọn Yes (Nghe lời khuyên, Hủy xóa) -> Dừng code lại luôn

                        // Cảnh báo đỏ nếu vẫn muốn xóa
                        DialogResult hiSinh = MessageBox.Show(
                            $"CẢNH BÁO ĐỎ: Nếu bạn vẫn tiếp tục, TOÀN BỘ {nv.HoaDonBans.Count} hóa đơn bán và {nv.HoaDonMuas.Count} hóa đơn mua do nhân viên này lập SẼ BỊ XÓA SẠCH THEO!\n\nBạn THỰC SỰ MUỐN XÓA VĨNH VIỄN?",
                            "Nguy hiểm mất dữ liệu",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Stop);

                        if (hiSinh == DialogResult.No) return;

                        // Nếu lọt qua được cả 2 lớp khiên -> Bắt đầu trảm Hóa đơn trước
                        context.HoaDonBan.RemoveRange(nv.HoaDonBans);
                        context.HoaDonMua.RemoveRange(nv.HoaDonMuas);
                    }
                    else
                    {
                        // TRƯỜNG HỢP: NGƯỜI NÀY CHƯA TỪNG LẬP HÓA ĐƠN NÀO -> Hỏi xóa bình thường
                        DialogResult xoaBinhThuong = MessageBox.Show("Bạn có chắc chắn muốn xóa vĩnh viễn nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (xoaBinhThuong == DialogResult.No) return;
                    }

                    // --- QUY TRÌNH XÓA GỐC RỄ ---

                    // 1. Xóa tài khoản (Nhổ ngọn)
                    if (nv.TaiKhoan != null)
                    {
                        context.TaiKhoan.Remove(nv.TaiKhoan);
                    }

                    // 2. Xóa nhân viên (Bứng gốc)
                    context.NhanVien.Remove(nv);

                    // 3. Lưu xuống Database
                    context.SaveChanges();

                    MessageBox.Show("Đã xóa vĩnh viễn nhân viên khỏi hệ thống!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BatTatChucNang(false);
                    LoadData(); // Cập nhật lại lưới
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình xóa dữ liệu: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData(); // Load lại để hủy các thay đổi trên TextBox
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text); // Gọi lại hàm LoadData với từ khóa tìm kiếm mới
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picNhapDuLieu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu từ tập tin Excel";
            openFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        IXLWorksheet worksheet = workbook.Worksheet(1);
                        bool firstRow = true;
                        string readRange = "1:1";

                        foreach (IXLRow row in worksheet.RowsUsed())
                        {
                            if (firstRow)
                            {
                                readRange = string.Format("{0}:{1}", 1, row.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Columns.Add(cell.Value.ToString());
                                }
                                firstRow = false;
                            }
                            else
                            {
                                table.Rows.Add();
                                int cellIndex = 0;
                                foreach (IXLCell cell in row.Cells(readRange))
                                {
                                    table.Rows[table.Rows.Count - 1][cellIndex] = cell.Value.ToString();
                                    cellIndex++;
                                }
                            }
                        }
                    }

                    if (table.Rows.Count > 0)
                    {
                        int countSuccess = 0;
                        foreach (DataRow r in table.Rows)
                        {
                            
                            string sdt = r["SDT"].ToString().Trim();
                            if (!context.NhanVien.Any(x => x.SDT == sdt))
                            {
                                NhanVien nv = new NhanVien();
                                nv.HoTen = r["HoTen"].ToString();
                                nv.GioiTinh = r["GioiTinh"].ToString();

                                DateTime ngaySinh;
                                if (DateTime.TryParse(r["NgaySinh"].ToString(), out ngaySinh))
                                    nv.NgaySinh = ngaySinh;

                                nv.SDT = sdt;
                                nv.DiaChi = r["DiaChi"].ToString();
                                nv.ChucVu = r["ChucVu"].ToString();
                                nv.TrangThai = r["TrangThai"].ToString();

                                // Nếu trong Excel có nhập Tên đăng nhập
                                string tenDN = r["TenDangNhap"].ToString().Trim();
                                if (!string.IsNullOrEmpty(tenDN) && !context.TaiKhoan.Any(x => x.TenDangNhap == tenDN))
                                {
                                    nv.TaiKhoan = new TaiKhoan();
                                    nv.TaiKhoan.TenDangNhap = tenDN;
                                    nv.TaiKhoan.QuyenHan = r["QuyenHan"].ToString();
                                    // Mật khẩu mặc định khi nhập từ Excel là 123456
                                    nv.TaiKhoan.MatKhau = BCrypt.Net.BCrypt.HashPassword("123456");
                                }

                                context.NhanVien.Add(nv);
                                countSuccess++;
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {countSuccess} dòng dữ liệu mới (bỏ qua các dòng trùng SĐT).", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData(); 
                    }
                    else
                    {
                        MessageBox.Show("Tập tin Excel rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi định dạng file hoặc dữ liệu: " + ex.Message, "Lỗi nhập Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picXuatDuLieu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
          
            saveFileDialog.FileName = "DanhSachNhanVien_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                   
                    table.Columns.AddRange(new DataColumn[] {
                new DataColumn("ID", typeof(int)),
                new DataColumn("HoTen", typeof(string)),
                new DataColumn("GioiTinh", typeof(string)),
                new DataColumn("NgaySinh", typeof(string)),
                new DataColumn("SDT", typeof(string)),
                new DataColumn("DiaChi", typeof(string)),
                new DataColumn("ChucVu", typeof(string)),
                new DataColumn("TrangThai", typeof(string)),
                new DataColumn("TenDangNhap", typeof(string)),
                new DataColumn("QuyenHan", typeof(string))
            });

                    // Lấy dữ liệu từ DB (bao gồm cả tài khoản)
                    var dsNhanVien = context.NhanVien.Include(x => x.TaiKhoan).ToList();

                    // Đổ dữ liệu vào DataTable
                    foreach (var nv in dsNhanVien)
                    {
                        table.Rows.Add(
                            nv.ID,
                            nv.HoTen,
                            nv.GioiTinh,
                            nv.NgaySinh?.ToString("dd/MM/yyyy"),
                            nv.SDT,
                            nv.DiaChi,
                            nv.ChucVu,
                            nv.TrangThai,
                            nv.TaiKhoan != null ? nv.TaiKhoan.TenDangNhap : "",
                            nv.TaiKhoan != null ? nv.TaiKhoan.QuyenHan : ""
                        );
                    }

                    // Dùng ClosedXML tạo file
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhanVien");
                        sheet.Columns().AdjustToContents(); // Tự động căn chỉnh độ rộng cột
                        wb.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Đã xuất dữ liệu ra tập tin Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}
    
