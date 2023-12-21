using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class sugare : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee792ff0-e201-4107-b1b5-092745f1936c", "AQAAAAIAAYagAAAAEAzSU1526p/6cMRqry8TGIOdkBiGP6ZJgbgy+i+yswgpjDEJv2zoKHkW08xPgC2HqQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a310b3e4-93a9-4e34-b37c-849e2714044c", "AQAAAAIAAYagAAAAEJHN7xIlM3ZmubDIHFBuUEE2N/Z/vHkyJe1L3tKutzMKi9I1a+sxy1id4Y+wH4pF1g==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25d150cf-9187-4a8b-9fba-301c1972ddee", 0, "7ce1b204-b244-4da2-945a-0bdeba4c94cd", null, false, true, null, null, "MAXWIK", "AQAAAAIAAYagAAAAEKVLuAbnrhNET3/t2wEV5xUUclHThXqu+VDpWVbi2qsyIrMWkjujOMKWQSoTjvTYpg==", null, false, "WHIMEAWPQ44OOY5IIDFFD4444W3VLH3G", false, "MaxWik" },
                    { "2a3691cd-2dcf-4850-a5f0-43f653fecc1a", 0, "c17dfd21-8e36-4806-b454-7f52b19b5b22", null, false, true, null, null, "JACOBW", "AQAAAAIAAYagAAAAELIl/zBaI3G1ithUdh9VqAUVQIdU73mIbwrsOcz0KOMx4kKG8+W58IWYh3mOsjJ45g==", null, false, "S4LN2MR2XLOF2MAH2DALTCBZ6UMVJV22", false, "JacobW" },
                    { "95140368-5cbe-46a2-8ff0-f573534cb391", 0, "ed12af07-a40a-4ed7-8fda-ea62e16b6407", null, false, true, null, null, "JOHANS", "AQAAAAIAAYagAAAAEPw4alx7YJ1cLc9IPTwgZYy/P37rjSq1PEZlKJ2mPdbqZZuaLNxMG2mIISnuzU20UA==", null, false, "2QB3XVNXYN3E3JKGLPF37UNUDS57MJC2", false, "JohanS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6da61e52-bf37-49f8-9694-a09fb36b6edf", "AQAAAAIAAYagAAAAEBaseDlVqehAEiA64HeKwbR1paeMz165ulZ1gT3dFdWIMafojwBGWUFZZu6JIspuvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3137addf-aa23-45a1-924c-3e925756996a", "AQAAAAIAAYagAAAAEPKpmf+qcUoxQdtOZxGHRLChR2uY+FKXhahCRn98z7Xb49CANXBmt9LLrUfQ1bbCdA==" });
        }
    }
}
