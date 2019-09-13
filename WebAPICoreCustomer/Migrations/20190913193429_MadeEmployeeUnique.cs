using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPICoreCustomer.Migrations
{
    public partial class MadeEmployeeUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IDX_Username",
                table: "Employees",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IDX_Username",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
