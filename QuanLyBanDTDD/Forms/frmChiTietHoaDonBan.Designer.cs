namespace QuanLyBanDTDD.Forms
{
    partial class frmChiTietHoaDonBan
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            picLuu = new PictureBox();
            groupBox2 = new GroupBox();
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            numThanhTien = new NumericUpDown();
            numDonGiaBan = new NumericUpDown();
            numSoLuongBan = new NumericUpDown();
            picThoat = new PictureBox();
            picHuyBo = new PictureBox();
            label4 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            cboKhachHang = new ComboBox();
            txtNgayHetHan = new TextBox();
            txtNgayKichHoat = new TextBox();
            txtTenSP = new TextBox();
            txtNhanVienNhap = new TextBox();
            txtID = new TextBox();
            InHoaDon = new PictureBox();
            groupBox1 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            picThemSanPham = new PictureBox();
            label12 = new Label();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboTenSanPham = new ComboBox();
            picXoa = new PictureBox();
            dgvChiTietHDB = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colSanPhamID = new DataGridViewTextBoxColumn();
            colTenSanPham = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            groupBox = new GroupBox();
            picSua = new PictureBox();
            picThem = new PictureBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picLuu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InHoaDon).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picThemSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHDB).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThem).BeginInit();
            SuspendLayout();
            // 
            // picLuu
            // 
            picLuu.Cursor = Cursors.Hand;
            picLuu.Image = Properties.Resources.save;
            picLuu.Location = new Point(519, 38);
            picLuu.Name = "picLuu";
            picLuu.Size = new Size(100, 71);
            picLuu.SizeMode = PictureBoxSizeMode.Zoom;
            picLuu.TabIndex = 0;
            picLuu.TabStop = false;
            toolTip1.SetToolTip(picLuu, "Lưu chi tiết hóa đơn");
            picLuu.Click += picLuu_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.BackColor = Color.DeepSkyBlue;
            groupBox2.Controls.Add(picTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(826, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 151);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(383, 62);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(76, 32);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 25;
            picTimKiem.TabStop = false;
            toolTip1.SetToolTip(picTimKiem, "Tìm kiếm");
            picTimKiem.Click += picTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiem.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTimKiem.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(6, 62);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên hoặc SĐT KH đề tìm kiếm...";
            txtTimKiem.Size = new Size(453, 32);
            txtTimKiem.TabIndex = 26;
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(607, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(numThanhTien);
            groupBox3.Controls.Add(numDonGiaBan);
            groupBox3.Controls.Add(numSoLuongBan);
            groupBox3.Controls.Add(picThoat);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cboKhachHang);
            groupBox3.Controls.Add(txtNgayHetHan);
            groupBox3.Controls.Add(txtNgayKichHoat);
            groupBox3.Controls.Add(txtTenSP);
            groupBox3.Controls.Add(txtNhanVienNhap);
            groupBox3.Controls.Add(txtID);
            groupBox3.Location = new Point(828, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 586);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // numThanhTien
            // 
            numThanhTien.Font = new Font("Calibri", 12F);
            numThanhTien.Location = new Point(197, 371);
            numThanhTien.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            numThanhTien.Name = "numThanhTien";
            numThanhTien.ReadOnly = true;
            numThanhTien.RightToLeft = RightToLeft.No;
            numThanhTien.Size = new Size(260, 32);
            numThanhTien.TabIndex = 5;
            numThanhTien.ThousandsSeparator = true;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Font = new Font("Calibri", 12F);
            numDonGiaBan.Location = new Point(197, 330);
            numDonGiaBan.Maximum = new decimal(new int[] { 1316134912, 2328, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.ReadOnly = true;
            numDonGiaBan.Size = new Size(260, 32);
            numDonGiaBan.TabIndex = 5;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Font = new Font("Calibri", 12F);
            numSoLuongBan.Location = new Point(197, 288);
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.ReadOnly = true;
            numSoLuongBan.Size = new Size(260, 32);
            numSoLuongBan.TabIndex = 5;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // picThoat
            // 
            picThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(333, 503);
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
            picHuyBo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picHuyBo.Cursor = Cursors.Hand;
            picHuyBo.Image = Properties.Resources.cancel;
            picHuyBo.Location = new Point(17, 517);
            picHuyBo.Name = "picHuyBo";
            picHuyBo.Size = new Size(100, 71);
            picHuyBo.SizeMode = PictureBoxSizeMode.Zoom;
            picHuyBo.TabIndex = 0;
            picHuyBo.TabStop = false;
            toolTip1.SetToolTip(picHuyBo, "Hủy mọi thao đang đang làm...");
            picHuyBo.Click += picHuyBo_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(23, 376);
            label4.Name = "label4";
            label4.Size = new Size(109, 24);
            label4.TabIndex = 2;
            label4.Text = "Thành Tiền:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.Location = new Point(23, 288);
            label9.Name = "label9";
            label9.Size = new Size(114, 24);
            label9.TabIndex = 2;
            label9.Text = "Số Lượng(*):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(23, 462);
            label8.Name = "label8";
            label8.Size = new Size(156, 24);
            label8.TabIndex = 2;
            label8.Text = "Ngày Hết Hạn BH:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(23, 420);
            label6.Name = "label6";
            label6.Size = new Size(142, 24);
            label6.TabIndex = 2;
            label6.Text = "Ngày Bảo Hành:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(23, 242);
            label7.Name = "label7";
            label7.Size = new Size(153, 24);
            label7.TabIndex = 2;
            label7.Text = "Tên Sản Phẩm(*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(19, 197);
            label3.Name = "label3";
            label3.Size = new Size(168, 24);
            label3.TabIndex = 2;
            label3.Text = "Tên Khách Hàng(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(23, 334);
            label5.Name = "label5";
            label5.Size = new Size(138, 24);
            label5.TabIndex = 2;
            label5.Text = "Đơn giá bán(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(16, 150);
            label2.Name = "label2";
            label2.Size = new Size(174, 24);
            label2.TabIndex = 2;
            label2.Text = "Nhân Viên Nhập(*):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(112, 23);
            label11.Name = "label11";
            label11.Size = new Size(239, 37);
            label11.TabIndex = 2;
            label11.Text = "Thông Tin Chi Tiết";
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
            // cboKhachHang
            // 
            cboKhachHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhachHang.Font = new Font("Calibri", 12F);
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboKhachHang.Location = new Point(197, 189);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(260, 32);
            cboKhachHang.TabIndex = 1;
            // 
            // txtNgayHetHan
            // 
            txtNgayHetHan.Font = new Font("Calibri", 12F);
            txtNgayHetHan.Location = new Point(197, 459);
            txtNgayHetHan.Name = "txtNgayHetHan";
            txtNgayHetHan.Size = new Size(260, 32);
            txtNgayHetHan.TabIndex = 0;
            // 
            // txtNgayKichHoat
            // 
            txtNgayKichHoat.Font = new Font("Calibri", 12F);
            txtNgayKichHoat.Location = new Point(197, 417);
            txtNgayKichHoat.Name = "txtNgayKichHoat";
            txtNgayKichHoat.ReadOnly = true;
            txtNgayKichHoat.Size = new Size(260, 32);
            txtNgayKichHoat.TabIndex = 0;
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Calibri", 12F);
            txtTenSP.Location = new Point(197, 239);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.ReadOnly = true;
            txtTenSP.Size = new Size(260, 32);
            txtTenSP.TabIndex = 0;
            // 
            // txtNhanVienNhap
            // 
            txtNhanVienNhap.Font = new Font("Calibri", 12F);
            txtNhanVienNhap.Location = new Point(197, 147);
            txtNhanVienNhap.Name = "txtNhanVienNhap";
            txtNhanVienNhap.ReadOnly = true;
            txtNhanVienNhap.Size = new Size(260, 32);
            txtNhanVienNhap.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Calibri", 12F);
            txtID.Location = new Point(194, 95);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(260, 32);
            txtID.TabIndex = 0;
            // 
            // InHoaDon
            // 
            InHoaDon.Cursor = Cursors.Hand;
            InHoaDon.Image = Properties.Resources.print;
            InHoaDon.Location = new Point(673, 38);
            InHoaDon.Name = "InHoaDon";
            InHoaDon.Size = new Size(100, 71);
            InHoaDon.SizeMode = PictureBoxSizeMode.Zoom;
            InHoaDon.TabIndex = 5;
            InHoaDon.TabStop = false;
            toolTip1.SetToolTip(InHoaDon, "In chi tiết hóa đơn...");
            InHoaDon.Click += InHoaDon_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightSkyBlue;
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(picThemSanPham);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(numDonGia);
            groupBox1.Controls.Add(numSoLuong);
            groupBox1.Controls.Add(cboTenSanPham);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(0, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 85);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết hóa đơn";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(601, 23);
            label14.Name = "label14";
            label14.Size = new Size(133, 24);
            label14.TabIndex = 2;
            label14.Text = "Đơn giá bán(*)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(471, 22);
            label13.Name = "label13";
            label13.Size = new Size(106, 24);
            label13.TabIndex = 2;
            label13.Text = "Số lượng(*)";
            // 
            // picThemSanPham
            // 
            picThemSanPham.Cursor = Cursors.Hand;
            picThemSanPham.Image = Properties.Resources.add;
            picThemSanPham.Location = new Point(353, 52);
            picThemSanPham.Name = "picThemSanPham";
            picThemSanPham.Size = new Size(55, 27);
            picThemSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            picThemSanPham.TabIndex = 0;
            picThemSanPham.TabStop = false;
            toolTip1.SetToolTip(picThemSanPham, "Thêm sản phẩm mới");
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 27);
            label12.Name = "label12";
            label12.Size = new Size(114, 24);
            label12.TabIndex = 2;
            label12.Text = "Sản Phẩm(*)";
            // 
            // numDonGia
            // 
            numDonGia.Location = new Point(601, 52);
            numDonGia.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(172, 32);
            numDonGia.TabIndex = 1;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(471, 50);
            numSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(91, 32);
            numSoLuong.TabIndex = 1;
            // 
            // cboTenSanPham
            // 
            cboTenSanPham.FormattingEnabled = true;
            cboTenSanPham.Location = new Point(12, 50);
            cboTenSanPham.Name = "cboTenSanPham";
            cboTenSanPham.Size = new Size(335, 32);
            cboTenSanPham.TabIndex = 0;
            cboTenSanPham.SelectedIndexChanged += cboTenSanPham_SelectedIndexChanged;
            // 
            // picXoa
            // 
            picXoa.Cursor = Cursors.Hand;
            picXoa.Image = Properties.Resources.delete;
            picXoa.Location = new Point(353, 38);
            picXoa.Name = "picXoa";
            picXoa.Size = new Size(100, 71);
            picXoa.SizeMode = PictureBoxSizeMode.Zoom;
            picXoa.TabIndex = 0;
            picXoa.TabStop = false;
            toolTip1.SetToolTip(picXoa, "Xóa chi tiết hóa đơn..");
            picXoa.Click += picXoa_Click;
            // 
            // dgvChiTietHDB
            // 
            dgvChiTietHDB.AllowUserToAddRows = false;
            dgvChiTietHDB.AllowUserToDeleteRows = false;
            dgvChiTietHDB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvChiTietHDB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHDB.Columns.AddRange(new DataGridViewColumn[] { colID, colSanPhamID, colTenSanPham, colSoLuong, colDonGia, colThanhTien });
            dgvChiTietHDB.Location = new Point(0, 239);
            dgvChiTietHDB.MultiSelect = false;
            dgvChiTietHDB.Name = "dgvChiTietHDB";
            dgvChiTietHDB.RowHeadersWidth = 51;
            dgvChiTietHDB.RowTemplate.Height = 35;
            dgvChiTietHDB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietHDB.Size = new Size(826, 502);
            dgvChiTietHDB.TabIndex = 12;
            toolTip1.SetToolTip(dgvChiTietHDB, "Hỗ trợ quét mã vạch để nhập nhanh IMEI");
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colSanPhamID
            // 
            colSanPhamID.DataPropertyName = "SanPhamID";
            colSanPhamID.HeaderText = "maSP";
            colSanPhamID.MinimumWidth = 6;
            colSanPhamID.Name = "colSanPhamID";
            colSanPhamID.Visible = false;
            // 
            // colTenSanPham
            // 
            colTenSanPham.DataPropertyName = "TenSanPham";
            colTenSanPham.HeaderText = "Tên Sản Phẩm";
            colTenSanPham.MinimumWidth = 6;
            colTenSanPham.Name = "colTenSanPham";
            // 
            // colSoLuong
            // 
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số Lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colDonGia
            // 
            colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle5.Format = "#,##0";
            colDonGia.DefaultCellStyle = dataGridViewCellStyle5;
            colDonGia.HeaderText = "Đơn Giá Bán";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.Format = "#,##0";
            colThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            colThanhTien.HeaderText = "Thành Tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.BackColor = Color.DeepSkyBlue;
            groupBox.Controls.Add(InHoaDon);
            groupBox.Controls.Add(picLuu);
            groupBox.Controls.Add(picXoa);
            groupBox.Controls.Add(picSua);
            groupBox.Controls.Add(picThem);
            groupBox.Location = new Point(0, 1);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(826, 151);
            groupBox.TabIndex = 8;
            groupBox.TabStop = false;
            // 
            // picSua
            // 
            picSua.Cursor = Cursors.Hand;
            picSua.Image = Properties.Resources.edit;
            picSua.Location = new Point(185, 38);
            picSua.Name = "picSua";
            picSua.Size = new Size(100, 71);
            picSua.SizeMode = PictureBoxSizeMode.Zoom;
            picSua.TabIndex = 0;
            picSua.TabStop = false;
            toolTip1.SetToolTip(picSua, "Sửa Chi tiết hóa đơn..");
            picSua.Click += picSua_Click;
            // 
            // picThem
            // 
            picThem.Cursor = Cursors.Hand;
            picThem.Image = Properties.Resources.shopping_cart;
            picThem.Location = new Point(20, 38);
            picThem.Name = "picThem";
            picThem.Size = new Size(100, 71);
            picThem.SizeMode = PictureBoxSizeMode.Zoom;
            picThem.TabIndex = 0;
            picThem.TabStop = false;
            toolTip1.SetToolTip(picThem, "Thêm sản phẩm...");
            picThem.Click += picThem_Click;
            // 
            // frmChiTietHoaDonBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 742);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dgvChiTietHDB);
            Controls.Add(groupBox);
            Name = "frmChiTietHoaDonBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi Tiết Hóa Đơn Bán";
            Load += frmChiTietHoaDonBan_Load;
            ((System.ComponentModel.ISupportInitialize)picLuu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).EndInit();
            ((System.ComponentModel.ISupportInitialize)InHoaDon).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picThemSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHDB).EndInit();
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picLuu;
        private GroupBox groupBox2;
        private PictureBox picTimKiem;
        private TextBox txtTimKiem;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private NumericUpDown numThanhTien;
        private NumericUpDown numDonGiaBan;
        private NumericUpDown numSoLuongBan;
        private PictureBox picThoat;
        private PictureBox picHuyBo;
        private Label label4;
        private Label label9;
        private Label label7;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label11;
        private Label label1;
        private ComboBox cboKhachHang;
        private TextBox txtTenSP;
        private TextBox txtNhanVienNhap;
        private TextBox txtID;
        private PictureBox InHoaDon;
        private GroupBox groupBox1;
        private Label label14;
        private Label label13;
        private PictureBox picThemSanPham;
        private Label label12;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboTenSanPham;
        private PictureBox picXoa;
        private DataGridView dgvChiTietHDB;
        private GroupBox groupBox;
        private PictureBox picSua;
        private PictureBox picThem;
        private Label label8;
        private Label label6;
        private TextBox txtNgayHetHan;
        private TextBox txtNgayKichHoat;
        private ToolTip toolTip1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSanPhamID;
        private DataGridViewTextBoxColumn colTenSanPham;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
    }
}