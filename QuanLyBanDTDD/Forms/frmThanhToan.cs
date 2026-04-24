using Microsoft.EntityFrameworkCore;
using QuanLyBanDTDD.Data;
using QuanLyBanDTDD.Reports;
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
    public partial class frmThanhToan : Form
    {
        QLBDTDTDbContext context = new QLBDTDTDbContext();

        // Khai báo danh sách tạm toàn cục 
        BindingList<MayCanQuetIMEI> listQuetIMEI = new BindingList<MayCanQuetIMEI>();
        string maHoaDonHienTai;


        public frmThanhToan(string maHD)
        {
            InitializeComponent();
            maHoaDonHienTai = maHD;
            datNgayThanhToan.Enabled = false;
            dgvThanhToan.AutoGenerateColumns = false;
        }




        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            // 1. Load thông tin Khách hàng, Tổng tiền... lên các ô TextBox bên phải
            LoadThongTinHoaDon();

            // 2. Load danh sách máy ra lưới bên trái để chuẩn bị quét IMEI
            LoadDanhSachQuetIMEI();
        }

        // =================================================================
        // HÀM 1: TẢI THÔNG TIN HÓA ĐƠN
        // =================================================================
        private void LoadThongTinHoaDon()
        {
            var hd = context.HoaDonBan
                .Include(h => h.KhachHang)
                .Include(h => h.NhanVien)
                .FirstOrDefault(h => h.ID == maHoaDonHienTai);

            if (hd != null)
            {
                txtID.Text = hd.ID;
                txtTenKhacHang.Text = hd.KhachHang.HoTen; // Sửa thành HoTen nếu Class của bạn là HoTen
                txtTenNhanVien.Text = hd.NhanVien.HoTen;   // Sửa thành HoTen nếu Class của bạn là HoTen
                numTongTien.Value = hd.TongTien;

                // Mặc định gợi ý khách đưa đủ tiền để tính tiền thừa cho nhanh
                numKhachDua.Value = hd.TongTien;
                datNgayThanhToan.Value = DateTime.Now;

                if (cboPhuongThucThanhToan.Items.Count > 0)
                    cboPhuongThucThanhToan.SelectedIndex = 0;
            }
        }

        // =================================================================
        // HÀM 2: TÁCH DÒNG VÀ ĐỔ VÀO LƯỚI QUÉT IMEI
        // =================================================================
        private void LoadDanhSachQuetIMEI()
        {
            var chiTietGoc = context.ChiTietHoaDonBan
                 .Include(ct => ct.PhienBanSanPham).ThenInclude(pb => pb.SanPham)
                 .Where(ct => ct.HoaDonBanID == maHoaDonHienTai)
                 .ToList();

            listQuetIMEI.Clear();

            foreach (var item in chiTietGoc)
            {
                // Mua bao nhiêu cái thì tách ra bấy nhiêu dòng
                for (int i = 0; i < item.SoLuong; i++)
                {
                    listQuetIMEI.Add(new MayCanQuetIMEI
                    {
                        SanPhamID = (int)item.PhienBanSanPhamID,
                        // Lưu ý: Nếu Class SanPham của bạn là TenSanPham thì đổi item.SanPham.TenSP thành item.SanPham.TenSanPham
                        TenSanPham = item.PhienBanSanPham.SanPham.TenSP,
                        DonGiaBan = item.DonGia,
                        SoIMEI = "" // Để trống cho nhân viên tít mã vạch
                    });
                }
            }

            dgvThanhToan.DataSource = listQuetIMEI;

            dgvThanhToan.ReadOnly = false;

            foreach (DataGridViewColumn col in dgvThanhToan.Columns)
            {
                // Kiểm tra tên cột (Name) hoặc tiêu đề cột (HeaderText)
                if (col.Name.Equals("SoIMEI", StringComparison.OrdinalIgnoreCase) || col.HeaderText.Contains("IMEI"))
                {
                    col.ReadOnly = false; // Mở khóa duy nhất cột IMEI
                    col.DefaultCellStyle.BackColor = Color.LightYellow; // Tô màu vàng cho nhân viên dễ thấy chỗ gõ
                }
                else
                {
                    col.ReadOnly = true; // Khóa tất cả các cột còn lại (Tên SP, Đơn giá...)
                }
            }
        }

        // =================================================================
        // HÀM 3: TỰ ĐỘNG TÍNH TIỀN THỪA
        // =================================================================
        private void numKhachDua_ValueChanged(object sender, EventArgs e)
        {
            decimal tongTien = numTongTien.Value;
            decimal khachDua = numKhachDua.Value;

            if (khachDua >= tongTien)
            {
                numTienThua.Value = khachDua - tongTien;
            }
            else
            {
                numTienThua.Value = 0; // Nếu đưa thiếu thì chưa có tiền thừa
            }
        }

     
        
        private void picLuu_Click(object sender, EventArgs e)
        {
            // A. Kiểm tra tiền khách đưa
            if (numKhachDua.Value < numTongTien.Value)
            {
                MessageBox.Show("Số tiền khách đưa chưa đủ để thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numKhachDua.Focus();
                return;
            }
            if (cboPhuongThucThanhToan.Text == "Chuyển khoản")
            {
                DialogResult confirm = MessageBox.Show(
                    "Vui lòng xác nhận tiền đã về tài khoản ngân hàng trước khi chốt hóa đơn!",
                    "Xác nhận chuyển khoản",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.No) return; //  chưa thấy tiền thì dừng lại, không lưu
            }
            //Kiểm tra đã quét đủ IMEI chưa
            foreach (var may in listQuetIMEI)
            {
                if (string.IsNullOrWhiteSpace(may.SoIMEI) || may.SoIMEI.Length < 15)
                {
                    MessageBox.Show($"Vui lòng quét đủ 15 số IMEI cho máy: {may.TenSanPham}", "Thiếu mã IMEI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

           
            try
            {
                var hd = context.HoaDonBan.Find(maHoaDonHienTai);
                if (hd != null)
                {
                    //  Xóa các dòng gộp cũ đi
                    var chiTietCu = context.ChiTietHoaDonBan.Where(x => x.HoaDonBanID == maHoaDonHienTai).ToList();
                    context.ChiTietHoaDonBan.RemoveRange(chiTietCu);

                    //thêm các dòng đã tách lẻ kèm IMEI vào
                    foreach (var may in listQuetIMEI)
                    {
               
                        context.ChiTietHoaDonBan.Add(new ChiTietHoaDonBan
                        {
                            HoaDonBanID = maHoaDonHienTai,
                            PhienBanSanPhamID = may.SanPhamID,
                            SoLuong = 1,                // LUÔN FIX LÀ 1
                            DonGia = may.DonGiaBan,
                            ThanhTien = may.DonGiaBan,
                            SoIMEI = may.SoIMEI,
                            NgayKichHoat = DateTime.Now,
                            NgayHetHan = DateTime.Now.AddMonths(12)
                        });
                    }

                    //Cập nhật trạng thái Hóa đơn
                    hd.TrangThai = "Đã thanh toán";
                    hd.PhuongThucThanhToan = cboPhuongThucThanhToan.Text;
                    hd.KhachDua = numKhachDua.Value;


                    

                    context.ThanhToan.Add(new ThanhToan
                    {
                        HoaDonID = maHoaDonHienTai,
                        TenKhachHang = txtTenKhacHang.Text,
                        TenNhanVien = txtTenNhanVien.Text,
                        TongTien = numTongTien.Value,
                        KhachDua = numKhachDua.Value,
                        PhuongThuc = cboPhuongThucThanhToan.Text,
                        NgayThanhToan = DateTime.Now,
                        GhiChu = "Thanh toán hoàn tất"
                    });
                    // LƯU TOÀN BỘ CÁC THAY ĐỔI
                    context.SaveChanges();

                    int diemCung = (int)(hd.TongTien / 100000);

                    // HỎI IN HÓA ĐƠN
                    DialogResult hoiIn = MessageBox.Show(
                        $"Thanh toán thành công!\n\nBạn có muốn in hóa đơn không?",
                        "Hoàn tất",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (hoiIn == DialogResult.Yes)
                    {

                        frmInHoaDonBan fIn = new frmInHoaDonBan(maHoaDonHienTai);
                        fIn.ShowDialog();
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

        private void cboPhuongThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhuongThucThanhToan.Text == "Chuyển khoản")
            {
                //gán tiền khách đưa bằng tổng tiền
                numKhachDua.Value = numTongTien.Value;

                //Tạo URL mã QR (VietQR)
                string nganHang = "TPBANK"; // Mã ngân hàng (VCB, MB, ICB...)
                string stk = "68838683883"; // Số tài khoản của bạn
                string soTien = numTongTien.Value.ToString("0");
                string noiDung = "Thanh toan " + txtID.Text;
                string noiDungMaHoa = Uri.EscapeDataString(noiDung);

                // Link API tạo QR động
                string urlQR = $"https://img.vietqr.io/image/{nganHang}-{stk}-compact2.png?amount={soTien}&addInfo={noiDungMaHoa}";

                // Hiển thị PictureBox và tải ảnh từ Internet
                picMaQr.ImageLocation = urlQR;
                picMaQr.Visible = true;
              
            }
            else
            {
               
                picMaQr.Visible = false;
               
            }
        }

        private void picSua_Click(object sender, EventArgs e)
        {
            //Cho phép sửa các ô nhập liệu bên phải
            cboPhuongThucThanhToan.Enabled = true;
            numKhachDua.ReadOnly = false;
           

            // Mở khóa cột IMEI trong bảng để nhân viên gõ lại nếu sai
            dgvThanhToan.ReadOnly = false;
            foreach (DataGridViewColumn col in dgvThanhToan.Columns)
            {
                if (col.Name.Equals("SoIMEI", StringComparison.OrdinalIgnoreCase))
                {
                    col.ReadOnly = false;
                    col.DefaultCellStyle.BackColor = Color.White; // Đổi lại màu trắng để biết đang sửa được
                }
            }

           
            MessageBox.Show("Đã mở khóa! Bạn có thể chỉnh sửa lại Phương thức thanh toán hoặc số IMEI.",
                            "Chế độ chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cboPhuongThucThanhToan.Focus();
        }


        private void InHoaDon_Click(object sender, EventArgs e)
        {
            //kiểm tra xem mã hóa đơn có tồn tại không
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Không có hóa đơn để in!", "Thông báo");
                return;
            }

            //kiểm tra trạng thái trong CSDL 
            var hd = context.HoaDonBan.Find(txtID.Text);
            if (hd != null && hd.TrangThai == "Đã thanh toán")
            {
               //in
                frmInHoaDonBan fIn = new frmInHoaDonBan(hd.ID);
                fIn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng bấm LƯU thanh toán trước khi in hóa đơn!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy bỏ thao tác thanh toán này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThanhToan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Tự động vẽ số thứ tự vào cột đầu tiên
    var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
