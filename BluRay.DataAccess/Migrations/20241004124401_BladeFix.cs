using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BluRay.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class BladeFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "\\images\\product\\8825f6bf-8eb7-4e06-b230-a3288e946807.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "\\images\\product\\b5b7b961-3e0b-47a9-94d1-0602f3df033a.jpg");
        }
    }
}
