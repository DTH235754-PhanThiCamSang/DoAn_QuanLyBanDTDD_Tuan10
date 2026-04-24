namespace QuanLyBanDTDD.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            mnuAdmin = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuNhaCungCap = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            mnuBaoCaoThongKe = new ToolStripMenuItem();
            mnuThongKeDoanhThu = new ToolStripMenuItem();
            mnuThongKeSanPham = new ToolStripMenuItem();
            mnuHauMai = new ToolStripMenuItem();
            mnuSuaChua_BaoHanh = new ToolStripMenuItem();
            mnuDoiTra = new ToolStripMenuItem();
            mnuHoaDonBan = new ToolStripMenuItem();
            mnuHoaDonMua = new ToolStripMenuItem();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHuongDanSuDung = new ToolStripMenuItem();
            mnuThongTinPhanMem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 1021);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(2, 0, 23, 0);
            statusStrip1.Size = new Size(1924, 34);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Calibri", 13.8F);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(165, 28);
            lblTrangThai.Text = "Đăng nhập bởi...";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Font = new Font("Calibri", 13.8F);
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(1734, 28);
            toolStripStatusLabel2.Spring = true;
            // 
            // mnuAdmin
            // 
            mnuAdmin.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLy, mnuBaoCaoThongKe, mnuHauMai });
            mnuAdmin.Name = "mnuAdmin";
            mnuAdmin.Size = new Size(86, 32);
            mnuAdmin.Text = "&Admin";
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuKhachHang, mnuNhaCungCap, toolStripMenuItem1, mnuNhanVien, mnuSanPham });
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(277, 32);
            mnuQuanLy.Text = "&Quản lý";
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(277, 32);
            mnuNhanVien.Text = "&Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(277, 32);
            mnuKhachHang.Text = "&Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(274, 6);
            // 
            // mnuNhaCungCap
            // 
            mnuNhaCungCap.Name = "mnuNhaCungCap";
            mnuNhaCungCap.Size = new Size(277, 32);
            mnuNhaCungCap.Text = "&Nhà cung cấp(NCC)";
            mnuNhaCungCap.Click += mnuNhaCungCap_Click;
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(277, 32);
            mnuSanPham.Text = "&Sản phẩm";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // mnuBaoCaoThongKe
            // 
            mnuBaoCaoThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKeDoanhThu, mnuThongKeSanPham });
            mnuBaoCaoThongKe.Name = "mnuBaoCaoThongKe";
            mnuBaoCaoThongKe.Size = new Size(277, 32);
            mnuBaoCaoThongKe.Text = "&Thống Kê - Báo Cáo";
            // 
            // mnuThongKeDoanhThu
            // 
            mnuThongKeDoanhThu.Name = "mnuThongKeDoanhThu";
            mnuThongKeDoanhThu.Size = new Size(290, 32);
            mnuThongKeDoanhThu.Text = "&Thống Kê Doanh Thu";
            mnuThongKeDoanhThu.Click += mnuThongKeDoanhThu_Click;
            // 
            // mnuThongKeSanPham
            // 
            mnuThongKeSanPham.Name = "mnuThongKeSanPham";
            mnuThongKeSanPham.Size = new Size(290, 32);
            mnuThongKeSanPham.Text = "&Thống Kê Sản Phẩm";
            mnuThongKeSanPham.Click += mnuThongKeSanPham_Click;
            // 
            // mnuHauMai
            // 
            mnuHauMai.DropDownItems.AddRange(new ToolStripItem[] { mnuSuaChua_BaoHanh, mnuDoiTra });
            mnuHauMai.Name = "mnuHauMai";
            mnuHauMai.Size = new Size(277, 32);
            mnuHauMai.Text = "&Hậu Mãi";
            // 
            // mnuSuaChua_BaoHanh
            // 
            mnuSuaChua_BaoHanh.Name = "mnuSuaChua_BaoHanh";
            mnuSuaChua_BaoHanh.Size = new Size(295, 32);
            mnuSuaChua_BaoHanh.Text = "Sửa Chữa - Bảo Hành";
            mnuSuaChua_BaoHanh.Click += mnuSuaChua_BaoHanh_Click;
            // 
            // mnuDoiTra
            // 
            mnuDoiTra.Name = "mnuDoiTra";
            mnuDoiTra.Size = new Size(295, 32);
            mnuDoiTra.Text = "&Đổi Trả";
            mnuDoiTra.Click += mnuDoiTra_Click;
            // 
            // mnuHoaDonBan
            // 
            mnuHoaDonBan.Name = "mnuHoaDonBan";
            mnuHoaDonBan.Size = new Size(148, 32);
            mnuHoaDonBan.Text = "&Hóa Đơn Bán";
            mnuHoaDonBan.Click += mnuHoaDonBan_Click;
            // 
            // mnuHoaDonMua
            // 
            mnuHoaDonMua.Name = "mnuHoaDonMua";
            mnuHoaDonMua.Size = new Size(155, 32);
            mnuHoaDonMua.Text = "&Hóa Đơn Mua";
            mnuHoaDonMua.Click += mnuHoaDonMua_Click;
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangXuat });
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(111, 32);
            mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(224, 32);
            mnuDangXuat.Text = "&Đăng xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Calibri", 13.8F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuAdmin, mnuHoaDonBan, mnuHoaDonMua, mnuHeThong, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(1924, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHuongDanSuDung, mnuThongTinPhanMem });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(102, 32);
            mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuHuongDanSuDung
            // 
            mnuHuongDanSuDung.Name = "mnuHuongDanSuDung";
            mnuHuongDanSuDung.Size = new Size(290, 32);
            mnuHuongDanSuDung.Text = "&Hướng dẫn sử dụng";
            // 
            // mnuThongTinPhanMem
            // 
            mnuThongTinPhanMem.Name = "mnuThongTinPhanMem";
            mnuThongTinPhanMem.Size = new Size(290, 32);
            mnuThongTinPhanMem.Text = "&Thông tin phần mềm";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Cửa Hàng Bán Điện Thoại Di Động";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripMenuItem mnuAdmin;
        private ToolStripMenuItem mnuHoaDonBan;
        private ToolStripMenuItem mnuHoaDonMua;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripMenuItem mnuHeThong;
        //private ToolStripMenuItem mnuDangXuat;
        //private ToolStripMenuItem mnuDoiMatKhau;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuNhaCungCap;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuBaoCaoThongKe;
        private ToolStripMenuItem mnuThongKeDoanhThu;
        private ToolStripMenuItem mnuHuongDanSuDung;
        private ToolStripMenuItem mnuThongTinPhanMem;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuHauMai;
        private ToolStripMenuItem mnuSuaChua_BaoHanh;
        private ToolStripMenuItem mnuDoiTra;
        private ToolStripMenuItem mnuThongKeSanPham;
    }
}