using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c5b0a043-2b3b-4dc6-b47e-ee95b5705774", "AQAAAAIAAYagAAAAELB4QsG0S0t95cOwqLCw5kLsrBoPwFP1uDijHr0Yk1ShLcTWyANU7MNrkS4rbTzKpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "281b6c2a-2420-49a3-88ba-6432b693aaeb", "AQAAAAIAAYagAAAAECcMk1GXkSt2aT+NI1btY9mNQZmU0yETBEr0O5G7UOkhR8t6UI+98UNTbwr48yS/FA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d1c31ee-df55-48cb-843b-73a01e622b0a", "AQAAAAIAAYagAAAAELc1fVsVohTrLueDpXoSKeeUY9bLhergSYtEiTtLYNl4pP+B9v7p+bRzA3zq//Sy0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "862a45ab-4b06-4215-bea6-c61705fc13e9", "AQAAAAIAAYagAAAAEEFeWH8gpeV8DdUh/6VTnzsxDojtpXrOJACnpyBNbKyoQa3wSo0BNI1tUT7gjM6cag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "676ac7ef-ffd5-4bb0-9934-d23e4592aae2", "AQAAAAIAAYagAAAAED/JOA8TKeDVmCZuzkLtCDGMqpMCwkC8vEX7ojbi2Me0QVPltitoWNWVQcO85WWPhA==" });
        }
    }
}
