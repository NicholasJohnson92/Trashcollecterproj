using Microsoft.EntityFrameworkCore.Migrations;

namespace Garbarje.Migrations
{
    public partial class SeedingRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a0fa191-31fd-4a57-89e0-7a1d4fcc157f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8ab0c817-9d62-401b-aeda-4961125e9e11", "11321509-900c-444d-9d7f-8a250a411064", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "43c6f040-b967-4ae8-977c-8d88f186f4bb", "8096fd8e-310a-44ad-8170-ae719011a602", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8d9429f8-aa19-42af-a11d-9846377a2d86", "5babc81a-53fb-4ce5-88ce-6e92e186e925", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43c6f040-b967-4ae8-977c-8d88f186f4bb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ab0c817-9d62-401b-aeda-4961125e9e11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d9429f8-aa19-42af-a11d-9846377a2d86");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a0fa191-31fd-4a57-89e0-7a1d4fcc157f", "83a48271-1da4-44a4-b92c-5fe654df71e3", "Admin", "ADMIN" });
        }
    }
}
