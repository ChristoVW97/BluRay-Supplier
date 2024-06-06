using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BluRay.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AuthorToDirector : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Products",
                newName: "Director");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Director",
                table: "Products",
                newName: "Author");
        }
    }
}
