namespace QuanLyBanDTDD.Reports
{
    partial class frmThongKeSanPham
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
            groupBox1 = new GroupBox();
            chkMinSoLuongBan = new CheckBox();
            chkMaxSoLuongBan = new CheckBox();
            chkSoLuongTonBeHon5 = new CheckBox();
            btnHienThiTatCa = new Button();
            btnLocKetQua = new Button();
            cboHangSanXuat = new ComboBox();
            label1 = new Label();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.DeepSkyBlue;
            groupBox1.Controls.Add(chkMinSoLuongBan);
            groupBox1.Controls.Add(chkMaxSoLuongBan);
            groupBox1.Controls.Add(chkSoLuongTonBeHon5);
            groupBox1.Controls.Add(btnHienThiTatCa);
            groupBox1.Controls.Add(btnLocKetQua);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1324, 115);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // chkMinSoLuongBan
            // 
            chkMinSoLuongBan.AutoSize = true;
            chkMinSoLuongBan.Font = new Font("Calibri", 12F);
            chkMinSoLuongBan.Location = new Point(717, 80);
            chkMinSoLuongBan.Name = "chkMinSoLuongBan";
            chkMinSoLuongBan.Size = new Size(268, 28);
            chkMinSoLuongBan.TabIndex = 3;
            chkMinSoLuongBan.Text = "Số Lượng Bán Thấp Đến Cao";
            chkMinSoLuongBan.UseVisualStyleBackColor = true;
            chkMinSoLuongBan.CheckedChanged += chkMinSoLuongBan_CheckedChanged;
            // 
            // chkMaxSoLuongBan
            // 
            chkMaxSoLuongBan.AutoSize = true;
            chkMaxSoLuongBan.Font = new Font("Calibri", 12F);
            chkMaxSoLuongBan.Location = new Point(717, 27);
            chkMaxSoLuongBan.Name = "chkMaxSoLuongBan";
            chkMaxSoLuongBan.Size = new Size(268, 28);
            chkMaxSoLuongBan.TabIndex = 3;
            chkMaxSoLuongBan.Text = "Số Lượng Bán Cao Đến Thấp";
            chkMaxSoLuongBan.UseVisualStyleBackColor = true;
            chkMaxSoLuongBan.CheckedChanged += chkMaxSoLuongBan_CheckedChanged;
            // 
            // chkSoLuongTonBeHon5
            // 
            chkSoLuongTonBeHon5.AutoSize = true;
            chkSoLuongTonBeHon5.Font = new Font("Calibri", 12F);
            chkSoLuongTonBeHon5.Location = new Point(497, 43);
            chkSoLuongTonBeHon5.Name = "chkSoLuongTonBeHon5";
            chkSoLuongTonBeHon5.Size = new Size(174, 28);
            chkSoLuongTonBeHon5.TabIndex = 3;
            chkSoLuongTonBeHon5.Text = "Số Lượng Tồn < 5";
            chkSoLuongTonBeHon5.UseVisualStyleBackColor = true;
            // 
            // btnHienThiTatCa
            // 
            btnHienThiTatCa.Font = new Font("Calibri", 12F);
            btnHienThiTatCa.Location = new Point(1163, 43);
            btnHienThiTatCa.Margin = new Padding(3, 4, 3, 4);
            btnHienThiTatCa.Name = "btnHienThiTatCa";
            btnHienThiTatCa.Size = new Size(122, 31);
            btnHienThiTatCa.TabIndex = 2;
            btnHienThiTatCa.Text = "Hiển Thị Tất Cả";
            btnHienThiTatCa.UseVisualStyleBackColor = true;
            btnHienThiTatCa.Click += btnHienThiTatCa_Click;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Font = new Font("Calibri", 12F);
            btnLocKetQua.Location = new Point(1002, 41);
            btnLocKetQua.Margin = new Padding(3, 4, 3, 4);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(134, 35);
            btnLocKetQua.TabIndex = 2;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.Font = new Font("Calibri", 12F);
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(217, 44);
            cboHangSanXuat.Margin = new Padding(3, 4, 3, 4);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(196, 32);
            cboHangSanXuat.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F);
            label1.Location = new Point(52, 47);
            label1.Name = "label1";
            label1.Size = new Size(133, 24);
            label1.TabIndex = 0;
            label1.Text = "Hãng sản xuất:";
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportViewer1.Location = new Point(0, 122);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1325, 645);
            reportViewer1.TabIndex = 2;
            // 
            // frmThongKeSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 768);
            Controls.Add(groupBox1);
            Controls.Add(reportViewer1);
            Name = "frmThongKeSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Sản Phẩm";
            Load += frmThongKeSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLocKetQua;
        private ComboBox cboHangSanXuat;
        private Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CheckBox chkMaxSoLuongBan;
        private CheckBox chkSoLuongTonBeHon5;
        private CheckBox chkMinSoLuongBan;
        private Button btnHienThiTatCa;
    }
}