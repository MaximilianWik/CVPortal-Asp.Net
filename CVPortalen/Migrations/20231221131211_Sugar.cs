using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Sugar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21f28f1c-957a-4daf-840c-6f418efa1d27", "AQAAAAIAAYagAAAAECb3hhXh+PSZ5S/Qu/0q84weqGVahX11ZIug1N6ZACD+HIjsZfbWbz5tP3UIIKX6vw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a846724d-79a9-43ca-9cd9-ef7714322447", "AQAAAAIAAYagAAAAECz0jQBWKaLceG96fQtaSK1oNdUYyLtudO8i88XQeaEur1wemrG3WMMBs/K7Yx5YHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "546a5521-c0b3-434d-b3df-1ae5973ecb54", "AQAAAAIAAYagAAAAEMXC/lY3tbpGHLgzXHSe+XBPrNk1qBRh3fzuh4WegZjH8zb6oTDeXHboxYyFcQj8rg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0533d953-ffba-442d-a99b-9368479a2969", "AQAAAAIAAYagAAAAEALc0XkwA+lz9cyoKHl396wtSVcLEtpdidrxuo3nRV038x0Hl5hm4ghNOr6iv+e6wA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "00fdeed5-06f6-4b9c-ac0e-fe09ca76e20d", "AQAAAAIAAYagAAAAEGOFMLWAEJf5pY+7keP7dhp0TjCaNWg92ylUGOhZyeWYSGeuRhonpIkUsdLAf5xSvw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ce1b204-b244-4da2-945a-0bdeba4c94cd", "AQAAAAIAAYagAAAAEKVLuAbnrhNET3/t2wEV5xUUclHThXqu+VDpWVbi2qsyIrMWkjujOMKWQSoTjvTYpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c17dfd21-8e36-4806-b454-7f52b19b5b22", "AQAAAAIAAYagAAAAELIl/zBaI3G1ithUdh9VqAUVQIdU73mIbwrsOcz0KOMx4kKG8+W58IWYh3mOsjJ45g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed12af07-a40a-4ed7-8fda-ea62e16b6407", "AQAAAAIAAYagAAAAEPw4alx7YJ1cLc9IPTwgZYy/P37rjSq1PEZlKJ2mPdbqZZuaLNxMG2mIISnuzU20UA==" });

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
        }
    }
}
