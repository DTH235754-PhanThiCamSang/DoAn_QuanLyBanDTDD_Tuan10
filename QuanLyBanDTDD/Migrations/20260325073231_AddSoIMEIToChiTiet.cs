using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanDTDD.Migrations
{
    /// <inheritdoc />
    public partial class AddSoIMEIToChiTiet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SoIMEI",
                table: "ChiTietHoaDonBan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SoIMEI",
                table: "ChiTietHoaDonBan");
        }
    }
}
