using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Nyt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bbe6c399-17af-47e8-9e46-2f0112fae52f", "AQAAAAIAAYagAAAAELVSI5c1Twrj+HA8p30su7QMqbxqO01Kd1DC0EF2yTqtFFcCvlT4i/LxjGxuhvubtQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "403e284a-0406-416d-8e92-7904496d8728", "AQAAAAIAAYagAAAAEBeIjDWnY6O20xGtSAKTEiUg7h1EIp48V5rAGTknLAhG+1rSt+c7MHBWtqqiJK8Qag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "472ef502-2759-4825-a564-00e424554bc9", "AQAAAAIAAYagAAAAELts6YFN5jCvC6f3xRV5+rw4aHz3J+++GtCcAddGjIxygatDgnXxGNp0tBbMPikrhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "931942b6-75e7-4ef8-9605-44dcb2ec0382", "AQAAAAIAAYagAAAAEJI11rEHfo/J0Z6oc3Wc/kbT9D1fGWBlkvlIxq1Ztn8twbe30InDdQK/VMrLjpXNcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f7e3b92-3758-439f-bba9-136d2b5ccb4d", "AQAAAAIAAYagAAAAEJozCXfZ8dJj5lD++oGAaXkXMNXc1cXtug9DQbVYtQ6CzaI/GGlrr7Lr2SqKfI+Yfw==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a04cce2-b63f-454c-af6e-159f2a211b53", "AQAAAAIAAYagAAAAEEmx/B7tYWIT3ltCOEdAulxf0jIGeLmi3u1EIAyrEZ6UiLhqUaQ2tZMQ10fE3y/3pQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6039eb9-2e43-480c-bbf6-4d4b19114e27", "AQAAAAIAAYagAAAAEKIRVGvgExadNKJ2NEqBwJFMHUaFI6Qx9KL0ZXHNYxiAKrxnoSoG66YoVVmhRKPeFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "268573ec-ce6b-4303-9f51-1f52968c0341", "AQAAAAIAAYagAAAAENbriVhjcfWuiaRemr4TfBr7/Bd4jiQdgsL3x60DkafaaME3SER79mKeqJBOxCC/Cw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2cc9c1c3-bd94-4cd1-8404-4d9f392fb39f", "AQAAAAIAAYagAAAAEDXtucNXjyHRc5Ukx7iiH4ivrvGqH8yGsPyIGHDyiYYveHAyAkiLU27mSxnOi9VpXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18a95dc1-f46c-478c-9b78-2b448430892e", "AQAAAAIAAYagAAAAELtt4Ow7AaTIjP+C9lXmCYo1VQL9kPPAO4yl5M8ipyjzPBJM2Ks3j/AVfURYnwyovA==" });
        }
    }
}
