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

namespace QuanLyBanDTDD.Forms
{


    public partial class frmKhachHang : Form
    {

        QLBDTDTDbContext context = new QLBDTDTDbContext(); 
        bool xuLyThem = false; 
        int id;
        string quyenHienTai = "";
        public frmKhachHang(string quyen)
        {
            InitializeComponent();
            this.quyenHienTai = quyen;
        }


        private void HieuUngNutBam(PictureBox pic, bool duocPhepBam)
        {
            pic.Enabled = duocPhepBam; // Khóa/Mở chức năng click

            if (duocPhepBam)
            {
                
                pic.BackColor = Color.Transparent;
                pic.Cursor = Cursors.Hand;
            }
            else
            {
               
                pic.BackColor = Color.Silver;
                pic.Cursor = Cursors.Default;
            }
        }
        private void BatTatChucNang(bool dangThaoTac)
        {

           
            txtHoTen.Enabled = dangThaoTac;
            txtSDT.Enabled = dangThaoTac;
            txtDiaChi.Enabled = dangThaoTac;
            txtEmail.Enabled = dangThaoTac;



           
            HieuUngNutBam(picThem, !dangThaoTac);
            HieuUngNutBam(picSua, !dangThaoTac);
            HieuUngNutBam(picXoa, !dangThaoTac);

            HieuUngNutBam(picLuu, dangThaoTac);
            HieuUngNutBam(picHuyBo, dangThaoTac);
        }


        private void LoadData(string tuKhoa = "", DateTime? ngayLoc = null)
        {
            //tim kiếm
            tuKhoa = tuKhoa.Trim().ToLower();

            // Lấy danh sách Khách hàng từ Database
            var query = context.KhachHang.AsQueryable();


            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(h => h.ID.ToString() == tuKhoa ||
                                         (h.HoTen != null && h.HoTen.ToLower().Contains(tuKhoa)) ||
                                         (h.SDT != null && h.SDT.Contains(tuKhoa)));
            }

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(kh => kh.HoTen.ToLower().Contains(tuKhoa) || kh.SDT.Contains(tuKhoa));
            }
           
