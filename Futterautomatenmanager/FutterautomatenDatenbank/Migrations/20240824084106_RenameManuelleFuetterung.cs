using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutterautomatenDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class RenameManuelleFuetterung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManuelleFuetterungModus",
                table: "Futterautomaten",
                newName: "ManuelleFuetterung");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManuelleFuetterung",
                table: "Futterautomaten",
                newName: "ManuelleFuetterungModus");
        }
    }
}
