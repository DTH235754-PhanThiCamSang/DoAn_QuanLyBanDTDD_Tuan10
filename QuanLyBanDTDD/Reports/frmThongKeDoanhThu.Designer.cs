namespace QuanLyBanDTDD.Reports
{
    partial class frmThongKeDoanhThu
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
            chkTuan = new CheckBox();
            chkNgay = new CheckBox();
            btnHienThiKetQua = new Button();
            btnLocKetQua = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpDenNgay = new DateTimePicker();
            dtpTuNgay = new DateTimePicker();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.DeepSkyBlue;
            groupBox1.Controls.Add(chkTuan);
            groupBox1.Controls.Add(chkNgay);
            groupBox1.Controls.Add(btnHienThiKetQua);
            groupBox1.Controls.Add(btnLocKetQua);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpDenNgay);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1294, 99);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // chkTuan
            // 
            chkTuan.AutoSize = true;
            chkTuan.Location = new Point(880, 36);
            chkTuan.Name = "chkTuan";
            chkTuan.Size = new Size(100, 24);
            chkTuan.TabIndex = 4;
            chkTuan.Text = "Theo Tuần";
            chkTuan.UseVisualStyleBackColor = true;
            chkTuan.CheckedChanged += chkTuan_CheckedChanged;
            // 
            // chkNgay
            // 
            chkNgay.AutoSize = true;
            chkNgay.Location = new Point(755, 36);
            chkNgay.Name = "chkNgay";
            chkNgay.Size = new Size(103, 24);
            chkNgay.TabIndex = 4;
            chkNgay.Text = "Theo Ngày";
            chkNgay.UseVisualStyleBackColor = true;
            chkNgay.CheckedChanged += chkNgay_CheckedChanged;
            // 
            // btnHienThiKetQua
            // 
            btnHienThiKetQua.Location = new Point(1170, 32);
            btnHienThiKetQua.Margin = new Padding(3, 4, 3, 4);
            btnHienThiKetQua.Name = "btnHienThiKetQua";
            btnHienThiKetQua.Size = new Size(114, 31);
            btnHienThiKetQua.TabIndex = 3;
            btnHienThiKetQua.Text = "Hiển thị tất cả";
            btnHienThiKetQua.UseVisualStyleBackColor = true;
            btnHienThiKetQua.Click += btnHienThiTatCa_Click;
            // 
            // btnLocKetQua
            // 
            btnLocKetQua.Location = new Point(1032, 34);
            btnLocKetQua.Margin = new Padding(3, 4, 3, 4);
            btnLocKetQua.Name = "btnLocKetQua";
            btnLocKetQua.Size = new Size(114, 31);
            btnLocKetQua.TabIndex = 3;
            btnLocKetQua.Text = "Lọc kết quả";
            btnLocKetQua.UseVisualStyleBackColor = true;
            btnLocKetQua.Click += btnLocKetQua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(379, 41);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 41);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Từ ngày:";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(488, 36);
            dtpDenNgay.Margin = new Padding(3, 4, 3, 4);
            dtpDenNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpDenNgay.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(239, 27);
            dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(144, 36);
            dtpTuNgay.Margin = new Padding(3, 4, 3, 4);
            dtpTuNgay.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpTuNgay.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(229, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Fill;
            reportViewer1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "reportViewer1";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1297, 742);
            reportViewer1.TabIndex = 2;
            // 
            // frmThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1297, 742);
            Controls.Add(groupBox1);
            Controls.Add(reportViewer1);
            Name = "frmThongKeDoanhThu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Doanh Thu";
            Load += frmThongKeDoanhThu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnHienThiKetQua;
        private Button btnLocKetQua;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDenNgay;
        private DateTimePicker dtpTuNgay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CheckBox chkTuan;
        private CheckBox chkNgay;
    }
}