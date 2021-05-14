using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class BasketAddedInCheckout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                table: "Checkouts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_BasketId",
                table: "Checkouts",
                column: "BasketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Baskets_BasketId",
                table: "Checkouts",
                column: "BasketId",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Baskets_BasketId",
                table: "Checkouts");

            migrationBuilder.DropIndex(
                name: "IX_Checkouts_BasketId",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "BasketId",
                table: "Checkouts");
        }
    }
}
