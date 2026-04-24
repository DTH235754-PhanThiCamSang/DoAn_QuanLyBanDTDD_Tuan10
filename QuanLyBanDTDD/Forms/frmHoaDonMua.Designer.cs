namespace QuanLyBanDTDD.Forms
{
    partial class frmHoaDonMua
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvHoaDonMua = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNgayNhap = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colNhanVienNhap = new DataGridViewTextBoxColumn();
            colTenNhaCungCap = new DataGridViewTextBoxColumn();
            colSanPhamID = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label5 = new Label();
            txtNhanVienNhap = new TextBox();
            groupBox3 = new GroupBox();
            picXuatDuLieu = new PictureBox();
            picNhapDuLieu = new PictureBox();
            picThoat = new PictureBox();
            picHuyBo = new PictureBox();
            cboNhaCungCap = new ComboBox();
            datNgayNhap = new DateTimePicker();
            picThemNCC = new PictureBox();
            label7 = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtGhiChu = new TextBox();
            txtTongTien = new TextBox();
            InHoaDon = new PictureBox();
            picXoa = new PictureBox();
            picSua = new PictureBox();
            picThem = new PictureBox();
            groupBox2 = new GroupBox();
            datTimKiem = new DateTimePicker();
            label6 = new Label();
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            textBox2 = new TextBox();
            picLuu = new PictureBox();
            groupBox = new GroupBox();
            picXem = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonMua).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXuatDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNhapDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThemNCC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThem).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXem).BeginInit();
            SuspendLayout();
            // 
            // dgvHoaDonMua
            // 
            dgvHoaDonMua.AllowUserToAddRows = false;
            dgvHoaDonMua.AllowUserToDeleteRows = false;
            dgvHoaDonMua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoaDonMua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDonMua.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonMua.Columns.AddRange(new DataGridViewColumn[] { colID, colNgayNhap, colTongTien, colNhanVienNhap, colTenNhaCungCap, colSanPhamID, colGhiChu });
            dgvHoaDonMua.Location = new Point(0, 155);
            dgvHoaDonMua.MultiSelect = false;
            dgvHoaDonMua.Name = "dgvHoaDonMua";
            dgvHoaDonMua.RowHeadersWidth = 51;
            dgvHoaDonMua.RowTemplate.Height = 35;
            dgvHoaDonMua.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDonMua.Size = new Size(826, 588);
            dgvHoaDonMua.TabIndex = 9;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 96.25668F;
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colNgayNhap
            // 
            colNgayNhap.DataPropertyName = "NgayNhap";
            colNgayNhap.FillWeight = 100.748665F;
            colNgayNhap.HeaderText = "Ngày Nhập";
            colNgayNhap.MinimumWidth = 6;
            colNgayNhap.Name = "colNgayNhap";
            // 
            // colTongTien
            // 
            colTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,##0";
            colTongTien.DefaultCellStyle = dataGridViewCellStyle1;
            colTongTien.FillWeight = 100.748665F;
            colTongTien.HeaderText = "Tổng Tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            // 
            // colNhanVienNhap
            // 
            colNhanVienNhap.DataPropertyName = "TenNhanVien";
            colNhanVienNhap.FillWeight = 100.748665F;
            colNhanVienNhap.HeaderText = "Nhân Viên Nhập";
            colNhanVienNhap.MinimumWidth = 6;
            colNhanVienNhap.Name = "colNhanVienNhap";
            // 
            // colTenNhaCungCap
            // 
            colTenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            colTenNhaCungCap.FillWeight = 100.748665F;
            colTenNhaCungCap.HeaderText = "Nhà Cung Cấp";
            colTenNhaCungCap.MinimumWidth = 6;
            colTenNhaCungCap.Name = "colTenNhaCungCap";
            // 
            // colSanPhamID
            // 
            colSanPhamID.DataPropertyName = "SanPhamID";
            colSanPhamID.HeaderText = "Sanphamid";
            colSanPhamID.MinimumWidth = 6;
            colSanPhamID.Name = "colSanPhamID";
            colSanPhamID.Visible = false;
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.FillWeight = 100.748665F;
            colGhiChu.HeaderText = "Ghi Chú";
            colGhiChu.MinimumWidth = 6;
            colGhiChu.Name = "colGhiChu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(17, 223);
            label3.Name = "label3";
            label3.Size = new Size(152, 24);
            label3.TabIndex = 15;
            label3.Text = "Nhân Viên Nhập:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(17, 175);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 16;
            label5.Text = "Tổng Tiền:";
            // 
            // txtNhanVienNhap
            // 
            txtNhanVienNhap.Font = new Font("Calibri", 12F);
            txtNhanVienNhap.Location = new Point(173, 220);
            txtNhanVienNhap.Multiline = true;
            txtNhanVienNhap.Name = "txtNhanVienNhap";
            txtNhanVienNhap.ReadOnly = true;
            txtNhanVienNhap.Size = new Size(204, 37);
            txtNhanVienNhap.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(picXuatDuLieu);
            groupBox3.Controls.Add(picNhapDuLieu);
            groupBox3.Controls.Add(picThoat);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(cboNhaCungCap);
            groupBox3.Controls.Add(datNgayNhap);
            groupBox3.Controls.Add(picThemNCC);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtID);
            groupBox3.Controls.Add(txtGhiChu);
            groupBox3.Controls.Add(txtNhanVienNhap);
            groupBox3.Controls.Add(txtTongTien);
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
            picXuatDuLieu.Location = new Point(250, 494);
            picXuatDuLieu.Name = "picXuatDuLieu";
            picXuatDuLieu.Size = new Size(100, 71);
            picXuatDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picXuatDuLieu.TabIndex = 22;
            picXuatDuLieu.TabStop = false;
            toolTip1.SetToolTip(picXuatDuLieu, "Xuất dữ liệu ra...");
            picXuatDuLieu.Click += picXuatDuLieu_Click;
            // 
            // picNhapDuLieu
            // 
            picNhapDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picNhapDuLieu.Cursor = Cursors.Hand;
            picNhapDuLieu.Image = Properties.Resources.input;
            picNhapDuLieu.Location = new Point(128, 494);
            picNhapDuLieu.Name = "picNhapDuLieu";
            picNhapDuLieu.Size = new Size(100, 71);
            picNhapDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picNhapDuLieu.TabIndex = 23;
            picNhapDuLieu.TabStop = false;
            toolTip1.SetToolTip(picNhapDuLieu, "Nhập dữ liệu vào...");
            picNhapDuLieu.Click += picNhapDuLieu_Click;
            // 
            // picThoat
            // 
            picThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(356, 494);
            picThoat.Name = "picThoat";
            picThoat.Size = new Size(100, 71);
            picThoat.SizeMode = PictureBoxSizeMode.Zoom;
            picThoat.TabIndex = 21;
            picThoat.TabStop = false;
            toolTip1.SetToolTip(picThoat, "Thoát Form");
            picThoat.Click += picThoat_Click;
            // 
            // picHuyBo
            // 
            picHuyBo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picHuyBo.Cursor = Cursors.Hand;
            picHuyBo.Image = Properties.Resources.cancel;
            picHuyBo.Location = new Point(8, 494);
            picHuyBo.Name = "picHuyBo";
            picHuyBo.Size = new Size(100, 71);
            picHuyBo.SizeMode = PictureBoxSizeMode.Zoom;
            picHuyBo.TabIndex = 20;
            picHuyBo.TabStop = false;
            toolTip1.SetToolTip(picHuyBo, "Hủy mọi thao tác đang làm...");
            picHuyBo.Click += picHuyBo_Click;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.Font = new Font("Calibri", 12F);
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(173, 266);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(204, 32);
            cboNhaCungCap.TabIndex = 19;
            // 
            // datNgayNhap
            // 
            datNgayNhap.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datNgayNhap.Font = new Font("Calibri", 12F);
            datNgayNhap.Format = DateTimePickerFormat.Short;
            datNgayNhap.Location = new Point(173, 139);
            datNgayNhap.Name = "datNgayNhap";
            datNgayNhap.Size = new Size(204, 32);
            datNgayNhap.TabIndex = 18;
            // 
            // picThemNCC
            // 
            picThemNCC.Cursor = Cursors.Hand;
            picThemNCC.Image = Properties.Resources.add;
            picThemNCC.Location = new Point(386, 266);
            picThemNCC.Name = "picThemNCC";
            picThemNCC.Size = new Size(70, 30);
            picThemNCC.SizeMode = PictureBoxSizeMode.Zoom;
            picThemNCC.TabIndex = 0;
            picThemNCC.TabStop = false;
            toolTip1.SetToolTip(picThemNCC, "Thêm nhà cung cấp");
            picThemNCC.Click += picThemNCC_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(17, 272);
            label7.Name = "label7";
            label7.Size = new Size(133, 24);
            label7.TabIndex = 2;
            label7.Text = "Nhà Cung Cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(17, 144);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 2;
            label2.Text = "Ngày Nhập:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(112, 23);
            label11.Name = "label11";
            label11.Size = new Size(321, 37);
            label11.TabIndex = 2;
            label11.Text = "Thông Tin Hóa Đơn Mua";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(17, 98);
            label1.Name = "label1";
            label1.Size = new Size(32, 24);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(17, 314);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 16;
            label4.Text = "Ghi Chú:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Calibri", 12F);
            txtID.Location = new Point(173, 95);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(204, 37);
            txtID.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Calibri", 12F);
            txtGhiChu.Location = new Point(173, 311);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(204, 126);
            txtGhiChu.TabIndex = 11;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Calibri", 12F);
            txtTongTien.Location = new Point(173, 172);
            txtTongTien.Multiline = true;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(204, 37);
            txtTongTien.TabIndex = 11;
            // 
            // InHoaDon
            // 
            InHoaDon.Cursor = Cursors.Hand;
            InHoaDon.Image = Properties.Resources.print;
            InHoaDon.Location = new Point(689, 26);
            InHoaDon.Name = "InHoaDon";
            InHoaDon.Size = new Size(100, 71);
            InHoaDon.SizeMode = PictureBoxSizeMode.Zoom;
            InHoaDon.TabIndex = 0;
            InHoaDon.TabStop = false;
            toolTip1.SetToolTip(InHoaDon, "In hóa đơn mua");
            InHoaDon.Click += InHoaDon_Click;
            // 
            // picXoa
            // 
            picXoa.Cursor = Cursors.Hand;
            picXoa.Image = Properties.Resources.delete;
            picXoa.Location = new Point(278, 27);
            picXoa.Name = "picXoa";
            picXoa.Size = new Size(100, 71);
            picXoa.SizeMode = PictureBoxSizeMode.Zoom;
            picXoa.TabIndex = 0;
            picXoa.TabStop = false;
            toolTip1.SetToolTip(picXoa, "Xóa hóa đơn mua");
            picXoa.Click += picXoa_Click;
            // 
            // picSua
            // 
            picSua.Cursor = Cursors.Hand;
            picSua.Image = Properties.Resources.edit;
            picSua.Location = new Point(142, 27);
            picSua.Name = "picSua";
            picSua.Size = new Size(100, 71);
            picSua.SizeMode = PictureBoxSizeMode.Zoom;
            picSua.TabIndex = 0;
            picSua.TabStop = false;
            toolTip1.SetToolTip(picSua, "Sửa hóa đơn mua");
            picSua.Click += picSua_Click;
            // 
            // picThem
            // 
            picThem.Cursor = Cursors.Hand;
            picThem.Image = Properties.Resources.add;
            picThem.Location = new Point(10, 26);
            picThem.Name = "picThem";
            picThem.Size = new Size(100, 71);
            picThem.SizeMode = PictureBoxSizeMode.Zoom;
            picThem.TabIndex = 0;
            picThem.TabStop = false;
            toolTip1.SetToolTip(picThem, "Thêm hóa đơn mua");
            picThem.Click += picThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.BackColor = Color.DeepSkyBlue;
            groupBox2.Controls.Add(datTimKiem);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(picTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(826, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 151);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // datTimKiem
            // 
            datTimKiem.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datTimKiem.Font = new Font("Calibri", 12F);
            datTimKiem.Format = DateTimePickerFormat.Short;
            datTimKiem.Location = new Point(252, 88);
            datTimKiem.Name = "datTimKiem";
            datTimKiem.ShowCheckBox = true;
            datTimKiem.Size = new Size(212, 32);
            datTimKiem.TabIndex = 20;
            datTimKiem.ValueChanged += datTimKiem_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(6, 92);
            label6.Name = "label6";
            label6.Size = new Size(241, 24);
            label6.TabIndex = 19;
            label6.Text = "Tìm Theo Ngày/Tháng/Năm";
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(388, 26);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(76, 32);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 2;
            picTimKiem.TabStop = false;
            toolTip1.SetToolTip(picTimKiem, "Tìm kiếm");
            picTimKiem.Click += picTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.Font = new Font("Calibri", 12F);
            txtTimKiem.Location = new Point(6, 26);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên NV hoặc NCC đề tìm kiếm...";
            txtTimKiem.Size = new Size(453, 32);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(607, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // picLuu
            // 
            picLuu.Cursor = Cursors.Hand;
            picLuu.Image = Properties.Resources.save;
            picLuu.Location = new Point(416, 26);
            picLuu.Name = "picLuu";
            picLuu.Size = new Size(100, 71);
            picLuu.SizeMode = PictureBoxSizeMode.Zoom;
            picLuu.TabIndex = 0;
            picLuu.TabStop = false;
            toolTip1.SetToolTip(picLuu, "Lưu hóa đơn mua");
            picLuu.Click += picLuu_Click;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.BackColor = Color.DeepSkyBlue;
            groupBox.Controls.Add(picXem);
            groupBox.Controls.Add(picLuu);
            groupBox.Controls.Add(picXoa);
            groupBox.Controls.Add(picSua);
            groupBox.Controls.Add(picThem);
            groupBox.Controls.Add(InHoaDon);
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(826, 151);
            groupBox.TabIndex = 8;
            groupBox.TabStop = false;
            // 
            // picXem
            // 
            picXem.Cursor = Cursors.Hand;
            picXem.Image = Properties.Resources.view_files;
            picXem.Location = new Point(565, 26);
            picXem.Name = "picXem";
            picXem.Size = new Size(100, 71);
            picXem.SizeMode = PictureBoxSizeMode.Zoom;
            picXem.TabIndex = 0;
            picXem.TabStop = false;
            toolTip1.SetToolTip(picXem, "Xem chi tiết hóa đơn mua");
            picXem.Click += picXem_Click;
            // 
            // frmHoaDonMua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 742);
            Controls.Add(dgvHoaDonMua);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox);
            Name = "frmHoaDonMua";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa Đơn Mua";
            Load += frmHoaDonMua_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonMua).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picXuatDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNhapDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThemNCC).EndInit();
            ((System.ComponentModel.ISupportInitialize)InHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThem).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).EndInit();
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picXem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHoaDonMua;
        private Label label3;
        private Label label5;
        private TextBox txtNhanVienNhap;
        private GroupBox groupBox3;
        private Label label2;
        private Label label11;
        private Label label1;
        private TextBox txtID;
        private TextBox txtTongTien;
        private PictureBox picXoa;
        private PictureBox picSua;
        private PictureBox picThem;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private PictureBox picLuu;
        private GroupBox groupBox;
        private Label label7;
        private Label label4;
        private TextBox txtGhiChu;
        private ComboBox cboNhaCungCap;
        private DateTimePicker datNgayNhap;
        private PictureBox picXem;
        private PictureBox picThemNCC;
        private PictureBox picTimKiem;
        private TextBox txtTimKiem;
        private PictureBox InHoaDon;
        private DateTimePicker datTimKiem;
        private Label label6;
        private PictureBox picXuatDuLieu;
        private PictureBox picNhapDuLieu;
        private PictureBox picThoat;
        private PictureBox picHuyBo;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNgayNhap;
        private DataGridViewTextBoxColumn colTongTien;
        private DataGridViewTextBoxColumn colNhanVienNhap;
        private DataGridViewTextBoxColumn colTenNhaCungCap;
        private DataGridViewTextBoxColumn colSanPhamID;
        private DataGridViewTextBoxColumn colGhiChu;
        private ToolTip toolTip1;
    }
}