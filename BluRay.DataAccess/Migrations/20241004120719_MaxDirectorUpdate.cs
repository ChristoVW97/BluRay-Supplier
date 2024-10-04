using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BluRay.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class MaxDirectorUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Director",
                value: "George Miller");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "Director",
                value: "Denis Villeneuve");
        }
    }
}
