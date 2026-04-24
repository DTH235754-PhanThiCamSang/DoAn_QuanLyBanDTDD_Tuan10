using Microsoft.EntityFrameworkCore;
using QuanLyBanDTDD.Data;
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

namespace QuanLyBanDTDD.Forms
{
    public partial class frmChiTietHoaDonBan : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext();
        bool xuLyThem = false;
        string id; 
        int maSanPhamDangSua = 0;

        BindingList<DanhSachHoaDonBan_ChiTiet> chiTietList = new BindingList<DanhSachHoaDonBan_ChiTiet>();
        public frmChiTietHoaDonBan(string maHoaDon = "")
        {
            InitializeComponent();
            this.id = maHoaDon;
        }


       
        
        private void HieuUngNutBam(PictureBox pic, bool duocPhepBam)
        {
            if (pic == null) return;
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
            cboTenSanPham.Enabled = dangThaoTac;
            numSoLuong.Enabled = dangThaoTac;
            numDonGia.Enabled = dangThaoTac;
         

            dgvChiTietHDB.Enabled = !dangThaoTac;

            HieuUngNutBam(picThem, !dangThaoTac);
            HieuUngNutBam(picSua, !dangThaoTac);
            HieuUngNutBam(picXoa, !dangThaoTac);


            HieuUngNutBam(picLuu, dangThaoTac);
            HieuUngNutBam(picHuyBo, dangThaoTac);
         
        }

        private void LoadComboBox()
        {
            try
            {
                // Lấy dữ liệu từ bảng Phiên Bản, nối sang bảng Sản Phẩm
                var dsPhienBan = context.PhienBanSanPham
                    .Include(pb => pb.SanPham)
                    .Select(pb => new
                    {
                        ID = pb.IDPhienBan,
                        
                        HienThi = (pb.SanPham != null ? pb.SanPham.TenSP : "Không tên")
                                  + " (" + pb.BoNho + " " + pb.MauSac + ")"
                    }).ToList();

                // Đổ dữ liệu vào ComboBox
                cboTenSanPham.DataSource = dsPhienBan;
                cboTenSanPham.DisplayMember = "HienThi"; 
                cboTenSanPham.ValueMember = "ID";        

               
                cboTenSanPham.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sản phẩm: " + ex.Message);
            }
        }

