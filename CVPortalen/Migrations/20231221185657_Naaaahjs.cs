using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class Naaaahjs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
