using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanDTDD.Migrations
{
    /// <inheritdoc />
    public partial class ketnoibangthanhtoan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HoaDonID",
                table: "ThanhToan",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_ThanhToan_HoaDonID",
                table: "ThanhToan",
                column: "HoaDonID");

            migrationBuilder.AddForeignKey(
                name: "FK_ThanhToan_HoaDonBan_HoaDonID",
                table: "ThanhToan",
                column: "HoaDonID",
                principalTable: "HoaDonBan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanhToan_HoaDonBan_HoaDonID",
                table: "ThanhToan");

            migrationBuilder.DropIndex(
                name: "IX_ThanhToan_HoaDonID",
                table: "ThanhToan");

            migrationBuilder.AlterColumn<string>(
                name: "HoaDonID",
                table: "ThanhToan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
