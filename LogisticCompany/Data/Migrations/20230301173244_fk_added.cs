using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticCompany.Data.Migrations
{
    /// <inheritdoc />
    public partial class fkadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_role_RoleId",
                table: "employee");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "employee",
                newName: "role_id");

            migrationBuilder.RenameIndex(
                name: "IX_employee_RoleId",
                table: "employee",
                newName: "IX_employee_role_id");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_role_role_id",
                table: "employee",
                column: "role_id",
                principalTable: "role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employee_role_role_id",
                table: "employee");

            migrationBuilder.RenameColumn(
                name: "role_id",
                table: "employee",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_employee_role_id",
                table: "employee",
                newName: "IX_employee_RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_employee_role_RoleId",
                table: "employee",
                column: "RoleId",
                principalTable: "role",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