        private void LoadData()
        {

            var ct = context.ChiTietHoaDonBan
                            .Include(c => c.PhienBanSanPham).ThenInclude(pb => pb.SanPham)
                            .Where(r => r.HoaDonBanID == id)
                            .Select(r => new DanhSachHoaDonBan_ChiTiet
                            {
                                ID = r.ID,
                                HoaDonBanID = r.HoaDonBanID,
                                PhienBanSanPhamID = r.PhienBanSanPhamID ?? 0,
                                TenSanPham = (r.PhienBanSanPham != null && r.PhienBanSanPham.SanPham != null)
                                     ? r.PhienBanSanPham.SanPham.TenSP + " (" + r.PhienBanSanPham.BoNho + " " + r.PhienBanSanPham.MauSac + ")"
                                     : "Sản phẩm không xác định",


                                SoLuong = r.SoLuong,
                                DonGia = r.DonGia ,
                                ThanhTien = r.ThanhTien , // Đã có sẵn cột Thành Tiền trong DB
                                NgayKichHoat = r.NgayKichHoat,
                                NgayHetHan = r.NgayHetHan,
                            
                            }).ToList();

            chiTietList = new BindingList<DanhSachHoaDonBan_ChiTiet>(ct);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = chiTietList;

            
            cboTenSanPham.DataBindings.Clear();
            numSoLuong.DataBindings.Clear();
            numDonGia.DataBindings.Clear();

            cboTenSanPham.DataBindings.Add("SelectedValue", bindingSource, "PhienBanSanPhamID", false, DataSourceUpdateMode.Never);
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", true, DataSourceUpdateMode.Never);
            numDonGia.DataBindings.Add("Value", bindingSource, "DonGia", true, DataSourceUpdateMode.Never);
            dgvChiTietHDB.DataSource = bindingSource;

            
            // lay DỮ LIỆU CÁC Ô HIỂN THỊ BÊN PHẢI (Chi Tiết)
       
            txtID.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            numSoLuongBan.DataBindings.Clear();
            numDonGiaBan.DataBindings.Clear();
            numThanhTien.DataBindings.Clear();
            txtNgayKichHoat.DataBindings.Clear();
            txtNgayHetHan.DataBindings.Clear();

            txtID.DataBindings.Add("Text", bindingSource, "ID", false, DataSourceUpdateMode.Never);
            txtTenSP.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);
            numSoLuongBan.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);
            numDonGiaBan.DataBindings.Add("Value", bindingSource, "DonGia", true, DataSourceUpdateMode.Never);
            numThanhTien.DataBindings.Add("Value", bindingSource, "ThanhTien", true, DataSourceUpdateMode.Never);
            txtNgayKichHoat.DataBindings.Add("Text", bindingSource, "NgayKichHoat", true, DataSourceUpdateMode.Never, "", "dd/MM/yyyy");
            txtNgayHetHan.DataBindings.Add("Text", bindingSource, "NgayHetHan", true, DataSourceUpdateMode.Never, "", "dd/MM/yyyy");
           
            //  LẤY THÔNG TIN HÓA ĐƠN CHA (NHÂN VIÊN & KHÁCH HÀNG)
           
            var hdBan = context.HoaDonBan
                               .Include(h => h.NhanVien)
                               .Include(h => h.KhachHang)
                               .FirstOrDefault(h => h.ID == id);

            if (hdBan != null)
            {
                txtNhanVienNhap.Text = hdBan.NhanVien != null ? hdBan.NhanVien.HoTen : "Không xác định";
                txtNhanVienNhap.ReadOnly = true;

                // Combobox Khách Hàng
                cboKhachHang.DataSource = null;
                cboKhachHang.Items.Clear();
                cboKhachHang.Items.Add(hdBan.KhachHang != null ? hdBan.KhachHang.HoTen : "Khách vãng lai");
                cboKhachHang.SelectedIndex = 0;
                cboKhachHang.Enabled = false;
            }

            SetupAutoComplete();
        }
        //tro giup tim kiem
        private void SetupAutoComplete()
        {
            try
            {
                AutoCompleteStringCollection danhSachGoiY = new AutoCompleteStringCollection();
                var listTenSP = chiTietList.Where(x => !string.IsNullOrEmpty(x.TenSanPham))
                                           .Select(x => x.TenSanPham)
                                           .Distinct()
                                           .ToList();

                danhSachGoiY.AddRange(listTenSP.ToArray());
                txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTimKiem.AutoCompleteCustomSource = danhSachGoiY;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo gợi ý tìm kiếm: " + ex.Message);
            }
        }

        private void frmChiTietHoaDonBan_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dgvChiTietHDB.AutoGenerateColumns = false;
            LoadComboBox();
            LoadData();
        }
        private void LuuToanBoXuongDB()
        {
            try
            {

                var oldDetails = context.ChiTietHoaDonBan.Where(r => r.HoaDonBanID == id).ToList();

                foreach (var old in oldDetails)
                {

                    var pbCu = context.PhienBanSanPham.Find(old.PhienBanSanPhamID);
                    if (pbCu != null)
                    {
                        pbCu.SoLuongTon += old.SoLuong; // Trả kho
                        context.PhienBanSanPham.Update(pbCu);
                    }
                }


                context.ChiTietHoaDonBan.RemoveRange(oldDetails);


                context.SaveChanges();


                //THÊM HÓA ĐƠN MỚI VÀ TRỪ KHO 

                decimal tongTienMoi = 0;

                foreach (var item in chiTietList.ToList())
                {
                    ChiTietHoaDonBan ct = new ChiTietHoaDonBan
                    {
                        HoaDonBanID = id,
                        PhienBanSanPhamID = item.PhienBanSanPhamID,
                        SoLuong = item.SoLuong,
                        DonGia = item.DonGia,
                        ThanhTien = item.ThanhTien,
                        NgayKichHoat = item.NgayKichHoat,
                        NgayHetHan = item.NgayHetHan,

                    };
                    context.ChiTietHoaDonBan.Add(ct);
                    tongTienMoi += item.ThanhTien;

                    // TRỪ KHO
                    var pbMoi = context.PhienBanSanPham.Find(item.PhienBanSanPhamID);
                    if (pbMoi != null)
                    {
                        pbMoi.SoLuongTon -= item.SoLuong; // Xuất kho
                        context.PhienBanSanPham.Update(pbMoi);
                    }
                }


                //CẬP NHẬT TỔNG TIỀN VÀ CHỐT SỔ

                var hd = context.HoaDonBan.Find(id);
                if (hd != null)
                {
                    hd.TongTien = tongTienMoi;
                    context.HoaDonBan.Update(hd);
                }

                context.SaveChanges();
                MessageBox.Show("Cập nhật hóa đơn và Trừ tồn kho thành công!", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu DB: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTenSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (cboTenSanPham.Enabled && cboTenSanPham.SelectedIndex != -1 && cboTenSanPham.SelectedValue != null)
            {
                if (int.TryParse(cboTenSanPham.SelectedValue.ToString(), out int idPB))
                {
                   
                    var phienBan = context.PhienBanSanPham.Find(idPB);

                    if (phienBan != null)
                    {
                        //Lấy GIÁ BÁN từ đúng phiên bản đó
                        numDonGia.Value = phienBan.GiaBan;

                       
                        if (phienBan.SoLuongTon < 10)
                        {
                            MessageBox.Show($"Chú ý: Phiên bản này sắp hết hàng! Trong kho hiện chỉ còn {phienBan.SoLuongTon} cái.",
                                            "Cảnh báo Tồn Kho",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }



        private void picThem_Click(object sender, EventArgs e)
        {
            xuLyThem = true;
            BatTatChucNang(true);

            cboTenSanPham.SelectedIndex = -1;
            numSoLuong.Value = 1;
            numDonGia.Value = 0;
            cboTenSanPham.Focus();
        }

        private void picSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHDB.CurrentRow == null) return;

            xuLyThem = false;
            BatTatChucNang(true);

            maSanPhamDangSua = Convert.ToInt32(dgvChiTietHDB.CurrentRow.Cells["colSanPhamID"].Value?.ToString());
            cboTenSanPham.Enabled = false; 
            numSoLuong.Focus();
        }

        private void picHuyBo_Click(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            LoadData();
        }

        private void picLuu_Click(object sender, EventArgs e)
        {
            int sl = int.TryParse(numSoLuong.Text.Trim(), out int tempSl) ? tempSl : 0;
            decimal dg = decimal.TryParse(numDonGia.Text.Trim(), out decimal tempDg) ? tempDg : 0;

            if (cboTenSanPham.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần bán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenSanPham.Focus();
                return;
            }

            if (sl <= 0 || dg <= 0)
            {
                MessageBox.Show("Số lượng và Đơn giá phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

         
            int maSP = Convert.ToInt32(cboTenSanPham.SelectedValue);
           
            context.ChangeTracker.Clear();
          
            // KIỂM TRA TỒN KHO TRƯỚC KHI BÁN (không bán âm kho)
         
            var spKiemTra = context.PhienBanSanPham.Find(maSP);
            int soLuongKhoHienTai = spKiemTra != null ? spKiemTra.SoLuongTon : 0;

            if (!xuLyThem)
            {
                var oldItem = chiTietList.FirstOrDefault(x => x.PhienBanSanPhamID == maSP);
                if (oldItem != null) soLuongKhoHienTai += oldItem.SoLuong;
            }

            if (sl > soLuongKhoHienTai)
            {
                MessageBox.Show($"Kho không đủ hàng! Bạn đang muốn xuất {sl} cái, nhưng kho chỉ còn {soLuongKhoHienTai} cái.", "Cảnh báo Kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numSoLuong.Focus();
                return;
            }

           
            //  TIẾN HÀNH LƯU TẠM VÀO LƯỚI
          
            try
            {
                if (xuLyThem)
                {
                    var exist = chiTietList.FirstOrDefault(x => x.PhienBanSanPhamID == maSP);
                    if (exist != null)
                    {
                        exist.SoLuong += sl;
                        exist.DonGia = dg;
                        exist.ThanhTien = exist.SoLuong * exist.DonGia;
                        
                    }
                    else
                    {
                        chiTietList.Add(new DanhSachHoaDonBan_ChiTiet
                        {
                            ID = 0,
                            HoaDonBanID = id,
                            PhienBanSanPhamID = maSP,
                            TenSanPham = cboTenSanPham.Text,
                            SoLuong = sl,
                            DonGia = dg,
                            ThanhTien = sl * dg,
                            NgayKichHoat = DateTime.Now,
                            NgayHetHan = DateTime.Now.AddMonths(12),
                           
                        });
                    }
                }
                else 
                {
                    var edit = chiTietList.FirstOrDefault(x => x.PhienBanSanPhamID == maSanPhamDangSua);
                    if (edit != null)
                    {
                      
                        edit.SoLuong = sl;
                        edit.DonGia = dg;
                        edit.ThanhTien = sl * dg;
                    }
                }

               
              
               
                LuuToanBoXuongDB();
                BatTatChucNang(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHDB.CurrentRow == null) return;

            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn HỦY mặt hàng này khỏi hóa đơn bán?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int maSPXoa = Convert.ToInt32(dgvChiTietHDB.CurrentRow.Cells["colSanPhamID"].Value?.ToString());
                    var row = chiTietList.FirstOrDefault(x => x.PhienBanSanPhamID == maSPXoa);

                    if (row != null)
                    {
                        chiTietList.Remove(row);
                        LuuToanBoXuongDB(); // Xóa xong lưu DB để kho trả lại hàng
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
       
      



        private void picTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                BindingSource bsFull = new BindingSource();
                bsFull.DataSource = chiTietList;
                dgvChiTietHDB.DataSource = bsFull;
            }
            else
            {
                var ketQuaLoc = chiTietList.Where(x => x.TenSanPham != null && x.TenSanPham.ToLower().Contains(tuKhoa)).ToList();
                BindingSource bsLoc = new BindingSource();
                bsLoc.DataSource = ketQuaLoc;
                dgvChiTietHDB.DataSource = bsLoc;
            }
        }

        private void InHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy mã hóa đơn tổng đang quản lý bởi Form này

                string maHDBTong = this.id.ToString();

                frmInHoaDonBan frmIn = new frmInHoaDonBan(maHDBTong);
                frmIn.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống khi in: " + ex.Message);
            }
        }
    
       
        
    }
    


}
