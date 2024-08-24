using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutterautomatenDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class AnpassungenFutterautoomat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ManuelleFuetterungModus",
                table: "Futterautomaten",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManuelleFuetterungModus",
                table: "Futterautomaten");
        }
    }
}
