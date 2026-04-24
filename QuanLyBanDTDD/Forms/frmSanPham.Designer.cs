using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDTDD.Forms
{
    public partial class frmSanPham : System.Windows.Forms.Form
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
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            picHuyBo = new PictureBox();
            label10 = new Label();
            label8 = new Label();
            picLuu = new PictureBox();
            groupBox3 = new GroupBox();
            picThemPhienBan = new PictureBox();
            picXuatDuLieu = new PictureBox();
            picNhapDuLieu = new PictureBox();
            numSoLuongTon = new NumericUpDown();
            numGiaBan = new NumericUpDown();
            numGiaNhap = new NumericUpDown();
            picThoat = new PictureBox();
            picHinhAnh = new PictureBox();
            picXoayAnh = new PictureBox();
            picDoiAnh = new PictureBox();
            label4 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label11 = new Label();
            label1 = new Label();
            cboThoiGianBaoHanh = new ComboBox();
            cboHangSanXuat = new ComboBox();
            txtMoTa = new TextBox();
            txtBoNho = new TextBox();
            txtMauSac = new TextBox();
            txtTenSanPham = new TextBox();
            txtID = new TextBox();
            groupBox = new GroupBox();
            picXoa = new PictureBox();
            picSua = new PictureBox();
            picThem = new PictureBox();
            textBox2 = new TextBox();
            dgvSanPham = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colTenSP = new DataGridViewTextBoxColumn();
            colHangSanXuat = new DataGridViewTextBoxColumn();
            colThoiGianBaoHanh = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            picTimKiem = new PictureBox();
            txtTimKiem = new TextBox();
            toolTip1 = new ToolTip(components);
            dgvPhienBanSanPham = new DataGridView();
            colIDPhienBan = new DataGridViewTextBoxColumn();
            colMauSac = new DataGridViewTextBoxColumn();
            colBoNho = new DataGridViewTextBoxColumn();
            colGiaNhap = new DataGridViewTextBoxColumn();
            colGiaBan = new DataGridViewTextBoxColumn();
            colSoLuongTon = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)picHuyBo).BeginInit();
            ((ISupportInitialize)picLuu).BeginInit();
            groupBox3.SuspendLayout();
            ((ISupportInitialize)picThemPhienBan).BeginInit();
            ((ISupportInitialize)picXuatDuLieu).BeginInit();
            ((ISupportInitialize)picNhapDuLieu).BeginInit();
            ((ISupportInitialize)numSoLuongTon).BeginInit();
            ((ISupportInitialize)numGiaBan).BeginInit();
            ((ISupportInitialize)numGiaNhap).BeginInit();
            ((ISupportInitialize)picThoat).BeginInit();
            ((ISupportInitialize)picHinhAnh).BeginInit();
            ((ISupportInitialize)picXoayAnh).BeginInit();
            ((ISupportInitialize)picDoiAnh).BeginInit();
            groupBox.SuspendLayout();
            ((ISupportInitialize)picXoa).BeginInit();
            ((ISupportInitialize)picSua).BeginInit();
            ((ISupportInitialize)picThem).BeginInit();
            ((ISupportInitialize)dgvSanPham).BeginInit();
            groupBox2.SuspendLayout();
            ((ISupportInitialize)picTimKiem).BeginInit();
            ((ISupportInitialize)dgvPhienBanSanPham).BeginInit();
            SuspendLayout();
            // 
            // picHuyBo
            // 
            picHuyBo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picHuyBo.Image = Properties.Resources.cancel;
            picHuyBo.Location = new Point(6, 534);
            picHuyBo.Name = "picHuyBo";
            picHuyBo.Size = new Size(100, 71);
            picHuyBo.SizeMode = PictureBoxSizeMode.Zoom;
            picHuyBo.TabIndex = 0;
            picHuyBo.TabStop = false;
            toolTip1.SetToolTip(picHuyBo, "Hủy Bỏ Thông Tin Đang Nhập");
            picHuyBo.Click += picHuyBo_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 10.2F);
            label10.Location = new Point(0, 408);
            label10.Name = "label10";
            label10.Size = new Size(58, 21);
            label10.TabIndex = 2;
            label10.Text = "Mô Tả:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 10.2F);
            label8.Location = new Point(0, 252);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 2;
            label8.Text = "Bộ Nhớ:";
            // 
            // picLuu
            // 
            picLuu.Image = Properties.Resources.save;
            picLuu.Location = new Point(618, 26);
            picLuu.Name = "picLuu";
            picLuu.Size = new Size(100, 71);
            picLuu.SizeMode = PictureBoxSizeMode.Zoom;
            picLuu.TabIndex = 0;
            picLuu.TabStop = false;
            toolTip1.SetToolTip(picLuu, "Lưu Sản Phẩm");
            picLuu.Click += picLuu_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox3.BackColor = Color.LightSkyBlue;
            groupBox3.Controls.Add(picThemPhienBan);
            groupBox3.Controls.Add(picXuatDuLieu);
            groupBox3.Controls.Add(picNhapDuLieu);
            groupBox3.Controls.Add(numSoLuongTon);
            groupBox3.Controls.Add(numGiaBan);
            groupBox3.Controls.Add(numGiaNhap);
            groupBox3.Controls.Add(picThoat);
            groupBox3.Controls.Add(picHinhAnh);
            groupBox3.Controls.Add(picXoayAnh);
            groupBox3.Controls.Add(picDoiAnh);
            groupBox3.Controls.Add(picHuyBo);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cboThoiGianBaoHanh);
            groupBox3.Controls.Add(cboHangSanXuat);
            groupBox3.Controls.Add(txtMoTa);
            groupBox3.Controls.Add(txtBoNho);
            groupBox3.Controls.Add(txtMauSac);
            groupBox3.Controls.Add(txtTenSanPham);
            groupBox3.Controls.Add(txtID);
            groupBox3.Location = new Point(828, 113);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 628);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // picThemPhienBan
            // 
            picThemPhienBan.Cursor = Cursors.Hand;
            picThemPhienBan.Image = Properties.Resources.shopping_bag;
            picThemPhienBan.Location = new Point(342, 407);
            picThemPhienBan.Name = "picThemPhienBan";
            picThemPhienBan.Size = new Size(79, 51);
            picThemPhienBan.SizeMode = PictureBoxSizeMode.Zoom;
            picThemPhienBan.TabIndex = 26;
            picThemPhienBan.TabStop = false;
            toolTip1.SetToolTip(picThemPhienBan, "Thêm phiên bản mới.");
            picThemPhienBan.Click += picThemPhienBan_Click;
            // 
            // picXuatDuLieu
            // 
            picXuatDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picXuatDuLieu.Cursor = Cursors.Hand;
            picXuatDuLieu.Image = Properties.Resources.output;
            picXuatDuLieu.Location = new Point(245, 534);
            picXuatDuLieu.Name = "picXuatDuLieu";
            picXuatDuLieu.Size = new Size(100, 71);
            picXuatDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picXuatDuLieu.TabIndex = 24;
            picXuatDuLieu.TabStop = false;
            toolTip1.SetToolTip(picXuatDuLieu, "Xuất Dữ Liệu");
            picXuatDuLieu.Click += picXuatDuLieu_Click;
            // 
            // picNhapDuLieu
            // 
            picNhapDuLieu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picNhapDuLieu.Cursor = Cursors.Hand;
            picNhapDuLieu.Image = Properties.Resources.input;
            picNhapDuLieu.Location = new Point(133, 534);
            picNhapDuLieu.Name = "picNhapDuLieu";
            picNhapDuLieu.Size = new Size(100, 71);
            picNhapDuLieu.SizeMode = PictureBoxSizeMode.Zoom;
            picNhapDuLieu.TabIndex = 25;
            picNhapDuLieu.TabStop = false;
            toolTip1.SetToolTip(picNhapDuLieu, "Nhập Dữ Liệu");
            picNhapDuLieu.Click += picNhapDuLieu_Click;
            // 
            // numSoLuongTon
            // 
            numSoLuongTon.Font = new Font("Calibri", 12F);
            numSoLuongTon.Location = new Point(119, 360);
            numSoLuongTon.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numSoLuongTon.Name = "numSoLuongTon";
            numSoLuongTon.Size = new Size(160, 32);
            numSoLuongTon.TabIndex = 6;
            // 
            // numGiaBan
            // 
            numGiaBan.Font = new Font("Calibri", 12F);
            numGiaBan.Location = new Point(119, 324);
            numGiaBan.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numGiaBan.Name = "numGiaBan";
            numGiaBan.Size = new Size(160, 32);
            numGiaBan.TabIndex = 6;
            // 
            // numGiaNhap
            // 
            numGiaNhap.Enabled = false;
            numGiaNhap.Font = new Font("Calibri", 12F);
            numGiaNhap.Location = new Point(119, 287);
            numGiaNhap.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numGiaNhap.Name = "numGiaNhap";
            numGiaNhap.Size = new Size(160, 32);
            numGiaNhap.TabIndex = 6;
            // 
            // picThoat
            // 
            picThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picThoat.Cursor = Cursors.Hand;
            picThoat.Image = Properties.Resources.close;
            picThoat.Location = new Point(363, 534);
            picThoat.Name = "picThoat";
            picThoat.Size = new Size(100, 71);
            picThoat.SizeMode = PictureBoxSizeMode.Zoom;
            picThoat.TabIndex = 5;
            picThoat.TabStop = false;
            toolTip1.SetToolTip(picThoat, "Thoát Form");
            picThoat.Click += picThoat_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(285, 45);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(172, 246);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 4;
            picHinhAnh.TabStop = false;
            toolTip1.SetToolTip(picHinhAnh, "Thêm Ảnh Sản Phẩm");
            // 
            // picXoayAnh
            // 
            picXoayAnh.Image = Properties.Resources.rotate;
            picXoayAnh.Location = new Point(286, 313);
            picXoayAnh.Name = "picXoayAnh";
            picXoayAnh.Size = new Size(67, 71);
            picXoayAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picXoayAnh.TabIndex = 0;
            picXoayAnh.TabStop = false;
            toolTip1.SetToolTip(picXoayAnh, "Xoay Ảnh Sản Phẩm");
            picXoayAnh.Click += picXoayAnh_Click;
            // 
            // picDoiAnh
            // 
            picDoiAnh.Image = Properties.Resources.change;
            picDoiAnh.Location = new Point(395, 313);
            picDoiAnh.Name = "picDoiAnh";
            picDoiAnh.Size = new Size(67, 71);
            picDoiAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picDoiAnh.TabIndex = 0;
            picDoiAnh.TabStop = false;
            toolTip1.SetToolTip(picDoiAnh, "Đổi Ảnh Sản Phẩm");
            picDoiAnh.Click += picDoiAnh_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 10.2F);
            label4.Location = new Point(0, 365);
            label4.Name = "label4";
            label4.Size = new Size(108, 21);
            label4.TabIndex = 2;
            label4.Text = "Số Lượng Tồn:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 10.2F);
            label9.Location = new Point(0, 286);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 2;
            label9.Text = "Giá Nhập:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 10.2F);
            label7.Location = new Point(0, 208);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 2;
            label7.Text = "Màu Sắc:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 10.2F);
            label6.Location = new Point(0, 177);
            label6.Name = "label6";
            label6.Size = new Size(153, 21);
            label6.TabIndex = 2;
            label6.Text = "Thời Gian Bảo Hành:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 10.2F);
            label3.Location = new Point(0, 147);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 2;
            label3.Text = "Hãng Sản Xuất:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 10.2F);
            label5.Location = new Point(0, 323);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 2;
            label5.Text = "Giá Bán:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F);
            label2.Location = new Point(-1, 110);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 2;
            label2.Text = "Tên Sản Phẩm:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(104, 3);
            label11.Name = "label11";
            label11.Size = new Size(269, 37);
            label11.TabIndex = 2;
            label11.Text = "Thông Tin Sản Phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.2F);
            label1.Location = new Point(0, 74);
            label1.Name = "label1";
            label1.Size = new Size(29, 21);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // cboThoiGianBaoHanh
            // 
            cboThoiGianBaoHanh.Font = new Font("Calibri", 12F);
            cboThoiGianBaoHanh.FormattingEnabled = true;
            cboThoiGianBaoHanh.Items.AddRange(new object[] { "12 tháng", "18 tháng", "24 tháng", "36 tháng" });
            cboThoiGianBaoHanh.Location = new Point(157, 171);
            cboThoiGianBaoHanh.Name = "cboThoiGianBaoHanh";
            cboThoiGianBaoHanh.Size = new Size(123, 32);
            cboThoiGianBaoHanh.TabIndex = 1;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.Font = new Font("Calibri", 12F);
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(120, 136);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(160, 32);
            cboHangSanXuat.TabIndex = 1;
            // 
            // txtMoTa
            // 
            txtMoTa.Font = new Font("Calibri", 12F);
            txtMoTa.Location = new Point(119, 407);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(160, 98);
            txtMoTa.TabIndex = 0;
            // 
            // txtBoNho
            // 
            txtBoNho.Font = new Font("Calibri", 12F);
            txtBoNho.Location = new Point(119, 251);
            txtBoNho.Name = "txtBoNho";
            txtBoNho.Size = new Size(160, 32);
            txtBoNho.TabIndex = 0;
            // 
            // txtMauSac
            // 
            txtMauSac.Font = new Font("Calibri", 12F);
            txtMauSac.Location = new Point(119, 207);
            txtMauSac.Name = "txtMauSac";
            txtMauSac.Size = new Size(160, 32);
            txtMauSac.TabIndex = 0;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Font = new Font("Calibri", 12F);
            txtTenSanPham.Location = new Point(120, 104);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(160, 32);
            txtTenSanPham.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Font = new Font("Calibri", 12F);
            txtID.Location = new Point(120, 71);
            txtID.Name = "txtID";
            txtID.Size = new Size(160, 32);
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
            groupBox.Size = new Size(826, 113);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            // 
            // picXoa
            // 
            picXoa.Image = Properties.Resources.delete;
            picXoa.Location = new Point(422, 26);
            picXoa.Name = "picXoa";
            picXoa.Size = new Size(100, 71);
            picXoa.SizeMode = PictureBoxSizeMode.Zoom;
            picXoa.TabIndex = 0;
            picXoa.TabStop = false;
            toolTip1.SetToolTip(picXoa, "Xóa Sản Phẩm");
            picXoa.Click += picXoa_Click;
            // 
            // picSua
            // 
            picSua.Image = Properties.Resources.edit;
            picSua.Location = new Point(214, 26);
            picSua.Name = "picSua";
            picSua.Size = new Size(100, 71);
            picSua.SizeMode = PictureBoxSizeMode.Zoom;
            picSua.TabIndex = 0;
            picSua.TabStop = false;
            toolTip1.SetToolTip(picSua, "Sửa Sản Phẩm");
            picSua.Click += picSua_Click;
            // 
            // picThem
            // 
            picThem.Cursor = Cursors.Hand;
            picThem.Image = Properties.Resources.add;
            picThem.Location = new Point(49, 26);
            picThem.Name = "picThem";
            picThem.Size = new Size(100, 71);
            picThem.SizeMode = PictureBoxSizeMode.Zoom;
            picThem.TabIndex = 0;
            picThem.TabStop = false;
            toolTip1.SetToolTip(picThem, "Thêm Sản Phẩm");
            picThem.Click += picThem_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(607, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Columns.AddRange(new DataGridViewColumn[] { colID, colTenSP, colHangSanXuat, colThoiGianBaoHanh, colHinhAnh, colMoTa });
            dgvSanPham.Location = new Point(0, 113);
            dgvSanPham.MultiSelect = false;
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 35;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(826, 309);
            dgvSanPham.TabIndex = 5;
            dgvSanPham.CellClick += dgvSanPham_CellClick;
            dgvSanPham.CellFormatting += dgvSanPham_CellFormatting;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.MinimumWidth = 6;
            colID.Name = "colID";
            // 
            // colTenSP
            // 
            colTenSP.DataPropertyName = "TenSP";
            colTenSP.HeaderText = "Tên Sản Phẩm";
            colTenSP.MinimumWidth = 6;
            colTenSP.Name = "colTenSP";
            // 
            // colHangSanXuat
            // 
            colHangSanXuat.DataPropertyName = "HangSanXuat";
            colHangSanXuat.HeaderText = "Hãng Sản Xuất";
            colHangSanXuat.MinimumWidth = 6;
            colHangSanXuat.Name = "colHangSanXuat";
            // 
            // colThoiGianBaoHanh
            // 
            colThoiGianBaoHanh.DataPropertyName = "ThoiGianBaoHanh";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.BottomRight;
            colThoiGianBaoHanh.DefaultCellStyle = dataGridViewCellStyle7;
            colThoiGianBaoHanh.HeaderText = "Thời Gian Bảo Hành";
            colThoiGianBaoHanh.MinimumWidth = 6;
            colThoiGianBaoHanh.Name = "colThoiGianBaoHanh";
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnh";
            colHinhAnh.HeaderText = "Hình Ảnh";
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.Resizable = DataGridViewTriState.True;
            colHinhAnh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // colMoTa
            // 
            colMoTa.DataPropertyName = "MoTa";
            colMoTa.HeaderText = "Mô Tả";
            colMoTa.MinimumWidth = 6;
            colMoTa.Name = "colMoTa";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.BackColor = Color.DeepSkyBlue;
            groupBox2.Controls.Add(picTimKiem);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(txtTimKiem);
            groupBox2.Location = new Point(826, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(470, 113);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // picTimKiem
            // 
            picTimKiem.Cursor = Cursors.Hand;
            picTimKiem.Image = Properties.Resources.finding;
            picTimKiem.Location = new Point(371, 39);
            picTimKiem.Name = "picTimKiem";
            picTimKiem.Size = new Size(88, 51);
            picTimKiem.SizeMode = PictureBoxSizeMode.Zoom;
            picTimKiem.TabIndex = 2;
            picTimKiem.TabStop = false;
            toolTip1.SetToolTip(picTimKiem, "Tìm Kiếm");
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(8, 39);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên hoặc SĐT đề tìm kiếm...";
            txtTimKiem.Size = new Size(451, 51);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextAlign = HorizontalAlignment.Center;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvPhienBanSanPham
            // 
            dgvPhienBanSanPham.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhienBanSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhienBanSanPham.ColumnHeadersHeight = 48;
            dgvPhienBanSanPham.Columns.AddRange(new DataGridViewColumn[] { colIDPhienBan, colMauSac, colBoNho, colGiaNhap, colGiaBan, colSoLuongTon });
            dgvPhienBanSanPham.Location = new Point(0, 415);
            dgvPhienBanSanPham.Name = "dgvPhienBanSanPham";
            dgvPhienBanSanPham.RowHeadersWidth = 51;
            dgvPhienBanSanPham.RowTemplate.Height = 35;
            dgvPhienBanSanPham.Size = new Size(826, 326);
            dgvPhienBanSanPham.TabIndex = 7;
            dgvPhienBanSanPham.CellClick += dgvPhienBanSanPham_CellClick;
            // 
            // colIDPhienBan
            // 
            colIDPhienBan.DataPropertyName = "IDPhienBan";
            colIDPhienBan.HeaderText = "ID";
            colIDPhienBan.MinimumWidth = 6;
            colIDPhienBan.Name = "colIDPhienBan";
            // 
            // colMauSac
            // 
            colMauSac.DataPropertyName = "MauSac";
            colMauSac.HeaderText = "Màu Sắc";
            colMauSac.MinimumWidth = 6;
            colMauSac.Name = "colMauSac";
            // 
            // colBoNho
            // 
            colBoNho.DataPropertyName = "BoNho";
            colBoNho.HeaderText = "Bộ Nhớ";
            colBoNho.MinimumWidth = 6;
            colBoNho.Name = "colBoNho";
            // 
            // colGiaNhap
            // 
            colGiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle8.Format = "N0";
            colGiaNhap.DefaultCellStyle = dataGridViewCellStyle8;
            colGiaNhap.HeaderText = "Giá Nhập";
            colGiaNhap.MinimumWidth = 6;
            colGiaNhap.Name = "colGiaNhap";
            // 
            // colGiaBan
            // 
            colGiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle9.Format = "N0";
            colGiaBan.DefaultCellStyle = dataGridViewCellStyle9;
            colGiaBan.HeaderText = "Giá Bán";
            colGiaBan.MinimumWidth = 6;
            colGiaBan.Name = "colGiaBan";
            // 
            // colSoLuongTon
            // 
            colSoLuongTon.DataPropertyName = "SoLuongTon";
            colSoLuongTon.HeaderText = "Số Lượng Tồn";
            colSoLuongTon.MinimumWidth = 6;
            colSoLuongTon.Name = "colSoLuongTon";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 742);
            Controls.Add(dgvPhienBanSanPham);
            Controls.Add(groupBox3);
            Controls.Add(groupBox);
            Controls.Add(dgvSanPham);
            Controls.Add(groupBox2);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản Phẩm";
            Load += frmSanPham_Load;
            ((ISupportInitialize)picHuyBo).EndInit();
            ((ISupportInitialize)picLuu).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((ISupportInitialize)picThemPhienBan).EndInit();
            ((ISupportInitialize)picXuatDuLieu).EndInit();
            ((ISupportInitialize)picNhapDuLieu).EndInit();
            ((ISupportInitialize)numSoLuongTon).EndInit();
            ((ISupportInitialize)numGiaBan).EndInit();
            ((ISupportInitialize)numGiaNhap).EndInit();
            ((ISupportInitialize)picThoat).EndInit();
            ((ISupportInitialize)picHinhAnh).EndInit();
            ((ISupportInitialize)picXoayAnh).EndInit();
            ((ISupportInitialize)picDoiAnh).EndInit();
            groupBox.ResumeLayout(false);
            ((ISupportInitialize)picXoa).EndInit();
            ((ISupportInitialize)picSua).EndInit();
            ((ISupportInitialize)picThem).EndInit();
            ((ISupportInitialize)dgvSanPham).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((ISupportInitialize)picTimKiem).EndInit();
            ((ISupportInitialize)dgvPhienBanSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picHuyBo;
        private Label label10;
        private Label label8;
        private PictureBox picLuu;
        private GroupBox groupBox3;
        private Label label4;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label2;
        private Label label11;
        private Label label1;
        private ComboBox cboTrangThai;
        private ComboBox cboChucVu;
        private ComboBox cboHangSanXuat;
        private TextBox txtBoNho;
        private TextBox txtMauSac;
        private TextBox txtTenSanPham;
        private TextBox txtID;
        private GroupBox groupBox;
        private PictureBox picXoa;
        private PictureBox picSua;
        private PictureBox picThem;
        private TextBox textBox2;
        private DataGridView dgvSanPham;
        private GroupBox groupBox2;
        private PictureBox picHinhAnh;
        private PictureBox picDoiAnh;
        private ToolTip toolTip1;
        private TextBox txtMoTa;
        private PictureBox picThoat;
        private PictureBox picTimKiem;
        private TextBox txtTimKiem;
        private ComboBox cboThoiGianBaoHanh;
        private NumericUpDown numGiaBan;
        private NumericUpDown numGiaNhap;
        private PictureBox picXoayAnh;
        private PictureBox picXuatDuLieu;
        private PictureBox picNhapDuLieu;
        private DataGridView dgvPhienBanSanPham;
        private DataGridViewTextBoxColumn colIDPhienBan;
        private DataGridViewTextBoxColumn colMauSac;
        private DataGridViewTextBoxColumn colBoNho;
        private DataGridViewTextBoxColumn colGiaNhap;
        private DataGridViewTextBoxColumn colGiaBan;
        private DataGridViewTextBoxColumn colSoLuongTon;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colTenSP;
        private DataGridViewTextBoxColumn colHangSanXuat;
        private DataGridViewTextBoxColumn colThoiGianBaoHanh;
        private DataGridViewImageColumn colHinhAnh;
        private DataGridViewTextBoxColumn colMoTa;
        private PictureBox picThemPhienBan;
        private NumericUpDown numSoLuongTon;
    }
}