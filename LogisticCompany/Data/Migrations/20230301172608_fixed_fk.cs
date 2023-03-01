using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticCompany.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixedfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_role_employee_EmployeeId",
                table: "role");

            migrationBuilder.DropIndex(
                name: "IX_role_EmployeeId",
                table: "role");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "role");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_employee_RoleId",
                table: "employee",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_role_RoleId",
                table: "employee",
                column: "RoleId",
                principalTable: "role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_role_RoleId",
                table: "employee");

            migrationBuilder.DropIndex(
                name: "IX_employee_RoleId",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "employee");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "role",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_role_EmployeeId",
                table: "role",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_role_employee_EmployeeId",
                table: "role",
                column: "EmployeeId",
                principalTable: "employee",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
