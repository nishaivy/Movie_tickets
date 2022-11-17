using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Movietickets.Migrations
{
    /// <inheritdoc />
    public partial class nisha2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Movies",
                newName: "Nmae");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nmae",
                table: "Movies",
                newName: "Name");
        }
    }
}
