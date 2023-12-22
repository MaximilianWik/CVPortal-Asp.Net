using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class lol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0a72702f-2db7-4931-9ed4-c9bb948bef2b", "AQAAAAIAAYagAAAAEM4SCAdDNS1GYffdC6Ce8fc8rYtxKjD8RWvPqEc7+x7f37fOX3y4kdGiZl/bIV0wdA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b288183e-e4c5-422a-af42-2801defaa04e", "AQAAAAIAAYagAAAAEITUP3K8TotchgoqffSAji5dyfd3e+RvPwl0/+CZRdY/K+IRP1hQzs9B+AmdesQq5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0dd38780-eeda-45a6-922b-c97ae2d56e92", "AQAAAAIAAYagAAAAEDGan4QujldnoFVXdislmVNV8CoUqevl0hBFVxZFuqohvmnI78Aq+aVBCJ+ev2N1fw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a70bc74a-155d-4f73-8d6c-9b72a0405db9", "AQAAAAIAAYagAAAAEFkbfEUrrL8GP/2bXXMV4v9/K7uu3NKMJL/R9FmodzW5TehOGQ0aEO/9FdS+xGRQFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7aee84cd-0330-4856-9087-0b6b6538780b", "AQAAAAIAAYagAAAAENQmdAXEkpPFe5zn5538RbK1fjjzcoH86jmyTjukj+YFF89SE7k11qg69tkcPhS3nA==" });
        }
    }
}
