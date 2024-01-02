using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Test123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "676ac7ef-ffd5-4bb0-9934-d23e4592aae2", "AQAAAAIAAYagAAAAED/JOA8TKeDVmCZuzkLtCDGMqpMCwkC8vEX7ojbi2Me0QVPltitoWNWVQcO85WWPhA==" });
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
