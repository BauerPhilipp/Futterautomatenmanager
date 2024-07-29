using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutterautomatenDatenbank.Migrations
{
    /// <inheritdoc />
    public partial class AddFutterautomatendatenbank : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aquarien",
                columns: table => new
                {
                    AquariumId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Aufstellort = table.Column<string>(type: "TEXT", nullable: false),
                    Groeße = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aquarien", x => x.AquariumId);
                });

            migrationBuilder.CreateTable(
                name: "FutterArt",
                columns: table => new
                {
                    FutterId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Packungsinhalt = table.Column<float>(type: "REAL", nullable: false),
                    FutterName = table.Column<string>(type: "TEXT", nullable: false),
                    Beschreibung = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FutterArt", x => x.FutterId);
                });

            migrationBuilder.CreateTable(
                name: "Personen",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personen", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Futterautomaten",
                columns: table => new
                {
                    FutterautomatId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FutterFaktor = table.Column<float>(type: "REAL", nullable: false),
                    FutterId = table.Column<int>(type: "INTEGER", nullable: true),
                    AquariumId = table.Column<int>(type: "INTEGER", nullable: true),
                    PersonId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Futterautomaten", x => x.FutterautomatId);
                    table.ForeignKey(
                        name: "FK_Futterautomaten_Aquarien_AquariumId",
                        column: x => x.AquariumId,
                        principalTable: "Aquarien",
                        principalColumn: "AquariumId");
                    table.ForeignKey(
                        name: "FK_Futterautomaten_FutterArt_FutterId",
                        column: x => x.FutterId,
                        principalTable: "FutterArt",
                        principalColumn: "FutterId");
                    table.ForeignKey(
                        name: "FK_Futterautomaten_Personen_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Personen",
                        principalColumn: "PersonId");
                });

            migrationBuilder.CreateTable(
                name: "Fuetterungen",
                columns: table => new
                {
                    FuetterungId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Futtermenge = table.Column<float>(type: "REAL", nullable: false),
                    Tag = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Uhrzeit = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    FutterautomatId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuetterungen", x => x.FuetterungId);
                    table.ForeignKey(
                        name: "FK_Fuetterungen_Futterautomaten_FutterautomatId",
                        column: x => x.FutterautomatId,
                        principalTable: "Futterautomaten",
                        principalColumn: "FutterautomatId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fuetterungen_FutterautomatId",
                table: "Fuetterungen",
                column: "FutterautomatId");

            migrationBuilder.CreateIndex(
                name: "IX_Futterautomaten_AquariumId",
                table: "Futterautomaten",
                column: "AquariumId");

            migrationBuilder.CreateIndex(
                name: "IX_Futterautomaten_FutterId",
                table: "Futterautomaten",
                column: "FutterId");

            migrationBuilder.CreateIndex(
                name: "IX_Futterautomaten_PersonId",
                table: "Futterautomaten",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fuetterungen");

            migrationBuilder.DropTable(
                name: "Futterautomaten");

            migrationBuilder.DropTable(
                name: "Aquarien");

            migrationBuilder.DropTable(
                name: "FutterArt");

            migrationBuilder.DropTable(
                name: "Personen");
        }
    }
}
