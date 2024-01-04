using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class test1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cVs_AspNetUsers_Anvandare",
                table: "cVs");

            migrationBuilder.DropIndex(
                name: "IX_cVs_Anvandare",
                table: "cVs");

            migrationBuilder.DropColumn(
                name: "Anvandare",
                table: "cVs");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "cVs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a04cce2-b63f-454c-af6e-159f2a211b53", "AQAAAAIAAYagAAAAEEmx/B7tYWIT3ltCOEdAulxf0jIGeLmi3u1EIAyrEZ6UiLhqUaQ2tZMQ10fE3y/3pQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6039eb9-2e43-480c-bbf6-4d4b19114e27", "AQAAAAIAAYagAAAAEKIRVGvgExadNKJ2NEqBwJFMHUaFI6Qx9KL0ZXHNYxiAKrxnoSoG66YoVVmhRKPeFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "268573ec-ce6b-4303-9f51-1f52968c0341", "AQAAAAIAAYagAAAAENbriVhjcfWuiaRemr4TfBr7/Bd4jiQdgsL3x60DkafaaME3SER79mKeqJBOxCC/Cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2cc9c1c3-bd94-4cd1-8404-4d9f392fb39f", "AQAAAAIAAYagAAAAEDXtucNXjyHRc5Ukx7iiH4ivrvGqH8yGsPyIGHDyiYYveHAyAkiLU27mSxnOi9VpXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18a95dc1-f46c-478c-9b78-2b448430892e", "AQAAAAIAAYagAAAAELtt4Ow7AaTIjP+C9lXmCYo1VQL9kPPAO4yl5M8ipyjzPBJM2Ks3j/AVfURYnwyovA==" });

            migrationBuilder.CreateIndex(
                name: "IX_cVs_UserId",
                table: "cVs",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_cVs_AspNetUsers_UserId",
                table: "cVs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cVs_AspNetUsers_UserId",
                table: "cVs");

            migrationBuilder.DropIndex(
                name: "IX_cVs_UserId",
                table: "cVs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "cVs");

            migrationBuilder.AddColumn<string>(
                name: "Anvandare",
                table: "cVs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32c1d1db-ca76-4b6d-a396-1e27678b23e2", "AQAAAAIAAYagAAAAEOTuq/I+LxRevZAwu4UfsV032zEpFDGYNAAnsplRFyHzVOLnKKM75kskxj6ZfmA2fQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "45c4d034-bb24-485f-9ec2-6f13e135a84c", "AQAAAAIAAYagAAAAENbWB6R9nb4ly7yt4thU6hI06qHJTUoT6ISGZrcmtG3AoGdo/sbb3nBpiXoUE/+E8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c1a99c9a-c51a-4132-ab88-15c52434bf0f", "AQAAAAIAAYagAAAAEIXUNlC/vGW/DHkcyrz25gY6OHSqaSiHXvyn6Y6Ylu1BFqUKVBnBd7lwOYSUTgVTnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d69df2bd-075b-4edc-aae5-4f555467f05a", "AQAAAAIAAYagAAAAECUYYQ0bAeG4L1D8Z/asNhKfSjTL5RRkS8kROwqnwM/e/g1wUyt3uH8ho6q3rPa3GQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e27a4c6-69a7-4cc5-89b0-d4ec4862b2e1", "AQAAAAIAAYagAAAAEMshLhj7t/o+Y1lex48ZeikUmUd5nAXgHFX7o5MSeJFBxi0KZbjhyVAjqN6fjh+m1Q==" });

            migrationBuilder.CreateIndex(
                name: "IX_cVs_Anvandare",
                table: "cVs",
                column: "Anvandare");

            migrationBuilder.AddForeignKey(
                name: "FK_cVs_AspNetUsers_Anvandare",
                table: "cVs",
                column: "Anvandare",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
