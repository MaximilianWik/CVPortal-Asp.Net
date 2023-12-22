using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22e241fd-1bf4-4c7f-8684-44fb9e983ddf", "AQAAAAIAAYagAAAAEEAG/hq2tF4FdAaZMB4OfvDOdtMOohWKUYlauMmT7GpDNVsyYfo4lS8EalRud8S6uA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0e0ea8c-853a-4eed-b2c6-c4181cb49f64", "AQAAAAIAAYagAAAAELGnmkNnzz4OfUEvLl+oEmH2YXdTdvKDU1H/uo9BXLWi2W/94pkNOuIyyxyYBFRyDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab80fa37-a110-4b15-94e9-ff2c63d24586", "AQAAAAIAAYagAAAAEBfy45DhqCh/hRH5WXXOXKTg5khw9icVm3F3aSz4XWnMOl4+TT17xB4bpwMu0m89Aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21a746be-6f8d-4180-8bd1-e57236bcc5b2", "AQAAAAIAAYagAAAAEFIwExBrNfJ181Rw2zrSN8o5fRbPRmvFoUAs/bc++5nK/LL9YEV7jcLyzL0InVzycA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eed8bffe-6351-420f-8d37-cab8ca8b25ed", "AQAAAAIAAYagAAAAELURDTAOU6XHkTqM+B6HIoKSLjnAqXRJftnJh+kbfJ2IV9bMfX2dgHII4JD7otfzUA==" });

            migrationBuilder.InsertData(
                table: "cVs",
                columns: new[] { "CVId", "Arbetsplats", "Beskrivning", "Titel", "UserId" },
                values: new object[] { 3, "TestCO", "Hej", "Test3", "eeafdb89-38a4-4e6f-a3de-63b1491c0b86" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "cVs",
                keyColumn: "CVId",
                keyValue: 3);

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
        }
    }
}
