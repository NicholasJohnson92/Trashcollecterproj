using Microsoft.EntityFrameworkCore.Migrations;

namespace Garbarje.Migrations
{
    public partial class ModelDbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd74eb55-0ad4-4b37-86a7-acf9079f772c");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CusFirstName = table.Column<string>(nullable: true),
                    CusLastName = table.Column<string>(nullable: true),
                    CusAddress = table.Column<string>(nullable: true),
                    CusZipcode = table.Column<int>(nullable: false),
                    PickupDay = table.Column<string>(nullable: true),
                    HasRecycleBin = table.Column<bool>(nullable: false),
                    AccountBalance = table.Column<double>(nullable: false),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CId);
                    table.ForeignKey(
                        name: "FK_Customer_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFirstName = table.Column<string>(nullable: true),
                    EmployeeLastName = table.Column<string>(nullable: true),
                    IdentityUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EId);
                    table.ForeignKey(
                        name: "FK_Employees_AspNetUsers_IdentityUserId",
                        column: x => x.IdentityUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4a0fa191-31fd-4a57-89e0-7a1d4fcc157f", "83a48271-1da4-44a4-b92c-5fe654df71e3", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_IdentityUserId",
                table: "Customer",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityUserId",
                table: "Employees",
                column: "IdentityUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a0fa191-31fd-4a57-89e0-7a1d4fcc157f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cd74eb55-0ad4-4b37-86a7-acf9079f772c", "2e44ced4-8f8b-4a26-ac10-32fc9b121735", "Admin", "ADMIN" });
        }
    }
}
