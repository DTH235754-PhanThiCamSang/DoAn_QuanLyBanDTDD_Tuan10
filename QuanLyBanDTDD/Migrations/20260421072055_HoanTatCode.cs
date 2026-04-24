using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanDTDD.Migrations
{
    /// <inheritdoc />
    public partial class HoanTatCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDonBan_SanPham_SanPhamID",
                table: "ChiTietHoaDonBan");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDonMua_SanPham_SanPhamID",
                table: "ChiTietHoaDonMua");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDonMua_SanPhamID",
                table: "ChiTietHoaDonMua");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDonBan_SanPhamID",
                table: "ChiTietHoaDonBan");

            migrationBuilder.DropColumn(
                name: "BoNho",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "MauSac",
                table: "SanPham");

            migrationBuilder.DropColumn(
                name: "SanPhamID",
                table: "ChiTietHoaDonMua");

            migrationBuilder.DropColumn(
                name: "SanPhamID",
                table: "ChiTietHoaDonBan");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PhienBanSanPham",
                newName: "IDPhienBan");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IDPhienBan",
                table: "PhienBanSanPham",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "BoNho",
                table: "SanPham",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MauSac",
                table: "SanPham",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SanPhamID",
                table: "ChiTietHoaDonMua",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SanPhamID",
                table: "ChiTietHoaDonBan",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonMua_SanPhamID",
                table: "ChiTietHoaDonMua",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBan_SanPhamID",
                table: "ChiTietHoaDonBan",
                column: "SanPhamID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDonBan_SanPham_SanPhamID",
                table: "ChiTietHoaDonBan",
                column: "SanPhamID",
                principalTable: "SanPham",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDonMua_SanPham_SanPhamID",
                table: "ChiTietHoaDonMua",
                column: "SanPhamID",
                principalTable: "SanPham",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
