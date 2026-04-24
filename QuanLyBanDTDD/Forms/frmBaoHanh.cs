using DocumentFormat.OpenXml.Bibliography;
using Microsoft.CodeAnalysis.Text;
using Microsoft.EntityFrameworkCore;
using QuanLyBanDTDD.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDTDD.Forms
{
    public partial class frmBaoHanh : Form
    {

        QLBDTDTDbContext context = new QLBDTDTDbContext();
        bool xuLyThem = false;
        int maDangChon = 0;
        int idChiTietHDBan = 0;


        public frmBaoHanh(int v)
        {
            InitializeComponent();
        }

        private void frmBaoHanh_Load(object sender, EventArgs e)
        {

            BatTatChucNang(false);
            dgvBaoHanh.AutoGenerateColumns = false;
            LoadDataBaoHanh();
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
            
            txtTimKiem.Enabled = !dangThaoTac;
            if (cboDanhSachIMEI != null) cboDanhSachIMEI.Enabled = !dangThaoTac;
            txtTinhTrangMay.Enabled = dangThaoTac;
            txtKetQuaXuLy.Enabled = dangThaoTac;
            cboLoaiBaoHanh.Enabled = dangThaoTac;
            numChiPhi.Enabled = dangThaoTac && cboLoaiBaoHanh.Text == "Sửa chữa có phí";
            cboTrangThai.Enabled = dangThaoTac;
            datNgayTraDuKien.Enabled = dangThaoTac;

            dgvBaoHanh.Enabled = !dangThaoTac;

            
            HieuUngNutBam(picThem, !dangThaoTac);
            HieuUngNutBam(picSua, !dangThaoTac);
            HieuUngNutBam(picXoa, !dangThaoTac);
            HieuUngNutBam(picLuu, dangThaoTac);
            HieuUngNutBam(picHuyBo, dangThaoTac);
        }


        private void LoadDataBaoHanh(string tuKhoa = "")
        {
            var query = context.BaoHanh
                .Include(b => b.ChiTietHoaDonBan).ThenInclude(ct => ct.PhienBanSanPham).ThenInclude(pb => pb.SanPham)
                .Include(b => b.ChiTietHoaDonBan)
                .Include(b => b.ChiTietHoaDonBan).ThenInclude(ct => ct.HoaDonBan).ThenInclude(h => h.KhachHang)
                .AsQueryable();

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(b => b.SoIMEI.Contains(tuKhoa) ||
                                         b.ChiTietHoaDonBan.HoaDonBan.KhachHang.SDT.Contains(tuKhoa));
            }

            dgvBaoHanh.DataSource = query.Select(b => new
            {
                b.ID,
                SoIMEI = b.SoIMEI,
                TenSP = b.ChiTietHoaDonBan.PhienBanSanPham.SanPham.TenSP,
                TenKH = b.ChiTietHoaDonBan.HoaDonBan.KhachHang.HoTen,
                b.NgayNhan,
                b.NgayTraDuKien,
                b.LoiKhachBao,
                PhanLoai = b.LoiDoKhach ? "Lỗi do khách" : "Lỗi NSX",
                b.TrangThai,
                b.ChiPhi
            }).ToList();
        }



       
        private void HienThiThongTinMay(ChiTietHoaDonBan mayKhach)
        {
            // Đổ dữ liệu lên giao diện 
            txtTenKhachHang.Text = mayKhach.HoaDonBan.KhachHang.HoTen;
            txtSoDienThoai.Text = mayKhach.HoaDonBan.KhachHang.SDT;
            txtTenSanPham.Text = mayKhach.PhienBanSanPham.SanPham.TenSP;
            txtIMEI_HienThi.Text = mayKhach.SoIMEI;

            datNgayMua.Value = mayKhach.HoaDonBan.NgayBan;
            idChiTietHDBan = mayKhach.ID;
            datNgayHetHan.Value = mayKhach.NgayHetHan;

           
            if (DateTime.Now > mayKhach.NgayHetHan)
            {
                cboLoaiBaoHanh.Text = "Sửa chữa có phí";
            }
            else
            {
                cboLoaiBaoHanh.Text = "Bảo hành";
            }

            BatTatChucNang(false);
            txtTinhTrangMay.Focus();
        }

       
        private void XoaTrangThongTin()
        {
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtTenSanPham.Clear();
            txtIMEI_HienThi.Clear();
            txtKetQuaXuLy.Clear();
            txtTinhTrangMay.Clear();
            numChiPhi.Value = 0;
            //ẩn imei
            if (cboDanhSachIMEI != null)
            {
                cboDanhSachIMEI.Visible = false;
            }

            // Reset lại ID máy
            idChiTietHDBan = 0;


            BatTatChucNang(false);
        }

      



        private void picThem_Click(object sender, EventArgs e)
        {
            if (idChiTietHDBan == 0)
            {
                MessageBox.Show("Vui lòng tìm đúng SĐT hoặc IMEI máy cần bảo hành trước!");
                txtTimKiem.Focus();
                return;
            }
            xuLyThem = true;
            BatTatChucNang(true);

            txtTinhTrangMay.Text = "";
            txtKetQuaXuLy.Text = "";
            numChiPhi.Value = 0;
            txtTinhTrangMay.Focus();
        }

        private void picSua_Click(object sender, EventArgs e)
        {
            if (dgvBaoHanh.CurrentRow == null) return;
            maDangChon = (int)dgvBaoHanh.CurrentRow.Cells["colID"].Value;
            xuLyThem = false;
            BatTatChucNang(true);
        }

        private void picLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (xuLyThem)
                {
                    BaoHanh bh = new BaoHanh
                    {
                        ChiTietHoaDonBanID = idChiTietHDBan,
                        SoIMEI = txtIMEI_HienThi.Text,
                        LoiKhachBao = txtTinhTrangMay.Text,
                        TrangThai = cboTrangThai.Text,
                        NgayTraDuKien = datNgayTraDuKien.Value,
                        LoiDoKhach = cboLoaiBaoHanh.Text == "Sửa chữa có phí",
                        ChiPhi = numChiPhi.Value
                    };
                    context.BaoHanh.Add(bh);
                }
                else
                {
                    var bh = context.BaoHanh.Find(maDangChon);
                    if (bh != null)
                    {
                        bh.LoiKhachBao = txtTinhTrangMay.Text;
                        bh.KetQuaXuLy = txtKetQuaXuLy.Text;
                        bh.TrangThai = cboTrangThai.Text;
                        bh.NgayTraDuKien = datNgayTraDuKien.Value;
                        bh.LoiDoKhach = cboLoaiBaoHanh.Text == "Sửa chữa có phí";
                        bh.ChiPhi = numChiPhi.Value;
                        if (bh.TrangThai == "Đã trả máy") bh.NgayTraThucTe = DateTime.Now;
                    }
                }
                context.SaveChanges();
                MessageBox.Show("Đã lưu thông tin bảo hành thành công!");
              
                txtTimKiem.Text = ""; 
                XoaTrangThongTin();   
                LoadDataBaoHanh("");  

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi dữ liệu: " + ex.Message);
            }
        }

        private void picHuyBo_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = ""; 
            XoaTrangThongTin();   
            LoadDataBaoHanh("");
        }

        private void picXoa_Click(object sender, EventArgs e)
        {
            if (dgvBaoHanh.CurrentRow == null) return;
            if (MessageBox.Show("Xóa phiếu bảo hành này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int? idXoa = (int)dgvBaoHanh.CurrentRow.Cells["colID"].Value;
                var bh = context.BaoHanh.Find(idXoa);
                if (bh != null) context.BaoHanh.Remove(bh);
                context.SaveChanges();
                LoadDataBaoHanh();
            }
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();


            LoadDataBaoHanh(tuKhoa);

            // Tìm thông tin chi tiết để điền lên các ô TextBox
            if (!string.IsNullOrEmpty(tuKhoa))
            {

                var danhSachMay = context.ChiTietHoaDonBan
                            .Include(ct => ct.PhienBanSanPham).ThenInclude(pb => pb.SanPham)
                            .Include(ct => ct.HoaDonBan).ThenInclude(h => h.KhachHang)
                            .Where(ct => ct.SoIMEI.Trim() == tuKhoa || ct.HoaDonBan.KhachHang.SDT.Contains(tuKhoa))
                            .ToList();

                if (danhSachMay.Count == 1)
                {

                    cboDanhSachIMEI.Visible = false;


                    if (danhSachMay[0].TrangThai == "Đã trả hàng")
                    {
                        MessageBox.Show("Máy này đã bị trả lại!"); return;
                    }

                    HienThiThongTinMay(danhSachMay[0]);
                }
                else if (danhSachMay.Count > 1)
                {
                    // Nếu mua nhiều máy -> Hiện cbo nhân viên chọn
                    cboDanhSachIMEI.Visible = true;

                    // Tạo một danh sách ảo kết hợp Tên máy và IMEI 
                    var dataSource = danhSachMay
                        .Where(m => m.TrangThai != "Đã trả hàng")
                        .Select(m => new
                        {
                            ID = m.ID,
                            HienThi = m.PhienBanSanPham.SanPham.TenSP + " (IMEI: " + m.SoIMEI + ")"
                        }).ToList();

                    cboDanhSachIMEI.DataSource = dataSource;
                    cboDanhSachIMEI.DisplayMember = "HienThi";
                    cboDanhSachIMEI.ValueMember = "ID";

                }
                else
                {
                   
                    cboDanhSachIMEI.Visible = false;
                    XoaTrangThongTin();
                }
            }
        }


        //xem thong tin 1 dòng
        private void dgvBaoHanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idBaoHanh = Convert.ToInt32(
    dgvBaoHanh.Rows[e.RowIndex].Cells[0].Value);

                var phieuBH = context.BaoHanh
                    .Include(x => x.ChiTietHoaDonBan).ThenInclude(ct => ct.PhienBanSanPham).ThenInclude(pb => pb.SanPham)
                    .Include(x => x.ChiTietHoaDonBan).ThenInclude(ct => ct.HoaDonBan).ThenInclude(hd => hd.KhachHang)
                    .FirstOrDefault(x => x.ID == idBaoHanh);

                if (phieuBH != null)
                {
                    txtIMEI_HienThi.Text = phieuBH.ChiTietHoaDonBan.SoIMEI;
                    txtTenSanPham.Text = phieuBH.ChiTietHoaDonBan.PhienBanSanPham.SanPham.TenSP;
                    txtTenKhachHang.Text = phieuBH.ChiTietHoaDonBan.HoaDonBan.KhachHang.HoTen;
                    txtSoDienThoai.Text = phieuBH.ChiTietHoaDonBan.HoaDonBan.KhachHang.SDT;

                    datNgayMua.Value = phieuBH.ChiTietHoaDonBan.HoaDonBan.NgayBan;


                    datNgayHetHan.Value = phieuBH.ChiTietHoaDonBan.NgayHetHan;


                    txtTinhTrangMay.Text = phieuBH.LoiKhachBao;
                    txtKetQuaXuLy.Text = phieuBH.KetQuaXuLy;
                    cboLoaiBaoHanh.Text = phieuBH.LoiDoKhach ? "Sửa chữa có phí" : "Bảo hành";
                    numChiPhi.Value = phieuBH.ChiPhi;
                    cboTrangThai.Text = phieuBH.TrangThai;
                    datNgayTraDuKien.Value = (DateTime)phieuBH.NgayTraDuKien;
                }
            }
        }


        private void cboLoaiBaoHanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nếu chọn Sửa Chữa Tính Phí thì nhập tiền
            if (cboLoaiBaoHanh.SelectedIndex == 1)
            {
                numChiPhi.Enabled = true;
                numChiPhi.Focus();
            }
            else
            {
                numChiPhi.Value = 0;
                numChiPhi.Enabled = false;
            }
        }

      


        private void dgvBaoHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy ID của phiếu bảo hành 
                int idBaoHanh = Convert.ToInt32(dgvBaoHanh.Rows[e.RowIndex].Cells["colID"].Value);

                // Truy vấn lại Database để lấy thông tin
                var phieuBH = context.BaoHanh
                    .Include(x => x.ChiTietHoaDonBan).ThenInclude(ct => ct.PhienBanSanPham).ThenInclude(pb => pb.SanPham)
                    .Include(x => x.ChiTietHoaDonBan).ThenInclude(ct => ct.HoaDonBan).ThenInclude(hd => hd.KhachHang)
                    .FirstOrDefault(x => x.ID == idBaoHanh);

                if (phieuBH != null)
                {
                    
                    txtIMEI_HienThi.Text = phieuBH.ChiTietHoaDonBan.SoIMEI; 
                    txtTenSanPham.Text = phieuBH.ChiTietHoaDonBan.PhienBanSanPham.SanPham.TenSP;

                    
                    DateTime ngayMua = phieuBH.ChiTietHoaDonBan.HoaDonBan.NgayBan;
                    datNgayMua.Value = ngayMua;

                   
                    datNgayHetHan.Value = ngayMua.AddMonths(12);
                }
            }
        }

        private void cboDanhSachIMEI_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDanhSachIMEI.SelectedValue != null && cboDanhSachIMEI.SelectedValue is int)
            {
                int idMayChon = (int)cboDanhSachIMEI.SelectedValue;

                // Truy vấn lại máy nhân viên chọn
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

     
    }

}
