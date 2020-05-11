using Microsoft.EntityFrameworkCore.Migrations;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class ChangeTermColumnNamesToSnakeCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_terms_classrooms_classroom_Id",
                table: "terms");

            migrationBuilder.RenameColumn(
                name: "classroom_Id",
                table: "terms",
                newName: "classroom_id");

            migrationBuilder.RenameIndex(
                name: "IX_terms_classroom_Id",
                table: "terms",
                newName: "IX_terms_classroom_id");

            migrationBuilder.AddForeignKey(
                name: "FK_terms_classrooms_classroom_id",
                table: "terms",
                column: "classroom_id",
                principalTable: "classrooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_terms_classrooms_classroom_id",
                table: "terms");

            migrationBuilder.RenameColumn(
                name: "classroom_id",
                table: "terms",
                newName: "classroom_Id");

            migrationBuilder.RenameIndex(
                name: "IX_terms_classroom_id",
                table: "terms",
                newName: "IX_terms_classroom_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_terms_classrooms_classroom_Id",
                table: "terms",
                column: "classroom_Id",
                principalTable: "classrooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
