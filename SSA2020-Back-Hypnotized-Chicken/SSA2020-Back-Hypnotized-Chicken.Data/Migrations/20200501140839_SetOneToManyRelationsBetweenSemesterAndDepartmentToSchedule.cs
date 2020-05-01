using Microsoft.EntityFrameworkCore.Migrations;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class SetOneToManyRelationsBetweenSemesterAndDepartmentToSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_schedules_department_id",
                table: "schedules");

            migrationBuilder.DropIndex(
                name: "IX_schedules_semester_id",
                table: "schedules");

            migrationBuilder.CreateIndex(
                name: "IX_schedules_semester_id",
                table: "schedules",
                column: "semester_id");

            migrationBuilder.CreateIndex(
                name: "IX_schedules_department_id_semester_id",
                table: "schedules",
                columns: new[] { "department_id", "semester_id" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_schedules_semester_id",
                table: "schedules");

            migrationBuilder.DropIndex(
                name: "IX_schedules_department_id_semester_id",
                table: "schedules");

            migrationBuilder.CreateIndex(
                name: "IX_schedules_department_id",
                table: "schedules",
                column: "department_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_schedules_semester_id",
                table: "schedules",
                column: "semester_id",
                unique: true);
        }
    }
}
