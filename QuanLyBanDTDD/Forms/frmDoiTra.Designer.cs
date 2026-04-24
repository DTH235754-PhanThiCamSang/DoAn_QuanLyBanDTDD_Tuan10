namespace QuanLyBanDTDD.Forms
{
    partial class frmDoiTra
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            picLuu = new PictureBox();
            txtTenKhachHang = new TextBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            cboDanhSachIMEI = new ComboBox();
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            picXoa = new PictureBox();
            picXuLyDoiTra = new PictureBox();
            groupBox = new GroupBox();
            picSua = new PictureBox();
            label5 = new Label();
            txtSoDienThoai = new TextBox();
            label7 = new Label();
            numGiaLucMua = new NumericUpDown();
            dgvDoiTra = new DataGridView();
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
            picThoat = new PictureBox();
            cboHinhThucTra = new ComboBox();
            picHuyBo = new PictureBox();
            datNgayMua = new DateTimePicker();
            Loai = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            label9 = new Label();
            label3 = new Label();
            txtTenSanPham = new TextBox();
            groupBox3 = new GroupBox();
            chkConSeal = new CheckBox();
            numTienHoanTra = new NumericUpDown();
            label13 = new Label();
            numPhuPhi = new NumericUpDown();
            label6 = new Label();
            cboTrangThai = new ComboBox();
            cboHuongXuLy = new ComboBox();
            label8 = new Label();
            label4 = new Label();
            label10 = new Label();
            txtIMEI_HienThi = new TextBox();
            txtLyDo = new TextBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picLuu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXuLyDoiTra).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaLucMua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoiTra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTienHoanTra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPhuPhi).BeginInit();
            SuspendLayout();
            // 
            // picLuu
            // 
            picLuu.Cursor = Cursors.Hand;
            picLuu.Image = Properties.Resources.save;
            picLuu.Location = new Point(586, 26);
            picLuu.Name = "picLuu";
            picLuu.Size = new Size(100, 71);
            picLuu.SizeMode = PictureBoxSizeMode.Zoom;
            picLuu.TabIndex = 0;
            picLuu.TabStop = false;
            picLuu.Tag = "";
            toolTip1.SetToolTip(picLuu, "Lưu đổi trả");
            picLuu.Click += picLuu_Click;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Calibri", 12F);
            txtTenKhachHang.Location = new Point(153, 106);
            txtTenKhachHang.Multiline = true;
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.ReadOnly = true;
            txtTenKhachHang.Size = new Size(201, 31);
            txtTenKhachHang.TabIndex = 11;
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
            groupBox2.Controls.Add(cboDanhSachIMEI);
            groupBox2.Controls.Add(picTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(826, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 149);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            // 
            // cboDanhSachIMEI
            // 
            cboDanhSachIMEI.Font = new Font("Calibri", 12F);
            cboDanhSachIMEI.FormattingEnabled = true;
            cboDanhSachIMEI.Location = new Point(6, 83);
            cboDanhSachIMEI.Name = "cboDanhSachIMEI";
            cboDanhSachIMEI.Size = new Size(380, 32);
            cboDanhSachIMEI.TabIndex = 21;
            cboDanhSachIMEI.Visible = false;
            cboDanhSachIMEI.SelectedIndexChanged += cboDanhSachIMEI_SelectedIndexChanged;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(383, 26);
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
            // picXoa
            // 
            picXoa.Cursor = Cursors.Hand;
            picXoa.Image = Properties.Resources.delete;
            picXoa.Location = new Point(397, 26);
            picXoa.Name = "picXoa";
            picXoa.Size = new Size(100, 71);
            picXoa.SizeMode = PictureBoxSizeMode.Zoom;
            picXoa.TabIndex = 0;
            picXoa.TabStop = false;
            picXoa.Tag = "";
            toolTip1.SetToolTip(picXoa, "Xóa đổi trả...");
            picXoa.Click += picXoa_Click;
            // 
            // picXuLyDoiTra
            // 
            picXuLyDoiTra.Cursor = Cursors.Hand;
            picXuLyDoiTra.Image = Properties.Resources.add;
            picXuLyDoiTra.Location = new Point(21, 26);
            picXuLyDoiTra.Name = "picXuLyDoiTra";
            picXuLyDoiTra.Size = new Size(100, 71);
            picXuLyDoiTra.SizeMode = PictureBoxSizeMode.Zoom;
            picXuLyDoiTra.TabIndex = 0;
            picXuLyDoiTra.TabStop = false;
            picXuLyDoiTra.Tag = "";
            toolTip1.SetToolTip(picXuLyDoiTra, "Thêm trang đổi trả...");
            picXuLyDoiTra.Click += picXuLyDoiTra_Click;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.BackColor = Color.DeepSkyBlue;
            groupBox.Controls.Add(picLuu);
            groupBox.Controls.Add(picXoa);
            groupBox.Controls.Add(picSua);
            groupBox.Controls.Add(picXuLyDoiTra);
            groupBox.Controls.Add(txtTenKhachHang);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(txtSoDienThoai);
            groupBox.Controls.Add(label7);
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(835, 149);
            groupBox.TabIndex = 20;
            groupBox.TabStop = false;
            // 
            // picSua
            // 
            picSua.Cursor = Cursors.Hand;
            picSua.Image = Properties.Resources.edit;
            picSua.Location = new Point(207, 26);
            picSua.Name = "picSua";
            picSua.Size = new Size(100, 71);
            picSua.SizeMode = PictureBoxSizeMode.Zoom;
            picSua.TabIndex = 0;
            picSua.TabStop = false;
            picSua.Tag = "";
            toolTip1.SetToolTip(picSua, "Sửa trang đổi trả...");
            picSua.Click += picSua_Click;
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
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Calibri", 12F);
            txtSoDienThoai.Location = new Point(521, 106);
            txtSoDienThoai.Multiline = true;
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.ReadOnly = true;
            txtSoDienThoai.Size = new Size(221, 31);
            txtSoDienThoai.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(377, 115);
            label7.Name = "label7";
            label7.Size = new Size(126, 24);
            label7.TabIndex = 15;
            label7.Text = "Số điện thoại:";
            // 
            // numGiaLucMua
            // 
            numGiaLucMua.Enabled = false;
            numGiaLucMua.Font = new Font("Calibri", 12F);
            numGiaLucMua.Location = new Point(142, 190);
            numGiaLucMua.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numGiaLucMua.Name = "numGiaLucMua";
            numGiaLucMua.Size = new Size(291, 32);
            numGiaLucMua.TabIndex = 28;
            // 
            // dgvDoiTra
            // 
            dgvDoiTra.AllowUserToAddRows = false;
            dgvDoiTra.AllowUserToDeleteRows = false;
            dgvDoiTra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoiTra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvDoiTra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoiTra.Columns.AddRange(new DataGridViewColumn[] { colID, colSoIMEI, colTenSanPham, colTenKhachHang, colNgayNhan, colNgayTraDuKien, colLoiKhachBao, colPhanLoai, colTrangThai, colChiPhi, colGhiChu });
            dgvDoiTra.Location = new Point(0, 148);
            dgvDoiTra.MultiSelect = false;
            dgvDoiTra.Name = "dgvDoiTra";
            dgvDoiTra.RowHeadersWidth = 51;
            dgvDoiTra.RowTemplate.Height = 35;
            dgvDoiTra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoiTra.Size = new Size(826, 587);
            dgvDoiTra.TabIndex = 21;
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
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            colNgayNhan.DefaultCellStyle = dataGridViewCellStyle4;
            colNgayNhan.HeaderText = "Ngày Nhận";
            colNgayNhan.MinimumWidth = 6;
            colNgayNhan.Name = "colNgayNhan";
            colNgayNhan.Width = 103;
            // 
            // colNgayTraDuKien
            // 
            colNgayTraDuKien.DataPropertyName = "NgayTraDuKien";
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            colNgayTraDuKien.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0";
            colChiPhi.DefaultCellStyle = dataGridViewCellStyle6;
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
            // picThoat
            // 
            picThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(362, 519);
            picThoat.Name = "picThoat";
            picThoat.Size = new Size(71, 67);
            picThoat.SizeMode = PictureBoxSizeMode.Zoom;
            picThoat.TabIndex = 25;
            picThoat.TabStop = false;
            picThoat.Tag = "";
            toolTip1.SetToolTip(picThoat, "Thoát Form");
            picThoat.Click += picThoat_Click;
            // 
            // cboHinhThucTra
            // 
            cboHinhThucTra.Font = new Font("Calibri", 12F);
            cboHinhThucTra.FormattingEnabled = true;
            cboHinhThucTra.Items.AddRange(new object[] { "Trả hàng hoàn tiền", "Đổi máy lỗi NSX" });
            cboHinhThucTra.Location = new Point(142, 235);
            cboHinhThucTra.Name = "cboHinhThucTra";
            cboHinhThucTra.Size = new Size(291, 32);
            cboHinhThucTra.TabIndex = 19;
            cboHinhThucTra.SelectedIndexChanged += cboHinhThuc_SelectedIndexChanged;
            // 
            // picHuyBo
            // 
            picHuyBo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picHuyBo.Cursor = Cursors.Hand;
            picHuyBo.Image = Properties.Resources.cancel;
            picHuyBo.Location = new Point(12, 513);
            picHuyBo.Name = "picHuyBo";
            picHuyBo.Size = new Size(70, 67);
            picHuyBo.SizeMode = PictureBoxSizeMode.Zoom;
            picHuyBo.TabIndex = 24;
            picHuyBo.TabStop = false;
            picHuyBo.Tag = "";
            toolTip1.SetToolTip(picHuyBo, "Hủy mọi thao tác đang làm...");
            picHuyBo.Click += picHuyBo_Click;
            // 
            // datNgayMua
            // 
            datNgayMua.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datNgayMua.Font = new Font("Calibri", 12F);
            datNgayMua.Format = DateTimePickerFormat.Short;
            datNgayMua.Location = new Point(142, 154);
            datNgayMua.Name = "datNgayMua";
            datNgayMua.Size = new Size(291, 32);
            datNgayMua.TabIndex = 18;
            // 
            // Loai
            // 
            Loai.AutoSize = true;
            Loai.Font = new Font("Calibri", 12F);
            Loai.Location = new Point(4, 235);
            Loai.Name = "Loai";
            Loai.Size = new Size(131, 24);
            Loai.TabIndex = 2;
            Loai.Text = "Hình Thức Trả:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(7, 154);
            label2.Name = "label2";
            label2.Size = new Size(106, 24);
            label2.TabIndex = 2;
            label2.Text = "Ngày Nhận:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(52, 10);
            label11.Name = "label11";
            label11.Size = new Size(387, 37);
            label11.TabIndex = 2;
            label11.Text = "Thông Tin Sản Phẩm Hoàn Trả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(7, 113);
            label1.Name = "label1";
            label1.Size = new Size(131, 24);
            label1.TabIndex = 2;
            label1.Text = "Tên Sản Phẩm:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.Location = new Point(7, 190);
            label9.Name = "label9";
            label9.Size = new Size(118, 24);
            label9.TabIndex = 16;
            label9.Text = "Giá Lúc Mua:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(7, 334);
            label3.Name = "label3";
            label3.Size = new Size(59, 24);
            label3.TabIndex = 16;
            label3.Text = "Lý Do:";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Calibri", 12F);
            txtTenSanPham.Location = new Point(142, 110);
            txtTenSanPham.Multiline = true;
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.ReadOnly = true;
            txtTenSanPham.Size = new Size(291, 37);
            txtTenSanPham.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(chkConSeal);
            groupBox3.Controls.Add(numTienHoanTra);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(numPhuPhi);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(numGiaLucMua);
            groupBox3.Controls.Add(picThoat);
            groupBox3.Controls.Add(cboTrangThai);
            groupBox3.Controls.Add(cboHuongXuLy);
            groupBox3.Controls.Add(cboHinhThucTra);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(datNgayMua);
            groupBox3.Controls.Add(Loai);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(txtIMEI_HienThi);
            groupBox3.Controls.Add(txtTenSanPham);
            groupBox3.Controls.Add(txtLyDo);
            groupBox3.Location = new Point(828, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 586);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            // 
            // chkConSeal
            // 
            chkConSeal.AutoSize = true;
            chkConSeal.BackColor = Color.White;
            chkConSeal.Font = new Font("Calibri", 12F);
            chkConSeal.Location = new Point(145, 490);
            chkConSeal.Name = "chkConSeal";
            chkConSeal.Size = new Size(191, 28);
            chkConSeal.TabIndex = 35;
            chkConSeal.Text = "Sản Phẩm Còn Seal";
            chkConSeal.UseVisualStyleBackColor = false;
            chkConSeal.CheckedChanged += chkConSeal_CheckedChanged;
            // 
            // numTienHoanTra
            // 
            numTienHoanTra.Enabled = false;
            numTienHoanTra.Font = new Font("Calibri", 12F);
            numTienHoanTra.Location = new Point(142, 368);
            numTienHoanTra.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numTienHoanTra.Name = "numTienHoanTra";
            numTienHoanTra.Size = new Size(291, 32);
            numTienHoanTra.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F);
            label13.Location = new Point(7, 368);
            label13.Name = "label13";
            label13.Size = new Size(131, 24);
            label13.TabIndex = 33;
            label13.Text = "Tiền Hoàn Trả:";
            // 
            // numPhuPhi
            // 
            numPhuPhi.Font = new Font("Calibri", 12F);
            numPhuPhi.Location = new Point(142, 277);
            numPhuPhi.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            numPhuPhi.Name = "numPhuPhi";
            numPhuPhi.Size = new Size(291, 32);
            numPhuPhi.TabIndex = 32;
            numPhuPhi.ValueChanged += numPhuPhi_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F);
            label6.Location = new Point(12, 277);
            label6.Name = "label6";
            label6.Size = new Size(78, 24);
            label6.TabIndex = 31;
            label6.Text = "Phụ Phí:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.Font = new Font("Calibri", 12F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đã xử lý", "Đang xử lý" });
            cboTrangThai.Location = new Point(142, 442);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(291, 32);
            cboTrangThai.TabIndex = 19;
            // 
            // cboHuongXuLy
            // 
            cboHuongXuLy.Font = new Font("Calibri", 12F);
            cboHuongXuLy.FormattingEnabled = true;
            cboHuongXuLy.Items.AddRange(new object[] { "Trả hàng hoàn tiền", "Đổi máy lỗi NSX" });
            cboHuongXuLy.Location = new Point(142, 404);
            cboHuongXuLy.Name = "cboHuongXuLy";
            cboHuongXuLy.Size = new Size(291, 32);
            cboHuongXuLy.TabIndex = 19;
            cboHuongXuLy.SelectedIndexChanged += cboHuongXuLy_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(12, 442);
            label8.Name = "label8";
            label8.Size = new Size(127, 62);
            label8.TabIndex = 2;
            label8.Text = "Trạng Thái Xử Lý:";
            // 
            // label4
            // 
            label4.Font = new Font("Calibri", 12F);
            label4.Location = new Point(4, 392);
            label4.Name = "label4";
            label4.Size = new Size(127, 62);
            label4.TabIndex = 2;
            label4.Text = "Hướng Xử Lý Sản Phẩm Trả:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F);
            label10.Location = new Point(7, 70);
            label10.Name = "label10";
            label10.Size = new Size(77, 24);
            label10.TabIndex = 2;
            label10.Text = "Số IMEI:";
            // 
            // txtIMEI_HienThi
            // 
            txtIMEI_HienThi.Font = new Font("Calibri", 12F);
            txtIMEI_HienThi.Location = new Point(142, 67);
            txtIMEI_HienThi.Multiline = true;
            txtIMEI_HienThi.Name = "txtIMEI_HienThi";
            txtIMEI_HienThi.ReadOnly = true;
            txtIMEI_HienThi.Size = new Size(291, 37);
            txtIMEI_HienThi.TabIndex = 0;
            txtIMEI_HienThi.TextChanged += textBox1_TextChanged;
            // 
            // txtLyDo
            // 
            txtLyDo.Font = new Font("Calibri", 12F);
            txtLyDo.Location = new Point(142, 313);
            txtLyDo.Multiline = true;
            txtLyDo.Name = "txtLyDo";
            txtLyDo.ScrollBars = ScrollBars.Both;
            txtLyDo.Size = new Size(291, 49);
            txtLyDo.TabIndex = 11;
            // 
            // frmDoiTra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 742);
            Controls.Add(groupBox2);
            Controls.Add(groupBox);
            Controls.Add(dgvDoiTra);
            Controls.Add(groupBox3);
            Name = "frmDoiTra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đổi Trả";
            Load += frmDoiTra_Load;
            ((System.ComponentModel.ISupportInitialize)picLuu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXuLyDoiTra).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaLucMua).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDoiTra).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTienHoanTra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPhuPhi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picLuu;
        private TextBox txtTenKhachHang;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private PictureBox picTimKiem;
        private TextBox txtTimKiem;
        private PictureBox picXoa;
        private PictureBox picXuLyDoiTra;
        private GroupBox groupBox;
        private PictureBox picSua;
        private Label label5;
        private TextBox txtSoDienThoai;
        private Label label7;
        private NumericUpDown numGiaLucMua;
        private DataGridView dgvDoiTra;
        private PictureBox picThoat;
        private ComboBox cboHinhThucTra;
        private PictureBox picHuyBo;
        private DateTimePicker datNgayMua;
        private Label Loai;
        private Label label2;
        private Label label11;
        private Label label1;
        private Label label9;
        private Label label3;
        private TextBox txtTenSanPham;
        private GroupBox groupBox3;
        private TextBox txtLyDo;
        private NumericUpDown numPhuPhi;
        private Label label6;
        private NumericUpDown numTienHoanTra;
        private Label label13;
        private CheckBox chkConSeal;
        private ComboBox cboHuongXuLy;
        private Label label4;
        private ComboBox cboTrangThai;
        private Label label8;
        private ComboBox cboDanhSachIMEI;
        private Label label10;
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