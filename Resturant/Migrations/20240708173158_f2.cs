using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resturant.Migrations
{
    /// <inheritdoc />
    public partial class f2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Moshtari",
                table: "Moshtari");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Moshtari");

            migrationBuilder.AddColumn<long>(
                name: "MyId",
                table: "Moshtari",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moshtari",
                table: "Moshtari",
                column: "MyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Moshtari",
                table: "Moshtari");

            migrationBuilder.DropColumn(
                name: "MyId",
                table: "Moshtari");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Moshtari",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moshtari",
                table: "Moshtari",
                column: "Id");
        }
    }
}
