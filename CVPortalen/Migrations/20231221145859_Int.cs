using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Int : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "a34e7d47-fd85-414f-a3fb-3e3b35eeaf2d", "AQAAAAIAAYagAAAAEJKGC+JW8TQgtMl1lxzo0RLNJYXjmHjOHddfcV6RS6fyD0t38nyIeUmd2EPAkD+IAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "513e4251-cbc9-4f44-9e0e-826d50d227b0", "AQAAAAIAAYagAAAAEEJ9/FovgkrqT4iLORum3vyDJ5xApVm39njqo8ZEo807Kgj3tbtL2fYbOXLE5Q+hMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1485af37-4da5-412b-82e6-1191f35bd6c6", "AQAAAAIAAYagAAAAEEKwsyO4oz+4yv8nQhkDeMwqEVTHKRm/QV410Qdr6+NRH0luBdQaCi8F7lmoAcelpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "270bb7f0-bc4f-4e03-aea0-102e62dea2e9", "AQAAAAIAAYagAAAAEIZeCQwmG+uVOkf1dorcKiYLZAwS/FR0dQ/PqpN/ffj8wxr0smSKG9cPmzm511bmmg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72647100-4b87-4487-afb3-10441cc4e945", "AQAAAAIAAYagAAAAEKLI8XkWfK2Gpzyasa1PL5Gy9/9R3PpRwUYTheg/cbi0obTpxX0plqXCFZks0GDIDg==" });

            migrationBuilder.UpdateData(
                table: "cVs",
                keyColumn: "CVId",
                keyValue: 1,
                column: "UserId",
                value: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86");

            migrationBuilder.UpdateData(
                table: "cVs",
                keyColumn: "CVId",
                keyValue: 2,
                column: "UserId",
                value: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86");

            migrationBuilder.CreateIndex(
                name: "IX_cVs_UserId",
                table: "cVs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_cVs_AspNetUsers_UserId",
                table: "cVs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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
