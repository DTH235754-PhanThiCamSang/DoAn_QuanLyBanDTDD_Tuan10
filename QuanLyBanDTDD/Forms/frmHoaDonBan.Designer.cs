namespace QuanLyBanDTDD.Forms
{
    partial class frmHoaDonBan
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
            picXem = new PictureBox();
            picLuu = new PictureBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            datTimKiem = new DateTimePicker();
            label6 = new Label();
            picXoa = new PictureBox();
            picSua = new PictureBox();
            picThem = new PictureBox();
            groupBox = new GroupBox();
            picInHoaDon = new PictureBox();
            cboKhachHang = new ComboBox();
            datNgayBan = new DateTimePicker();
            picThemKH = new PictureBox();
            label7 = new Label();
            dgvHoaDonBan = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colNgayBan = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            colTenNhanVien = new DataGridViewTextBoxColumn();
            colTenKhachHang = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            picXuatDuLieu = new PictureBox();
            picThanhToan = new PictureBox();
            picNhapDuLieu = new PictureBox();
            picThoat = new PictureBox();
            picHuyBo = new PictureBox();
            txtID = new TextBox();
            txtGhiChu = new TextBox();
            txtNhanVienNhap = new TextBox();
            txtTongTien = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picXem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThem).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThemKH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonBan).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXuatDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThanhToan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNhapDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).BeginInit();
            SuspendLayout();
            // 
            // picXem
            // 
            picXem.Cursor = Cursors.Hand;
            picXem.Image = Properties.Resources.view_files;
            picXem.Location = new Point(557, 39);
            picXem.Name = "picXem";
            picXem.Size = new Size(100, 71);
            picXem.SizeMode = PictureBoxSizeMode.Zoom;
            picXem.TabIndex = 0;
            picXem.TabStop = false;
            toolTip1.SetToolTip(picXem, "Xem chi tiết hóa đơn");
            picXem.Click += picXem_Click;
            // 
            // picLuu
            // 
            picLuu.Cursor = Cursors.Hand;
            picLuu.Image = Properties.Resources.save;
            picLuu.Location = new Point(416, 39);
            picLuu.Name = "picLuu";
            picLuu.Size = new Size(100, 71);
            picLuu.SizeMode = PictureBoxSizeMode.Zoom;
            picLuu.TabIndex = 0;
            picLuu.TabStop = false;
            toolTip1.SetToolTip(picLuu, "Lưu hóa đơn");
            picLuu.Click += picLuu_Click;
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
            groupBox2.Controls.Add(picTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(datTimKiem);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(826, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 151);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(382, 26);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(77, 32);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 19;
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
            txtTimKiem.PlaceholderText = "Nhập tên hoặc SĐT đề tìm kiếm...";
            txtTimKiem.Size = new Size(453, 32);
            txtTimKiem.TabIndex = 20;
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // datTimKiem
            // 
            datTimKiem.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datTimKiem.Font = new Font("Calibri", 12F);
            datTimKiem.Format = DateTimePickerFormat.Short;
            datTimKiem.Location = new Point(253, 83);
            datTimKiem.Name = "datTimKiem";
            datTimKiem.ShowCheckBox = true;
            datTimKiem.Size = new Size(205, 32);
            datTimKiem.TabIndex = 18;
            datTimKiem.ValueChanged += datTimKiem_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(6, 83);
            label6.Name = "label6";
            label6.Size = new Size(241, 24);
            label6.TabIndex = 16;
            label6.Text = "Tìm Theo Ngày/Tháng/Năm";
            // 
            // picXoa
            // 
            picXoa.Cursor = Cursors.Hand;
            picXoa.Image = Properties.Resources.delete;
            picXoa.Location = new Point(283, 39);
            picXoa.Name = "picXoa";
            picXoa.Size = new Size(100, 71);
            picXoa.SizeMode = PictureBoxSizeMode.Zoom;
            picXoa.TabIndex = 0;
            picXoa.TabStop = false;
            toolTip1.SetToolTip(picXoa, "Xóa hóa đơn");
            picXoa.Click += picXoa_Click;
            // 
            // picSua
            // 
            picSua.Cursor = Cursors.Hand;
            picSua.Image = Properties.Resources.edit;
            picSua.Location = new Point(146, 39);
            picSua.Name = "picSua";
            picSua.Size = new Size(100, 71);
            picSua.SizeMode = PictureBoxSizeMode.Zoom;
            picSua.TabIndex = 0;
            picSua.TabStop = false;
            toolTip1.SetToolTip(picSua, "Sửa hóa đơn");
            picSua.Click += picSua_Click;
            // 
            // picThem
            // 
            picThem.Cursor = Cursors.Hand;
            picThem.Image = Properties.Resources.add;
            picThem.Location = new Point(12, 39);
            picThem.Name = "picThem";
            picThem.Size = new Size(100, 71);
            picThem.SizeMode = PictureBoxSizeMode.Zoom;
            picThem.TabIndex = 0;
            picThem.TabStop = false;
            toolTip1.SetToolTip(picThem, "Thêm hóa đơn mới..");
            picThem.Click += picThem_Click;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.BackColor = Color.DeepSkyBlue;
            groupBox.Controls.Add(picXem);
            groupBox.Controls.Add(picLuu);
            groupBox.Controls.Add(picXoa);
            groupBox.Controls.Add(picInHoaDon);
            groupBox.Controls.Add(picSua);
            groupBox.Controls.Add(picThem);
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(835, 151);
            groupBox.TabIndex = 12;
            groupBox.TabStop = false;
            // 
            // picInHoaDon
            // 
            picInHoaDon.Cursor = Cursors.Hand;
            picInHoaDon.Image = Properties.Resources.print;
            picInHoaDon.Location = new Point(679, 39);
            picInHoaDon.Name = "picInHoaDon";
            picInHoaDon.Size = new Size(100, 71);
            picInHoaDon.SizeMode = PictureBoxSizeMode.Zoom;
            picInHoaDon.TabIndex = 0;
            picInHoaDon.TabStop = false;
            toolTip1.SetToolTip(picInHoaDon, "In hóa đơn");
            picInHoaDon.Click += picInHoaDon_Click;
            // 
            // cboKhachHang
            // 
            cboKhachHang.Font = new Font("Calibri", 12F);
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(185, 270);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(204, 32);
            cboKhachHang.TabIndex = 19;
            // 
            // datNgayBan
            // 
            datNgayBan.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datNgayBan.Font = new Font("Calibri", 12F);
            datNgayBan.Format = DateTimePickerFormat.Short;
            datNgayBan.Location = new Point(185, 143);
            datNgayBan.Name = "datNgayBan";
            datNgayBan.Size = new Size(204, 32);
            datNgayBan.TabIndex = 18;
            // 
            // picThemKH
            // 
            picThemKH.Cursor = Cursors.Hand;
            picThemKH.Image = Properties.Resources.add;
            picThemKH.Location = new Point(402, 270);
            picThemKH.Name = "picThemKH";
            picThemKH.Size = new Size(60, 30);
            picThemKH.SizeMode = PictureBoxSizeMode.Zoom;
            picThemKH.TabIndex = 0;
            picThemKH.TabStop = false;
            toolTip1.SetToolTip(picThemKH, "Thêm khách hàng....");
            picThemKH.Click += picThemKH_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(17, 272);
            label7.Name = "label7";
            label7.Size = new Size(134, 24);
            label7.TabIndex = 2;
            label7.Text = "Khách Hàng(*):";
            // 
            // dgvHoaDonBan
            // 
            dgvHoaDonBan.AllowUserToAddRows = false;
            dgvHoaDonBan.AllowUserToDeleteRows = false;
            dgvHoaDonBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHoaDonBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDonBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonBan.Columns.AddRange(new DataGridViewColumn[] { colID, colNgayBan, colTongTien, colTenNhanVien, colTenKhachHang, colTrangThai, colGhiChu });
            dgvHoaDonBan.Location = new Point(0, 155);
            dgvHoaDonBan.MultiSelect = false;
            dgvHoaDonBan.Name = "dgvHoaDonBan";
            dgvHoaDonBan.RowHeadersWidth = 51;
            dgvHoaDonBan.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvHoaDonBan.RowTemplate.Height = 35;
            dgvHoaDonBan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDonBan.Size = new Size(826, 587);
            dgvHoaDonBan.TabIndex = 13;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colNgayBan
            // 
            colNgayBan.DataPropertyName = "NgayBan";
            colNgayBan.HeaderText = "Ngày Bán";
            colNgayBan.MinimumWidth = 6;
            colNgayBan.Name = "colNgayBan";
            // 
            // colTongTien
            // 
            colTongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,##0";
            colTongTien.DefaultCellStyle = dataGridViewCellStyle1;
            colTongTien.HeaderText = "Tổng Tiền";
            colTongTien.MinimumWidth = 6;
            colTongTien.Name = "colTongTien";
            // 
            // colTenNhanVien
            // 
            colTenNhanVien.DataPropertyName = "TenNhanVien";
            colTenNhanVien.HeaderText = "Nhân Viên Nhập";
            colTenNhanVien.MinimumWidth = 6;
            colTenNhanVien.Name = "colTenNhanVien";
            // 
            // colTenKhachHang
            // 
            colTenKhachHang.DataPropertyName = "TenKhachHang";
            colTenKhachHang.HeaderText = "Tên Khách Hàng";
            colTenKhachHang.MinimumWidth = 6;
            colTenKhachHang.Name = "colTenKhachHang";
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi Chú";
            colGhiChu.MinimumWidth = 6;
            colGhiChu.Name = "colGhiChu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(17, 144);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 2;
            label2.Text = "Ngày Bán:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(112, 23);
            label11.Name = "label11";
            label11.Size = new Size(312, 37);
            label11.TabIndex = 2;
            label11.Text = "Thông Tin Hóa Đơn Bán";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(4, 227);
            label3.Name = "label3";
            label3.Size = new Size(174, 24);
            label3.TabIndex = 15;
            label3.Text = "Nhân Viên Nhập(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(17, 187);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 16;
            label5.Text = "Tổng Tiền:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(picXuatDuLieu);
            groupBox3.Controls.Add(picThanhToan);
            groupBox3.Controls.Add(picNhapDuLieu);
            groupBox3.Controls.Add(picThoat);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(cboKhachHang);
            groupBox3.Controls.Add(datNgayBan);
            groupBox3.Controls.Add(picThemKH);
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
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            // 
            // picXuatDuLieu
            // 
            picXuatDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picXuatDuLieu.Cursor = Cursors.Hand;
            picXuatDuLieu.Image = Properties.Resources.output;
            picXuatDuLieu.Location = new Point(256, 487);
            picXuatDuLieu.Name = "picXuatDuLieu";
            picXuatDuLieu.Size = new Size(100, 71);
            picXuatDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picXuatDuLieu.TabIndex = 26;
            picXuatDuLieu.TabStop = false;
            toolTip1.SetToolTip(picXuatDuLieu, "Xuất dữ liệu ra...");
            picXuatDuLieu.Click += picXuatDuLieu_Click;
            // 
            // picThanhToan
            // 
            picThanhToan.Cursor = Cursors.Hand;
            picThanhToan.Image = Properties.Resources.pay;
            picThanhToan.Location = new Point(169, 410);
            picThanhToan.Name = "picThanhToan";
            picThanhToan.Size = new Size(204, 71);
            picThanhToan.SizeMode = PictureBoxSizeMode.Zoom;
            picThanhToan.TabIndex = 27;
            picThanhToan.TabStop = false;
            toolTip1.SetToolTip(picThanhToan, "Thanh toán tại đây...");
            picThanhToan.Click += picThanhToan_Click;
            // 
            // picNhapDuLieu
            // 
            picNhapDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picNhapDuLieu.Cursor = Cursors.Hand;
            picNhapDuLieu.Image = Properties.Resources.input;
            picNhapDuLieu.Location = new Point(134, 487);
            picNhapDuLieu.Name = "picNhapDuLieu";
            picNhapDuLieu.Size = new Size(100, 71);
            picNhapDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picNhapDuLieu.TabIndex = 27;
            picNhapDuLieu.TabStop = false;
            toolTip1.SetToolTip(picNhapDuLieu, "Nhập dữ liệu vào...");
            picNhapDuLieu.Click += picNhapDuLieu_Click;
            // 
            // picThoat
            // 
            picThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(362, 487);
            picThoat.Name = "picThoat";
            picThoat.Size = new Size(100, 71);
            picThoat.SizeMode = PictureBoxSizeMode.Zoom;
            picThoat.TabIndex = 25;
            picThoat.TabStop = false;
            toolTip1.SetToolTip(picThoat, "Thoát Form");
            picThoat.Click += picThoat_Click;
            // 
            // picHuyBo
            // 
            picHuyBo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picHuyBo.Cursor = Cursors.Hand;
            picHuyBo.Image = Properties.Resources.cancel;
            picHuyBo.Location = new Point(14, 487);
            picHuyBo.Name = "picHuyBo";
            picHuyBo.Size = new Size(100, 71);
            picHuyBo.SizeMode = PictureBoxSizeMode.Zoom;
            picHuyBo.TabIndex = 24;
            picHuyBo.TabStop = false;
            toolTip1.SetToolTip(picHuyBo, "Hủy mọi thao tác đang làm...");
            picHuyBo.Click += picHuyBo_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Calibri", 12F);
            txtID.Location = new Point(185, 99);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(204, 37);
            txtID.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Calibri", 12F);
            txtGhiChu.Location = new Point(185, 315);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(204, 89);
            txtGhiChu.TabIndex = 11;
            // 
            // txtNhanVienNhap
            // 
            txtNhanVienNhap.Font = new Font("Calibri", 12F);
            txtNhanVienNhap.Location = new Point(185, 224);
            txtNhanVienNhap.Multiline = true;
            txtNhanVienNhap.Name = "txtNhanVienNhap";
            txtNhanVienNhap.ReadOnly = true;
            txtNhanVienNhap.Size = new Size(204, 37);
            txtNhanVienNhap.TabIndex = 10;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Calibri", 12F);
            txtTongTien.Location = new Point(185, 176);
            txtTongTien.Multiline = true;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.ReadOnly = true;
            txtTongTien.Size = new Size(204, 37);
            txtTongTien.TabIndex = 11;
            // 
            // frmHoaDonBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 742);
            Controls.Add(groupBox2);
            Controls.Add(groupBox);
            Controls.Add(dgvHoaDonBan);
            Controls.Add(groupBox3);
            Name = "frmHoaDonBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa Đơn Bán";
            WindowState = FormWindowState.Maximized;
            Load += frmHoaDonBan_Load;
            ((System.ComponentModel.ISupportInitialize)picXem).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThem).EndInit();
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picInHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThemKH).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonBan).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picXuatDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThanhToan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNhapDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picXem;
        private PictureBox picLuu;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private PictureBox picXoa;
        private PictureBox picSua;
        private PictureBox picThem;
        private GroupBox groupBox;
        private ComboBox cboKhachHang;
        private DateTimePicker datNgayBan;
        private PictureBox picInHoaDon;
        private PictureBox picThemKH;
        private Label label7;
        private DataGridView dgvHoaDonBan;
        private Label label2;
        private Label label11;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label5;
        private GroupBox groupBox3;
        private TextBox txtID;
        private TextBox txtGhiChu;
        private TextBox txtNhanVienNhap;
        private TextBox txtTongTien;
        private DateTimePicker datTimKiem;
        private Label label6;
        private PictureBox picTimKiem;
        private TextBox txtTimKiem;
        private PictureBox picXuatDuLieu;
        private PictureBox picNhapDuLieu;
        private PictureBox picThoat;
        private PictureBox picHuyBo;
        private PictureBox picThanhToan;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colNgayBan;
        private DataGridViewTextBoxColumn colTongTien;
        private DataGridViewTextBoxColumn colTenNhanVien;
        private DataGridViewTextBoxColumn colTenKhachHang;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colGhiChu;
        private ToolTip toolTip1;
    }
}