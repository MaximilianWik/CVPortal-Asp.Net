using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Profils_ProfilId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProfilId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Profils",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Profils_UserId",
                table: "Profils",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Profils_AspNetUsers_UserId",
                table: "Profils",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profils_AspNetUsers_UserId",
                table: "Profils");

            migrationBuilder.DropIndex(
                name: "IX_Profils_UserId",
                table: "Profils");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Profils");

            migrationBuilder.AddColumn<int>(
                name: "ProfilId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfilId",
                table: "AspNetUsers",
                column: "ProfilId",
                unique: true,
                filter: "[ProfilId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Profils_ProfilId",
                table: "AspNetUsers",
                column: "ProfilId",
                principalTable: "Profils",
                principalColumn: "ProfilId");
        }
    }
}
