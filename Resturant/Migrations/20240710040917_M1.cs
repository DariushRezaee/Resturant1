using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resturant.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyOrders_Moshtari_CustomerMyId",
                table: "MyOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Moshtari",
                table: "Moshtari");

            migrationBuilder.RenameTable(
                name: "Moshtari",
                newName: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "StatusId1",
                table: "MyOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "MyId");

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "likes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostumerId = table.Column<int>(type: "int", nullable: false),
                    CostumerMyId = table.Column<long>(type: "bigint", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    LikeDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_likes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_likes_Comment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_likes_Customers_CostumerMyId",
                        column: x => x.CostumerMyId,
                        principalTable: "Customers",
                        principalColumn: "MyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyOrders_FoodId",
                table: "MyOrders",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MyOrders_StatusId1",
                table: "MyOrders",
                column: "StatusId1");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_FoodId",
                table: "Comment",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_likes_CommentId",
                table: "likes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_likes_CostumerMyId",
                table: "likes",
                column: "CostumerMyId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyOrders_Customers_CustomerMyId",
                table: "MyOrders",
                column: "CustomerMyId",
                principalTable: "Customers",
                principalColumn: "MyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyOrders_Food_FoodId",
                table: "MyOrders",
                column: "FoodId",
                principalTable: "Food",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyOrders_Status_StatusId1",
                table: "MyOrders",
                column: "StatusId1",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyOrders_Customers_CustomerMyId",
                table: "MyOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_MyOrders_Food_FoodId",
                table: "MyOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_MyOrders_Status_StatusId1",
                table: "MyOrders");

            migrationBuilder.DropTable(
                name: "likes");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropIndex(
                name: "IX_MyOrders_FoodId",
                table: "MyOrders");

            migrationBuilder.DropIndex(
                name: "IX_MyOrders_StatusId1",
                table: "MyOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "StatusId1",
                table: "MyOrders");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Moshtari");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moshtari",
                table: "Moshtari",
                column: "MyId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyOrders_Moshtari_CustomerMyId",
                table: "MyOrders",
                column: "CustomerMyId",
                principalTable: "Moshtari",
                principalColumn: "MyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
