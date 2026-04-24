using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyBanDTDD.Forms
{
    public partial class frmNhaCungCap : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext(); 
        bool xuLyThem = false; 
        int id;
        string quyenHienTai = "";
        public frmNhaCungCap(string quyen)
        {
            InitializeComponent();
            this.quyenHienTai = quyen;
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
            txtTenNCC.Enabled = dangThaoTac;
            txtSDT.Enabled = dangThaoTac;
            txtDiaChi.Enabled = dangThaoTac;
            txtEmail.Enabled = dangThaoTac;
            txtGhiChu.Enabled = dangThaoTac;

            // Gọi hàm tạo hiệu ứng ---
            HieuUngNutBam(picThem, !dangThaoTac);
            HieuUngNutBam(picSua, !dangThaoTac);
            HieuUngNutBam(picXoa, !dangThaoTac);

            HieuUngNutBam(picLuu, dangThaoTac);
            HieuUngNutBam(picHuyBo, dangThaoTac);
        }

        private void LoadData(string tuKhoa = "")
        {
            tuKhoa = tuKhoa.Trim().ToLower();

            // Lấy danh sách Nhà cung cấp từ Database
            // (Lưu ý: Thay context.NhaCungCaps thành tên DbSet của bạn trong DbContext nếu khác)
            var query = context.NhaCungCap.AsQueryable();

            // Tính năng Live Search: Tìm theo Tên hoặc SĐT
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(ncc => ncc.TenNhaCungCap.ToLower().Contains(tuKhoa) || ncc.SoDienThoai.Contains(tuKhoa));
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = query.ToList();

            // XÓA BINDING CŨ
            txtID.DataBindings.Clear();
            txtTenNCC.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtGhiChu.DataBindings.Clear();

            // GÁN BINDING MỚI (Lưu ý Property name phải khớp với Class NhaCungCap của bạn)
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);
            txtTenNCC.DataBindings.Add("Text", bindingSource, "TenNhaCungCap", false, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Add("Text", bindingSource, "SoDienThoai", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);
            txtGhiChu.DataBindings.Add("Text", bindingSource, "GhiChu", false, DataSourceUpdateMode.Never);

            dgvNhaCungCap.DataSource = bindingSource;
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvNhaCungCap.AutoGenerateColumns = false; // Tắt tự sinh cột
            LoadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text);
        }

        private void picThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtID.Clear();
            txtTenNCC.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();
            txtTenNCC.Focus();
        }

        private void picSua_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);

            // Giả định cột chứa ID trên lưới của bạn tên là colID
            id = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["colID"].Value?.ToString());


        }

        private void picHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void picLuu_Click(object sender, EventArgs e)
        {
            string SDT = txtSDT.Text.Trim();
            string Email = txtEmail.Text.Trim();
           
            if (string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNCC.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            else if (!(SDT.Length == 10 && SDT.StartsWith("0") && SDT.All(char.IsDigit)))
            {
                MessageBox.Show("Số điện thoại phải là 10 số, bắt đầu từ 0 và không chứa chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            // Kiểm tra trùng
            else if (context.NhaCungCap.Any(ncc => ncc.SoDienThoai == SDT && (xuLyThem || ncc.ID != id)))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(Email) && !Email.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập địa chỉ email có chứa ký tự '@'.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            else
            {
                // TIẾN HÀNH LƯU DATABASE
                try
                {
                    if (xuLyThem)
                    {
                        NhaCungCap ncc = new NhaCungCap();
                        ncc.TenNhaCungCap = txtTenNCC.Text;
                        ncc.SoDienThoai = txtSDT.Text;
                        ncc.DiaChi = txtDiaChi.Text;
                        ncc.Email = txtEmail.Text;
                        ncc.GhiChu = txtGhiChu.Text;

                        context.NhaCungCap.Add(ncc);
                        context.SaveChanges();
                        MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        NhaCungCap? ncc = context.NhaCungCap.Find(id);
                        if (ncc != null)
                        {
                            ncc.TenNhaCungCap = txtTenNCC.Text;
                            ncc.SoDienThoai = txtSDT.Text;
                            ncc.DiaChi = txtDiaChi.Text;
                            ncc.Email = txtEmail.Text;
                            ncc.GhiChu = txtGhiChu.Text;

                            context.NhaCungCap.Update(ncc);
                            context.SaveChanges();
                            MessageBox.Show("Cập nhật nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    BatTatChucNang(false);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PicXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhaCungCap.CurrentRow == null) return;

            try
            {
                int idXoa = Convert.ToInt32(dgvNhaCungCap.CurrentRow.Cells["colID"].Value?.ToString());

                // Kèm theo Include để lôi các Hóa Đơn Mua của Nhà Cung Cấp này lên
                // (Lưu ý: Tên Navigation property 'HoaDonMua' phải khớp với class bạn đã tạo)
                var ncc = context.NhaCungCap.Include(x => x.HoaDonMua).FirstOrDefault(x => x.ID == idXoa);

                if (ncc != null)
                {
                    // LỚP BẢO VỆ: Nếu nhà cung cấp này đã từng cung cấp hàng
                    if (ncc.HoaDonMua != null && ncc.HoaDonMua.Count > 0)
                    {
                        DialogResult khuyenCao = MessageBox.Show(
                            $"Nhà cung cấp này đã nhập {ncc.HoaDonMua.Count} hóa đơn. Xóa nhà cung cấp sẽ làm mất dữ liệu lịch sử nhập hàng.\n\nBạn có muốn HỦY thao tác xóa này không?",
                            "Lời khuyên an toàn",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                        if (khuyenCao == DialogResult.Yes) return; // Quay xe

                        DialogResult hiSinh = MessageBox.Show(
                            "CẢNH BÁO ĐỎ: Xóa nhà cung cấp này sẽ xóa sạch các hóa đơn nhập hàng liên quan. Bạn CHẮC CHẮN MUỐN XÓA?",
                            "Nguy hiểm",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Stop);

                        if (hiSinh == DialogResult.No) return;

                        // Trảm hóa đơn nhập trước (Giả định bạn có DbSet HoaDonMuas trong context)
                        context.HoaDonMua.RemoveRange(ncc.HoaDonMua);
                    }
                    else
                    {
                        // Nếu chưa nhập hàng gì thì hỏi xóa bình thường
                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;
                    }

                    // Xóa nhà cung cấp
                    context.NhaCungCap.Remove(ncc);
                    context.SaveChanges();

                    MessageBox.Show("Đã xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BatTatChucNang(false);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picNhapDuLieu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Nhà cung cấp từ Excel";
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
                            // Lọc trùng số điện thoại
                            string sdt = r["SoDienThoai"].ToString().Trim();
                            if (!context.NhaCungCap.Any(x => x.SoDienThoai == sdt))
                            {
                                NhaCungCap ncc = new NhaCungCap();
                                ncc.TenNhaCungCap = r["TenNhaCungCap"].ToString();
                                ncc.SoDienThoai = sdt;
                                ncc.DiaChi = r["DiaChi"].ToString();
                                ncc.Email = r["Email"].ToString();
                                ncc.GhiChu = r["GhiChu"].ToString();

                                context.NhaCungCap.Add(ncc);
                                countSuccess++;
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {countSuccess} dòng dữ liệu mới (bỏ qua các dòng bị trùng SĐT).", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Tập tin Excel rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi định dạng file hoặc dữ liệu. Vui lòng kiểm tra lại cấu trúc cột: " + ex.Message, "Lỗi nhập Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picXuatDuLieu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DanhSachNCC_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("TenNhaCungCap", typeof(string)),
                        new DataColumn("SoDienThoai", typeof(string)),
                        new DataColumn("DiaChi", typeof(string)),
                        new DataColumn("Email", typeof(string)),
                        new DataColumn("GhiChu", typeof(string))
                    });

                    var dsNCC = context.NhaCungCap.ToList();

                    foreach (var ncc in dsNCC)
                    {
                        table.Rows.Add(ncc.ID, ncc.TenNhaCungCap, ncc.SoDienThoai, ncc.DiaChi, ncc.Email, ncc.GhiChu);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "NhaCungCap");
                        sheet.Columns().AdjustToContents(); // Tự căn lề độ rộng của cột
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
