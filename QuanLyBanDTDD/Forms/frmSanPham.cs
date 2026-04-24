using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using QuanLyBanDTDD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDTDD.Forms
{
    public partial class frmSanPham : System.Windows.Forms.Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext();
        bool xuLyThem = false;
        int id;

       
        string imagesFolder = Path.Combine(Application.StartupPath, "Images");

        public frmSanPham()
        {
            InitializeComponent();
        }
        private void HieuUngNutBam(PictureBox pic, bool duocPhepBam)
        {
            pic.Enabled = duocPhepBam;
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
            // Bật/tắt các ô nhập liệu
            txtTenSanPham.Enabled = dangThaoTac;
            cboHangSanXuat.Enabled = dangThaoTac;
            cboThoiGianBaoHanh.Enabled = dangThaoTac;
            txtMauSac.Enabled = dangThaoTac;
            txtBoNho.Enabled = dangThaoTac;
            numGiaNhap.Enabled = dangThaoTac;
            numGiaBan.Enabled = dangThaoTac;
            numSoLuongTon.Enabled = dangThaoTac;
            txtMoTa.Enabled = dangThaoTac;

                       
            bool chiSuaMoiDuocThem = dangThaoTac && (xuLyThem == false);
            HieuUngNutBam(picThemPhienBan, chiSuaMoiDuocThem);


            // Bật/tắt các nút tính năng

            HieuUngNutBam(picThem, !dangThaoTac);
            HieuUngNutBam(picSua, !dangThaoTac);
            HieuUngNutBam(picXoa, !dangThaoTac);
            

            HieuUngNutBam(picDoiAnh, dangThaoTac);
            HieuUngNutBam(picXoayAnh, dangThaoTac);
            HieuUngNutBam(picLuu, dangThaoTac);
            HieuUngNutBam(picHuyBo, dangThaoTac);
           
        }


        private void LoadData(string tuKhoa = "")
        {
            context.ChangeTracker.Clear();
            int currentID = 0;
            if (dgvSanPham.CurrentRow != null)
                currentID = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["colID"].Value);
            tuKhoa = tuKhoa.Trim().ToLower();

            
            var query = context.SanPham.AsQueryable();

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(sp => sp.TenSP.ToLower().Contains(tuKhoa));
            }

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = query.ToList();

            // XÓA BINDING CŨ
            txtID.DataBindings.Clear();
            txtTenSanPham.DataBindings.Clear();
            cboHangSanXuat.DataBindings.Clear();
            cboThoiGianBaoHanh.DataBindings.Clear();
            txtMauSac.DataBindings.Clear();
            txtBoNho.DataBindings.Clear();
            numGiaNhap.DataBindings.Clear();
            numGiaBan.DataBindings.Clear();
            numSoLuongTon.DataBindings.Clear();
            txtMoTa.DataBindings.Clear();
            picHinhAnh.DataBindings.Clear();



            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);
            txtTenSanPham.DataBindings.Add("Text", bindingSource, "TenSP", false, DataSourceUpdateMode.Never);

            cboHangSanXuat.DataBindings.Add("Text", bindingSource, "HangSanXuat", false, DataSourceUpdateMode.Never);
            cboThoiGianBaoHanh.DataBindings.Add("Text", bindingSource, "ThoiGianBaoHanh", true, DataSourceUpdateMode.Never);

            numGiaNhap.DataBindings.Add("Value", bindingSource, "GiaNhap", true, DataSourceUpdateMode.Never);
            numGiaBan.DataBindings.Add("Value", bindingSource, "GiaBan", true, DataSourceUpdateMode.Never);
            numSoLuongTon.DataBindings.Add("Text", bindingSource, "SoLuongTon", true, DataSourceUpdateMode.Never);
            txtMoTa.DataBindings.Add("Text", bindingSource, "MoTa", false, DataSourceUpdateMode.Never);

            // BINDING HÌNH ẢNH 
            Binding hinhAnhBind = new Binding("ImageLocation", bindingSource, "HinhAnh", true, DataSourceUpdateMode.Never);
            hinhAnhBind.Format += (s, e) =>
            {
                // Lấy tên file, nếu là null hoặc rỗng ("") thì xài no-image.png
                string tenFile = e.Value?.ToString();
                string fileHienThi = string.IsNullOrWhiteSpace(tenFile) ? "no-image.png" : tenFile;

                e.Value = Path.Combine(imagesFolder, fileHienThi);
            };
            bindingSource.CurrentChanged += (s, e) =>
            {
                var sp = bindingSource.Current as SanPham;
                if (sp != null)
                {
                    string file = string.IsNullOrWhiteSpace(sp.HinhAnh) ? "no-image.png" : sp.HinhAnh;
                    string path = Path.Combine(imagesFolder, file);

                    if (File.Exists(path))
                        picHinhAnh.ImageLocation = path;
                    else
                        picHinhAnh.ImageLocation = Path.Combine(imagesFolder, "no-image.png");
                }
            };

            dgvSanPham.DataSource = bindingSource;
            bindingSource.ResetBindings(false);

        }

        private void LoadComboHangSanXuat()
        {
            try
            {
                var dsHang = context.HangSanXuat.ToList();

                dsHang.Insert(0, new HangSanXuat { ID = 0, TenHangSanXuat = "-- Tất cả các hãng --" });

                // 3. Đổ dữ liệu vào ComboBox
                cboHangSanXuat.DataSource = dsHang;
                cboHangSanXuat.DisplayMember = "TenHangSanXuat";
                cboHangSanXuat.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải hãng: " + ex.Message);
            }
        }




        private void frmSanPham_Load(object sender, EventArgs e)
        {

            
            context.ChangeTracker.Clear();


            // Tạo sẵn thư mục Images 
            if (!Directory.Exists(imagesFolder)) Directory.CreateDirectory(imagesFolder);

            dgvSanPham.AutoGenerateColumns = false;
            dgvPhienBanSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataError += (s, ex) => ex.ThrowException = false;
            BatTatChucNang(false);
            LoadComboHangSanXuat();
            LoadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            LoadData(txtTimKiem.Text);
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvSanPham.Columns[e.ColumnIndex].Name == "colHinhAnh" && e.RowIndex >= 0)
            {
                var sp = dgvSanPham.Rows[e.RowIndex].DataBoundItem as SanPham;

                //xác định file cần hiển thị
                string tenFile = sp?.HinhAnh;
                string fileHienThi = string.IsNullOrWhiteSpace(tenFile) ? "no-image.png" : tenFile;
                string path = Path.Combine(imagesFolder, fileHienThi);

                // file không tồn tại -> fallback về no-image.png
                if (!File.Exists(path))
                {
                    path = Path.Combine(imagesFolder, "no-image.png");
                }

                if (File.Exists(path))
                {
                    try
                    {
                        byte[] bytes = File.ReadAllBytes(path);
                        using var ms = new MemoryStream(bytes);
                        using var original = Image.FromStream(ms);

                        e.Value = new Bitmap(original, 40, 40);
                        e.FormattingApplied = true;
                        return;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }

                // Nếu ngay cả no-image.png 
                e.Value = new Bitmap(40, 40);
                e.FormattingApplied = true;

            }
        }



        private void picThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            txtID.Clear();
            txtTenSanPham.Clear();
            cboHangSanXuat.SelectedIndex = -1;
            cboThoiGianBaoHanh.SelectedIndex = 0;
            txtMauSac.Clear();
            txtBoNho.Clear();
            numGiaNhap.Value = 0;
            numGiaBan.Value = 0;
            numSoLuongTon.Text = "0";
            txtMoTa.Clear();

            // Xóa ảnh cũ
            picHinhAnh.ImageLocation = null;
            picHinhAnh.Image = null;

            txtTenSanPham.Focus();
        }

        private void picSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            // Lấy ID của sản phẩm đang chọn
            id = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["colID"].Value?.ToString());

            picHinhAnh.Tag = null;
        }

        private void picHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }
        private void picLuu_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (xuLyThem)
            {
                bool biTrung = context.SanPham.Any(sp => sp.TenSP.ToLower() == txtTenSanPham.Text.Trim().ToLower());
                if (biTrung)
                {
                    MessageBox.Show("Tên sản phẩm này đã tồn tại trong hệ thống!", "Lỗi trùng tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            else
            {
               
                int idHienTai = int.Parse(dgvSanPham.CurrentRow.Cells["colID"].Value.ToString());
                bool biTrung = context.SanPham.Any(sp => sp.TenSP.ToLower() == txtTenSanPham.Text.Trim().ToLower() && sp.ID != idHienTai);
                if (biTrung)
                {
                    MessageBox.Show("Tên sản phẩm mới này đã trùng với một sản phẩm khác!", "Lỗi trùng tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (string.IsNullOrWhiteSpace(cboHangSanXuat.Text))
            {
                MessageBox.Show("Vui lòng chọn hãng sản xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //LƯU DATABASE
            try
            {
                if (xuLyThem)
                {
                    SanPham sp = new SanPham();
                    sp.TenSP = txtTenSanPham.Text.Trim();
                    sp.HangSanXuat = cboHangSanXuat.Text.Trim();
                    sp.ThoiGianBaoHanh = cboThoiGianBaoHanh.Text;

                    sp.MoTa = txtMoTa.Text;

                    sp.HinhAnh = picHinhAnh.Tag != null ? picHinhAnh.Tag.ToString() : "no-image.png";//Lấy từ Tag do nút Đổi Ảnh gán vào, nếu không có thì dùng ảnh mặc định

                    context.SanPham.Add(sp);
                    context.SaveChanges(); 

                    //  Tự động tạo 1 Phiên bản mặc định để hiện ở bảng dưới
                    PhienBanSanPham pb = new PhienBanSanPham();
                    pb.SanPhamID = sp.ID;
                    pb.MauSac = string.IsNullOrWhiteSpace(txtMauSac.Text) ? "Chưa rõ" : txtMauSac.Text;
                    pb.BoNho = string.IsNullOrWhiteSpace(txtBoNho.Text) ? "Chưa rõ" : txtBoNho.Text;
                    pb.GiaNhap = numGiaNhap.Value;
                    pb.GiaBan = numGiaBan.Value;
                    pb.SoLuongTon = int.TryParse(numSoLuongTon.Text, out int sl) ? sl : 0;

                    context.PhienBanSanPham.Add(pb);
                    context.SaveChanges();

                    MessageBox.Show("Thêm sản phẩm và phiên bản đầu tiên thành công!", "Thông báo");
                }
                else
                {
                    SanPham? sp = context.SanPham.Find(id);
                    if (sp != null)
                    {
                        sp.TenSP = txtTenSanPham.Text;
                        sp.HangSanXuat = cboHangSanXuat.Text.Trim();
                        sp.ThoiGianBaoHanh = cboThoiGianBaoHanh.Text;
                        sp.MoTa = txtMoTa.Text;


                        if (picHinhAnh.Tag != null)
                        {
                            sp.HinhAnh = picHinhAnh.Tag.ToString();
                        }



                        context.SanPham.Update(sp);
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    }
                }


                picHinhAnh.Tag = null; 
                BatTatChucNang(false);

               
                context.ChangeTracker.Clear();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            int idXoa = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["colID"].Value?.ToString());
            string? tenSP = dgvSanPham.CurrentRow.Cells["colTenSP"].Value?.ToString();

            if (MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm: {tenSP}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SanPham? sp = context.SanPham.Find(idXoa);
                    if (sp != null)
                    {
                        context.SanPham.Remove(sp);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa sản phẩm này vì đã phát sinh hóa đơn giao dịch!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {

                int sanPhamID = Convert.ToInt32(dgvSanPham.Rows[e.RowIndex].Cells["colID"].Value);
                LoadPhienBan(sanPhamID);


            }
        }



        // Hàm tải danh sách phiên bản
        private void LoadPhienBan(int idCha)
        {
            var listPB = context.PhienBanSanPham
                                .Where(pb => pb.SanPhamID == idCha)
                                .ToList();

            
            dgvPhienBanSanPham.DataSource = listPB;
        }

        private void dgvPhienBanSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lấy dòng đang chọn
                DataGridViewRow row = dgvPhienBanSanPham.Rows[e.RowIndex];

                //Đổ dữ liệu vào các ô nhập liệu bên phải

                txtMauSac.Text = row.Cells["colMauSac"].Value?.ToString();
                txtBoNho.Text = row.Cells["colBoNho"].Value?.ToString();

                numGiaNhap.Value = Convert.ToDecimal(row.Cells["colGiaNhap"].Value);
                numGiaBan.Value = Convert.ToDecimal(row.Cells["colGiaBan"].Value);
                numSoLuongTon.Text = row.Cells["colSoLuongTon"].Value?.ToString();

               
            }
        }


        private void picDoiAnh_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow == null) return;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn hình ảnh sản phẩm";
            openFileDialog.Filter = "Tập tin hình ảnh|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string ext = Path.GetExtension(openFileDialog.FileName);
                    string tenFileMoi = "SP_" + DateTime.Now.Ticks + ext;
                    string fileSavePath = Path.Combine(imagesFolder, tenFileMoi);

                    File.Copy(openFileDialog.FileName, fileSavePath, true);

                    picHinhAnh.Image = Image.FromFile(fileSavePath);
                    picHinhAnh.Tag = tenFileMoi;

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message);
                }
            }
        }


        private void XuLyXoayVaLuu(RotateFlipType kieuXoay)
        {
            
            if (picHinhAnh.Image == null || dgvSanPham.CurrentRow == null) return;

            try
            {
                //  ẢNH SẠCH (Tạo bản sao trên RAM để không bị dính khóa file gốc)
                using (Bitmap bmpSach = new Bitmap(picHinhAnh.Image))
                {
                    //XOAY ẢNH TRÊN RAM
                    bmpSach.RotateFlip(kieuXoay);

                    //HIỂN THỊ LẠI NGAY LÊN MÀN HÌNH
                    Image anhHienThi = (Image)bmpSach.Clone();
                    if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose(); 
                    picHinhAnh.Image = anhHienThi;

                    
                    int idSanPham = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["colID"].Value);
                    var sp = context.SanPham.Find(idSanPham);

                    if (sp != null)
                    {
                        // Tạo tên file mới để không bị đè file cũ đang bị khóa
                        string tenFileMoi = $"SP_{sp.ID}_Rotated_{DateTime.Now.Ticks}.png";
                        string duongDanFull = Path.Combine(imagesFolder, tenFileMoi);

                        //  Lưu vào RAM trước rồi mới chép ra ổ cứng ---
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bmpSach.Save(ms, System.Drawing.Imaging.ImageFormat.Png); 
                            File.WriteAllBytes(duongDanFull, ms.ToArray()); // Ghi 1 cục từ RAM xuống đĩa
                        }

                        
                        sp.HinhAnh = tenFileMoi;
                        context.SanPham.Update(sp);
                        context.SaveChanges();

                       
                        picHinhAnh.Tag = tenFileMoi;

                       
                        int viTriDongCung = dgvSanPham.CurrentRow.Index;

                       
                        LoadData();

                        
                        if (viTriDongCung >= 0 && viTriDongCung < dgvSanPham.Rows.Count)
                        {
                            dgvSanPham.ClearSelection(); // Bỏ chọn dòng đầu tiên
                            dgvSanPham.Rows[viTriDongCung].Selected = true; // Bôi xanh lại dòng cũ
                            dgvSanPham.CurrentCell = dgvSanPham.Rows[viTriDongCung].Cells[0]; // Kích hoạt để dữ liệu bên phải nhảy theo
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xoay ảnh: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void picXoayAnh_Click(object sender, EventArgs e)
        {
            XuLyXoayVaLuu(RotateFlipType.Rotate90FlipNone);
        }

        private void picNhapDuLieu_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file Excel danh sách điện thoại mới";
            openFileDialog.Filter = "Tập tin Excel|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook(openFileDialog.FileName))
                    {
                        int soSPThem = 0;
                        int soPBThem = 0;

                       
                        var sheet1 = workbook.Worksheet(1);
                        foreach (var row in sheet1.RowsUsed().Skip(1))
                        {
                            string tenSP = row.Cell(2).GetValue<string>().Trim();
                            if (string.IsNullOrWhiteSpace(tenSP)) continue;

                            // Tìm xem máy này có trong CSDL chưa, chưa có thì tạo mới
                            var sp = context.SanPham.FirstOrDefault(s => s.TenSP == tenSP);
                            if (sp == null)
                            {
                                sp = new SanPham();
                                sp.TenSP = tenSP;
                                context.SanPham.Add(sp);
                                soSPThem++;
                            }

                            sp.HangSanXuat = row.Cell(3).GetValue<string>() ?? "Chưa rõ";
                            sp.ThoiGianBaoHanh = row.Cell(4).GetValue<string>() ?? "12 tháng";
                            sp.MoTa = row.Cell(5).GetValue<string>() ?? "";
                            if (string.IsNullOrEmpty(sp.HinhAnh)) sp.HinhAnh = "";

                          
                            context.SaveChanges();
                        }

                      
                        // trang2
                        if (workbook.Worksheets.Count > 1) // Kiểm tra xem file có trang 2 không
                        {
                            var sheet2 = workbook.Worksheet(2);
                            foreach (var row in sheet2.RowsUsed().Skip(1))
                            {
                                
                                string keyCuaSheet2 = row.Cell(1).GetValue<string>().Trim();
                                if (string.IsNullOrWhiteSpace(keyCuaSheet2)) continue; 

                                SanPham sp_cha = null;

                                // Tìm theo ID 
                                if (int.TryParse(keyCuaSheet2, out int idSP))
                                {
                                    sp_cha = context.SanPham.Find(idSP);
                                }

                                //Tìm theo Tên 
                                if (sp_cha == null)
                                {
                                    sp_cha = context.SanPham.FirstOrDefault(s => s.TenSP == keyCuaSheet2);
                                }

                                // Nếu tìm thấy Sản Phẩm  gan PB vào
                                if (sp_cha != null)
                                {
                                    string mauSac = row.Cell(2).GetValue<string>() ?? "Chưa rõ";
                                    string boNho = row.Cell(3).GetValue<string>() ?? "Chưa rõ";

                                    // Kiểm tra xem trùng phiên bản không
                                    var pb = context.PhienBanSanPham.FirstOrDefault(p => p.SanPhamID == sp_cha.ID && p.MauSac == mauSac && p.BoNho == boNho);
                                    if (pb == null)
                                    {
                                        pb = new PhienBanSanPham();
                                        pb.SanPhamID = sp_cha.ID;
                                        pb.MauSac = mauSac;
                                        pb.BoNho = boNho;
                                        context.PhienBanSanPham.Add(pb);
                                        soPBThem++;
                                    }

                                    // Xử lý giá tiền 
                                    string strGiaNhap = row.Cell(4).GetValue<string>().Replace(",", "").Replace(".", "");
                                    if (decimal.TryParse(strGiaNhap, out decimal giaNhap)) pb.GiaNhap = giaNhap;

                                    string strGiaBan = row.Cell(5).GetValue<string>().Replace(",", "").Replace(".", "");
                                    if (decimal.TryParse(strGiaBan, out decimal giaBan)) pb.GiaBan = giaBan;

                                    string strTon = row.Cell(6).GetValue<string>();
                                    if (int.TryParse(strTon, out int tonKho)) pb.SoLuongTon = tonKho;
                                }
                            }
                            context.SaveChanges(); 
                        }

                        MessageBox.Show($"Nhập thành công!\n- Số Sản Phẩm mới: {soSPThem}\n- Số Phiên Bản mới: {soPBThem}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        context.ChangeTracker.Clear();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picXuatDuLieu_Click(object sender, EventArgs e)
        {

            // Khởi tạo hộp thoại lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất danh sách sản phẩm ra Excel";
            saveFileDialog.Filter = "Tập tin Excel|*.xlsx";
            saveFileDialog.FileName = "DanhSachSanPham_" + DateTime.Now.ToString("yyyyMMdd_HHmm");

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    context.ChangeTracker.Clear();
                    //trng 1 (sheet 1): THÔNG TIN CƠ BẢN CỦA SẢN PHẨM
                    DataTable tableSP = new DataTable();
                    tableSP.Columns.Add("ID", typeof(string));
                    tableSP.Columns.Add("Tên Sản Phẩm", typeof(string));
                    tableSP.Columns.Add("Hãng Sản Xuất", typeof(string));
                    tableSP.Columns.Add("Bảo Hành", typeof(string));
                    tableSP.Columns.Add("Mô Tả", typeof(string));

                    var listSP = context.SanPham.ToList();
                    foreach (var sp in listSP)
                    {
                        tableSP.Rows.Add(
                            sp.ID.ToString(),
                            sp.TenSP?.ToString() ?? "",
                            sp.HangSanXuat?.ToString() ?? "",
                            sp.ThoiGianBaoHanh?.ToString() ?? "",
                            sp.MoTa?.ToString() ?? ""
                        );
                    }

                    
                    // trang 2 (SHEET 2): CHI TIẾT CÁC PHIÊN BẢN SẢN PHẨM
                    
                    DataTable tablePB = new DataTable();
                    tablePB.Columns.Add("ID Sản Phẩm", typeof(string));
                    tablePB.Columns.Add("Màu Sắc", typeof(string));
                    tablePB.Columns.Add("Bộ Nhớ", typeof(string));
                    tablePB.Columns.Add("Giá Nhập", typeof(string));
                    tablePB.Columns.Add("Giá Bán", typeof(string));
                    tablePB.Columns.Add("Tồn Kho", typeof(string));

                    var listPB = context.PhienBanSanPham.ToList();
                    foreach (var pb in listPB)
                    {
                        tablePB.Rows.Add(
                            pb.SanPhamID.ToString(),
                            pb.MauSac?.ToString() ?? "",
                            pb.BoNho?.ToString() ?? "",
                            string.Format("{0:N0}", pb.GiaNhap), 
                            string.Format("{0:N0}", pb.GiaBan),  
                            pb.SoLuongTon.ToString()
                        );
                    }

                   
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        // Dựng Trang 1
                        var sheet1 = wb.Worksheets.Add(tableSP, "Sản Phẩm");
                        var header1 = sheet1.FirstRow();
                        header1.Style.Font.Bold = true;
                        header1.Style.Fill.BackgroundColor = XLColor.Cyan;
                        header1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        sheet1.Columns().AdjustToContents(); // Tự động giãn cột

                        // Dựng Trang 2
                        var sheet2 = wb.Worksheets.Add(tablePB, "Phiên Bản Chi Tiết");
                        var header2 = sheet2.FirstRow();
                        header2.Style.Font.Bold = true;
                        header2.Style.Fill.BackgroundColor = XLColor.LightGreen;
                        header2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        sheet2.Columns().AdjustToContents(); // Tự động giãn cột

                       
                        wb.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Đã xuất dữ liệu ra Excel gồm 2 trang thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    Process.Start(new ProcessStartInfo(saveFileDialog.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void picThemPhienBan_Click(object sender, EventArgs e)
        {
           
            if (dgvSanPham.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một Sản Phẩm ở bảng trên trước khi thêm phiên bản!");
                return;
            }

           //lấy ID của  dgv san pham
            int idSanPhamDuocChon = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["colID"].Value);

           
            if (string.IsNullOrEmpty(txtMauSac.Text) || string.IsNullOrEmpty(txtBoNho.Text))
            {
                MessageBox.Show("Vui lòng nhập Màu sắc và Bộ nhớ!");
                return;
            }

            try
            {

                PhienBanSanPham pbMoi = new PhienBanSanPham
                {
                    SanPhamID = idSanPhamDuocChon,
                    MauSac = txtMauSac.Text.Trim(),
                    BoNho = txtBoNho.Text.Trim(),

                    GiaNhap = numGiaNhap.Value,
                    GiaBan = numGiaBan.Value,
                    SoLuongTon = int.TryParse(numSoLuongTon.Text, out int sl) ? sl : 0
                };

                //lưu vào Database
                context.PhienBanSanPham.Add(pbMoi);
                context.SaveChanges();

              
                MessageBox.Show("Đã thêm phiên bản mới thành công! Số lượng và Giá sẽ được cập nhật khi Nhập Hàng.");

                
                txtMauSac.Clear();
                txtBoNho.Clear();
                numGiaNhap.Value = 0;
                numGiaBan.Value = 0;

                
                numSoLuongTon.Value = 0;


                LoadPhienBan(idSanPhamDuocChon);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phiên bản: " + ex.Message);
            }
            BatTatChucNang(true);
        }
    }


}
