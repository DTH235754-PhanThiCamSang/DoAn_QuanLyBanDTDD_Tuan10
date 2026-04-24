namespace QuanLyBanDTDD.Forms
{
    partial class frmNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox = new GroupBox();
            picLuu = new PictureBox();
            picXoa = new PictureBox();
            picSua = new PictureBox();
            picThem = new PictureBox();
            txtTimKiem = new TextBox();
            groupBox2 = new GroupBox();
            datTimKiem = new DateTimePicker();
            label12 = new Label();
            textBox2 = new TextBox();
            picTimKiem = new PictureBox();
            groupBox3 = new GroupBox();
            picXuatDuLieu = new PictureBox();
            picNhapDuLieu = new PictureBox();
            picThoat = new PictureBox();
            picHuyBo = new PictureBox();
            datNgaySinh = new DateTimePicker();
            label10 = new Label();
            label8 = new Label();
            lable = new Label();
            label4 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            cboQuyenHan = new ComboBox();
            cboTrangThai = new ComboBox();
            cboChucVu = new ComboBox();
            txtMatKhau = new TextBox();
            txtTenDN = new TextBox();
            cboGioiTinh = new ComboBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            txtID = new TextBox();
            dgvNhanVien = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colChucVu = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colTenDangNhap = new DataGridViewTextBoxColumn();
            colQuyenHan = new DataGridViewTextBoxColumn();
            toolTip1 = new ToolTip(components);
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLuu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThem).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picXuatDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picNhapDuLieu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
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
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            // 
            // picLuu
            // 
            picLuu.Cursor = Cursors.Hand;
            picLuu.Image = Properties.Resources.save;
            picLuu.Location = new Point(548, 35);
            picLuu.Name = "picLuu";
            picLuu.Size = new Size(100, 71);
            picLuu.SizeMode = PictureBoxSizeMode.Zoom;
            picLuu.TabIndex = 0;
            picLuu.TabStop = false;
            toolTip1.SetToolTip(picLuu, "Lưu nhân viên");
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
            toolTip1.SetToolTip(picXoa, "Xóa nhân viên");
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
            toolTip1.SetToolTip(picSua, "Sửa nhân viên");
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
            toolTip1.SetToolTip(picThem, "Thêm nhân viên");
            picThem.Click += picThem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Calibri", 12F);
            txtTimKiem.Location = new Point(6, 26);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên hoặc SĐT đề tìm kiếm...";
            txtTimKiem.Size = new Size(453, 51);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.BackColor = Color.DeepSkyBlue;
            groupBox2.Controls.Add(datTimKiem);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(picTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(826, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 151);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // datTimKiem
            // 
            datTimKiem.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datTimKiem.Font = new Font("Calibri", 12F);
            datTimKiem.Format = DateTimePickerFormat.Short;
            datTimKiem.Location = new Point(253, 97);
            datTimKiem.Name = "datTimKiem";
            datTimKiem.ShowCheckBox = true;
            datTimKiem.Size = new Size(206, 32);
            datTimKiem.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F);
            label12.Location = new Point(6, 101);
            label12.Name = "label12";
            label12.Size = new Size(241, 24);
            label12.TabIndex = 21;
            label12.Text = "Tìm Theo Ngày/Tháng/Năm";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(607, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(395, 26);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(64, 51);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 0;
            picTimKiem.TabStop = false;
            toolTip1.SetToolTip(picTimKiem, "Tìm kiếm");
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(picXuatDuLieu);
            groupBox3.Controls.Add(picNhapDuLieu);
            groupBox3.Controls.Add(picThoat);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(datNgaySinh);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(lable);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cboQuyenHan);
            groupBox3.Controls.Add(cboTrangThai);
            groupBox3.Controls.Add(cboChucVu);
            groupBox3.Controls.Add(txtMatKhau);
            groupBox3.Controls.Add(txtTenDN);
            groupBox3.Controls.Add(cboGioiTinh);
            groupBox3.Controls.Add(txtDiaChi);
            groupBox3.Controls.Add(txtSDT);
            groupBox3.Controls.Add(txtHoTen);
            groupBox3.Controls.Add(txtID);
            groupBox3.Location = new Point(828, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 586);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // picXuatDuLieu
            // 
            picXuatDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picXuatDuLieu.Cursor = Cursors.Hand;
            picXuatDuLieu.Image = Properties.Resources.output;
            picXuatDuLieu.Location = new Point(251, 504);
            picXuatDuLieu.Name = "picXuatDuLieu";
            picXuatDuLieu.Size = new Size(100, 71);
            picXuatDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picXuatDuLieu.TabIndex = 5;
            picXuatDuLieu.TabStop = false;
            toolTip1.SetToolTip(picXuatDuLieu, "Xuất Dữ Liệu");
            picXuatDuLieu.Click += picXuatDuLieu_Click;
            // 
            // picNhapDuLieu
            // 
            picNhapDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picNhapDuLieu.Cursor = Cursors.Hand;
            picNhapDuLieu.Image = Properties.Resources.input;
            picNhapDuLieu.Location = new Point(129, 504);
            picNhapDuLieu.Name = "picNhapDuLieu";
            picNhapDuLieu.Size = new Size(100, 71);
            picNhapDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picNhapDuLieu.TabIndex = 5;
            picNhapDuLieu.TabStop = false;
            toolTip1.SetToolTip(picNhapDuLieu, "Nhập Dữ Liệu");
            picNhapDuLieu.Click += picNhapDuLieu_Click;
            // 
            // picThoat
            // 
            picThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(357, 504);
            picThoat.Name = "picThoat";
            picThoat.Size = new Size(100, 71);
            picThoat.SizeMode = PictureBoxSizeMode.Zoom;
            picThoat.TabIndex = 4;
            picThoat.TabStop = false;
            toolTip1.SetToolTip(picThoat, "Thoát Form");
            picThoat.Click += picThoat_Click;
            // 
            // picHuyBo
            // 
            picHuyBo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            picHuyBo.Cursor = Cursors.Hand;
            picHuyBo.Image = Properties.Resources.cancel;
            picHuyBo.Location = new Point(9, 504);
            picHuyBo.Name = "picHuyBo";
            picHuyBo.Size = new Size(100, 71);
            picHuyBo.SizeMode = PictureBoxSizeMode.Zoom;
            picHuyBo.TabIndex = 0;
            picHuyBo.TabStop = false;
            toolTip1.SetToolTip(picHuyBo, "Hủy Bỏ Thao Tác");
            picHuyBo.Click += picHuyBo_Click;
            // 
            // datNgaySinh
            // 
            datNgaySinh.CustomFormat = "dd/MM/yyyy";
            datNgaySinh.Font = new Font("Calibri", 12F);
            datNgaySinh.Format = DateTimePickerFormat.Custom;
            datNgaySinh.Location = new Point(187, 193);
            datNgaySinh.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            datNgaySinh.MinDate = new DateTime(2008, 1, 1, 0, 0, 0, 0);
            datNgaySinh.Name = "datNgaySinh";
            datNgaySinh.Size = new Size(260, 32);
            datNgaySinh.TabIndex = 3;
            datNgaySinh.Value = new DateTime(2008, 1, 1, 0, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F);
            label10.Location = new Point(17, 458);
            label10.Name = "label10";
            label10.Size = new Size(129, 24);
            label10.TabIndex = 2;
            label10.Text = "Quyền Hạn(*):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(17, 273);
            label8.Name = "label8";
            label8.Size = new Size(74, 24);
            label8.TabIndex = 2;
            label8.Text = "Địa Chỉ:";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Font = new Font("Calibri", 12F);
            lable.Location = new Point(17, 425);
            lable.Name = "lable";
            lable.Size = new Size(118, 24);
            lable.TabIndex = 2;
            lable.Text = "Mật Khẩu(*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(17, 386);
            label4.Name = "label4";
            label4.Size = new Size(163, 24);
            label4.TabIndex = 2;
            label4.Text = "Tên Đăng Nhập(*):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.Location = new Point(17, 307);
            label9.Name = "label9";
            label9.Size = new Size(106, 24);
            label9.TabIndex = 2;
            label9.Text = "Chức Vụ(*):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(17, 229);
            label7.Name = "label7";
            label7.Size = new Size(68, 24);
            label7.TabIndex = 2;
            label7.Text = "SĐT(*):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(17, 198);
            label6.Name = "label6";
            label6.Size = new Size(97, 24);
            label6.TabIndex = 2;
            label6.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(17, 163);
            label3.Name = "label3";
            label3.Size = new Size(92, 24);
            label3.TabIndex = 2;
            label3.Text = "Giới Tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(17, 344);
            label5.Name = "label5";
            label5.Size = new Size(124, 24);
            label5.TabIndex = 2;
            label5.Text = "Trạng Thái(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(13, 131);
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
            label11.Size = new Size(276, 37);
            label11.TabIndex = 2;
            label11.Text = "Thông Tin Nhân Viên";
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
            // cboQuyenHan
            // 
            cboQuyenHan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyenHan.Font = new Font("Calibri", 12F);
            cboQuyenHan.FormattingEnabled = true;
            cboQuyenHan.Items.AddRange(new object[] { "Quản lý", "Nhân viên", "Thủ kho" });
            cboQuyenHan.Location = new Point(187, 458);
            cboQuyenHan.Name = "cboQuyenHan";
            cboQuyenHan.Size = new Size(260, 32);
            cboQuyenHan.TabIndex = 1;
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Calibri", 12F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Đã nghỉ" });
            cboTrangThai.Location = new Point(187, 344);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(260, 32);
            cboTrangThai.TabIndex = 1;
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.Font = new Font("Calibri", 12F);
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Items.AddRange(new object[] { "Quản lý", "Bán hàng", "Thủ kho" });
            cboChucVu.Location = new Point(187, 306);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(260, 32);
            cboChucVu.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Calibri", 12F);
            txtMatKhau.Location = new Point(187, 425);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(260, 32);
            txtMatKhau.TabIndex = 0;
            // 
            // txtTenDN
            // 
            txtTenDN.Font = new Font("Calibri", 12F);
            txtTenDN.Location = new Point(187, 386);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(260, 32);
            txtTenDN.TabIndex = 0;
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Calibri", 12F);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.Location = new Point(187, 160);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(260, 32);
            cboGioiTinh.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Calibri", 12F);
            txtDiaChi.Location = new Point(187, 266);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(260, 32);
            txtDiaChi.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Calibri", 12F);
            txtSDT.Location = new Point(187, 226);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(260, 32);
            txtSDT.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Calibri", 12F);
            txtHoTen.Location = new Point(187, 128);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(260, 32);
            txtHoTen.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Calibri", 12F);
            txtID.Location = new Point(187, 95);
            txtID.Name = "txtID";
            txtID.Size = new Size(260, 32);
            txtID.TabIndex = 0;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AllowUserToDeleteRows = false;
            dgvNhanVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colID, colHoTen, colGioiTinh, colNgaySinh, colSDT, colDiaChi, colChucVu, colTrangThai, colTenDangNhap, colQuyenHan });
            dgvNhanVien.Location = new Point(0, 153);
            dgvNhanVien.MultiSelect = false;
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 35;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(826, 588);
            dgvNhanVien.TabIndex = 3;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 53;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ Và Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.Width = 105;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới Tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.Width = 97;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            colNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.Width = 105;
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SDT";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            colSDT.DefaultCellStyle = dataGridViewCellStyle2;
            colSDT.HeaderText = "Số Điện Thoại";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            colSDT.Width = 131;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.Width = 86;
            // 
            // colChucVu
            // 
            colChucVu.DataPropertyName = "ChucVu";
            colChucVu.HeaderText = "Chức Vụ";
            colChucVu.MinimumWidth = 6;
            colChucVu.Name = "colChucVu";
            colChucVu.Width = 92;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.Width = 107;
            // 
            // colTenDangNhap
            // 
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            colTenDangNhap.HeaderText = "Tên Đăng Nhập";
            colTenDangNhap.MinimumWidth = 6;
            colTenDangNhap.Name = "colTenDangNhap";
            colTenDangNhap.Width = 141;
            // 
            // colQuyenHan
            // 
            colQuyenHan.DataPropertyName = "QuyenHan";
            colQuyenHan.HeaderText = "Quyền Hạn";
            colQuyenHan.MinimumWidth = 6;
            colQuyenHan.Name = "colQuyenHan";
            colQuyenHan.Width = 111;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 742);
            Controls.Add(dgvNhanVien);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox);
            Name = "frmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân Viên";
            Load += frmNhanVien_Load;
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLuu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThem).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picXuatDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picNhapDuLieu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private PictureBox picXoa;
        private PictureBox picSua;
        private PictureBox picThem;
        private TextBox txtTimKiem;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private PictureBox picTimKiem;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox cboGioiTinh;
        private TextBox txtID;
        private Label label8;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private ComboBox cboChucVu;
        private TextBox txtTenDN;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private Label label10;
        private Label label9;
        private Label label11;
        private DateTimePicker datNgaySinh;
        private ComboBox cboQuyenHan;
        private ComboBox cboTrangThai;
        private TextBox txtHoTen;
        private PictureBox picLuu;
        private PictureBox picHuyBo;
        private DataGridView dgvNhanVien;
        private Label lable;
        private TextBox txtMatKhau;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colHoTen;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colSDT;
        private DataGridViewTextBoxColumn colDiaChi;
        private DataGridViewTextBoxColumn colChucVu;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colTenDangNhap;
        private DataGridViewTextBoxColumn colQuyenHan;
        private PictureBox picThoat;
        private PictureBox picNhapDuLieu;
        private PictureBox picXuatDuLieu;
        private DateTimePicker datTimKiem;
        private Label label12;
        private ToolTip toolTip1;
    }
}