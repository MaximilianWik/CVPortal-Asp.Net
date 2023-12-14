using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cVs",
                columns: table => new
                {
                    CVId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Arbetsplats = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beskrivning = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cVs", x => x.CVId);
                });

            migrationBuilder.CreateTable(
                name: "meddelande",
                columns: table => new
                {
                    MeddelandeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeddelandeText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkickatTill = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meddelande", x => x.MeddelandeId);
                });

            migrationBuilder.CreateTable(
                name: "Profils",
                columns: table => new
                {
                    ProfilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnvandarNamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Losenord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNummer = table.Column<int>(type: "int", nullable: false),
                    Epost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TillhorandeCV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profils", x => x.ProfilId);
                });

            migrationBuilder.CreateTable(
                name: "projekt",
                columns: table => new
                {
                    ProjektId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjektName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artal = table.Column<int>(type: "int", nullable: false),
                    Tid = table.Column<DateOnly>(type: "date", nullable: false),
                    Infromation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projekt", x => x.ProjektId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cVs");

            migrationBuilder.DropTable(
                name: "meddelande");

            migrationBuilder.DropTable(
                name: "Profils");

            migrationBuilder.DropTable(
                name: "projekt");
        }
    }
}
