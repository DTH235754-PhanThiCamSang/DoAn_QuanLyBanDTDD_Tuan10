namespace QuanLyBanDTDD.Forms
{
    partial class frmNhaCungCap
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
            dgvNhaCungCap = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenNCC = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            datTimKiem = new DateTimePicker();
            label6 = new Label();
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            picXoa = new PictureBox();
            picSua = new PictureBox();
            picThem = new PictureBox();
            picLuu = new PictureBox();
            groupBox = new GroupBox();
            label8 = new Label();
            txtEmail = new TextBox();
            txtDiaChi = new TextBox();
            txtID = new TextBox();
            groupBox3 = new GroupBox();
            picXuatDuLieu = new PictureBox();
            picNhapDuLieu = new PictureBox();
            picThoat = new PictureBox();
            picHuyBo = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            txtGhiChu = new TextBox();
            txtSDT = new TextBox();
            txtTenNCC = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).BeginInit();
            groupBox.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXuatDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNhapDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).BeginInit();
            SuspendLayout();
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.AllowUserToDeleteRows = false;
            dgvNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Columns.AddRange(new DataGridViewColumn[] { colID, colTenNCC, colSDT, colDiaChi, colEmail, colGhiChu });
            dgvNhaCungCap.Location = new Point(0, 155);
            dgvNhaCungCap.MultiSelect = false;
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.RowHeadersWidth = 51;
            dgvNhaCungCap.RowTemplate.Height = 35;
            dgvNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhaCungCap.Size = new Size(826, 588);
            dgvNhaCungCap.TabIndex = 9;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenNCC
            // 
            colTenNCC.DataPropertyName = "TenNhaCungCap";
            colTenNCC.HeaderText = "Tên NCC";
            colTenNCC.MinimumWidth = 6;
            colTenNCC.Name = "colTenNCC";
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SoDienThoai";
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
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi Chú";
            colGhiChu.MinimumWidth = 6;
            colGhiChu.Name = "colGhiChu";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(607, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.BackColor = Color.DeepSkyBlue;
            groupBox2.Controls.Add(datTimKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(picTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(826, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 151);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // datTimKiem
            // 
            datTimKiem.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datTimKiem.Font = new Font("Calibri", 12F);
            datTimKiem.Format = DateTimePickerFormat.Short;
            datTimKiem.Location = new Point(253, 107);
            datTimKiem.Name = "datTimKiem";
            datTimKiem.ShowCheckBox = true;
            datTimKiem.Size = new Size(206, 32);
            datTimKiem.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(6, 109);
            label6.Name = "label6";
            label6.Size = new Size(241, 24);
            label6.TabIndex = 21;
            label6.Text = "Tìm Theo Ngày/Tháng/Năm";
            // 
            // picTimKiem
            // 
            picTimKiem.Cursor = Cursors.Hand;
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(359, 35);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(81, 51);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 0;
            picTimKiem.TabStop = false;
            toolTip1.SetToolTip(picTimKiem, "Tìm kiếm");
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Calibri", 12F);
            txtTimKiem.Location = new Point(6, 35);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên hoặc SĐT đề tìm kiếm...";
            txtTimKiem.Size = new Size(434, 51);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // picXoa
            // 
            picXoa.Cursor = Cursors.Hand;
            picXoa.Image = Properties.Resources.delete;
            picXoa.Location = new Point(440, 35);
            picXoa.Name = "picXoa";
            picXoa.Size = new Size(100, 71);
            picXoa.SizeMode = PictureBoxSizeMode.Zoom;
            picXoa.TabIndex = 0;
            picXoa.TabStop = false;
            toolTip1.SetToolTip(picXoa, "Xóa nhà cung cấp");
            picXoa.Click += PicXoa_Click;
            // 
            // picSua
            // 
            picSua.Cursor = Cursors.Hand;
            picSua.Image = Properties.Resources.edit;
            picSua.Location = new Point(234, 35);
            picSua.Name = "picSua";
            picSua.Size = new Size(100, 71);
            picSua.SizeMode = PictureBoxSizeMode.Zoom;
            picSua.TabIndex = 0;
            picSua.TabStop = false;
            toolTip1.SetToolTip(picSua, "Sửa nhà cung cấp");
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
            toolTip1.SetToolTip(picThem, "Thêm nhà cung cấp");
            picThem.Click += picThem_Click;
            // 
            // picLuu
            // 
            picLuu.Cursor = Cursors.Hand;
            picLuu.Image = Properties.Resources.save;
            picLuu.Location = new Point(615, 35);
            picLuu.Name = "picLuu";
            picLuu.Size = new Size(100, 71);
            picLuu.SizeMode = PictureBoxSizeMode.Zoom;
            picLuu.TabIndex = 0;
            picLuu.TabStop = false;
            toolTip1.SetToolTip(picLuu, "Lưu nhà cung cấp");
            picLuu.Click += picLuu_Click;
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
            groupBox.TabIndex = 7;
            groupBox.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F);
            label8.Location = new Point(17, 247);
            label8.Name = "label8";
            label8.Size = new Size(68, 24);
            label8.TabIndex = 2;
            label8.Text = "Địa Chỉ:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial Narrow", 12F);
            txtEmail.Location = new Point(112, 294);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(297, 30);
            txtEmail.TabIndex = 0;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Arial Narrow", 12F);
            txtDiaChi.Location = new Point(112, 240);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(297, 30);
            txtDiaChi.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial Narrow", 12F);
            txtID.Location = new Point(112, 95);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(297, 30);
            txtID.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(picXuatDuLieu);
            groupBox3.Controls.Add(picNhapDuLieu);
            groupBox3.Controls.Add(picThoat);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtGhiChu);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(txtDiaChi);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(txtTenNCC);
            groupBox3.Controls.Add(txtID);
            groupBox3.Location = new Point(828, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 586);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // picXuatDuLieu
            // 
            picXuatDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picXuatDuLieu.Cursor = Cursors.Hand;
            picXuatDuLieu.Image = Properties.Resources.output;
            picXuatDuLieu.Location = new Point(256, 504);
            picXuatDuLieu.Name = "picXuatDuLieu";
            picXuatDuLieu.Size = new Size(100, 71);
            picXuatDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picXuatDuLieu.TabIndex = 8;
            picXuatDuLieu.TabStop = false;
            toolTip1.SetToolTip(picXuatDuLieu, "Xuất dữ liệu ra...");
            picXuatDuLieu.Click += picXuatDuLieu_Click;
            // 
            // picNhapDuLieu
            // 
            picNhapDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picNhapDuLieu.Cursor = Cursors.Hand;
            picNhapDuLieu.Image = Properties.Resources.input;
            picNhapDuLieu.Location = new Point(134, 504);
            picNhapDuLieu.Name = "picNhapDuLieu";
            picNhapDuLieu.Size = new Size(100, 71);
            picNhapDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picNhapDuLieu.TabIndex = 9;
            picNhapDuLieu.TabStop = false;
            toolTip1.SetToolTip(picNhapDuLieu, "Nhập dữ liệu vào...");
            picNhapDuLieu.Click += picNhapDuLieu_Click;
            // 
            // picThoat
            // 
            picThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(362, 504);
            picThoat.Name = "picThoat";
            picThoat.Size = new Size(100, 71);
            picThoat.SizeMode = PictureBoxSizeMode.Zoom;
            picThoat.TabIndex = 7;
            picThoat.TabStop = false;
            toolTip1.SetToolTip(picThoat, "Thoát Form");
            picThoat.Click += picThoat_Click;
            // 
            // picHuyBo
            // 
            picHuyBo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picHuyBo.Cursor = Cursors.Hand;
            picHuyBo.Image = Properties.Resources.cancel;
            picHuyBo.Location = new Point(14, 504);
            picHuyBo.Name = "picHuyBo";
            picHuyBo.Size = new Size(100, 71);
            picHuyBo.SizeMode = PictureBoxSizeMode.Zoom;
            picHuyBo.TabIndex = 6;
            picHuyBo.TabStop = false;
            toolTip1.SetToolTip(picHuyBo, "Hủy mọi thao tác đang làm...");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(17, 349);
            label3.Name = "label3";
            label3.Size = new Size(75, 24);
            label3.TabIndex = 2;
            label3.Text = "Ghi Chú:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.Location = new Point(17, 294);
            label4.Name = "label4";
            label4.Size = new Size(56, 24);
            label4.TabIndex = 2;
            label4.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F);
            label7.Location = new Point(17, 195);
            label7.Name = "label7";
            label7.Size = new Size(48, 24);
            label7.TabIndex = 2;
            label7.Text = "SĐT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.Location = new Point(17, 140);
            label2.Name = "label2";
            label2.Size = new Size(84, 24);
            label2.TabIndex = 2;
            label2.Text = "Tên NCC:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(92, 23);
            label11.Name = "label11";
            label11.Size = new Size(320, 37);
            label11.TabIndex = 2;
            label11.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F);
            label1.Location = new Point(17, 95);
            label1.Name = "label1";
            label1.Size = new Size(32, 24);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Arial Narrow", 12F);
            txtGhiChu.Location = new Point(112, 349);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(297, 121);
            txtGhiChu.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Arial Narrow", 12F);
            txtSDT.Location = new Point(112, 192);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(297, 30);
            txtSDT.TabIndex = 0;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Arial Narrow", 12F);
            txtTenNCC.Location = new Point(112, 143);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(297, 30);
            txtTenNCC.TabIndex = 0;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 742);
            Controls.Add(dgvNhaCungCap);
            Controls.Add(groupBox2);
            Controls.Add(groupBox);
            Controls.Add(groupBox3);
            Name = "frmNhaCungCap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhà Cung Cấp(NCC)";
            Load += frmNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThem).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).EndInit();
            groupBox.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picXuatDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNhapDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNhaCungCap;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox txtTimKiem;
        private PictureBox picTimKiem;
        private PictureBox picXoa;
        private PictureBox picSua;
        private PictureBox picThem;
        private PictureBox picLuu;
        private GroupBox groupBox;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtDiaChi;
        private TextBox txtID;
        private GroupBox groupBox3;
        private Label label4;
        private Label label7;
        private Label label2;
        private Label label11;
        private Label label1;
        private TextBox txtSDT;
        private TextBox txtTenNCC;
        private Label label3;
        private TextBox txtGhiChu;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenNCC;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colGhiChu;
        private PictureBox picXuatDuLieu;
        private PictureBox picNhapDuLieu;
        private PictureBox picThoat;
        private PictureBox picHuyBo;
        private DateTimePicker datTimKiem;
        private Label label6;
        private ToolTip toolTip1;
    }
}