using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CVPortalen.Migrations
{
    /// <inheritdoc />
    public partial class XDDDDD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25d150cf-9187-4a8b-9fba-301c1972ddee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "107dba7a-17b0-41c7-b44a-2aac9eb8decb", "AQAAAAIAAYagAAAAEGw4oIKxp65LIdO/0iaYMGGeSMPE3DtqNq88kprorsfkq3wlytLz7JguVL3GO+vBRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a3691cd-2dcf-4850-a5f0-43f653fecc1a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "241560a4-4b9b-48df-b093-b6d4c517c09a", "AQAAAAIAAYagAAAAELg2Pu+oWKDWBp4x4VOM5Vt/i8RPEbjw8nNQiUXMQYIfr+wG+BpwUBbxLw2MeyzRmw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95140368-5cbe-46a2-8ff0-f573534cb391",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ca3f2e7-34a1-4037-aa32-8293f4566b82", "AQAAAAIAAYagAAAAEKZ333LBmH0cyOumHWh1BC/Xbq2ZE1wKE4MObAEbkgpR9RONnBwOB4HDUwrJkVu/Rw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ccf1a123-7134-4ca2-9487-aa497f680489", "AQAAAAIAAYagAAAAEIqWQF1KFR14shSIzvwTbQOojldqNLNTjHqsO/YL5vfW97u6Tel74RhHMqktFTn02w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eeafdb89-38a4-4e6f-a3de-63b1491c0b86",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5809c45-2a87-4e49-bad8-d15ead81c55d", "AQAAAAIAAYagAAAAEDKBnzlSW6RDcBr8cTXWY3YVG3oc8SFXogRtfqJ2ZRzGGKiCxR+pK/ZMN62xf6megg==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
