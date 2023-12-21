using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class boom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0558d82b-ffa4-4062-872b-44503afab407", "AQAAAAIAAYagAAAAENFknXvfuKNKfZsKOeF9GPfQYvQEoam8DSPpVT7LGoTGBNTiIe4BXu1/0l+9XaJM0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c4da45b-f1b9-4eb2-8f18-3a43694ebbe3", "AQAAAAIAAYagAAAAEFoaZE49pEaPf8zFWKks5toaCa+Oyub/uiaNf+As4ukATlMiX23yBRjbUb3qTnZijQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "95140368-5cbe-46a2-8ff0-f573534cb391", 0, "35f2573e-dd1a-494b-a2e7-d3df1f325682", null, false, true, null, null, "JOHANS", "AQAAAAIAAYagAAAAEMKXq12n3UFaNbr4r479t5Cv0/1TX4d+rOkREcf6t71OnEiNwHOfkRbP3fpyYGqzwA==", null, false, "2QB3XVNXYN3E3JKGLPF37UNUDS57MJC2", false, "JohanS" });
        }
    }
}
