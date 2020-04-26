using Microsoft.EntityFrameworkCore.Migrations;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class RemoveDepartmentRequiredFromModule_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_modules_departments_DepartmentId",
                table: "modules");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "modules",
                newName: "department_id");

            migrationBuilder.RenameIndex(
                name: "IX_modules_DepartmentId",
                table: "modules",
                newName: "IX_modules_department_id");

            migrationBuilder.AlterColumn<short>(
                name: "department_id",
                table: "modules",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_modules_departments_department_id",
                table: "modules",
                column: "department_id",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_modules_departments_department_id",
                table: "modules");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "modules",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_modules_department_id",
                table: "modules",
                newName: "IX_modules_DepartmentId");

            migrationBuilder.AlterColumn<short>(
                name: "DepartmentId",
                table: "modules",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(short));

            migrationBuilder.AddForeignKey(
                name: "FK_modules_departments_DepartmentId",
                table: "modules",
                column: "DepartmentId",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
