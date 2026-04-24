using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanDTDD.Migrations
{
    /// <inheritdoc />
    public partial class ThemTrangThaiChiTietHDBan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoLuongTra",
                table: "DoiTra");

            migrationBuilder.RenameColumn(
                name: "NhapLaiKho",
                table: "DoiTra",
                newName: "ConSeal");

            migrationBuilder.RenameColumn(
                name: "NgayTra",
                table: "DoiTra",
                newName: "NgayDoiTra");

            migrationBuilder.AlterColumn<string>(
                name: "TrangThai",
                table: "HoaDonBan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhuongThucThanhToan",
                table: "HoaDonBan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "GhiChu",
                table: "DoiTra",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HinhThuc",
                table: "DoiTra",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HuongXuLy",
                table: "DoiTra",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PhuPhi",
                table: "DoiTra",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "SoIMEI",
                table: "DoiTra",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SoIMEI",
                table: "ChiTietHoaDonBan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "GhiChu",
                table: "ChiTietHoaDonBan",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TrangThai",
                table: "ChiTietHoaDonBan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HinhThuc",
                table: "DoiTra");

            migrationBuilder.DropColumn(
                name: "HuongXuLy",
                table: "DoiTra");

            migrationBuilder.DropColumn(
                name: "PhuPhi",
                table: "DoiTra");

            migrationBuilder.DropColumn(
                name: "SoIMEI",
                table: "DoiTra");

            migrationBuilder.DropColumn(
                name: "GhiChu",
                table: "ChiTietHoaDonBan");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "ChiTietHoaDonBan");

            migrationBuilder.RenameColumn(
                name: "NgayDoiTra",
                table: "DoiTra",
                newName: "NgayTra");

            migrationBuilder.RenameColumn(
                name: "ConSeal",
                table: "DoiTra",
                newName: "NhapLaiKho");

            migrationBuilder.AlterColumn<string>(
                name: "TrangThai",
                table: "HoaDonBan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhuongThucThanhToan",
                table: "HoaDonBan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GhiChu",
                table: "DoiTra",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoLuongTra",
                table: "DoiTra",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "SoIMEI",
                table: "ChiTietHoaDonBan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
