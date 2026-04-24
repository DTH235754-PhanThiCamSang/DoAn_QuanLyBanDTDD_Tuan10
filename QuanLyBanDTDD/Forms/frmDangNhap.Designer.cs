namespace QuanLyBanDTDD.Forms
{
    partial class frmDangNhap
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            label1 = new Label();
            txtTenDangNhap = new TextBox();
            picThoat = new PictureBox();
            linkQuenMatKhau = new LinkLabel();
            label2 = new Label();
            txtMatKhau = new TextBox();
            label3 = new Label();
            picDangNhap = new PictureBox();
            picMat = new PictureBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDangNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMat).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label1.Location = new Point(5, 188);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Calibri", 13.8F);
            txtTenDangNhap.Location = new Point(209, 176);
            txtTenDangNhap.Multiline = true;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(262, 47);
            txtTenDangNhap.TabIndex = 0;
            // 
            // picThoat
            // 
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(355, 324);
            picThoat.Name = "picThoat";
            picThoat.Size = new Size(110, 54);
            picThoat.SizeMode = PictureBoxSizeMode.Zoom;
            picThoat.TabIndex = 2;
            picThoat.TabStop = false;
            toolTip1.SetToolTip(picThoat, "Thoát phần mềm");
            picThoat.Click += picThoat_Click;
            // 
            // linkQuenMatKhau
            // 
            linkQuenMatKhau.AutoSize = true;
            linkQuenMatKhau.Font = new Font("Calibri", 13.8F);
            linkQuenMatKhau.Location = new Point(304, 284);
            linkQuenMatKhau.Name = "linkQuenMatKhau";
            linkQuenMatKhau.Size = new Size(167, 28);
            linkQuenMatKhau.TabIndex = 3;
            linkQuenMatKhau.TabStop = true;
            linkQuenMatKhau.Text = "Quên Mật khẩu?";
            linkQuenMatKhau.LinkClicked += linkQuenMatKhau_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label2.Location = new Point(5, 253);
            label2.Name = "label2";
            label2.Size = new Size(136, 35);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Calibri", 13.8F);
            txtMatKhau.Location = new Point(209, 241);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(262, 40);
            txtMatKhau.TabIndex = 1;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            label3.Location = new Point(178, 120);
            label3.Name = "label3";
            label3.Size = new Size(159, 35);
            label3.TabIndex = 0;
            label3.Text = "ĐĂNG NHẬP";
            label3.Click += label3_Click;
            // 
            // picDangNhap
            // 
            picDangNhap.Image = Properties.Resources.login;
            picDangNhap.Location = new Point(29, 326);
            picDangNhap.Name = "picDangNhap";
            picDangNhap.Size = new Size(110, 54);
            picDangNhap.SizeMode = PictureBoxSizeMode.Zoom;
            picDangNhap.TabIndex = 2;
            picDangNhap.TabStop = false;
            toolTip1.SetToolTip(picDangNhap, "Đăng nhập vào phần mềm");
            picDangNhap.Click += picDangNhap_Click;
            // 
            // picMat
            // 
            picMat.BackColor = Color.White;
            picMat.Image = Properties.Resources.hide;
            picMat.Location = new Point(419, 240);
            picMat.Name = "picMat";
            picMat.Size = new Size(52, 41);
            picMat.SizeMode = PictureBoxSizeMode.Zoom;
            picMat.TabIndex = 2;
            picMat.TabStop = false;
            toolTip1.SetToolTip(picMat, "Click để mở / ẩn mật khẩu");
            picMat.Click += picMat_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(0, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(494, 118);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(494, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(493, 491);
            Controls.Add(groupBox1);
            Controls.Add(picMat);
            Controls.Add(linkQuenMatKhau);
            Controls.Add(picDangNhap);
            Controls.Add(picThoat);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(txtTenDangNhap);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập";
            Load += frmDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDangNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMat).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTenDangNhap;
        private PictureBox picThoat;
        private LinkLabel linkQuenMatKhau;
        private Label label2;
        private TextBox txtMatKhau;
        private Label label3;
        private PictureBox picDangNhap;
        private PictureBox picMat;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
    }
}