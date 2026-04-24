using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanDTDD.Migrations
{
    /// <inheritdoc />
    public partial class ThemCotPhienBanVaoCTHM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhienBanSanPhamID",
                table: "ChiTietHoaDonMua",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhienBanSanPhamID",
                table: "ChiTietHoaDonBan",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonMua_PhienBanSanPhamID",
                table: "ChiTietHoaDonMua",
                column: "PhienBanSanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDonBan_PhienBanSanPhamID",
                table: "ChiTietHoaDonBan",
                column: "PhienBanSanPhamID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDonBan_PhienBanSanPham_PhienBanSanPhamID",
                table: "ChiTietHoaDonBan",
                column: "PhienBanSanPhamID",
                principalTable: "PhienBanSanPham",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietHoaDonMua_PhienBanSanPham_PhienBanSanPhamID",
                table: "ChiTietHoaDonMua",
                column: "PhienBanSanPhamID",
                principalTable: "PhienBanSanPham",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDonBan_PhienBanSanPham_PhienBanSanPhamID",
                table: "ChiTietHoaDonBan");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietHoaDonMua_PhienBanSanPham_PhienBanSanPhamID",
                table: "ChiTietHoaDonMua");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDonMua_PhienBanSanPhamID",
                table: "ChiTietHoaDonMua");

            migrationBuilder.DropIndex(
                name: "IX_ChiTietHoaDonBan_PhienBanSanPhamID",
                table: "ChiTietHoaDonBan");

            migrationBuilder.DropColumn(
                name: "PhienBanSanPhamID",
                table: "ChiTietHoaDonMua");

            migrationBuilder.DropColumn(
                name: "PhienBanSanPhamID",
                table: "ChiTietHoaDonBan");
        }
    }
}
