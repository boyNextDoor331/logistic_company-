using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticCompany.Data.Migrations
{
    /// <inheritdoc />
    public partial class fix007 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_waybill_client_ClientsId",
                table: "waybill");

            migrationBuilder.DropIndex(
                name: "IX_waybill_ClientsId",
                table: "waybill");

            migrationBuilder.DropColumn(
                name: "ClientsId",
                table: "waybill");

            migrationBuilder.CreateIndex(
                name: "IX_waybill_client_id",
                table: "waybill",
                column: "client_id");

            migrationBuilder.AddForeignKey(
                name: "FK_waybill_client_client_id",
                table: "waybill",
                column: "client_id",
                principalTable: "client",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_waybill_client_client_id",
                table: "waybill");

            migrationBuilder.DropIndex(
                name: "IX_waybill_client_id",
                table: "waybill");

            migrationBuilder.AddColumn<int>(
                name: "ClientsId",
                table: "waybill",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_waybill_ClientsId",
                table: "waybill",
                column: "ClientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_waybill_client_ClientsId",
                table: "waybill",
                column: "ClientsId",
                principalTable: "client",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
