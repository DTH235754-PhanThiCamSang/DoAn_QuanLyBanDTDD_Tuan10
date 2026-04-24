using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanDTDD.Migrations
{
    /// <inheritdoc />
    public partial class KhoiTaoCSDLMoi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HangSanXuat",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHangSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuocGia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangSanXuat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SDT = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                   
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhaCungCap = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ChucVu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TrangThai = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HangSanXuat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ThoiGianBaoHanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MauSac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BoNho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgungKinhDoanh = table.Column<bool>(type: "bit", nullable: false),
                    HangSanXuatID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SanPham_HangSanXuat_HangSanXuatID",
                        column: x => x.HangSanXuatID,
                        principalTable: "HangSanXuat",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "HoaDonBan",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayBan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiamGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TongThanhToan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DoiTraID = table.Column<int>(type: "int", nullable: true),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    KhachHangID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonBan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDonBan_KhachHang_KhachHangID",
                        column: x => x.KhachHangID,
                        principalTable: "KhachHang",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonBan_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonMua",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    NhaCungCapID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonMua", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDonMua_NhaCungCap_NhaCungCapID",
                        column: x => x.NhaCungCapID,
                        principalTable: "NhaCungCap",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonMua_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    TenDangNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    QuyenHan = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.NhanVienID);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonBan",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NgayKichHoat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoaDonBanID = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SanPhamID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonBan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonBan_HoaDonBan_HoaDonBanID",
                        column: x => x.HoaDonBanID,
                        principalTable: "HoaDonBan",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonBan_SanPham_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDonMua",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HoaDonMuaID = table.Column<int>(type: "int", nullable: false),
                    SanPhamID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDonMua", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonMua_HoaDonMua_HoaDonMuaID",
                        column: x => x.HoaDonMuaID,
                        principalTable: "HoaDonMua",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDonMua_SanPham_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "SanPham",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichSuHoatDong",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaiKhoanID = table.Column<int>(type: "int", nullable: false),
                    HanhDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DoiTuong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GiaTriCu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaTriMoi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuHoatDong", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LichSuHoatDong_TaiKhoan_TaiKhoanID",
                        column: x => x.TaiKhoanID,
                        principalTable: "TaiKhoan",
                        principalColumn: "NhanVienID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BaoHanh",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiTietHoaDonBanID = table.Column<int>(type: "int", nullable: false),
                    SoIMEI = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    NgayNhan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayTraDuKien = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTraThucTe = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LoiKhachBao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KetQuaXuLy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoiDoKhach = table.Column<bool>(type: "bit", nullable: false),
                    ChiPhi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaoHanh", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BaoHanh_ChiTietHoaDonBan_ChiTietHoaDonBanID",
                        column: x => x.ChiTietHoaDonBanID,
                        principalTable: "ChiTietHoaDonBan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoiTra",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChiTietHoaDonBanID = table.Column<int>(type: "int", nullable: false),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuongTra = table.Column<int>(type: "int", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NhapLaiKho = table.Column<bool>(type: "bit", nullable: false),
                    SoTienHoanLai = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoiTra", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DoiTra_ChiTietHoaDonBan_ChiTietHoaDonBanID",
                        column: x => x.ChiTietHoaDonBanID,
                        principalTable: "ChiTietHoaDonBan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoanTien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoiTraID = table.Column<int>(type: "int", nullable: false),
                    NgayHoan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoTienDaChi = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhuongThuc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NhanVienID = table.Column<int>(type: "int", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoanTien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoanTien_DoiTra_DoiTraID",
                        column: x => x.DoiTraID,
                        principalTable: "DoiTra",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoanTien_NhanVien_NhanVienID",
                        column: x => x.NhanVienID,
                        principalTable: "NhanVien",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaoHanh_ChiTietHoaDonBanID",
                table: "BaoHanh",
                column: "ChiTietHoaDonBanID");

            migrationBuilder.CreateIndex(
                name: "IX_BaoHanh_SoIMEI",
                table: "BaoHanh",
                column: "SoIMEI");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBan_HoaDonBanID",
                table: "ChiTietHoaDonBan",
                column: "HoaDonBanID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBan_SanPhamID",
                table: "ChiTietHoaDonBan",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonMua_HoaDonMuaID",
                table: "ChiTietHoaDonMua",
                column: "HoaDonMuaID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonMua_SanPhamID",
                table: "ChiTietHoaDonMua",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_DoiTra_ChiTietHoaDonBanID",
                table: "DoiTra",
                column: "ChiTietHoaDonBanID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBan_KhachHangID",
                table: "HoaDonBan",
                column: "KhachHangID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBan_NhanVienID",
                table: "HoaDonBan",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonMua_NhaCungCapID",
                table: "HoaDonMua",
                column: "NhaCungCapID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonMua_NhanVienID",
                table: "HoaDonMua",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_HoanTien_DoiTraID",
                table: "HoanTien",
                column: "DoiTraID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HoanTien_NhanVienID",
                table: "HoanTien",
                column: "NhanVienID");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_SDT",
                table: "KhachHang",
                column: "SDT",
                unique: true,
                filter: "[SDT] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuHoatDong_TaiKhoanID",
                table: "LichSuHoatDong",
                column: "TaiKhoanID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_HangSanXuatID",
                table: "SanPham",
                column: "HangSanXuatID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_TenSP",
                table: "SanPham",
                column: "TenSP");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaoHanh");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonMua");

            migrationBuilder.DropTable(
                name: "HoanTien");

            migrationBuilder.DropTable(
                name: "LichSuHoatDong");

            migrationBuilder.DropTable(
                name: "HoaDonMua");

            migrationBuilder.DropTable(
                name: "DoiTra");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "ChiTietHoaDonBan");

            migrationBuilder.DropTable(
                name: "HoaDonBan");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "HangSanXuat");
        }
    }
}
