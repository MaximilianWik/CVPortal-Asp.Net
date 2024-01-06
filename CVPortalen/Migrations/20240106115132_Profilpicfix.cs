using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Profilpicfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a");

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

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfilePicture",
                table: "Profils",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePicture",
                table: "Profils");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilId", "ProjektId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25d150cf-9187-4a8b-9fba-301c1972ddee", 0, "f9099000-0959-4142-b03b-2693d732ea02", null, false, true, null, null, "MAXWIK", "AQAAAAIAAYagAAAAEP8L7VFbeFnOynCPD57qACQ5cq1bi1S1ZksiFgwhYLAle9gcRmOVXRGiY74fRX/gUw==", null, false, null, null, "WHIMEAWPQ44OOY5IIDFFD4444W3VLH3G", false, "MaxWik" },
                    { "2a3691cd-2dcf-4850-a5f0-43f653fecc1a", 0, "c3cae2ee-cb5c-4536-ac6a-c8de80570bd6", null, false, true, null, null, "JACOBW", "AQAAAAIAAYagAAAAEDTOpwD6u+Yq0aOpVUQjHccooUZ9ahfihTK8CBvkUgzLn71CLpb9cKGMlENPmA7/2g==", null, false, null, null, "S4LN2MR2XLOF2MAH2DALTCBZ6UMVJV22", false, "JacobW" },
                    { "95140368-5cbe-46a2-8ff0-f573534cb391", 0, "a4515f67-1677-460c-bdd9-968c9ecf6c05", null, false, true, null, null, "JOHANS", "AQAAAAIAAYagAAAAEFYUkVCR9EMCJVLMVOm9PoyHbZzBXpzbn2mNfQX12txYstR6YaPyL/Dg+OwIQ0hs8w==", null, false, null, null, "2QB3XVNXYN3E3JKGLPF37UNUDS57MJC2", false, "JohanS" },
                    { "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9", 0, "e53c3354-cb16-4acc-ae08-935c5e3c8f10", null, false, true, null, null, "ANTONLIND", "AQAAAAIAAYagAAAAEKrOFQLbax2rr83/fzpI0YnrjFkc0zlgNcTr49Si9C9kH3a9fhXcF1TyDzcQZMLZ5Q==", null, false, null, null, "3KSCKA2ZWKSZLFTU6VTN2U47BE2WEQRN", false, "AntonLind" },
                    { "eeafdb89-38a4-4e6f-a3de-63b1491c0b86", 0, "25a654e5-026e-4eb5-b23c-9837298b773c", null, false, true, null, null, "FILIPNYDEN", "AQAAAAIAAYagAAAAEDTGTwNGukccelj8ndvFTwjEGvvumfZ+qRJizYXMcFG2WUMrnm6D5u5CNwwlG4lK2g==", null, false, null, null, "ZHC7O3BJZA6YHMG7J4LWDL7NW4VPWY3D", false, "filipnyden" }
                });
        }
    }
}
