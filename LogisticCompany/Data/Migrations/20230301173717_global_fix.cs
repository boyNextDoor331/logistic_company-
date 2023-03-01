using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticCompany.Data.Migrations
{
    /// <inheritdoc />
    public partial class globalfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_waybill_car_CarsId",
                table: "waybill");

            migrationBuilder.DropForeignKey(
                name: "FK_waybill_employee_EmployeeId",
                table: "waybill");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "waybill",
                newName: "employee_id");

            migrationBuilder.RenameColumn(
                name: "CarsId",
                table: "waybill",
                newName: "car_id");

            migrationBuilder.RenameIndex(
                name: "IX_waybill_EmployeeId",
                table: "waybill",
                newName: "IX_waybill_employee_id");

            migrationBuilder.RenameIndex(
                name: "IX_waybill_CarsId",
                table: "waybill",
                newName: "IX_waybill_car_id");

            migrationBuilder.AddColumn<int>(
                name: "client_id",
                table: "waybill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_waybill_car_car_id",
                table: "waybill",
                column: "car_id",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_waybill_employee_employee_id",
                table: "waybill",
                column: "employee_id",
                principalTable: "employee",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_waybill_car_car_id",
                table: "waybill");

            migrationBuilder.DropForeignKey(
                name: "FK_waybill_employee_employee_id",
                table: "waybill");

            migrationBuilder.DropColumn(
                name: "client_id",
                table: "waybill");

            migrationBuilder.RenameColumn(
                name: "employee_id",
                table: "waybill",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "car_id",
                table: "waybill",
                newName: "CarsId");

            migrationBuilder.RenameIndex(
                name: "IX_waybill_employee_id",
                table: "waybill",
                newName: "IX_waybill_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_waybill_car_id",
                table: "waybill",
                newName: "IX_waybill_CarsId");

            migrationBuilder.AddForeignKey(
                name: "FK_waybill_car_CarsId",
                table: "waybill",
                column: "CarsId",
                principalTable: "car",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_waybill_employee_EmployeeId",
                table: "waybill",
                column: "EmployeeId",
                principalTable: "employee",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
