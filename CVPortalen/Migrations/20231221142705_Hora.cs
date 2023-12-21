using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Hora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6483b2c7-a1e7-44b5-8b6e-c84f4e2dfe9b", "AQAAAAIAAYagAAAAEGkfI5k3qugyqZF9N4mmxngDRLsC+ezguLome93JSYV2kcJgC7oPvQriRdn3CyGssw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e9028a3-ff90-46cc-ba40-427b860ecabf", "AQAAAAIAAYagAAAAED/hzhPUaK+jY17eeRHx9sUEwRs1HHYujDBk6OXgt5hRzxG7KFPa3l4Fx/pacXZ+7g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d17de43-73c6-486c-8b9b-f598b947ef46", "AQAAAAIAAYagAAAAEGBc8vWGrsq3F99+8XgQTkvBjvAicvwBcslbixl374z5ZoMtSHrYXLaQOY22qWg2ow==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "931d4fa8-a79f-4c69-a2cf-23397a3f0162", "AQAAAAIAAYagAAAAEEgrHiVfyUVXNF4oK28Qx7GduveJU+8GNwtuqgBohkvtPlbD+8rGJx6dbm6llRDpHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e3fdf53-3843-4bdd-ba81-e24de8144e8c", "AQAAAAIAAYagAAAAEOUuRsi102JGA7swZZjlrABGeVh9B766s1yO9pRSDVvU1sjaZW7m2X0aT1N1nzjXhA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
