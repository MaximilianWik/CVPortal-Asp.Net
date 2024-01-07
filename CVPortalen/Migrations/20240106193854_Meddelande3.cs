using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Meddelande3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnvandareId",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_AnvandareId",
                table: "Messages",
                column: "AnvandareId");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_AnvandareId",
                table: "Messages",
                column: "AnvandareId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_AnvandareId",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_AnvandareId",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "AnvandareId",
                table: "Messages");
        }
    }
}
