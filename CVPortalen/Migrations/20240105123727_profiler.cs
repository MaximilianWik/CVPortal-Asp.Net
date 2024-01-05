using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class profiler : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TillhorandeCV",
                table: "Profils");

            migrationBuilder.AddColumn<string>(
                name: "UserIdId",
                table: "Profils",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db76f920-3138-4784-b915-a1eb0875fd78", "AQAAAAIAAYagAAAAEImyYPgXu7sYmqDhD+GB18QBk9llMczqpHpxqOELbXVCJ1OaXCw+FnAZtL94dJuRJg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f28a409-42f6-499a-a2ff-a2a312eb3a80", "AQAAAAIAAYagAAAAEPg9K3J6yG3esodfkrceGJnAgMDX2QgXNAfBlfmlflJ/+uSGIdWYuL0++gbUeQWx4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0abdc6d3-8581-4a43-bf3e-c58369af98c1", "AQAAAAIAAYagAAAAEHASprb4makdS40No7EGC9jyVXzMsd9LUN6jw4TvW/sw4305dDMprpkRosMuDOupTQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0175bc5-bc3b-4657-9d0d-7b569fc89520", "AQAAAAIAAYagAAAAEMP0vfUvfdLAcoc2DYu+rmcmHo6GwBbo+QRNvxp49UZiYq5/axRW4U4JcN6WGC6kvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "76bd799f-c54f-48f0-b745-f89e8a9a3590", "AQAAAAIAAYagAAAAEFY7OpRLQ8d/hmbswet9DuhwGEHeAUtPDpG4Ze6LaGXYeI2aSm+NnlDpTv26WhHYRQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Profils_UserIdId",
                table: "Profils",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profils_AspNetUsers_UserIdId",
                table: "Profils",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profils_AspNetUsers_UserIdId",
                table: "Profils");

            migrationBuilder.DropIndex(
                name: "IX_Profils_UserIdId",
                table: "Profils");

            migrationBuilder.DropColumn(
                name: "UserIdId",
                table: "Profils");

            migrationBuilder.AddColumn<int>(
                name: "TillhorandeCV",
                table: "Profils",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f27a826-331e-46e1-9b4b-3a91fd3f2203", "AQAAAAIAAYagAAAAEKl1Ws7V8pQR7jio6f5T3XBFxML6ycKJ0UC/sNDvFfGG0q7nOY8qkTrRcnme4/VcUw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b5717da-5d12-4efb-a0c0-9d8f2fe5a8eb", "AQAAAAIAAYagAAAAEDKwm/c3sKbYRrjj4cYofw5Vl/gBEkJ07vRAEXOlPW0ZcrteuXU84Zl8fbaZ444V6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4d044f5-83fc-4800-9cc3-93cf193cf207", "AQAAAAIAAYagAAAAEB5cMXgsxns3pT3PEEiITdJ+whJdgLhVxlr/xEYNm8C/HafDaeJ17H22GJL1ylvkKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38dddca8-6f32-4e16-8739-66dd8d63cfba", "AQAAAAIAAYagAAAAELX/XFR3g4sYF7hY4muOP75/bqIppCBy7FlTSI0A5vAcna1ffCIXyfxVVmBCJlNyDA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e2b1913d-fc56-448d-84b6-4cd047f05950", "AQAAAAIAAYagAAAAEAq4q7E7NmCKEddFr5A4N6twDAoRf9P626TAQE0LV0dlVRt8O/I70nHsiGDRPjrRkw==" });
        }
    }
}
