namespace QuanLyBanDTDD.Forms
{
    partial class frmBaoHanh
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            picThoat = new PictureBox();
            picHuyBo = new PictureBox();
            txtTenSanPham = new TextBox();
            txtGhiChu = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            cboTrangThai = new ComboBox();
            label12 = new Label();
            numChiPhi = new NumericUpDown();
            cboLoaiBaoHanh = new ComboBox();
            datNgayTraDuKien = new DateTimePicker();
            datNgayHetHan = new DateTimePicker();
            datNgayMua = new DateTimePicker();
            label8 = new Label();
            Loai = new Label();
            label6 = new Label();
            label13 = new Label();
            label9 = new Label();
            label10 = new Label();
            label3 = new Label();
            txtIMEI_HienThi = new TextBox();
            txtKetQuaXuLy = new TextBox();
            txtTinhTrangMay = new TextBox();
            txtTenKhachHang = new TextBox();
            picLuu = new PictureBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            cboDanhSachIMEI = new ComboBox();
            picXoa = new PictureBox();
            picThem = new PictureBox();
            groupBox = new GroupBox();
            picSua = new PictureBox();
            txtSoDienThoai = new TextBox();
            label7 = new Label();
            dgvBaoHanh = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colSoIMEI = new DataGridViewTextBoxColumn();
            colTenSanPham = new DataGridViewTextBoxColumn();
            colTenKhachHang = new DataGridViewTextBoxColumn();
            colNgayNhan = new DataGridViewTextBoxColumn();
            colNgayTraDuKien = new DataGridViewTextBoxColumn();
            colLoiKhachBao = new DataGridViewTextBoxColumn();
            colPhanLoai = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            colChiPhi = new DataGridViewTextBoxColumn();
            colGhiChu = new DataGridViewTextBoxColumn();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numChiPhi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThem).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBaoHanh).BeginInit();
            SuspendLayout();
            // 
            // picThoat
            // 
            picThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(362, 586);
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
            picHuyBo.Location = new Point(-4, 586);
            picHuyBo.Name = "picHuyBo";
            picHuyBo.Size = new Size(100, 71);
            picHuyBo.SizeMode = PictureBoxSizeMode.Zoom;
            picHuyBo.TabIndex = 24;
            picHuyBo.TabStop = false;
            toolTip1.SetToolTip(picHuyBo, "Hủy mọi thao tác đang làm...");
            picHuyBo.Click += picHuyBo_Click;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Calibri", 12F);
            txtTenSanPham.Location = new Point(200, 137);
            txtTenSanPham.Multiline = true;
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.ReadOnly = true;
            txtTenSanPham.Size = new Size(257, 37);
            txtTenSanPham.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Calibri", 12F);
            txtGhiChu.Location = new Point(200, 414);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(257, 31);
            txtGhiChu.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(18, 112);
            label5.Name = "label5";
            label5.Size = new Size(99, 24);
            label5.TabIndex = 16;
            label5.Text = "Tên Khách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(10, 179);
            label2.Name = "label2";
            label2.Size = new Size(99, 24);
            label2.TabIndex = 2;
            label2.Text = "Ngày Mua:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(116, 10);
            label11.Name = "label11";
            label11.Size = new Size(269, 37);
            label11.TabIndex = 2;
            label11.Text = "Thông Tin Sản Phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(10, 138);
            label1.Name = "label1";
            label1.Size = new Size(131, 24);
            label1.TabIndex = 2;
            label1.Text = "Tên Sản Phẩm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(12, 421);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 16;
            label4.Text = "Ghi Chú:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(cboTrangThai);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(numChiPhi);
            groupBox3.Controls.Add(picThoat);
            groupBox3.Controls.Add(cboLoaiBaoHanh);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(datNgayTraDuKien);
            groupBox3.Controls.Add(datNgayHetHan);
            groupBox3.Controls.Add(datNgayMua);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(Loai);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtIMEI_HienThi);
            groupBox3.Controls.Add(txtTenSanPham);
            groupBox3.Controls.Add(txtKetQuaXuLy);
            groupBox3.Controls.Add(txtTinhTrangMay);
            groupBox3.Controls.Add(txtGhiChu);
            groupBox3.Location = new Point(828, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 663);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            // 
            // cboTrangThai
            // 
            cboTrangThai.Font = new Font("Calibri", 12F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đã tiếp nhận & Sửa chữa", "Đã trả hàng" });
            cboTrangThai.Location = new Point(200, 506);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(257, 32);
            cboTrangThai.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F);
            label12.Location = new Point(4, 507);
            label12.Name = "label12";
            label12.Size = new Size(187, 24);
            label12.TabIndex = 29;
            label12.Text = "Trạng Thái Sửa Chữa:";
            // 
            // numChiPhi
            // 
            numChiPhi.Font = new Font("Calibri", 12F);
            numChiPhi.Location = new Point(200, 347);
            numChiPhi.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            numChiPhi.Name = "numChiPhi";
            numChiPhi.Size = new Size(257, 32);
            numChiPhi.TabIndex = 28;
            // 
            // cboLoaiBaoHanh
            // 
            cboLoaiBaoHanh.Font = new Font("Calibri", 12F);
            cboLoaiBaoHanh.FormattingEnabled = true;
            cboLoaiBaoHanh.Items.AddRange(new object[] { "Bảo hành", "Sửa chữa có phí" });
            cboLoaiBaoHanh.Location = new Point(200, 254);
            cboLoaiBaoHanh.Name = "cboLoaiBaoHanh";
            cboLoaiBaoHanh.Size = new Size(257, 32);
            cboLoaiBaoHanh.TabIndex = 19;
            cboLoaiBaoHanh.SelectedIndexChanged += cboLoaiBaoHanh_SelectedIndexChanged;
            // 
            // datNgayTraDuKien
            // 
            datNgayTraDuKien.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datNgayTraDuKien.Font = new Font("Calibri", 12F);
            datNgayTraDuKien.Format = DateTimePickerFormat.Short;
            datNgayTraDuKien.Location = new Point(200, 378);
            datNgayTraDuKien.Name = "datNgayTraDuKien";
            datNgayTraDuKien.Size = new Size(257, 32);
            datNgayTraDuKien.TabIndex = 18;
            // 
            // datNgayHetHan
            // 
            datNgayHetHan.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datNgayHetHan.Font = new Font("Calibri", 12F);
            datNgayHetHan.Format = DateTimePickerFormat.Short;
            datNgayHetHan.Location = new Point(200, 212);
            datNgayHetHan.Name = "datNgayHetHan";
            datNgayHetHan.Size = new Size(257, 32);
            datNgayHetHan.TabIndex = 18;
            // 
            // datNgayMua
            // 
            datNgayMua.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datNgayMua.Font = new Font("Calibri", 12F);
            datNgayMua.Format = DateTimePickerFormat.Short;
            datNgayMua.Location = new Point(200, 179);
            datNgayMua.Name = "datNgayMua";
            datNgayMua.Size = new Size(257, 32);
            datNgayMua.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(12, 384);
            label8.Name = "label8";
            label8.Size = new Size(157, 24);
            label8.TabIndex = 2;
            label8.Text = "Ngày Trả Dự Kiến:";
            // 
            // Loai
            // 
            Loai.AutoSize = true;
            Loai.Font = new Font("Calibri", 12F);
            Loai.Location = new Point(9, 254);
            Loai.Name = "Loai";
            Loai.Size = new Size(135, 24);
            Loai.TabIndex = 2;
            Loai.Text = "Loại Bảo Hành:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(10, 212);
            label6.Name = "label6";
            label6.Size = new Size(176, 24);
            label6.TabIndex = 2;
            label6.Text = "Ngày Hết Bảo Hành:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F);
            label13.Location = new Point(10, 93);
            label13.Name = "label13";
            label13.Size = new Size(77, 24);
            label13.TabIndex = 2;
            label13.Text = "Số IMEI:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.Location = new Point(12, 350);
            label9.Name = "label9";
            label9.Size = new Size(73, 24);
            label9.TabIndex = 16;
            label9.Text = "Chi Phí:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F);
            label10.Location = new Point(9, 463);
            label10.Name = "label10";
            label10.Size = new Size(129, 24);
            label10.TabIndex = 16;
            label10.Text = "Kết Quả Xử Lý:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(7, 304);
            label3.Name = "label3";
            label3.Size = new Size(144, 24);
            label3.TabIndex = 16;
            label3.Text = "Tình Trạng Máy:";
            // 
            // txtIMEI_HienThi
            // 
            txtIMEI_HienThi.Font = new Font("Calibri", 12F);
            txtIMEI_HienThi.Location = new Point(200, 83);
            txtIMEI_HienThi.Multiline = true;
            txtIMEI_HienThi.Name = "txtIMEI_HienThi";
            txtIMEI_HienThi.ReadOnly = true;
            txtIMEI_HienThi.Size = new Size(257, 37);
            txtIMEI_HienThi.TabIndex = 0;
            // 
            // txtKetQuaXuLy
            // 
            txtKetQuaXuLy.Font = new Font("Calibri", 12F);
            txtKetQuaXuLy.Location = new Point(200, 451);
            txtKetQuaXuLy.Multiline = true;
            txtKetQuaXuLy.Name = "txtKetQuaXuLy";
            txtKetQuaXuLy.Size = new Size(257, 49);
            txtKetQuaXuLy.TabIndex = 11;
            // 
            // txtTinhTrangMay
            // 
            txtTinhTrangMay.Font = new Font("Calibri", 12F);
            txtTinhTrangMay.Location = new Point(200, 292);
            txtTinhTrangMay.Multiline = true;
            txtTinhTrangMay.Name = "txtTinhTrangMay";
            txtTinhTrangMay.ScrollBars = ScrollBars.Both;
            txtTinhTrangMay.Size = new Size(257, 49);
            txtTinhTrangMay.TabIndex = 11;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Calibri", 12F);
            txtTenKhachHang.Location = new Point(153, 106);
            txtTenKhachHang.Multiline = true;
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.ReadOnly = true;
            txtTenKhachHang.Size = new Size(201, 39);
            txtTenKhachHang.TabIndex = 11;
            // 
            // picLuu
            // 
            picLuu.Cursor = Cursors.Hand;
            picLuu.Image = Properties.Resources.save;
            picLuu.Location = new Point(532, 26);
            picLuu.Name = "picLuu";
            picLuu.Size = new Size(100, 71);
            picLuu.SizeMode = PictureBoxSizeMode.Zoom;
            picLuu.TabIndex = 0;
            picLuu.TabStop = false;
            toolTip1.SetToolTip(picLuu, "Lưu trang bảo hành..");
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
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(cboDanhSachIMEI);
            groupBox2.Location = new Point(826, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 151);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(388, 26);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(76, 32);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 19;
            picTimKiem.TabStop = false;
            toolTip1.SetToolTip(picTimKiem, "Tìm kiếm");
            // 
            // txtTimKiem
            // 
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.Font = new Font("Calibri", 12F);
            txtTimKiem.Location = new Point(6, 26);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập SĐT hoặc IMEI để tìm kiếm...";
            txtTimKiem.Size = new Size(453, 32);
            txtTimKiem.TabIndex = 20;
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // cboDanhSachIMEI
            // 
            cboDanhSachIMEI.Font = new Font("Calibri", 12F);
            cboDanhSachIMEI.FormattingEnabled = true;
            cboDanhSachIMEI.Location = new Point(6, 84);
            cboDanhSachIMEI.Name = "cboDanhSachIMEI";
            cboDanhSachIMEI.Size = new Size(381, 32);
            cboDanhSachIMEI.TabIndex = 19;
            cboDanhSachIMEI.Visible = false;
            cboDanhSachIMEI.SelectedIndexChanged += cboDanhSachIMEI_SelectedIndexChanged;
            // 
            // picXoa
            // 
            picXoa.Cursor = Cursors.Hand;
            picXoa.Image = Properties.Resources.delete;
            picXoa.Location = new Point(359, 26);
            picXoa.Name = "picXoa";
            picXoa.Size = new Size(100, 71);
            picXoa.SizeMode = PictureBoxSizeMode.Zoom;
            picXoa.TabIndex = 0;
            picXoa.TabStop = false;
            toolTip1.SetToolTip(picXoa, "Xóa trang bảo hành...");
            picXoa.Click += picXoa_Click;
            // 
            // picThem
            // 
            picThem.Cursor = Cursors.Hand;
            picThem.Image = Properties.Resources.add;
            picThem.Location = new Point(21, 26);
            picThem.Name = "picThem";
            picThem.Size = new Size(100, 71);
            picThem.SizeMode = PictureBoxSizeMode.Zoom;
            picThem.TabIndex = 0;
            picThem.TabStop = false;
            toolTip1.SetToolTip(picThem, "Thêm trang bảo hành mới..");
            picThem.Click += picThem_Click;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.BackColor = Color.DeepSkyBlue;
            groupBox.Controls.Add(picLuu);
            groupBox.Controls.Add(picXoa);
            groupBox.Controls.Add(picSua);
            groupBox.Controls.Add(picThem);
            groupBox.Controls.Add(txtTenKhachHang);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(txtSoDienThoai);
            groupBox.Controls.Add(label7);
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(835, 151);
            groupBox.TabIndex = 16;
            groupBox.TabStop = false;
            // 
            // picSua
            // 
            picSua.Cursor = Cursors.Hand;
            picSua.Image = Properties.Resources.edit;
            picSua.Location = new Point(189, 26);
            picSua.Name = "picSua";
            picSua.Size = new Size(100, 71);
            picSua.SizeMode = PictureBoxSizeMode.Zoom;
            picSua.TabIndex = 0;
            picSua.TabStop = false;
            toolTip1.SetToolTip(picSua, "Sửa trang bảo hành..");
            picSua.Click += picSua_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Calibri", 12F);
            txtSoDienThoai.Location = new Point(521, 106);
            txtSoDienThoai.Multiline = true;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.ReadOnly = true;
            txtSoDienThoai.Size = new Size(221, 39);
            txtSoDienThoai.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(381, 106);
            label7.Name = "label7";
            label7.Size = new Size(126, 24);
            label7.TabIndex = 15;
            label7.Text = "Số điện thoại:";
            // 
            // dgvBaoHanh
            // 
            dgvBaoHanh.AllowUserToAddRows = false;
            dgvBaoHanh.AllowUserToDeleteRows = false;
            dgvBaoHanh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBaoHanh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvBaoHanh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoHanh.Columns.AddRange(new DataGridViewColumn[] { colID, colSoIMEI, colTenSanPham, colTenKhachHang, colNgayNhan, colNgayTraDuKien, colLoiKhachBao, colPhanLoai, colTrangThai, colChiPhi, colGhiChu });
            dgvBaoHanh.Location = new Point(0, 155);
            dgvBaoHanh.MultiSelect = false;
            dgvBaoHanh.Name = "dgvBaoHanh";
            dgvBaoHanh.RowHeadersWidth = 51;
            dgvBaoHanh.RowTemplate.Height = 35;
            dgvBaoHanh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBaoHanh.Size = new Size(826, 664);
            dgvBaoHanh.TabIndex = 17;
            dgvBaoHanh.CellClick += dgvBaoHanh_CellClick;
            dgvBaoHanh.CellContentClick += dgvBaoHanh_CellContentClick;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Width = 53;
            // 
            // colSoIMEI
            // 
            colSoIMEI.DataPropertyName = "SoIMEI";
            colSoIMEI.HeaderText = "Số IMEI";
            colSoIMEI.MinimumWidth = 6;
            colSoIMEI.Name = "colSoIMEI";
            colSoIMEI.Width = 82;
            // 
            // colTenSanPham
            // 
            colTenSanPham.DataPropertyName = "TenSP";
            colTenSanPham.HeaderText = "Tên Sản Phẩm";
            colTenSanPham.MinimumWidth = 6;
            colTenSanPham.Name = "colTenSanPham";
            colTenSanPham.Width = 119;
            // 
            // colTenKhachHang
            // 
            colTenKhachHang.DataPropertyName = "TenKH";
            colTenKhachHang.HeaderText = "Tên Khách Hàng";
            colTenKhachHang.MinimumWidth = 6;
            colTenKhachHang.Name = "colTenKhachHang";
            colTenKhachHang.Width = 133;
            // 
            // colNgayNhan
            // 
            colNgayNhan.DataPropertyName = "NgayNhan";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            colNgayNhan.DefaultCellStyle = dataGridViewCellStyle1;
            colNgayNhan.HeaderText = "Ngày Nhận";
            colNgayNhan.MinimumWidth = 6;
            colNgayNhan.Name = "colNgayNhan";
            colNgayNhan.Width = 103;
            // 
            // colNgayTraDuKien
            // 
            colNgayTraDuKien.DataPropertyName = "NgayTraDuKien";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            colNgayTraDuKien.DefaultCellStyle = dataGridViewCellStyle2;
            colNgayTraDuKien.HeaderText = "Ngày Trả Dự Kiến";
            colNgayTraDuKien.MinimumWidth = 6;
            colNgayTraDuKien.Name = "colNgayTraDuKien";
            colNgayTraDuKien.Width = 115;
            // 
            // colLoiKhachBao
            // 
            colLoiKhachBao.DataPropertyName = "LoiKhachBao";
            colLoiKhachBao.HeaderText = "Lỗi Khách Báo";
            colLoiKhachBao.MinimumWidth = 6;
            colLoiKhachBao.Name = "colLoiKhachBao";
            colLoiKhachBao.Width = 121;
            // 
            // colPhanLoai
            // 
            colPhanLoai.DataPropertyName = "PhanLoai";
            colPhanLoai.HeaderText = "Phân Loại";
            colPhanLoai.MinimumWidth = 6;
            colPhanLoai.Name = "colPhanLoai";
            colPhanLoai.Width = 94;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.Width = 99;
            // 
            // colChiPhi
            // 
            colChiPhi.DataPropertyName = "ChiPhi";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0";
            colChiPhi.DefaultCellStyle = dataGridViewCellStyle3;
            colChiPhi.HeaderText = "Chi Phí";
            colChiPhi.MinimumWidth = 6;
            colChiPhi.Name = "colChiPhi";
            colChiPhi.Width = 59;
            // 
            // colGhiChu
            // 
            colGhiChu.DataPropertyName = "GhiChu";
            colGhiChu.HeaderText = "Ghi Chú";
            colGhiChu.MinimumWidth = 6;
            colGhiChu.Name = "colGhiChu";
            colGhiChu.Width = 83;
            // 
            // frmBaoHanh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 819);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox);
            Controls.Add(dgvBaoHanh);
            Name = "frmBaoHanh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảo Hành";
            Load += frmBaoHanh_Load;
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numChiPhi).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThem).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBaoHanh).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picThoat;
        private PictureBox picHuyBo;
        private TextBox txtTenSanPham;
        private TextBox txtGhiChu;
        private Label label5;
        private Label label2;
        private Label label11;
        private Label label1;
        private Label label4;
        private GroupBox groupBox3;
        private DateTimePicker datNgayMua;
        private TextBox txtTenKhachHang;
        private PictureBox picLuu;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private PictureBox picTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cboDanhSachIMEI;
        private PictureBox picXoa;
        private PictureBox picThem;
        private GroupBox groupBox;
        private PictureBox picSua;
        private DataGridView dgvBaoHanh;
        private DateTimePicker datNgayHetHan;
        private Label label6;
        private TextBox txtSoDienThoai;
        private Label label7;
        private ComboBox cboLoaiBaoHanh;
        private DateTimePicker datNgayTraDuKien;
        private Label label8;
        private Label Loai;
        private Label label3;
        private TextBox txtTinhTrangMay;
        private NumericUpDown numChiPhi;
        private Label label9;
        private Label label10;
        private TextBox txtKetQuaXuLy;
        private ComboBox cboTrangThai;
        private Label label12;
        private Label label13;
        private TextBox txtIMEI_HienThi;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSoIMEI;
        private DataGridViewTextBoxColumn colTenSanPham;
        private DataGridViewTextBoxColumn colTenKhachHang;
        private DataGridViewTextBoxColumn colNgayNhan;
        private DataGridViewTextBoxColumn colNgayTraDuKien;
        private DataGridViewTextBoxColumn colLoiKhachBao;
        private DataGridViewTextBoxColumn colPhanLoai;
        private DataGridViewTextBoxColumn colTrangThai;
        private DataGridViewTextBoxColumn colChiPhi;
        private DataGridViewTextBoxColumn colGhiChu;
        private ToolTip toolTip1;
    }
}