using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutterautomatenDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class WiederholendeFuetterung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "WiederholendeFuetterung",
                table: "Fuetterungen",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WiederholendeFuetterung",
                table: "Fuetterungen");
        }
    }
}
