using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class basket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_Products_ProductId",
                table: "Basket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Basket",
                table: "Basket");

            migrationBuilder.RenameTable(
                name: "Basket",
                newName: "Baskets");

            migrationBuilder.RenameIndex(
                name: "IX_Basket_ProductId",
                table: "Baskets",
                newName: "IX_Baskets_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Baskets_Products_ProductId",
                table: "Baskets",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Baskets_Products_ProductId",
                table: "Baskets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Baskets",
                table: "Baskets");

            migrationBuilder.RenameTable(
                name: "Baskets",
                newName: "Basket");

            migrationBuilder.RenameIndex(
                name: "IX_Baskets_ProductId",
                table: "Basket",
                newName: "IX_Basket_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Basket",
                table: "Basket",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_Products_ProductId",
                table: "Basket",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
