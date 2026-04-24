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
    public partial class frmDangNhap : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext();
        bool anMatKhau = true;
       
        public frmDangNhap()
        {
            InitializeComponent();
            txtTenDangNhap.Focus();
            txtMatKhau.PasswordChar = '*'; 
        }

        private void picDangNhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrWhiteSpace(tenDN) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return;
            }

            try
            {
                // Tìm tài khoản trong Database lấy T.T bang NhanVien ktra trang thái làm việc
                var tk = context.TaiKhoan.Include(x => x.NhanVien).FirstOrDefault(x => x.TenDangNhap == tenDN);

                if (tk != null)
                {
                    // Tài khoản có tồn tại -> Kiểm tra mật khẩu bằng BCrypt
                    bool mkDung = BCrypt.Net.BCrypt.Verify(matKhau, tk.MatKhau);

                    if (mkDung)
                    {
                        // Kiểm tra trạng thái: Nếu đã nghỉ việc thì ko cho đăng nhập
                        if (tk.NhanVien.TrangThai == "Đã nghỉ")
                        {
                            MessageBox.Show("Tài khoản này thuộc về nhân viên đã nghỉ việc. Truy cập bị từ chối!", "Lỗi bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }


                        MessageBox.Show($"Đăng nhập thành công!\nXin chào {tk.NhanVien.HoTen} - Quyền: {tk.QuyenHan}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //
                        frmMain frm = new frmMain(tk.NhanVien.ID, tk.NhanVien.HoTen, tk.QuyenHan);
                        //frmMain đóng thì tự động Close luôn frmDangNhap
                        frm.FormClosed += (s, args) => this.Close();



                        frm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Sai mật khẩu! Vui lòng kiểm tra lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhau.Focus();
                        txtMatKhau.SelectAll(); // Bôi đen sẵn mật khẩu cũ 
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại trong hệ thống!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenDangNhap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát phần mềm?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit(); // Đóng hoàn toàn chương trình
            }
        }

        private void picMat_Click(object sender, EventArgs e)
        {
            // Kiểm tra biến anMatKhau
            if (anMatKhau)
            {
                // --- TRƯỜNG HỢP ĐANG ẨN -> CHUYỂN SANG HIỆN ---

                // 1. Hiện mật khẩu thật (dùng ký tự null '\0')
                txtMatKhau.PasswordChar = '\0';


                picMat.Image = Properties.Resources.show;

                // 3. Cập nhật lại trạng thái cờ
                anMatKhau = false;
            }
            else
            {
                // --- TRƯỜNG HỢP ĐANG HIỆN -> CHUYỂN SANG ẨN ---


                txtMatKhau.PasswordChar = '*';

                // 2. Đổi icon lại thành hình mắt ĐÓNG
                picMat.Image = Properties.Resources.hide;

                // 3. Cập nhật lại trạng thái cờ
                anMatKhau = true;
            }
        }

        private void linkQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();

            // 1. Kiểm tra xem người dùng đã gõ Tên đăng nhập chưa
            if (string.IsNullOrWhiteSpace(tenDN))
            {
                MessageBox.Show("Vui lòng nhập 'Tên đăng nhập' của bạn vào ô trống phía trên, sau đó bấm lại vào 'Quên mật khẩu'!", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenDangNhap.Focus();
                return;
            }

            try
            {
                // 2. Tìm tài khoản trong Database
                var tk = context.TaiKhoan.FirstOrDefault(x => x.TenDangNhap == tenDN);

                if (tk != null)
                {
                    // 3. Nếu tìm thấy nick -> Hỏi xác nhận có muốn Reset không
                    DialogResult rs = MessageBox.Show(
                        $"Hệ thống đã tìm thấy tài khoản '{tenDN}'.\n\nBạn có muốn khôi phục mật khẩu về mặc định là '123456' không?",
                        "Xác nhận khôi phục",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (rs == DialogResult.Yes)
                    {
                        // 4. Tiến hành Reset và băm (Hash) lại mật khẩu mới bằng BCrypt
                        tk.MatKhau = BCrypt.Net.BCrypt.HashPassword("123456");
                        context.SaveChanges(); // Lưu xuống CSDL

                        MessageBox.Show("Khôi phục thành công!\n\nMật khẩu mới của bạn là: 123456\n\nVui lòng đăng nhập và tiến hành đổi mật khẩu sớm nhất có thể để bảo mật.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // điền luôn mật khẩu mới vào ô Mật khẩu 
                        txtMatKhau.Text = "123456";
                        txtMatKhau.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập này không tồn tại trong hệ thống. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra phím 
            if (e.KeyCode == Keys.Enter)
            {
                picDangNhap_Click(sender, e);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }
    }
}