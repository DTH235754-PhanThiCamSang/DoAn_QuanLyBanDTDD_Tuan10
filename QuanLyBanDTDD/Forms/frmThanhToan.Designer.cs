namespace QuanLyBanDTDD.Forms
{
    partial class frmThanhToan
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
            picThoat = new PictureBox();
            picHuyBo = new PictureBox();
            txtID = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label11 = new Label();
            label1 = new Label();
            txtTenKhacHang = new TextBox();
            groupBox3 = new GroupBox();
            numTienThua = new NumericUpDown();
            numKhachDua = new NumericUpDown();
            picMaQr = new PictureBox();
            numTongTien = new NumericUpDown();
            cboPhuongThucThanhToan = new ComboBox();
            datNgayThanhToan = new DateTimePicker();
            label7 = new Label();
            label2 = new Label();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            txtTenNhanVien = new TextBox();
            picLuu = new PictureBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            datTimKiem = new DateTimePicker();
            label6 = new Label();
            dgvThanhToan = new DataGridView();
            picSua = new PictureBox();
            groupBox = new GroupBox();
            label12 = new Label();
            picQuetIMEI = new PictureBox();
            InHoaDon = new PictureBox();
            toolTip1 = new ToolTip(components);
            COLSTT = new DataGridViewTextBoxColumn();
            colTenSanPham = new DataGridViewTextBoxColumn();
            colDonGiaBan = new DataGridViewTextBoxColumn();
            colSoIMEI = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)picThoat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTienThua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKhachDua).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picMaQr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTongTien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSua).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQuetIMEI).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InHoaDon).BeginInit();
            SuspendLayout();
            // 
            // picThoat
            // 
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(355, 544);
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
            picHuyBo.Cursor = Cursors.Hand;
            picHuyBo.Image = Properties.Resources.cancel;
            picHuyBo.Location = new Point(7, 544);
            picHuyBo.Name = "picHuyBo";
            picHuyBo.Size = new Size(100, 71);
            picHuyBo.SizeMode = PictureBoxSizeMode.Zoom;
            picHuyBo.TabIndex = 24;
            picHuyBo.TabStop = false;
            toolTip1.SetToolTip(picHuyBo, "Hủy Bỏ Thao Tác");
            picHuyBo.Click += picHuyBo_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("Calibri", 12F);
            txtID.Location = new Point(189, 68);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(226, 37);
            txtID.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F);
            label3.Location = new Point(18, 111);
            label3.Name = "label3";
            label3.Size = new Size(168, 24);
            label3.TabIndex = 15;
            label3.Text = "Tên Khách Hàng(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F);
            label5.Location = new Point(18, 200);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 16;
            label5.Text = "Tổng Tiền:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(112, 23);
            label11.Name = "label11";
            label11.Size = new Size(290, 37);
            label11.TabIndex = 2;
            label11.Text = "Thông Tin Thanh Toán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(18, 71);
            label1.Name = "label1";
            label1.Size = new Size(32, 24);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // txtTenKhacHang
            // 
            txtTenKhacHang.Font = new Font("Calibri", 12F);
            txtTenKhacHang.Location = new Point(189, 111);
            txtTenKhacHang.Multiline = true;
            txtTenKhacHang.Name = "txtTenKhacHang";
            txtTenKhacHang.ReadOnly = true;
            txtTenKhacHang.Size = new Size(226, 37);
            txtTenKhacHang.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(numTienThua);
            groupBox3.Controls.Add(numKhachDua);
            groupBox3.Controls.Add(picMaQr);
            groupBox3.Controls.Add(numTongTien);
            groupBox3.Controls.Add(picThoat);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(cboPhuongThucThanhToan);
            groupBox3.Controls.Add(datNgayThanhToan);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtID);
            groupBox3.Controls.Add(txtTenNhanVien);
            groupBox3.Controls.Add(txtTenKhacHang);
            groupBox3.Location = new Point(828, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 626);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            // 
            // numTienThua
            // 
            numTienThua.Font = new Font("Calibri", 12F);
            numTienThua.Location = new Point(189, 259);
            numTienThua.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            numTienThua.Name = "numTienThua";
            numTienThua.Size = new Size(226, 32);
            numTienThua.TabIndex = 28;
            // 
            // numKhachDua
            // 
            numKhachDua.Font = new Font("Calibri", 12F);
            numKhachDua.Location = new Point(189, 232);
            numKhachDua.Maximum = new decimal(new int[] { -1981284352, -1966660860, 0, 0 });
            numKhachDua.Name = "numKhachDua";
            numKhachDua.Size = new Size(226, 32);
            numKhachDua.TabIndex = 29;
            numKhachDua.ValueChanged += numKhachDua_ValueChanged;
            // 
            // picMaQr
            // 
            picMaQr.Cursor = Cursors.Hand;
            picMaQr.Location = new Point(130, 382);
            picMaQr.Name = "picMaQr";
            picMaQr.Size = new Size(202, 238);
            picMaQr.SizeMode = PictureBoxSizeMode.StretchImage;
            picMaQr.TabIndex = 4;
            picMaQr.TabStop = false;
            picMaQr.Visible = false;
            // 
            // numTongTien
            // 
            numTongTien.Enabled = false;
            numTongTien.Font = new Font("Calibri", 12F);
            numTongTien.Location = new Point(189, 202);
            numTongTien.Maximum = new decimal(new int[] { 1874919424, 2328306, 0, 0 });
            numTongTien.Name = "numTongTien";
            numTongTien.Size = new Size(226, 32);
            numTongTien.TabIndex = 28;
            // 
            // cboPhuongThucThanhToan
            // 
            cboPhuongThucThanhToan.Font = new Font("Calibri", 12F);
            cboPhuongThucThanhToan.FormattingEnabled = true;
            cboPhuongThucThanhToan.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản" });
            cboPhuongThucThanhToan.Location = new Point(189, 292);
            cboPhuongThucThanhToan.Name = "cboPhuongThucThanhToan";
            cboPhuongThucThanhToan.Size = new Size(226, 32);
            cboPhuongThucThanhToan.TabIndex = 19;
            cboPhuongThucThanhToan.SelectedIndexChanged += cboPhuongThucThanhToan_SelectedIndexChanged;
            // 
            // datNgayThanhToan
            // 
            datNgayThanhToan.CalendarFont = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datNgayThanhToan.Font = new Font("Calibri", 12F);
            datNgayThanhToan.Format = DateTimePickerFormat.Short;
            datNgayThanhToan.Location = new Point(189, 330);
            datNgayThanhToan.Name = "datNgayThanhToan";
            datNgayThanhToan.Size = new Size(226, 32);
            datNgayThanhToan.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F);
            label7.Location = new Point(18, 295);
            label7.Name = "label7";
            label7.Size = new Size(173, 24);
            label7.TabIndex = 2;
            label7.Text = "Phương Thức TT(*):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F);
            label2.Location = new Point(18, 330);
            label2.Name = "label2";
            label2.Size = new Size(159, 24);
            label2.TabIndex = 2;
            label2.Text = "Ngày Thanh Toán:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F);
            label8.Location = new Point(18, 153);
            label8.Name = "label8";
            label8.Size = new Size(158, 24);
            label8.TabIndex = 15;
            label8.Text = "Tên Nhân Viên(*):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F);
            label10.Location = new Point(18, 266);
            label10.Name = "label10";
            label10.Size = new Size(99, 24);
            label10.TabIndex = 16;
            label10.Text = "Tiền Thừa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.Location = new Point(18, 233);
            label9.Name = "label9";
            label9.Size = new Size(145, 24);
            label9.TabIndex = 16;
            label9.Text = "Tiền Khách Đưa:";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Calibri", 12F);
            txtTenNhanVien.Location = new Point(189, 153);
            txtTenNhanVien.Multiline = true;
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.ReadOnly = true;
            txtTenNhanVien.Size = new Size(226, 37);
            txtTenNhanVien.TabIndex = 10;
            // 
            // picLuu
            // 
            picLuu.Cursor = Cursors.Hand;
            picLuu.Image = Properties.Resources.save;
            picLuu.Location = new Point(177, 27);
            picLuu.Name = "picLuu";
            picLuu.Size = new Size(99, 88);
            picLuu.SizeMode = PictureBoxSizeMode.Zoom;
            picLuu.TabIndex = 0;
            picLuu.TabStop = false;
            toolTip1.SetToolTip(picLuu, "Lưu Thanh Toán");
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
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            // 
            // picTimKiem
            // 
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(388, 26);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(76, 27);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 19;
            picTimKiem.TabStop = false;
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
            datTimKiem.CalendarFont = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datTimKiem.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datTimKiem.Format = DateTimePickerFormat.Short;
            datTimKiem.Location = new Point(253, 83);
            datTimKiem.Name = "datTimKiem";
            datTimKiem.ShowCheckBox = true;
            datTimKiem.Size = new Size(205, 27);
            datTimKiem.TabIndex = 18;
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
            // dgvThanhToan
            // 
            dgvThanhToan.AllowUserToAddRows = false;
            dgvThanhToan.AllowUserToDeleteRows = false;
            dgvThanhToan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvThanhToan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThanhToan.Columns.AddRange(new DataGridViewColumn[] { COLSTT, colTenSanPham, colDonGiaBan, colSoIMEI });
            dgvThanhToan.Location = new Point(-2, 152);
            dgvThanhToan.MultiSelect = false;
            dgvThanhToan.Name = "dgvThanhToan";
            dgvThanhToan.RowHeadersWidth = 51;
            dgvThanhToan.RowTemplate.Height = 35;
            dgvThanhToan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvThanhToan.Size = new Size(826, 629);
            dgvThanhToan.TabIndex = 17;
            dgvThanhToan.RowPostPaint += dgvThanhToan_RowPostPaint;
            // 
            // picSua
            // 
            picSua.Cursor = Cursors.Hand;
            picSua.Image = Properties.Resources.edit;
            picSua.Location = new Point(17, 27);
            picSua.Name = "picSua";
            picSua.Size = new Size(99, 88);
            picSua.SizeMode = PictureBoxSizeMode.Zoom;
            picSua.TabIndex = 0;
            picSua.TabStop = false;
            toolTip1.SetToolTip(picSua, "Sửa Hóa Đơn");
            picSua.Click += picSua_Click;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.BackColor = Color.DeepSkyBlue;
            groupBox.Controls.Add(label12);
            groupBox.Controls.Add(picQuetIMEI);
            groupBox.Controls.Add(picLuu);
            groupBox.Controls.Add(InHoaDon);
            groupBox.Controls.Add(picSua);
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(835, 151);
            groupBox.TabIndex = 16;
            groupBox.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(551, 33);
            label12.Name = "label12";
            label12.Size = new Size(95, 20);
            label12.TabIndex = 5;
            label12.Text = "QUÉT IMEI(*)";
            // 
            // picQuetIMEI
            // 
            picQuetIMEI.Cursor = Cursors.Hand;
            picQuetIMEI.Image = Properties.Resources.qr_code;
            picQuetIMEI.Location = new Point(682, 27);
            picQuetIMEI.Name = "picQuetIMEI";
            picQuetIMEI.Size = new Size(112, 88);
            picQuetIMEI.SizeMode = PictureBoxSizeMode.Zoom;
            picQuetIMEI.TabIndex = 4;
            picQuetIMEI.TabStop = false;
            toolTip1.SetToolTip(picQuetIMEI, "Quét bằng máy để nhập nhanh số IMEI");
            // 
            // InHoaDon
            // 
            InHoaDon.Cursor = Cursors.Hand;
            InHoaDon.Image = Properties.Resources.print;
            InHoaDon.Location = new Point(357, 26);
            InHoaDon.Name = "InHoaDon";
            InHoaDon.Size = new Size(116, 88);
            InHoaDon.SizeMode = PictureBoxSizeMode.Zoom;
            InHoaDon.TabIndex = 0;
            InHoaDon.TabStop = false;
            toolTip1.SetToolTip(InHoaDon, "In Hóa Đơn");
            InHoaDon.Click += InHoaDon_Click;
            // 
            // COLSTT
            // 
            COLSTT.FillWeight = 96.25668F;
            COLSTT.HeaderText = "STT";
            COLSTT.MinimumWidth = 6;
            COLSTT.Name = "COLSTT";
            // 
            // colTenSanPham
            // 
            colTenSanPham.DataPropertyName = "TenSanPham";
            colTenSanPham.FillWeight = 144.228333F;
            colTenSanPham.HeaderText = "Tên Sản Phẩm";
            colTenSanPham.MinimumWidth = 6;
            colTenSanPham.Name = "colTenSanPham";
            // 
            // colDonGiaBan
            // 
            colDonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Format = "N0";
            colDonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            colDonGiaBan.FillWeight = 94.21642F;
            colDonGiaBan.HeaderText = "Đơn Giá Bán";
            colDonGiaBan.MinimumWidth = 6;
            colDonGiaBan.Name = "colDonGiaBan";
            // 
            // colSoIMEI
            // 
            colSoIMEI.DataPropertyName = "SoIMEI";
            colSoIMEI.HeaderText = "Số IMEI";
            colSoIMEI.MinimumWidth = 6;
            colSoIMEI.Name = "colSoIMEI";
            // 
            // frmThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 782);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(dgvThanhToan);
            Controls.Add(groupBox);
            Name = "frmThanhToan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán";
            Load += frmThanhToan_Load;
            ((System.ComponentModel.ISupportInitialize)picThoat).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHuyBo).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTienThua).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKhachDua).EndInit();
            ((System.ComponentModel.ISupportInitialize)picMaQr).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTongTien).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLuu).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTimKiem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvThanhToan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSua).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picQuetIMEI).EndInit();
            ((System.ComponentModel.ISupportInitialize)InHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picThoat;
        private PictureBox picHuyBo;
        private TextBox txtID;
        private Label label3;
        private Label label5;
        private Label label11;
        private Label label1;
        private TextBox txtTenKhacHang;
        private GroupBox groupBox3;
        private ComboBox cboPhuongThucThanhToan;
        private Label label7;
        private PictureBox picLuu;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private PictureBox picTimKiem;
        private TextBox txtTimKiem;
        private DateTimePicker datTimKiem;
        private Label label6;
        private DataGridView dgvThanhToan;
        private PictureBox picSua;
        private GroupBox groupBox;
        private PictureBox InHoaDon;
        private Label label8;
        private TextBox txtTenNhanVien;
        private NumericUpDown numKhachDua;
        private NumericUpDown numTongTien;
        private Label label9;
        private NumericUpDown numTienThua;
        private Label label10;
        private Label label12;
        private PictureBox picQuetIMEI;
        private ToolTip toolTip1;
        private DateTimePicker datNgayThanhToan;
        private Label label2;
        private PictureBox picMaQr;
        private DataGridViewTextBoxColumn COLSTT;
        private DataGridViewTextBoxColumn colTenSanPham;
        private DataGridViewTextBoxColumn colDonGiaBan;
        private DataGridViewTextBoxColumn colSoIMEI;
    }
}