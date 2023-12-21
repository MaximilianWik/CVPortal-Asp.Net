using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Sugars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93973063-9a1d-4cea-b5d0-c5ab965f575d", "AQAAAAIAAYagAAAAEBGCmYUXyJzdXobR+ULI0b0SAeG3JTJ3Tg/M/rRX+SfoKwV3JcHgx3XG5Lz+gLvqSA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "590905f5-e623-4517-aa36-8b0b7e695aba", "AQAAAAIAAYagAAAAEFBlLba4VSttsLkx9+TB27pTuVkUiCV15FQM/xB0oRJkfwh1T4NqzWsqV7FaOdJFnA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fc7adadd-3e57-4f32-b314-7dd9f051ac23", "AQAAAAIAAYagAAAAEM0ddvoGbbxR52uodQsLdU1joRdpexV/pgOMsFgDxiO00XZXtvHdSbrX9GP1c59weg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a9188ac-074c-4097-8fdb-5d86569bce4e", "AQAAAAIAAYagAAAAEI3TpPyaqjiUt2VYc4AeRnmPvHH2ayepYPYfSIOTGxaVpEANZ+tNLTzAPIHTAO4+uw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ed9f6b7-7994-4996-8142-a4d9cd29b3fe", "AQAAAAIAAYagAAAAEOK39yxim+kFvluBlAmPpm84q3dKtxrwTFPEmXohC7UA5rvH5RouCui2fIeDyR2ClA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
