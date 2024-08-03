using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutterautomatenDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class addPersonIdDifferent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Futterautomaten_Personen_PersonId",
                table: "Futterautomaten");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Futterautomaten",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Futterautomaten_Personen_PersonId",
                table: "Futterautomaten",
                column: "PersonId",
                principalTable: "Personen",
                principalColumn: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Futterautomaten_Personen_PersonId",
                table: "Futterautomaten");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Futterautomaten",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Futterautomaten_Personen_PersonId",
                table: "Futterautomaten",
                column: "PersonId",
                principalTable: "Personen",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
