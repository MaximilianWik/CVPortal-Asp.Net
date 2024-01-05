using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class profilfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "ProfilId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilId" },
                values: new object[] { "f9099000-0959-4142-b03b-2693d732ea02", "AQAAAAIAAYagAAAAEP8L7VFbeFnOynCPD57qACQ5cq1bi1S1ZksiFgwhYLAle9gcRmOVXRGiY74fRX/gUw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilId" },
                values: new object[] { "c3cae2ee-cb5c-4536-ac6a-c8de80570bd6", "AQAAAAIAAYagAAAAEDTOpwD6u+Yq0aOpVUQjHccooUZ9ahfihTK8CBvkUgzLn71CLpb9cKGMlENPmA7/2g==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilId" },
                values: new object[] { "a4515f67-1677-460c-bdd9-968c9ecf6c05", "AQAAAAIAAYagAAAAEFYUkVCR9EMCJVLMVOm9PoyHbZzBXpzbn2mNfQX12txYstR6YaPyL/Dg+OwIQ0hs8w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilId" },
                values: new object[] { "e53c3354-cb16-4acc-ae08-935c5e3c8f10", "AQAAAAIAAYagAAAAEKrOFQLbax2rr83/fzpI0YnrjFkc0zlgNcTr49Si9C9kH3a9fhXcF1TyDzcQZMLZ5Q==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilId" },
                values: new object[] { "25a654e5-026e-4eb5-b23c-9837298b773c", "AQAAAAIAAYagAAAAEDTGTwNGukccelj8ndvFTwjEGvvumfZ+qRJizYXMcFG2WUMrnm6D5u5CNwwlG4lK2g==", null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
