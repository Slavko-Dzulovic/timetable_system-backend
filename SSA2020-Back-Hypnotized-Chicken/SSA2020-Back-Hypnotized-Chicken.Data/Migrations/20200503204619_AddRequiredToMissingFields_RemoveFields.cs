using Microsoft.EntityFrameworkCore.Migrations;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class AddRequiredToMissingFields_RemoveFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_terms_schedules_schedule_id",
                table: "terms");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_slots_slot_id",
                table: "terms");

            migrationBuilder.RenameColumn(
                name: "slot_id",
                table: "terms",
                newName: "SlotId");

            migrationBuilder.RenameColumn(
                name: "schedule_id",
                table: "terms",
                newName: "ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_terms_slot_id",
                table: "terms",
                newName: "IX_terms_SlotId");

            migrationBuilder.RenameIndex(
                name: "IX_terms_schedule_id",
                table: "terms",
                newName: "IX_terms_ScheduleId");

            migrationBuilder.AlterColumn<long>(
                name: "SlotId",
                table: "terms",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<short>(
                name: "ScheduleId",
                table: "terms",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AddForeignKey(
                name: "FK_terms_schedules_ScheduleId",
                table: "terms",
                column: "ScheduleId",
                principalTable: "schedules",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_terms_slots_SlotId",
                table: "terms",
                column: "SlotId",
                principalTable: "slots",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_terms_schedules_ScheduleId",
                table: "terms");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_slots_SlotId",
                table: "terms");

            migrationBuilder.RenameColumn(
                name: "SlotId",
                table: "terms",
                newName: "slot_id");

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "terms",
                newName: "schedule_id");

            migrationBuilder.RenameIndex(
                name: "IX_terms_SlotId",
                table: "terms",
                newName: "IX_terms_slot_id");

            migrationBuilder.RenameIndex(
                name: "IX_terms_ScheduleId",
                table: "terms",
                newName: "IX_terms_schedule_id");

            migrationBuilder.AlterColumn<long>(
                name: "slot_id",
                table: "terms",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "schedule_id",
                table: "terms",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_terms_schedules_schedule_id",
                table: "terms",
                column: "schedule_id",
                principalTable: "schedules",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_terms_slots_slot_id",
                table: "terms",
                column: "slot_id",
                principalTable: "slots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
