using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "95140368-5cbe-46a2-8ff0-f573534cb391", 0, "35f2573e-dd1a-494b-a2e7-d3df1f325682", null, false, true, null, null, "JOHANS", "AQAAAAIAAYagAAAAEMKXq12n3UFaNbr4r479t5Cv0/1TX4d+rOkREcf6t71OnEiNwHOfkRbP3fpyYGqzwA==", null, false, "2QB3XVNXYN3E3JKGLPF37UNUDS57MJC2", false, "JohanS" },
                    { "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9", 0, "0558d82b-ffa4-4062-872b-44503afab407", null, false, true, null, null, "ANTONLIND", "AQAAAAIAAYagAAAAENFknXvfuKNKfZsKOeF9GPfQYvQEoam8DSPpVT7LGoTGBNTiIe4BXu1/0l+9XaJM0g==", null, false, "3KSCKA2ZWKSZLFTU6VTN2U47BE2WEQRN", false, "AntonLind" },
                    { "eeafdb89-38a4-4e6f-a3de-63b1491c0b86", 0, "9c4da45b-f1b9-4eb2-8f18-3a43694ebbe3", null, false, true, null, null, "FILIPNYDEN", "AQAAAAIAAYagAAAAEFoaZE49pEaPf8zFWKks5toaCa+Oyub/uiaNf+As4ukATlMiX23yBRjbUb3qTnZijQ==", null, false, "ZHC7O3BJZA6YHMG7J4LWDL7NW4VPWY3D", false, "filipnyden" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86");
        }
    }
}
