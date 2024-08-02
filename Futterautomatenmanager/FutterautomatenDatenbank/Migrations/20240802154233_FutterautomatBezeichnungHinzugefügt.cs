using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutterautomatenDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class FutterautomatBezeichnungHinzugefügt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bezeichnung",
                table: "Futterautomaten",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bezeichnung",
                table: "Futterautomaten");
        }
    }
}
