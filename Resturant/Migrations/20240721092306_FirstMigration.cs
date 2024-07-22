using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resturant.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CodeEshterak",
                table: "Customers",
                newName: "Eshterak");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNubmber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Eshterak",
                table: "Customers",
                newName: "CodeEshterak");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNubmber",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
