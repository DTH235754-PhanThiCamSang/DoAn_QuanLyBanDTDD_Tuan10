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
    public partial class frmDoiTra : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext();
        int idChiTietHDBan = 0;
        int idSanPham = 0;
        decimal giaLucMua = 0;

        public frmDoiTra()
        {
            InitializeComponent();
        }

        private void frmDoiTra_Load(object sender, EventArgs e)
        {
            // 1. Cấu hình hình thức
            cboHinhThucTra.Items.Clear();
            cboHinhThucTra.Items.Add("Đổi trả do lỗi NSX (Miễn phí)");
            cboHinhThucTra.Items.Add("Trả hàng theo nhu cầu (Thu phí %)");
            cboHinhThucTra.SelectedIndex = 0;

            // 2. Cấu hình hướng xử lý (dành cho máy mất Seal)
            cboHuongXuLy.Items.Clear();
            cboHuongXuLy.Items.AddRange(new string[] { "Gửi trả hãng bảo hành", "Làm hàng trưng bày", "Kho thanh lý sỉ" });

            // 3. Mặc định tích vào Còn Seal
            chkConSeal.Checked = true;
            cboHuongXuLy.Enabled = false; // Còn seal thì không cần chọn hướng xử lý

            BatTatChucNang(false);
            HieuUngNutBam(picXuLyDoiTra, false);
            LoadDanhSachDoiTra();

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
            // Các ô nhập liệu
            cboHinhThucTra.Enabled = dangThaoTac;
            numPhuPhi.Enabled = dangThaoTac;
            txtLyDo.Enabled = dangThaoTac;
            chkConSeal.Enabled = dangThaoTac;

            // Nếu khóa khu vực thì cboHuongXuLy cũng phải khóa theo
            if (!dangThaoTac) cboHuongXuLy.Enabled = false;

            // --- BỔ SUNG ĐIỀU KHIỂN CÁC NÚT Ở ĐÂY ---
            // Khi dangThaoTac = false (Chưa làm gì) -> Sáng 3 nút Thêm, Sửa, Xóa
            HieuUngNutBam(picXuLyDoiTra, dangThaoTac);
            HieuUngNutBam(picSua, !dangThaoTac);
            HieuUngNutBam(picXoa, !dangThaoTac);

            // Khi dangThaoTac = true (Đang gõ phiếu) -> Sáng nút Lưu và Hủy
            HieuUngNutBam(picXuLyDoiTra, dangThaoTac);
            HieuUngNutBam(picHuyBo, dangThaoTac);
        }
        private void XoaTrangThongTin()
        {
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtTenSanPham.Clear();
            txtIMEI_HienThi.Clear();
            txtLyDo.Clear();

            datNgayMua.Value = DateTime.Now;
            numGiaLucMua.Value = 0;
            numPhuPhi.Value = 0;
            numTienHoanTra.Text = "0 VNĐ"; // Hoặc numTienHoanTra.Value = 0 tùy thiết kế của bạn

            if (cboDanhSachIMEI != null) cboDanhSachIMEI.Visible = false;

            idChiTietHDBan = 0;
            idSanPham = 0;

            BatTatChucNang(false);
        }
        private void HienThiThongTinMay(ChiTietHoaDonBan mayKhach)
        {
            txtTenKhachHang.Text = mayKhach?.HoaDonBan?.KhachHang?.HoTen ?? "Không rõ tên";
            txtSoDienThoai.Text = mayKhach?.HoaDonBan?.KhachHang?.SDT ?? "";

            txtTenSanPham.Text = mayKhach?.PhienBanSanPham?.SanPham?.TenSP ?? "Sản phẩm không xác định";
            txtIMEI_HienThi.Text = mayKhach?.SoIMEI ?? "";

            datNgayMua.Value = mayKhach.HoaDonBan.NgayBan;
            numGiaLucMua.Value = (decimal)mayKhach.DonGia;

            idChiTietHDBan = mayKhach.ID;
            idSanPham = (int)mayKhach.PhienBanSanPhamID;

            BatTatChucNang(false);
            HieuUngNutBam(picXuLyDoiTra, true);
            chkConSeal.Checked = true;
            TinhPhuPhiTuDong();

            int soNgay = (int)(DateTime.Now - mayKhach.HoaDonBan.NgayBan).TotalDays;
            if (soNgay > 10)
            {
                MessageBox.Show($"Máy đã mua được {soNgay} ngày (Vượt quá 10 ngày tiêu chuẩn).\nHệ thống tự động đề xuất mức phí phạt 15%.", "Chính sách Đổi Trả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // 1. Hàm tính phụ phí tự động theo chính sách
        private void TinhPhuPhiTuDong()
        {
            if (numGiaLucMua.Value == 0) return;

            decimal giaLucMua = numGiaLucMua.Value;
            decimal tiLePhat = 0;

            // Chính sách 10 ngày 
            int soNgay = (int)(DateTime.Now - datNgayMua.Value).TotalDays;
            if (soNgay > 10) tiLePhat += 10;

            // Chính sách Hình thức (Trả lấy tiền thì trừ 5% khấu hao)
            if (cboHinhThucTra.Text == "Trả hàng theo nhu cầu (Thu phí %)") tiLePhat += 5;



            numPhuPhi.Value = giaLucMua * tiLePhat / 100;
        }

        // 2. Hàm TÍNH TIỀN cuổi cùng (Luôn lấy Giá Mua trừ đi ô Phụ Phí trên màn hình)
        private void TinhTienHoanTra()
        {
            if (numGiaLucMua.Value == 0) return;

            decimal tienHoan = numGiaLucMua.Value - numPhuPhi.Value;
            if (tienHoan < 0) tienHoan = 0;

            // Mình thấy trong hình của bạn Tiền hoàn trả đang là ô NumericUpDown nên mình dùng .Value nhé
            numTienHoanTra.Value = tienHoan;
        }
        private void LoadDanhSachDoiTra()
        {
            try
            {
                // 1. Ép Entity Framework dọn dẹp bộ nhớ đệm, luôn lấy dữ liệu tươi mới nhất từ SQL
                context.ChangeTracker.Clear();

                // 2. Kéo dữ liệu và bọc thép chống sập Form
                var dsDoiTra = context.DoiTra
                    .Include(dt => dt.ChiTiet_HoaDonBan).ThenInclude(ct => ct.PhienBanSanPham).ThenInclude(pb => pb.SanPham)
                    .Include(dt => dt.ChiTiet_HoaDonBan.HoaDonBan).ThenInclude(hd => hd.KhachHang)
                    .Select(dt => new
                    {
                        ID = dt.ID,
                        SoIMEI = dt.SoIMEI ?? "Không có IMEI",

                        // Bọc thép đường dẫn dài: Nếu đứt đoạn ở đâu thì trả về "Không rõ" thay vì báo lỗi
                        TenSP = (dt.ChiTiet_HoaDonBan != null && dt.ChiTiet_HoaDonBan.PhienBanSanPham != null && dt.ChiTiet_HoaDonBan.PhienBanSanPham.SanPham != null)
                                  ? dt.ChiTiet_HoaDonBan.PhienBanSanPham.SanPham.TenSP
                                  : "Không rõ sản phẩm",

                        TenKH = (dt.ChiTiet_HoaDonBan != null && dt.ChiTiet_HoaDonBan.HoaDonBan != null && dt.ChiTiet_HoaDonBan.HoaDonBan.KhachHang != null)
                                  ? dt.ChiTiet_HoaDonBan.HoaDonBan.KhachHang.HoTen
                                  : "Khách lẻ",



                        NgayNhan = dt.NgayDoiTra,


                        NgayTraDuKien = dt.NgayDoiTra.AddDays(7),


                        LoiKhachBao = dt.LyDo ?? "",

                        PhanLoai = dt.HinhThuc ?? "",


                        TrangThai = dt.HuongXuLy ?? "Đã xử lý",

                        ChiPhi = dt.PhuPhi,
                        GhiChu = dt.GhiChu ?? "",
                        HoanTien = dt.SoTienHoanLai


                    })
                    .OrderByDescending(dt => dt.NgayTraDuKien) // Hiện phiếu mới nhất lên đầu
                    .ToList();

                // 3. Gán vào DataGridView an toàn
                dgvDoiTra.DataSource = null;
                dgvDoiTra.DataSource = dsDoiTra;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách đổi trả: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                XoaTrangThongTin();
                cboDanhSachIMEI.Visible = false;
                return;
            }

            // 1. Truy vấn Database 
            var danhSachMay = context.ChiTietHoaDonBan
                .Include(ct => ct.PhienBanSanPham).ThenInclude(pb => pb.SanPham)
                .Include(ct => ct.HoaDonBan).ThenInclude(h => h.KhachHang)
                .Where(ct => (ct.SoIMEI.Contains(tuKhoa) || ct.HoaDonBan.KhachHang.SDT.Contains(tuKhoa))
                          && ct.TrangThai != "Đã trả hàng")
                .ToList();

            // 2. Xử lý hiển thị
            if (danhSachMay.Count == 1)
            {
                // Có 1 máy -> Điền luôn, ẩn ComboBox
                cboDanhSachIMEI.Visible = false;
                HienThiThongTinMay(danhSachMay[0]);
            }
            else if (danhSachMay.Count > 1)
            {
                // Có nhiều máy -> Hiện ComboBox để chọn
                cboDanhSachIMEI.Visible = true;


                var dataSource = danhSachMay.Select(m => new
                {
                    ID = m.ID,

                    HienThi = (m.PhienBanSanPham?.SanPham?.TenSP ?? "Sản phẩm không xác định") + " (IMEI: " + (m.SoIMEI ?? "Trống") + ")"
                }).ToList();

                cboDanhSachIMEI.SelectedIndexChanged -= cboDanhSachIMEI_SelectedIndexChanged;

                cboDanhSachIMEI.DataSource = dataSource;
                cboDanhSachIMEI.DisplayMember = "HienThi";
                cboDanhSachIMEI.ValueMember = "ID";
                cboDanhSachIMEI.SelectedIndex = -1;

                // Bật lại sự kiện
                cboDanhSachIMEI.SelectedIndexChanged += cboDanhSachIMEI_SelectedIndexChanged;

                txtTenKhachHang.Clear();
                txtSoDienThoai.Clear();
                txtTenSanPham.Clear();
                txtIMEI_HienThi.Clear();
                numGiaLucMua.Value = 0;
                numPhuPhi.Value = 0;
                idChiTietHDBan = 0;
            }
            else
            {
                // Không tìm thấy
                cboDanhSachIMEI.Visible = false;
                XoaTrangThongTin();
            }
        }
        // ==========================================
        // 2. XỬ LÝ SỰ KIỆN GIAO DIỆN
        // ==========================================


        private void numPhuPhi_ValueChanged(object sender, EventArgs e)
        {
            TinhTienHoanTra();
        }

        private void chkConSeal_CheckedChanged(object sender, EventArgs e)
        {

            cboHuongXuLy.Enabled = !chkConSeal.Checked;
            if (chkConSeal.Checked) cboHuongXuLy.SelectedIndex = -1;

            TinhPhuPhiTuDong(); // Thay vì gọi TinhTienHoanTra, giờ gọi hàm này
        }

        private void picXuLyDoiTra_Click(object sender, EventArgs e)
        {

            if (idChiTietHDBan == 0)
            {
                MessageBox.Show("Vui lòng tìm và chọn đúng máy cần đổi trả trước khi thao tác!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTimKiem.Focus();
                return;
            }

            BatTatChucNang(true); // Mở khóa Form cho phép gõ Lý do
            txtLyDo.Focus();
        }

        private void picHuyBo_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            XoaTrangThongTin();
            BatTatChucNang(false);
        }

        private void cboHuongXuLy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDanhSachIMEI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhSachIMEI.SelectedValue != null && cboDanhSachIMEI.SelectedValue is int)
            {
                int idMayChon = (int)cboDanhSachIMEI.SelectedValue;

                var mayDuocChon = context.ChiTietHoaDonBan
                    .Include(ct => ct.PhienBanSanPham).ThenInclude(pb => pb.SanPham)
                    .Include(ct => ct.HoaDonBan).ThenInclude(h => h.KhachHang)
                    .FirstOrDefault(ct => ct.ID == idMayChon);

                if (mayDuocChon != null)
                {
                    HienThiThongTinMay(mayDuocChon);
                }
            }
        }

        private void cboHinhThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhPhuPhiTuDong();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void picSua_Click(object sender, EventArgs e)
        {
            string trangThai = "Đã xử lý";

            if (trangThai == "Đã xử lý")
            {
                MessageBox.Show("Phiếu này đã hoàn tất xử lý. Không được phép sửa đổi thông tin!", "Khóa thao tác", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            BatTatChucNang(true);
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (dgvDoiTra.CurrentRow == null) return;

            try
            {

                int idXoa = Convert.ToInt32(dgvDoiTra.CurrentRow.Cells["colID"].Value);

                // 2. Tìm phiếu trong Database
                var phieuXoa = context.DoiTra.Find(idXoa);
                if (phieuXoa == null) return;


                string huongXuLy = phieuXoa.HuongXuLy ?? "";


                if (huongXuLy != "")
                {
                    MessageBox.Show($"Phiếu này đã hoàn tất với hướng xử lý: [{huongXuLy}].\nTuyệt đối không được phép xóa hay sửa đổi!", "Khóa thao tác", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }


                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu đổi trả này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    context.DoiTra.Remove(phieuXoa);
                    context.SaveChanges();

                    MessageBox.Show("Đã xóa phiếu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDoiTra();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void picLuu_Click(object sender, EventArgs e)
        {
            // Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(txtLyDo.Text))
            {
                MessageBox.Show("Vui lòng nhập lý do đổi trả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLyDo.Focus();
                return;
            }

            if (!chkConSeal.Checked && string.IsNullOrWhiteSpace(cboHuongXuLy.Text))
            {
                MessageBox.Show("Vì máy Đã Mất Seal, vui lòng chọn [Hướng xử lý] cho máy này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHuongXuLy.Focus();
                return;
            }

            if (MessageBox.Show("Xác nhận thu hồi máy này và hoàn tiền cho khách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // 1. Cập nhật Hóa Đơn cũ
                    var mayCu = context.ChiTietHoaDonBan.Find(idChiTietHDBan);
                    if (mayCu != null)
                    {
                        mayCu.TrangThai = "Đã trả hàng";
                        mayCu.GhiChu = $"Đổi trả: {cboHinhThucTra.Text} | Phí thu: {numPhuPhi.Value}";
                    }

                    // 2. Tạo phiếu Đổi Trả
                    DoiTra phieuDT = new DoiTra
                    {
                        ChiTietHoaDonBanID = idChiTietHDBan,
                        SoIMEI = txtIMEI_HienThi.Text, // Lấy đúng ô hiển thị IMEI
                        NgayDoiTra = DateTime.Now,
                        HinhThuc = cboHinhThucTra.Text,
                        LyDo = txtLyDo.Text,
                        PhuPhi = numPhuPhi.Value,
                        SoTienHoanLai = numGiaLucMua.Value - numPhuPhi.Value,
                        ConSeal = chkConSeal.Checked,
                        HuongXuLy = chkConSeal.Checked ? "Nhập kho bán mới" : cboHuongXuLy.Text

                    };
                    context.DoiTra.Add(phieuDT);

                    // 3. ĐIỀU HƯỚNG KHO (Logic cốt lõi)
                    if (chkConSeal.Checked)
                    {

                        var phienBan = context.PhienBanSanPham.Find(idSanPham);
                        if (phienBan != null)
                        {
                            phienBan.SoLuongTon += 1; // Cộng trả lại 1 máy vào kho
                            context.PhienBanSanPham.Update(phienBan); // Ép EF ghi nhận thay đổi
                        }
                    }
                    context.SaveChanges();

                    string thongBao = chkConSeal.Checked ? "Máy còn Seal đã được hoàn lại vào KHO BÁN MỚI." : $"Máy đã được chuyển sang diện: [{cboHuongXuLy.Text}]";
                    MessageBox.Show($"Xử lý thành công!\n\n{thongBao}", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachDoiTra();
                    // Reset Form sau khi lưu xong
                    txtTimKiem.Clear();
                    XoaTrangThongTin();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