            try
            {
                AutoCompleteStringCollection danhSachGoiY = new AutoCompleteStringCollection();

              
                var listTenKH = context.KhachHang
                                     .Where(n => !string.IsNullOrEmpty(n.HoTen))
                                     .Select(n => n.HoTen)
                                     .ToList();
                
                var listSDTKH = context.KhachHang
                                       .Where(n => !string.IsNullOrEmpty(n.SDT))
                                       .Select(n => n.SDT)
                                       .ToList();
               
                danhSachGoiY.AddRange(listTenKH.ToArray());
                danhSachGoiY.AddRange(listSDTKH.ToArray());

               
                txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTimKiem.AutoCompleteCustomSource = danhSachGoiY;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo gợi ý tìm kiếm: " + ex.Message);
            }


            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = query.ToList();

           
            txtID.DataBindings.Clear();
            txtHoTen.DataBindings.Clear();
            txtSDT.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtEmail.DataBindings.Clear();


           
            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);
            txtHoTen.DataBindings.Add("Text", bindingSource, "HoTen", false, DataSourceUpdateMode.Never);
            txtSDT.DataBindings.Add("Text", bindingSource, "SDT", false, DataSourceUpdateMode.Never);
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);


            dgvKhachHang.DataSource = bindingSource;
        }

        
        
       
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvKhachHang.AutoGenerateColumns = false; //tắt tự sinh cột
            LoadData();
        }



        private void picThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtID.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtHoTen.Focus();

        }


        private void picSua_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;
            xuLyThem = false;
            BatTatChucNang(true);

            id = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["colID"].Value?.ToString());
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

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên khách hàng không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            else if (SDT.Length != 10 || !SDT.StartsWith("0") || !SDT.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải là 10 số, bắt đầu từ 0 và không chứa chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(Email) && !Email.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập địa chỉ email có chứa ký tự '@'.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (context.KhachHang.Any(kh => kh.SDT == SDT && (xuLyThem || kh.ID != id)))
            {
                MessageBox.Show("Số điện thoại này đã tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            else
            {
                //LƯU DATABASE
                try
                {
                    if (xuLyThem)
                    {
                        KhachHang kh = new KhachHang();
                        kh.HoTen = txtHoTen.Text;
                        kh.SDT = txtSDT.Text;
                        kh.DiaChi = txtDiaChi.Text;
                        kh.Email = txtEmail.Text;


                        context.KhachHang.Add(kh);
                        context.SaveChanges();
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        KhachHang? kh = context.KhachHang.Find(id);
                        if (kh != null)
                        {
                            kh.HoTen = txtHoTen.Text;
                            kh.SDT = txtSDT.Text;
                            kh.DiaChi = txtDiaChi.Text;
                            kh.Email = txtEmail.Text;


                            context.KhachHang.Update(kh);
                            context.SaveChanges();
                            MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    BatTatChucNang(false);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow == null) return;

            try
            {
                int idXoa = Convert.ToInt32(dgvKhachHang.CurrentRow.Cells["colID"].Value?.ToString());

                //Include để đem các Hóa Đơn Bán của Khách Hàng này lên
                var kh = context.KhachHang.Include(x => x.HoaDonBans).FirstOrDefault(x => x.ID == idXoa);

                if (kh != null)
                {
                   
                    if (kh.HoaDonBans.Count > 0)
                    {
                        DialogResult khuyenCao = MessageBox.Show(
                            $"Khách hàng này đã mua {kh.HoaDonBans.Count} đơn hàng. Xóa khách hàng sẽ làm ảnh hưởng đến lịch sử doanh thu.\n\nBạn có muốn HỦY thao tác xóa này không?",
                            "Lời khuyên an toàn",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                        if (khuyenCao == DialogResult.Yes) return;

                        DialogResult hiSinh = MessageBox.Show(
                            "CẢNH BÁO ĐỎ: Xóa khách hàng này sẽ xóa sạch các hóa đơn liên quan. Bạn CHẮC CHẮN MUỐN XÓA?",
                            "Nguy hiểm",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Stop);

                        if (hiSinh == DialogResult.No) return;

                        
                        context.HoaDonBan.RemoveRange(kh.HoaDonBans);
                    }
                    else
                    {
                       if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;
                    }

                    // Xóa khách hàng
                    context.KhachHang.Remove(kh);
                    context.SaveChanges();

                    MessageBox.Show("Đã xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BatTatChucNang(false);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void picThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text);
        }
        

        private void picNhapDuLieu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Nhập dữ liệu Khách Hàng từ Excel";
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
                            if (!context.KhachHang.Any(x => x.SDT == sdt))
                            {
                                KhachHang kh = new KhachHang();
                                kh.HoTen = r["HoTen"].ToString();
                                kh.SDT = sdt;
                                kh.DiaChi = r["DiaChi"].ToString();
                                kh.Email = r["Email"].ToString();


                                context.KhachHang.Add(kh);
                                countSuccess++;
                            }
                        }

                        context.SaveChanges();
                        MessageBox.Show($"Đã nhập thành công {countSuccess} dòng dữ liệu mới.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                       
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
            saveFileDialog.Title = "Xuất dữ liệu Khách Hàng ra tập tin Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xls;*.xlsx";
            saveFileDialog.FileName = "DanhSachKhachHang_" + DateTime.Now.ToShortDateString().Replace("/", "_") + ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable table = new DataTable();
                    table.Columns.AddRange(new DataColumn[] {
                        new DataColumn("ID", typeof(int)),
                        new DataColumn("HoTen", typeof(string)),
                        new DataColumn("SDT", typeof(string)),
                        new DataColumn("DiaChi", typeof(string)),
                        new DataColumn("Email", typeof(string))

                    });

                    var dsKH = context.KhachHang.ToList();

                    foreach (var kh in dsKH)
                    {
                        table.Rows.Add(kh.ID, kh.HoTen, kh.SDT, kh.DiaChi, kh.Email);
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var sheet = wb.Worksheets.Add(table, "KhachHang");
                        sheet.Columns().AdjustToContents();
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
   