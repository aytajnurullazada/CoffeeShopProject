using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Recipes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Recipes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_CategoryId",
                table: "Recipes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Categories_CategoryId",
                table: "Recipes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
