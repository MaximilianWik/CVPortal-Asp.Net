using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class meddelanden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cVs",
                keyColumn: "CVId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "cVs",
                keyColumn: "CVId",
                keyValue: 2);

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReceiverId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SentAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e025c7cb-62c3-4ed4-88af-6feeb9ae43be", "AQAAAAIAAYagAAAAEC0sR676GGGIMzFXopGJyrcDvcHLOE8BV7t/012XybSjpBNgyt382xnoccvG0jd+XQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a0f34a7-aea0-4619-9af1-8d0548323884", "AQAAAAIAAYagAAAAEFWga5Tps9VQ+9uj6DozuUq8JRw0yq1kifJtxF9wrWVT+nTDJxoYkVr1Icm7mAaVhw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "32cf557e-a2c3-4bea-8b9a-c4cccc1e4148", "AQAAAAIAAYagAAAAEF2yrE+kNwUYu4V0NfyVeCOEmhb2QFER70vyaSt1ZjYfH8Qkybi7FNpDKc7iQ/4DAQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77366d65-4fac-424f-a1d9-a96350aba810", "AQAAAAIAAYagAAAAEIGClQf1GMSWl3oaJ5HkSoocDFdMO9dD68YFQD0KiWELAFL2tu8uBjxCF0cv5YnF7Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "baf590c3-b1d7-451e-ba2b-9a80ec37ad9f", "AQAAAAIAAYagAAAAEH5M0Z+w3BTfUboMZwwcLlwaRq9ostedSSADAmNrcRwjwvxXqusiIh5Eaiu3Lo0EFw==" });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ReceiverId",
                table: "Messages",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_SenderId",
                table: "Messages",
                column: "SenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

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

            migrationBuilder.InsertData(
                table: "cVs",
                columns: new[] { "CVId", "Arbetsplats", "Beskrivning", "Titel" },
                values: new object[,]
                {
                    { 1, "TestCO", "Hej", "Test1" },
                    { 2, "TestCO", "Hej", "Test2" }
                });
        }
    }
}
