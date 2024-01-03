using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class HOOOOOORA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86");

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
                values: new object[] { "e7e8e851-5837-4a2d-9b26-c2af7485e0a7", "AQAAAAIAAYagAAAAELiGkmhf3kIus0K+rUQNiHeeU9bvyr33CUgICeTO6TKHJwAHxsyy2lDNaz5UA8fVnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4b44b8ce-47f7-4600-ae5e-5590ac2e6e1e", "AQAAAAIAAYagAAAAELhOs5VGDbBc4oN6huAzBdVDdlFIKMWuBHy9RPWhE+vf1nxZZYAqe96/OCKhiKwgYw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "81ba2d8f-0b12-4937-b2a8-002acc1ae914", "AQAAAAIAAYagAAAAEIP0put5fxDth46jxY0dy5rWfr9eqzoNExh9jpNFfAPw54US4pOSL66EUuDLiZQ6SQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "500b510d-c2a7-4ee8-802c-eac921f22672", "AQAAAAIAAYagAAAAEBwXYcPvrTr3PtiJwP5O+0DHQgz4Q3wJeGmuHf/GDN0Kjx6jATQLwp9HY5ZKS/3UCA==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "Fille", 0, "1ac47cfb-fa5b-4754-9b3c-93f27a44f1b0", null, false, true, null, null, "FILIPNYDEN", "AQAAAAIAAYagAAAAEPShWRnIlgTnw70pV0wPyboVv6v/X9FR0ecwI0vfyynFYNggjcIQooMZjvNE+68Ucw==", null, false, "ZHC7O3BJZA6YHMG7J4LWDL7NW4VPWY3D", false, "filipnyden" });

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

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Fille");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eeafdb89-38a4-4e6f-a3de-63b1491c0b86", 0, "676ac7ef-ffd5-4bb0-9934-d23e4592aae2", null, false, true, null, null, "FILIPNYDEN", "AQAAAAIAAYagAAAAED/JOA8TKeDVmCZuzkLtCDGMqpMCwkC8vEX7ojbi2Me0QVPltitoWNWVQcO85WWPhA==", null, false, "ZHC7O3BJZA6YHMG7J4LWDL7NW4VPWY3D", false, "filipnyden" });
        }
    }
}
