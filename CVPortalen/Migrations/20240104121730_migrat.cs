using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class migrat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "projekt",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f5c333d-9429-4455-a644-67e579b61534", "AQAAAAIAAYagAAAAEA78X2TotHgCuUBrRCoSS0xDk8KX+Ju9wN61tOjg5+tv3WMHcA99qkhiJ3sd4ugy3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bcaffc02-87a5-42a0-bb58-3bda4920a75c", "AQAAAAIAAYagAAAAELL8rW7j4/BsEe4gk2AZC0urvNndfwFN4xh56EPfQ/bz8P84ocEnqrMr1SpzRrIORA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae5c5b68-83c5-40a7-aae0-7183675dd39b", "AQAAAAIAAYagAAAAEGv431VKUDzElS1BEorUVj94KPFc6vj37PDhRgXEFXYevhuhWcOvqqfUzEByLpp50g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "199b372d-903a-4889-983c-99af808cf86c", "AQAAAAIAAYagAAAAEPQ/NpKjEToCGywOcseJkrZkbPSvRifjmqOK55ZRgBMcv0QN5Qsw7T4OMM07kV3rhA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1e024f2d-6b14-434b-bae6-8db01ee240a9", "AQAAAAIAAYagAAAAEB9ARG0WebUNAh7R3QFXglbJh297btxtXs7vhacdlCjkxZHr8mMp31qpxpnAf7eXwA==" });

            migrationBuilder.CreateIndex(
                name: "IX_projekt_UserId",
                table: "projekt",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_projekt_AspNetUsers_UserId",
                table: "projekt",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projekt_AspNetUsers_UserId",
                table: "projekt");

            migrationBuilder.DropIndex(
                name: "IX_projekt_UserId",
                table: "projekt");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "projekt");

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
    }
}
