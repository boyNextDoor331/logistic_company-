using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticCompany.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixcolumnname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "type",
                table: "client",
                newName: "address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "address",
                table: "client",
                newName: "type");
        }
    }
}
