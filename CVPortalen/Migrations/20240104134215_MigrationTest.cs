using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class MigrationTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projekt_AspNetUsers_UserId",
                table: "projekt");

            migrationBuilder.DropIndex(
                name: "IX_projekt_UserId",
                table: "projekt");

            migrationBuilder.AddColumn<int>(
                name: "ProjektId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProjektId" },
                values: new object[] { "0f27a826-331e-46e1-9b4b-3a91fd3f2203", "AQAAAAIAAYagAAAAEKl1Ws7V8pQR7jio6f5T3XBFxML6ycKJ0UC/sNDvFfGG0q7nOY8qkTrRcnme4/VcUw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProjektId" },
                values: new object[] { "9b5717da-5d12-4efb-a0c0-9d8f2fe5a8eb", "AQAAAAIAAYagAAAAEDKwm/c3sKbYRrjj4cYofw5Vl/gBEkJ07vRAEXOlPW0ZcrteuXU84Zl8fbaZ444V6g==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProjektId" },
                values: new object[] { "d4d044f5-83fc-4800-9cc3-93cf193cf207", "AQAAAAIAAYagAAAAEB5cMXgsxns3pT3PEEiITdJ+whJdgLhVxlr/xEYNm8C/HafDaeJ17H22GJL1ylvkKw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProjektId" },
                values: new object[] { "38dddca8-6f32-4e16-8739-66dd8d63cfba", "AQAAAAIAAYagAAAAELX/XFR3g4sYF7hY4muOP75/bqIppCBy7FlTSI0A5vAcna1ffCIXyfxVVmBCJlNyDA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProjektId" },
                values: new object[] { "e2b1913d-fc56-448d-84b6-4cd047f05950", "AQAAAAIAAYagAAAAEAq4q7E7NmCKEddFr5A4N6twDAoRf9P626TAQE0LV0dlVRt8O/I70nHsiGDRPjrRkw==", null });

            migrationBuilder.CreateIndex(
                name: "IX_projekt_UserId",
                table: "projekt",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProjektId",
                table: "AspNetUsers",
                column: "ProjektId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_projekt_ProjektId",
                table: "AspNetUsers",
                column: "ProjektId",
                principalTable: "projekt",
                principalColumn: "ProjektId");

            migrationBuilder.AddForeignKey(
                name: "FK_projekt_AspNetUsers_UserId",
                table: "projekt",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_projekt_ProjektId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_projekt_AspNetUsers_UserId",
                table: "projekt");

            migrationBuilder.DropIndex(
                name: "IX_projekt_UserId",
                table: "projekt");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProjektId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProjektId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f5c333d-9429-4455-a644-67e579b61534", "AQAAAAIAAYagAAAAEA78X2TotHgCuUBrRCoSS0xDk8KX+Ju9wN61tOjg5+tv3WMHcA99qkhiJ3sd4ugy3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bcaffc02-87a5-42a0-bb58-3bda4920a75c", "AQAAAAIAAYagAAAAELL8rW7j4/BsEe4gk2AZC0urvNndfwFN4xh56EPfQ/bz8P84ocEnqrMr1SpzRrIORA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae5c5b68-83c5-40a7-aae0-7183675dd39b", "AQAAAAIAAYagAAAAEGv431VKUDzElS1BEorUVj94KPFc6vj37PDhRgXEFXYevhuhWcOvqqfUzEByLpp50g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "199b372d-903a-4889-983c-99af808cf86c", "AQAAAAIAAYagAAAAEPQ/NpKjEToCGywOcseJkrZkbPSvRifjmqOK55ZRgBMcv0QN5Qsw7T4OMM07kV3rhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e024f2d-6b14-434b-bae6-8db01ee240a9", "AQAAAAIAAYagAAAAEB9ARG0WebUNAh7R3QFXglbJh297btxtXs7vhacdlCjkxZHr8mMp31qpxpnAf7eXwA==" });

            migrationBuilder.CreateIndex(
                name: "IX_projekt_UserId",
                table: "projekt",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_projekt_AspNetUsers_UserId",
                table: "projekt",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
