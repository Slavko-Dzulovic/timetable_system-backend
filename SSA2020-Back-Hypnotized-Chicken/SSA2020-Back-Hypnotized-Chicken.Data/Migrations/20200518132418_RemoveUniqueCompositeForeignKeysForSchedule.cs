using Microsoft.EntityFrameworkCore.Migrations;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class RemoveUniqueCompositeForeignKeysForSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_schedules_department_id_semester_id",
                table: "schedules");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_schedules_department_id_semester_id",
                table: "schedules",
                columns: new[] { "department_id", "semester_id" },
                unique: true);
        }
    }
}
