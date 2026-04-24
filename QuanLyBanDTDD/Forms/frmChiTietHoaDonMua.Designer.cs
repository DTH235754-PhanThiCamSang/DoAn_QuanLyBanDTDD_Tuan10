namespace QuanLyBanDTDD.Forms
{
    partial class frmChiTietHoaDonMua
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
            picThoat = new PictureBox();
            picHuyBo = new PictureBox();
            label4 = new Label();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            dgvChiTietHDM = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colSanPhamID = new DataGridViewTextBoxColumn();
            colTenSanPham = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            groupBox = new GroupBox();
            picInHoaDon = new PictureBox();
            picLuu = new PictureBox();
            picXoa = new PictureBox();
            picSua = new PictureBox();
            picThem = new PictureBox();
            txtTenSP = new TextBox();
            groupBox2 = new GroupBox();
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            textBox2 = new TextBox();
            txtNhanVienNhap = new TextBox();
            txtID = new TextBox();
            groupBox3 = new GroupBox();
            numThanhTien = new NumericUpDown();
            numDonGiaMua = new NumericUpDown();
            numSoLuongMua = new NumericUpDown();
            groupBox1 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            picThemSanPham = new PictureBox();
            label12 = new Label();
            numDonGia = new NumericUpDown();
            numSoLuong = new NumericUpDown();
            cboTenSanPham = new ComboBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHDM).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThem).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaMua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongMua).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picThemSanPham).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // picThoat
            // 
            picThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(311, 504);
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
            picHuyBo.Location = new Point(17, 504);
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
            label4.Location = new Point(17, 362);
            label4.Name = "label4";
            label4.Size = new Size(109, 24);
            label4.TabIndex = 2;
            label4.Text = "Thành Tiền:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.Location = new Point(17, 247);
            label9.Name = "label9";
            label9.Size = new Size(114, 24);
            label9.TabIndex = 2;
            label9.Text = "Số Lượng(*):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(17, 199);
            label7.Name = "label7";
            label7.Size = new Size(153, 24);
            label7.TabIndex = 2;
            label7.Text = "Tên Sản Phẩm(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(17, 308);
            label5.Name = "label5";
            label5.Size = new Size(153, 24);
            label5.TabIndex = 2;
            label5.Text = "Đơn Giá nhập(*):";
            // 
            // dgvChiTietHDM
            // 
            dgvChiTietHDM.AllowUserToAddRows = false;
            dgvChiTietHDM.AllowUserToDeleteRows = false;
            dgvChiTietHDM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHDM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHDM.Columns.AddRange(new DataGridViewColumn[] { colID, colSanPhamID, colTenSanPham, colSoLuong, colDonGia, colThanhTien });
            dgvChiTietHDM.Location = new Point(0, 239);
            dgvChiTietHDM.MultiSelect = false;
            dgvChiTietHDM.Name = "dgvChiTietHDM";
            dgvChiTietHDM.RowHeadersWidth = 51;
            dgvChiTietHDM.RowTemplate.Height = 35;
            dgvChiTietHDM.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietHDM.Size = new Size(826, 502);
            dgvChiTietHDM.TabIndex = 7;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            colID.Visible = false;
            // 
            // colSanPhamID
            // 
            colSanPhamID.DataPropertyName = "SanPhamID";
            colSanPhamID.HeaderText = "Ma SP";
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
            dataGridViewCellStyle1.Format = "#,##0";
            colDonGia.DefaultCellStyle = dataGridViewCellStyle1;
            colDonGia.HeaderText = "Đơn Giá Nhập";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            colThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Lime;
            dataGridViewCellStyle2.Format = "#,##0";
            colThanhTien.DefaultCellStyle = dataGridViewCellStyle2;
            colThanhTien.HeaderText = "Thành Tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(13, 147);
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
            // groupBox
            // 
            groupBox.BackColor = Color.DeepSkyBlue;
            groupBox.Controls.Add(picInHoaDon);
            groupBox.Controls.Add(picLuu);
            groupBox.Controls.Add(picXoa);
            groupBox.Controls.Add(picSua);
            groupBox.Controls.Add(picThem);
            groupBox.Location = new Point(0, 1);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(826, 151);
            groupBox.TabIndex = 4;
            groupBox.TabStop = false;
            // 
            // picInHoaDon
            // 
            picInHoaDon.Cursor = Cursors.Hand;
            picInHoaDon.Image = Properties.Resources.print;
            picInHoaDon.Location = new Point(673, 38);
            picInHoaDon.Name = "picInHoaDon";
            picInHoaDon.Size = new Size(100, 71);
            picInHoaDon.SizeMode = PictureBoxSizeMode.Zoom;
            picInHoaDon.TabIndex = 5;
            picInHoaDon.TabStop = false;
            toolTip1.SetToolTip(picInHoaDon, "In hóa đơn chi tiết hóa đơn mua");
            picInHoaDon.Click += InHoaDon_Click;
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
            toolTip1.SetToolTip(picLuu, "Lưu trang sản phẩm mua vào");
            picLuu.Click += picLuu_Click;
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
            toolTip1.SetToolTip(picXoa, "Xóa trang sản phẩm mua vào");
            picXoa.Click += picXoa_Click;
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
            toolTip1.SetToolTip(picSua, "Sửa trang sản phẩm mua vào");
            picSua.Click += picSua_Click;
            // 
            // picThem
            // 
            picThem.Cursor = Cursors.Hand;
            picThem.Image = Properties.Resources.add;
            picThem.Location = new Point(20, 38);
            picThem.Name = "picThem";
            picThem.Size = new Size(100, 71);
            picThem.SizeMode = PictureBoxSizeMode.Zoom;
            picThem.TabIndex = 0;
            picThem.TabStop = false;
            toolTip1.SetToolTip(picThem, "Thêm trang sản phẩm mua vào");
            picThem.Click += picThem_Click;
            // 
            // txtTenSP
            // 
            txtTenSP.Font = new Font("Calibri", 12F);
            txtTenSP.Location = new Point(185, 196);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.ReadOnly = true;
            txtTenSP.Size = new Size(237, 32);
            txtTenSP.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DeepSkyBlue;
            groupBox2.Controls.Add(picTimKiem);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(826, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 151);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(388, 62);
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
            txtTimKiem.PlaceholderText = "Nhập tên hoặc SĐT đề tìm kiếm...";
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
            // txtNhanVienNhap
            // 
            txtNhanVienNhap.Font = new Font("Calibri", 12F);
            txtNhanVienNhap.Location = new Point(185, 144);
            txtNhanVienNhap.Name = "txtNhanVienNhap";
            txtNhanVienNhap.ReadOnly = true;
            txtNhanVienNhap.Size = new Size(237, 32);
            txtNhanVienNhap.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Calibri", 12F);
            txtID.Location = new Point(185, 95);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(237, 32);
            txtID.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(numThanhTien);
            groupBox3.Controls.Add(numDonGiaMua);
            groupBox3.Controls.Add(numSoLuongMua);
            groupBox3.Controls.Add(picThoat);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtTenSP);
            groupBox3.Controls.Add(txtNhanVienNhap);
            groupBox3.Controls.Add(txtID);
            groupBox3.Location = new Point(828, 156);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 586);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // numThanhTien
            // 
            numThanhTien.Font = new Font("Calibri", 12F);
            numThanhTien.Location = new Point(185, 357);
            numThanhTien.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numThanhTien.Name = "numThanhTien";
            numThanhTien.ReadOnly = true;
            numThanhTien.Size = new Size(237, 32);
            numThanhTien.TabIndex = 5;
            numThanhTien.ValueChanged += numThanhTien_ValueChanged;
            // 
            // numDonGiaMua
            // 
            numDonGiaMua.Font = new Font("Calibri", 12F);
            numDonGiaMua.Location = new Point(185, 304);
            numDonGiaMua.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaMua.Name = "numDonGiaMua";
            numDonGiaMua.ReadOnly = true;
            numDonGiaMua.Size = new Size(237, 32);
            numDonGiaMua.TabIndex = 5;
            // 
            // numSoLuongMua
            // 
            numSoLuongMua.Font = new Font("Calibri", 12F);
            numSoLuongMua.Location = new Point(185, 247);
            numSoLuongMua.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numSoLuongMua.Name = "numSoLuongMua";
            numSoLuongMua.ReadOnly = true;
            numSoLuongMua.Size = new Size(237, 32);
            numSoLuongMua.TabIndex = 5;
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
            groupBox1.Location = new Point(0, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 85);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chi tiết hóa đơn";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 12F);
            label14.Location = new Point(598, 28);
            label14.Name = "label14";
            label14.Size = new Size(144, 24);
            label14.TabIndex = 2;
            label14.Text = "Đơn giá nhập(*)";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F);
            label13.Location = new Point(388, 23);
            label13.Name = "label13";
            label13.Size = new Size(106, 24);
            label13.TabIndex = 2;
            label13.Text = "Số lượng(*)";
            // 
            // picThemSanPham
            // 
            picThemSanPham.Cursor = Cursors.Hand;
            picThemSanPham.Image = Properties.Resources.add;
            picThemSanPham.Location = new Point(304, 52);
            picThemSanPham.Name = "picThemSanPham";
            picThemSanPham.Size = new Size(55, 27);
            picThemSanPham.SizeMode = PictureBoxSizeMode.Zoom;
            picThemSanPham.TabIndex = 0;
            picThemSanPham.TabStop = false;
            toolTip1.SetToolTip(picThemSanPham, "Thêm sản phẩm bên trang sản phẩm");
            picThemSanPham.Click += picThemSanPham_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F);
            label12.Location = new Point(12, 27);
            label12.Name = "label12";
            label12.Size = new Size(114, 24);
            label12.TabIndex = 2;
            label12.Text = "Sản Phẩm(*)";
            // 
            // numDonGia
            // 
            numDonGia.Font = new Font("Calibri", 12F);
            numDonGia.Location = new Point(598, 51);
            numDonGia.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numDonGia.Name = "numDonGia";
            numDonGia.Size = new Size(200, 32);
            numDonGia.TabIndex = 1;
            // 
            // numSoLuong
            // 
            numSoLuong.Font = new Font("Calibri", 12F);
            numSoLuong.Location = new Point(388, 51);
            numSoLuong.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 32);
            numSoLuong.TabIndex = 1;
            // 
            // cboTenSanPham
            // 
            cboTenSanPham.Font = new Font("Calibri", 12F);
            cboTenSanPham.FormattingEnabled = true;
            cboTenSanPham.Location = new Point(12, 50);
            cboTenSanPham.Name = "cboTenSanPham";
            cboTenSanPham.Size = new Size(273, 32);
            cboTenSanPham.TabIndex = 0;
            cboTenSanPham.SelectionChangeCommitted += cboTenSanPham_SelectionChangeCommitted;
            // 
            // frmChiTietHoaDonMua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 742);
            Controls.Add(dgvChiTietHDM);
            Controls.Add(groupBox1);
            Controls.Add(groupBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "frmChiTietHoaDonMua";
            Text = "frmChiTietHoaDonMua";
            Load += frmChiTietHoaDonMua_Load;
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHDM).EndInit();
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picInHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picXoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSua).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThem).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numThanhTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaMua).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuongMua).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picThemSanPham).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picThoat;
        private PictureBox picHuyBo;
        private Label label4;
        private Label label9;
        private Label label7;
        private Label label5;
        private DataGridView dgvChiTietHDM;
        private Label label2;
        private Label label11;
        private Label label1;
        private GroupBox groupBox;
        private PictureBox picLuu;
        private PictureBox picXoa;
        private PictureBox picSua;
        private PictureBox picThem;
        private TextBox txtTenSP;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox txtNhanVienNhap;
        private TextBox txtID;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Label label12;
        private NumericUpDown numDonGia;
        private NumericUpDown numSoLuong;
        private ComboBox cboTenSanPham;
        private Label label14;
        private Label label13;
        private PictureBox picThemSanPham;
        private PictureBox picInHoaDon;
        private NumericUpDown numSoLuongMua;
        private NumericUpDown numThanhTien;
        private NumericUpDown numDonGiaMua;
        private PictureBox picTimKiem;
        private TextBox txtTimKiem;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSanPhamID;
        private DataGridViewTextBoxColumn colTenSanPham;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private ToolTip toolTip1;
    }
}