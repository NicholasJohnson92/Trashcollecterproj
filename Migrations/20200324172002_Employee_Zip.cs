using Microsoft.EntityFrameworkCore.Migrations;

namespace Garbarje.Migrations
{
    public partial class Employee_Zip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "EmployeeZipcode",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "608bed97-18a8-4e94-bfcc-45d21bc31801", "226e7c13-dc95-45d4-82bc-8a699c6845fb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13dffa3d-199a-400e-96b6-650edd3a2887", "0315576f-be53-4e2a-88f4-699363f8e74a", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eae97671-6a44-4014-9afb-0340a1d8a5d0", "2f9c3c25-4b39-40a3-a43d-6f6835fd5926", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13dffa3d-199a-400e-96b6-650edd3a2887");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "608bed97-18a8-4e94-bfcc-45d21bc31801");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eae97671-6a44-4014-9afb-0340a1d8a5d0");

            migrationBuilder.DropColumn(
                name: "EmployeeZipcode",
                table: "Employees");

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
    }
}
