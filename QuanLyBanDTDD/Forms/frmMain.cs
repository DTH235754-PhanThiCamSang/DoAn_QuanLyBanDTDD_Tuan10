using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanDTDD.Reports;

namespace QuanLyBanDTDD.Forms
{
    public partial class frmMain : Form
    {
        // 1. Khai báo 3 biến cấp Form để giữ thông tin
        int idNhanVien;
        string tenNhanVien;
        string quyenHan;
        

        public frmMain(int idNV, string tenNV, string quyen)
        {
            InitializeComponent();
            this.idNhanVien = idNV;
            this.tenNhanVien = tenNV;
            this.quyenHan = quyen;
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            menuStrip1.Cursor = Cursors.Hand;


            // Gọi hàm phân quyền
            PhanQuyen();
        }

        // XỬ LÝ ẨN/HIỆN MENU THEO QUYỀN
        private void PhanQuyen()
        {
            // Mặc định cho hiển thị menu Tài khoản và Trợ giúp 

            if (quyenHan == "Quản lý")
            {
                // Quản lý thì có toàn quyền (Bật sáng tất cả)
                mnuAdmin.Enabled = true;
                mnuHoaDonBan.Enabled = true;
                mnuHoaDonMua.Enabled = true;
                


                lblTrangThai.Text = "Xin chào quản lý: " + tenNhanVien;
            }
           
            else if (quyenHan == "Nhân viên")
            {
                mnuAdmin.Enabled = true;

              
                mnuNhanVien.Enabled = false;
                mnuNhaCungCap.Enabled = false;
                mnuSanPham.Enabled = false;
                mnuBaoCaoThongKe.Enabled = false;
                mnuHauMai.Enabled = false;

               
                mnuKhachHang.Enabled = true;
               
                mnuHoaDonBan.Enabled = true;
                mnuHoaDonMua.Enabled = false;

                lblTrangThai.Text = "Xin chào nhân viên: " + tenNhanVien;
            }
            else if (quyenHan == "Thủ kho")
            {

                mnuAdmin.Enabled = true;


                mnuNhanVien.Enabled = false;
                mnuKhachHang.Enabled = false;
                mnuSanPham.Enabled = false;
                mnuBaoCaoThongKe.Enabled = false;
                mnuHauMai.Enabled = false;


                mnuNhaCungCap.Enabled = true;

                mnuHoaDonBan.Enabled = false;
                mnuHoaDonMua.Enabled = true;




                lblTrangThai.Text = "Xin chào thủ kho: " + tenNhanVien;
            }
        }
        
        // 3. HÀM HỖ TRỢ MỞ FORM CON THÔNG MINH (Không bị mở trùng)
        
        private void MoFormCon(Form frmCon)
        {
            // Bước 1: Quét xem form này đã được mở trước đó chưa
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == frmCon.Name)
                {
                    // Nếu đang mở rồi thì gọi nó ngoi lên trên cùng
                    frm.Activate();
                    return; // Dừng luôn, không mở thêm form mới nữa
                }
            }

            // cài đặt frmMain làm frmcha và hiển thị
            frmCon.MdiParent = this;

            //frmCon.WindowState = FormWindowState.Maximized;
            frmCon.Show();
        }

       
        // Mở form Nhân Viên
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhanVien());
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmKhachHang(this.quyenHan));
        }


        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmNhaCungCap(this.quyenHan));
        }


        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmSanPham());
        }

        // Chức năng Đăng Xuất (Tùy chọn thêm)
        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi tài khoản này?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Khởi động lại toàn bộ phần mềm để quay về form Đăng Nhập nguyên sơ
                Application.Restart();
            }
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmHoaDonBan(this.idNhanVien, this.tenNhanVien));

        }

        private void mnuAdmin_Click(object sender, EventArgs e)
        {


        }

        private void mnuHoaDonMua_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmHoaDonMua(this.idNhanVien, this.tenNhanVien));
        }

     

        
        private void mnuSuaChua_BaoHanh_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmBaoHanh(1));
        }

        private void mnuDoiTra_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmDoiTra());
        }


        private void mnuThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            frmThongKeDoanhThu frm = new frmThongKeDoanhThu();
            frm.ShowDialog();
        }

        private void mnuThongKeSanPham_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmThongKeSanPham());
        }
    }
}

