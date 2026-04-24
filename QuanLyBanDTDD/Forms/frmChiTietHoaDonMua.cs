using Microsoft.EntityFrameworkCore;
using QuanLyBanDTDD.Data;
using QuanLyBanDTDD.Reports;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanDTDD.Forms
{
    public partial class frmChiTietHoaDonMua : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext(); // Khởi tạo biến ngữ cảnh CSDL
        bool xuLyThem = false; // Kiểm tra có nhấn vào nút Thêm hay không?
        int id; // Lưu ID Hóa Đơn Cha truyền vào từ form ngoài
        int maSanPhamDangSua = 0; // Lưu ID Sản phẩm đang được chọn để Sửa

        BindingList<DanhSachHoaDonMua_ChiTiet> chiTietList = new BindingList<DanhSachHoaDonMua_ChiTiet>();

        public frmChiTietHoaDonMua(int maHoaDon = 0)
        {
            InitializeComponent();
            this.id = maHoaDon;
        }

        // ==========================================
        // 1. CÁC HÀM TIỆN ÍCH & TRẠNG THÁI GIAO DIỆN
        // ==========================================
        private void HieuUngNutBam(PictureBox pic, bool duocPhepBam)
        {
            if (pic == null) return;
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
            cboTenSanPham.Enabled = dangThaoTac;
            numSoLuong.Enabled = dangThaoTac;
            numDonGia.Enabled = dangThaoTac;

            // Khóa/Mở lưới DataGridView để chống click lung tung khi đang nhập
            dgvChiTietHDM.Enabled = !dangThaoTac;

            // Gọi hàm tạo hiệu ứng cho các nút
            HieuUngNutBam(picThem, !dangThaoTac);
            HieuUngNutBam(picSua, !dangThaoTac);
            HieuUngNutBam(picXoa, !dangThaoTac);

            HieuUngNutBam(picLuu, dangThaoTac);
            HieuUngNutBam(picHuyBo, dangThaoTac);
        }

        private void LoadComboBox()
        {
            var dsPhienBan = context.PhienBanSanPham
         .Include(pb => pb.SanPham) // Cây cầu nối quan trọng
         .Select(pb => new {
             ID = pb.IDPhienBan,
             // Thêm kiểm tra null để chắc chắn không bị văng lỗi
             HienThi = (pb.SanPham != null ? pb.SanPham.TenSP : "Không tên")
                       + " (" + pb.BoNho + " " + pb.MauSac + ")"
         }).ToList();

            cboTenSanPham.DataSource = dsPhienBan;
            cboTenSanPham.DisplayMember = "HienThi";
            cboTenSanPham.ValueMember = "ID";
            cboTenSanPham.SelectedIndex = -1;
        }

        private void LoadData()
        {
            // 1. Lấy dữ liệu chi tiết từ DB lên
            var ct = context.ChiTietHoaDonMua
                            .Include(c => c.PhienBanSanPham).ThenInclude(pb => pb.SanPham)
                            .Where(r => r.HoaDonMuaID == id)
                            .Select(r => new DanhSachHoaDonMua_ChiTiet
                            {
                                ID = r.ID,
                                HoaDonMuaID = r.HoaDonMuaID,
                                PhienBanSanPhamID = r.PhienBanSanPhamID ?? 0,
                                TenSanPham = r.PhienBanSanPham != null ?
                                     r.PhienBanSanPham.SanPham.TenSP + " (" + r.PhienBanSanPham.BoNho + " " + r.PhienBanSanPham.MauSac + ")"
                                     : "",
                                SoLuong = r.SoLuong,
                                DonGia = r.DonGia,
                                ThanhTien = r.SoLuong * r.DonGia
                            }).ToList();

            chiTietList = new BindingList<DanhSachHoaDonMua_ChiTiet>(ct);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = chiTietList;

            // =======================================================
            // A. MÓC DỮ LIỆU CHO CÁC Ô NHẬP LIỆU BÊN TRÁI
            // =======================================================
            cboTenSanPham.DataBindings.Clear();
            numSoLuong.DataBindings.Clear();
            numDonGia.DataBindings.Clear();


            cboTenSanPham.DataBindings.Add("SelectedValue", bindingSource, "PhienBanSanPhamID", false, DataSourceUpdateMode.Never);
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", true, DataSourceUpdateMode.Never);
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", true, DataSourceUpdateMode.Never, 0, "#,##0");

            dgvChiTietHDM.DataSource = bindingSource;


            // ---------------TT CHI TIẾT CÁC Ô HIỂN THỊ CHI TIẾT BÊN PHẢI----------------------

            txtID.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            numSoLuongMua.DataBindings.Clear();
            numDonGiaMua.DataBindings.Clear();
            numThanhTien.DataBindings.Clear();

            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);
            txtTenSP.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);
            numSoLuongMua.DataBindings.Add("Value", bindingSource, "SoLuong", true, DataSourceUpdateMode.Never);
            numDonGiaMua.DataBindings.Add("Value", bindingSource, "DonGia", true, DataSourceUpdateMode.Never, 0, "#,##0");
            numThanhTien.DataBindings.Add("Value", bindingSource, "ThanhTien", true, DataSourceUpdateMode.Never, 0, "#,##0");

            // =======================================================
            // LẤY THÔNG TIN HÓA ĐƠN CHA (NHÂN VIÊN & NHÀ CUNG CẤP)
            // =======================================================
            var hdMe = context.HoaDonMua
                              .Include(h => h.NhanVien)
                              .Include(h => h.NhaCungCap)
                              .FirstOrDefault(h => h.ID == id);

            if (hdMe != null)
            {
                txtNhanVienNhap.Text = hdMe.NhanVien != null ? hdMe.NhanVien.HoTen : "Không xác định";
                txtNhanVienNhap.ReadOnly = true;


            }
            if (hdMe != null)
            {
                txtNhanVienNhap.Text = hdMe.NhanVien != null ? hdMe.NhanVien.HoTen : "Không xác định";
                txtNhanVienNhap.ReadOnly = true;


            }

            // GỌI HÀM GỢI Ý Ở ĐÂY SAU KHI ĐÃ CÓ DỮ LIỆU
            SetupAutoComplete();
        }
        private void SetupAutoComplete()
        {
            try
            {
                AutoCompleteStringCollection danhSachGoiY = new AutoCompleteStringCollection();

                // Rút trích danh sách tên sản phẩm đang có trên cái bảng lưới (chiTietList)
                // Dùng Distinct() để nếu có 2 dòng iphone thì nó chỉ gợi ý 1 chữ iphone thôi
                var listTenSP = chiTietList.Where(x => !string.IsNullOrEmpty(x.TenSanPham))
                                           .Select(x => x.TenSanPham)
                                           .Distinct()
                                           .ToList();


                danhSachGoiY.AddRange(listTenSP.ToArray());

                // Ép TextBox tìm kiếm nhận cấu hình gợi ý
                txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTimKiem.AutoCompleteCustomSource = danhSachGoiY;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo gợi ý tìm kiếm: " + ex.Message);
            }
        }



        // ==========================================
        // 2. XỬ LÝ SỰ KIỆN FORM VÀ TỰ ĐIỀN
        // ==========================================
        private void frmChiTietHoaDonMua_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false); // Vừa vào thì khóa hết nhập liệu
            dgvChiTietHDM.AutoGenerateColumns = false; // Tắt tự sinh cột
            LoadComboBox();
            LoadData();
        }

        private void cboTenSanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboTenSanPham.SelectedValue != null && int.TryParse(cboTenSanPham.SelectedValue.ToString(), out int idPB))
            {
                var phienBan = context.PhienBanSanPham.Find(idPB);
                if (phienBan != null)
                {
                    numDonGia.Value = phienBan.GiaNhap;
                }
            }
        }

        private void picThemSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.ShowDialog();
            LoadComboBox(); // Tải lại CBO sau khi thêm SP mới
        }

        // ==========================================
        // 3. XỬ LÝ CÁC NÚT THAO TÁC (CRUD)
        // ==========================================
        private void picThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            // Xóa trắng để nhập mới
            cboTenSanPham.SelectedIndex = -1;
            numSoLuong.Text = "1";
            numDonGia.Text = "0";
            cboTenSanPham.Focus();
        }

        private void picSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHDM.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            var dongHienTai = dgvChiTietHDM.CurrentRow.DataBoundItem as DanhSachHoaDonMua_ChiTiet;
            if (dongHienTai != null)
            {
                maSanPhamDangSua = dongHienTai.PhienBanSanPhamID; // Gắn ID chuẩn 100%
            }

            // Khóa ComboBox không cho đổi sản phẩm khác khi đang sửa
            cboTenSanPham.Enabled = false;
            numSoLuong.Focus();
        }

        private void picHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData(); // Load lại để clear các ô nhập liệu về trạng thái cũ
        }

        private void picLuu_Click(object sender, EventArgs e)
        {
            int sl = int.TryParse(numSoLuong.Text.Trim(), out int tempSl) ? tempSl : 0;
            decimal dg = decimal.TryParse(numDonGia.Text.Trim(), out decimal tempDg) ? tempDg : 0;

            if (cboTenSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenSanPham.Focus();
            }
            else if (sl <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numSoLuong.Focus();
            }
            else if (dg <= 0)
            {
                MessageBox.Show("Đơn giá nhập phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numDonGia.Focus();
            }
            else
            {
                // TIẾN HÀNH XỬ LÝ DỮ LIỆU
                try
                {
                    int maSP = Convert.ToInt32(cboTenSanPham.SelectedValue);

                    if (xuLyThem)
                    {
                        var exist = chiTietList.FirstOrDefault(x => x.PhienBanSanPhamID == maSP);
                        if (exist != null)
                        {
                            // Nếu đã có trong lưới -> Cộng dồn
                            exist.SoLuong += sl;
                            exist.DonGia = dg;
                            exist.ThanhTien = exist.SoLuong * exist.DonGia;
                        }
                        else
                        {
                            // Nếu chưa có -> Thêm mới
                            chiTietList.Add(new DanhSachHoaDonMua_ChiTiet
                            {
                                ID = 0,
                                HoaDonMuaID = id,
                                PhienBanSanPhamID = maSP,
                                TenSanPham = cboTenSanPham.Text,
                                SoLuong = sl,
                                DonGia = dg,
                                ThanhTien = sl * dg
                            });
                        }
                    }
                    else // Nếu là Sửa
                    {
                        var edit = chiTietList.FirstOrDefault(x => x.PhienBanSanPhamID == maSanPhamDangSua);
                        if (edit != null)
                        {
                            edit.SoLuong = sl;
                            edit.DonGia = dg;
                            edit.ThanhTien = sl * dg;
                        }
                    }

                    // Gọi hàm lưu toàn bộ xuống Database
                    LuuToanBoXuongDB();

                    // Đưa form về trạng thái an toàn
                    BatTatChucNang(false);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHDM.CurrentRow == null) return;

            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này khỏi hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int maSPXoa = Convert.ToInt32(dgvChiTietHDM.CurrentRow.Cells["colSanPhamID"].Value?.ToString());
                    var row = chiTietList.FirstOrDefault(x => x.PhienBanSanPhamID == maSPXoa);

                    if (row != null)
                    {
                        chiTietList.Remove(row);
                        LuuToanBoXuongDB(); // Xóa xong phải cập nhật DB liền

                        BatTatChucNang(false);
                        LoadData();
                    }
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

        // ==========================================
        // 4. HÀM CORE: ĐỒNG BỘ XUỐNG CƠ SỞ DỮ LIỆU
        // ==========================================
        private void LuuToanBoXuongDB()
        {
            // 1. Phục hồi tồn kho cũ cho bảng Phiên Bản
            var oldDetails = context.ChiTietHoaDonMua.Where(r => r.HoaDonMuaID == id).ToList();
            foreach (var old in oldDetails)
            {
                var pbCu = context.PhienBanSanPham.Find(old.PhienBanSanPhamID);
                if (pbCu != null) pbCu.SoLuongTon -= old.SoLuong;
            }

            context.ChiTietHoaDonMua.RemoveRange(oldDetails);
            decimal tongTienMoi = 0;

            // 2. Thêm mới và cập nhật cho bảng Phiên Bản
            foreach (var item in chiTietList.ToList())
            {
                ChiTietHoaDonMua ct = new ChiTietHoaDonMua
                {
                    HoaDonMuaID = id,
                    PhienBanSanPhamID = item.PhienBanSanPhamID,
                    SoLuong = item.SoLuong,
                    DonGia = item.DonGia
                };
                context.ChiTietHoaDonMua.Add(ct);
                tongTienMoi += (decimal)item.ThanhTien;

                // Cập nhật bảng PHIÊN BẢN (Giá và Tồn kho)
                var pb = context.PhienBanSanPham.Include(p => p.SanPham).FirstOrDefault(p => p.IDPhienBan == item.PhienBanSanPhamID);
                if (pb != null)
                {
                    pb.SoLuongTon += item.SoLuong;

                    // Tìm giá nhập cao nhất lịch sử của ĐÚNG phiên bản này
                    decimal maxGiaLichSu = context.ChiTietHoaDonMua
                        .Where(c => c.PhienBanSanPhamID == pb.IDPhienBan && c.HoaDonMuaID != id)
                        .Max(c => (decimal?)c.DonGia) ?? 0;

                    decimal giaNhapMoi = Math.Max(maxGiaLichSu, item.DonGia);
                    pb.GiaNhap = giaNhapMoi;

                    // Tính giá bán cho phiên bản (Dựa trên hãng của Sản phẩm cha)
                    decimal phanTramLoi = 15;
                    string hang = pb.SanPham?.HangSanXuat?.ToLower().Trim() ?? "";
                    // ... (Giữ nguyên switch case tính phanTramLoi của bạn)

                    pb.GiaBan = giaNhapMoi + (giaNhapMoi * phanTramLoi / 100);
                }
            }

            // 3. Cập nhật tổng tiền Hóa đơn cha
            var hd = context.HoaDonMua.Find(id);
            if (hd != null)
            {
                hd.TongTien = tongTienMoi;
                context.HoaDonMua.Update(hd);
            }

            context.SaveChanges();
            MessageBox.Show("Đã cập nhật Tồn Kho và Giá Bán cho từng phiên bản thành công!", "Hoàn tất");
        }

        // ==========================================
        // 5. IN HÓA ĐƠN
        // ==========================================
        private void InHoaDon_Click(object sender, EventArgs e)
        {
           
            if (chiTietList.Count == 0)
            {
                MessageBox.Show("Chưa có mặt hàng nào để in!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try { 
            int maHoaDonTong = this.id;

            // Nếu bạn không có biến, hãy lấy từ TextBox hiển thị Mã Hóa Đơn trên đầu Form
            // int maHoaDonTong = Convert.ToInt32(txtMaHoaDon.Text);

            // Truyền Mã Hóa Đơn Tổng này sang Form In
            frmInHoaDon frmIn = new frmInHoaDon(maHoaDonTong);
            frmIn.ShowDialog();
        }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

}

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy chữ người dùng gõ vào (chuyển thành chữ thường để dễ tìm)
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                // Nếu xóa trắng ô tìm kiếm -> Trả lại toàn bộ danh sách ban đầu
                BindingSource bsFull = new BindingSource();
                bsFull.DataSource = chiTietList;
                dgvChiTietHDM.DataSource = bsFull;
            }
            else
            {
                // Lọc ra những dòng có Tên Sản Phẩm chứa từ khóa
                var ketQuaLoc = chiTietList.Where(x => (x.TenSanPham?? "").ToLower().Contains(tuKhoa)).ToList();

                // Đổ kết quả đã lọc lên lại lưới DataGridView
                BindingSource bsLoc = new BindingSource();
                bsLoc.DataSource = ketQuaLoc;
                dgvChiTietHDM.DataSource = bsLoc;
            }
        }

        private void numThanhTien_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}