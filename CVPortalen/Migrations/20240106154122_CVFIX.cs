using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class CVFIX : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titel",
                table: "cVs",
                newName: "Utbildningar");

            migrationBuilder.RenameColumn(
                name: "Beskrivning",
                table: "cVs",
                newName: "TidigareErfarenheter");

            migrationBuilder.RenameColumn(
                name: "Arbetsplats",
                table: "cVs",
                newName: "Kompetenser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Utbildningar",
                table: "cVs",
                newName: "Titel");

            migrationBuilder.RenameColumn(
                name: "TidigareErfarenheter",
                table: "cVs",
                newName: "Beskrivning");

            migrationBuilder.RenameColumn(
                name: "Kompetenser",
                table: "cVs",
                newName: "Arbetsplats");
        }
    }
}
