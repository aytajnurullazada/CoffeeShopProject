using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class RecipeCategoryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecipeId",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_RecipeId",
                table: "Departments",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Recipes_RecipeId",
                table: "Departments",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Recipes_RecipeId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_RecipeId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "RecipeId",
                table: "Departments");
        }
    }
}
