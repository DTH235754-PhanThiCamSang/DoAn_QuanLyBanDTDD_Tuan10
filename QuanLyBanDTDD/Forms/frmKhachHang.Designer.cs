namespace QuanLyBanDTDD.Forms
{
    partial class frmKhachHang
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
            label8 = new Label();
            label4 = new Label();
            label7 = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            picXuatDuLieu = new PictureBox();
            picNhapDuLieu = new PictureBox();
            picThoát = new PictureBox();
            picHuyBo = new PictureBox();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            txtID = new TextBox();
            groupBox = new GroupBox();
            picLuu = new PictureBox();
            picXoa = new PictureBox();
            picSua = new PictureBox();
            picThem = new PictureBox();
            groupBox2 = new GroupBox();
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            textBox2 = new TextBox();
            dgvKhachHang = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            toolTip1 = new ToolTip(components);
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXuatDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNhapDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThoát).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLuu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThem).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(17, 247);
            label8.Name = "label8";
            label8.Size = new Size(74, 24);
            label8.TabIndex = 2;
            label8.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(17, 294);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(17, 195);
            label7.Name = "label7";
            label7.Size = new Size(68, 24);
            label7.TabIndex = 2;
            label7.Text = "SĐT(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(17, 140);
            label2.Name = "label2";
            label2.Size = new Size(119, 24);
            label2.TabIndex = 2;
            label2.Text = "Họ Và Tên(*):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(112, 23);
            label11.Name = "label11";
            label11.Size = new Size(293, 37);
            label11.TabIndex = 2;
            label11.Text = "Thông Tin Khách Hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(17, 95);
            label1.Name = "label1";
            label1.Size = new Size(32, 24);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(picXuatDuLieu);
            groupBox3.Controls.Add(picNhapDuLieu);
            groupBox3.Controls.Add(picThoát);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(txtDiaChi);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(txtHoTen);
            groupBox3.Controls.Add(txtID);
            groupBox3.Location = new Point(828, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 586);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // picXuatDuLieu
            // 
            picXuatDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picXuatDuLieu.Cursor = Cursors.Hand;
            picXuatDuLieu.Image = Properties.Resources.output;
            picXuatDuLieu.Location = new Point(251, 479);
            picXuatDuLieu.Name = "picXuatDuLieu";
            picXuatDuLieu.Size = new Size(100, 71);
            picXuatDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picXuatDuLieu.TabIndex = 12;
            picXuatDuLieu.TabStop = false;
            toolTip1.SetToolTip(picXuatDuLieu, "Xuất dữ liệu ra...");
            picXuatDuLieu.Click += picXuatDuLieu_Click;
            // 
            // picNhapDuLieu
            // 
            picNhapDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picNhapDuLieu.Cursor = Cursors.Hand;
            picNhapDuLieu.Image = Properties.Resources.input;
            picNhapDuLieu.Location = new Point(129, 479);
            picNhapDuLieu.Name = "picNhapDuLieu";
            picNhapDuLieu.Size = new Size(100, 71);
            picNhapDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picNhapDuLieu.TabIndex = 13;
            picNhapDuLieu.TabStop = false;
            toolTip1.SetToolTip(picNhapDuLieu, "Nhập dữ liệu vào...");
            picNhapDuLieu.Click += picNhapDuLieu_Click;
            // 
            // picThoát
            // 
            picThoát.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picThoát.Cursor = Cursors.Hand;
            picThoát.Image = Properties.Resources.close;
            picThoát.Location = new Point(357, 479);
            picThoát.Name = "picThoát";
            picThoát.Size = new Size(100, 71);
            picThoát.SizeMode = PictureBoxSizeMode.Zoom;
            picThoát.TabIndex = 11;
            picThoát.TabStop = false;
            toolTip1.SetToolTip(picThoát, "Thoát Form");
            picThoát.Click += picThoát_Click;
            // 
            // picHuyBo
            // 
            picHuyBo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picHuyBo.Cursor = Cursors.Hand;
            picHuyBo.Image = Properties.Resources.cancel;
            picHuyBo.Location = new Point(9, 479);
            picHuyBo.Name = "picHuyBo";
            picHuyBo.Size = new Size(100, 71);
            picHuyBo.SizeMode = PictureBoxSizeMode.Zoom;
            picHuyBo.TabIndex = 10;
            picHuyBo.TabStop = false;
            toolTip1.SetToolTip(picHuyBo, "Hủy mọi thao tác đang làm...");
            picHuyBo.Click += picHuyBo_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Calibri", 12F);
            txtEmail.Location = new Point(145, 294);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 32);
            txtEmail.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Calibri", 12F);
            txtDiaChi.Location = new Point(145, 240);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(268, 32);
            txtDiaChi.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Calibri", 12F);
            txtSDT.Location = new Point(145, 192);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(268, 32);
            txtSDT.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Calibri", 12F);
            txtHoTen.Location = new Point(145, 143);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(268, 32);
            txtHoTen.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Calibri", 12F);
            txtID.Location = new Point(145, 95);
            txtID.Name = "txtID";
            txtID.Size = new Size(268, 32);
            txtID.TabIndex = 0;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.BackColor = Color.DeepSkyBlue;
            groupBox.Controls.Add(picLuu);
            groupBox.Controls.Add(picXoa);
            groupBox.Controls.Add(picSua);
            groupBox.Controls.Add(picThem);
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(826, 151);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            // 
            // picLuu
            // 
            picLuu.Cursor = Cursors.Hand;
            picLuu.Image = Properties.Resources.save;
            picLuu.Location = new Point(557, 35);
            picLuu.Name = "picLuu";
            picLuu.Size = new Size(100, 71);
            picLuu.SizeMode = PictureBoxSizeMode.Zoom;
            picLuu.TabIndex = 0;
            picLuu.TabStop = false;
            toolTip1.SetToolTip(picLuu, "Lưu khách hàng");
            picLuu.Click += picLuu_Click;
            // 
            // picXoa
            // 
            picXoa.Cursor = Cursors.Hand;
            picXoa.Image = Properties.Resources.delete;
            picXoa.Location = new Point(382, 35);
            picXoa.Name = "picXoa";
            picXoa.Size = new Size(100, 71);
            picXoa.SizeMode = PictureBoxSizeMode.Zoom;
            picXoa.TabIndex = 0;
            picXoa.TabStop = false;
            toolTip1.SetToolTip(picXoa, "Xóa khách hàng");
            picXoa.Click += picXoa_Click;
            // 
            // picSua
            // 
            picSua.Cursor = Cursors.Hand;
            picSua.Image = Properties.Resources.edit;
            picSua.Location = new Point(214, 35);
            picSua.Name = "picSua";
            picSua.Size = new Size(100, 71);
            picSua.SizeMode = PictureBoxSizeMode.Zoom;
            picSua.TabIndex = 0;
            picSua.TabStop = false;
            toolTip1.SetToolTip(picSua, "Sửa khách hàng");
            picSua.Click += picSua_Click;
            // 
            // picThem
            // 
            picThem.Cursor = Cursors.Hand;
            picThem.Image = Properties.Resources.add;
            picThem.Location = new Point(49, 35);
            picThem.Name = "picThem";
            picThem.Size = new Size(100, 71);
            picThem.SizeMode = PictureBoxSizeMode.Zoom;
            picThem.TabIndex = 0;
            picThem.TabStop = false;
            toolTip1.SetToolTip(picThem, "Thêm khách hàng");
            picThem.Click += picThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.BackColor = Color.DeepSkyBlue;
            groupBox2.Controls.Add(picTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(826, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 151);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(383, 33);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(76, 34);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 23;
            picTimKiem.TabStop = false;
            toolTip1.SetToolTip(picTimKiem, "Tìm kiếm");
            // 
            // txtTimKiem
            // 
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(6, 33);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên hoặc SĐT đề tìm kiếm...";
            txtTimKiem.Size = new Size(453, 32);
            txtTimKiem.TabIndex = 24;
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(607, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AllowUserToDeleteRows = false;
            dgvKhachHang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Columns.AddRange(new DataGridViewColumn[] { colID, colHoTen, colSDT, colDiaChi, colEmail });
            dgvKhachHang.Location = new Point(0, 153);
            dgvKhachHang.MultiSelect = false;
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.RowTemplate.Height = 35;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(826, 588);
            dgvKhachHang.TabIndex = 5;
            // 
            // colID
            // 
            colID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 90;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ Và Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SDT";
            colSDT.HeaderText = "Số Điện Thoại";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 742);
            Controls.Add(groupBox3);
            Controls.Add(groupBox);
            Controls.Add(groupBox2);
            Controls.Add(dgvKhachHang);
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách Hàng";
            Load += frmKhachHang_Load;
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picXuatDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNhapDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThoát).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).EndInit();
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLuu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThem).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label2;
        private Label label11;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private TextBox txtID;
        private GroupBox groupBox;
        private PictureBox picXoa;
        private PictureBox picSua;
        private PictureBox picThem;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private DataGridView dgvKhachHang;
        private PictureBox picLuu;
        private PictureBox picTimKiem;
        private TextBox txtTimKiem;
        private PictureBox picXuatDuLieu;
        private PictureBox picNhapDuLieu;
        private PictureBox picThoát;
        private PictureBox picHuyBo;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colEmail;
    }
}