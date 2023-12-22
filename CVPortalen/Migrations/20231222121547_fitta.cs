using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class fitta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "beba9b23-7015-4010-8edc-8e2efdde0cc6", "AQAAAAIAAYagAAAAEGt/LbGtKVN9u3CW0apl47zpztdV66+q8nkml/qu9ZG7b4SLqOH50e/zofOLlyWCvQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a638e4e3-af84-4191-8080-cfe5f28c8687", "AQAAAAIAAYagAAAAEJfRTRJnXAVgnbu+ywyDyZx52/gYU6jlf+DP1/EAoWW56kFg5MUbDzQ7kNmYniS1lg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7905fbf9-64ee-4bc9-b012-935ba2b03aa6", "AQAAAAIAAYagAAAAEAYH1iX0BpmE8qd62ONZg0Fr+8VtncmD3e+ai4mnS/GXCK0gmRHTCftMYc7uKhgOxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8ae51814-6711-4a1f-8adb-2872ed1bfb3b", "AQAAAAIAAYagAAAAEKI6y+mODaLVByTbsaRYh6LzlOpOkx6gCQw0R5/ykE8nD0Pccm4b+SlxcmqtbdZAVQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "85d1a0e2-204c-4765-ae79-b94df98e598b", "AQAAAAIAAYagAAAAELFXt2i8sD63A5fjcGoFqoG1gMUODkjCtucnmAe3poLK5fBNfuRqvDICjKxPIG2JLA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "454605e9-8127-4a7d-8827-39ebeb1bc495", "AQAAAAIAAYagAAAAEN3+gj3lIVyNczEpJY3YUlQ6cL7JAVzBwwFrmcZC8mp8vsOZDzQ+jayrQFGEKq6A8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f9d28ce5-b8d3-40e4-ad98-cf848aafb540", "AQAAAAIAAYagAAAAEKbhc25nEQT4VaGmjgztxFTgoer93g5eX8DBfkzaTw+O3NdsB5L+1addH7BB72EfaA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9455528d-7358-4359-b6c4-da3ab7c1fd45", "AQAAAAIAAYagAAAAEOWM44LN8mX0lSP9UEO8djC4fLw385JsuRwEARLaYINboYdFuQkT9QwJJ6uUDe4MsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f90f09e-fe91-4cab-bedf-9dc9ba842d9b", "AQAAAAIAAYagAAAAEAaMkJWEGFOIhrwqogU8Yo7wj0dyuS81JCHRFZ2Jlmw7gPNP40HcBeEGwO+BxXT5MQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d07622fa-9c0a-428d-a75f-60aceadbd61b", "AQAAAAIAAYagAAAAEDmI1v5HjCZFjoact1ACUzBt4ngKSYjKJKfLVRKr+wrJ2MhDBxJTDgGbV5YZu8I2Kg==" });
        }
    }
}
