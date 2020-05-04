using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class ChangedColumnNamesInTermToCamelCaseSoSlavkoWouldLikeIt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_terms_classrooms_classroom_id",
                table: "terms");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_schedules_schedule_id",
                table: "terms");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_slots_slot_id",
                table: "terms");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_weekdays_weekday_id",
                table: "terms");

            migrationBuilder.DropColumn(
                name: "time",
                table: "terms");

            migrationBuilder.RenameColumn(
                name: "weekday_id",
                table: "terms",
                newName: "weekdayId");

            migrationBuilder.RenameColumn(
                name: "slot_id",
                table: "terms",
                newName: "slotId");

            migrationBuilder.RenameColumn(
                name: "schedule_id",
                table: "terms",
                newName: "scheduleId");

            migrationBuilder.RenameColumn(
                name: "number_of_lectures",
                table: "terms",
                newName: "numberOfLectures");

            migrationBuilder.RenameColumn(
                name: "number_of_lab_exercises",
                table: "terms",
                newName: "numberOfLabExercises");

            migrationBuilder.RenameColumn(
                name: "number_of_exercises",
                table: "terms",
                newName: "numberOfExercises");

            migrationBuilder.RenameColumn(
                name: "classroom_id",
                table: "terms",
                newName: "classroomId");

            migrationBuilder.RenameIndex(
                name: "IX_terms_weekday_id",
                table: "terms",
                newName: "IX_terms_weekdayId");

            migrationBuilder.RenameIndex(
                name: "IX_terms_slot_id",
                table: "terms",
                newName: "IX_terms_slotId");

            migrationBuilder.RenameIndex(
                name: "IX_terms_schedule_id",
                table: "terms",
                newName: "IX_terms_scheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_terms_classroom_id",
                table: "terms",
                newName: "IX_terms_classroomId");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "endTime",
                table: "terms",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "startTime",
                table: "terms",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddForeignKey(
                name: "FK_terms_classrooms_classroomId",
                table: "terms",
                column: "classroomId",
                principalTable: "classrooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_terms_schedules_scheduleId",
                table: "terms",
                column: "scheduleId",
                principalTable: "schedules",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_terms_slots_slotId",
                table: "terms",
                column: "slotId",
                principalTable: "slots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_terms_weekdays_weekdayId",
                table: "terms",
                column: "weekdayId",
                principalTable: "weekdays",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_terms_classrooms_classroomId",
                table: "terms");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_schedules_scheduleId",
                table: "terms");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_slots_slotId",
                table: "terms");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_weekdays_weekdayId",
                table: "terms");

            migrationBuilder.DropColumn(
                name: "endTime",
                table: "terms");

            migrationBuilder.DropColumn(
                name: "startTime",
                table: "terms");

            migrationBuilder.RenameColumn(
                name: "weekdayId",
                table: "terms",
                newName: "weekday_id");

            migrationBuilder.RenameColumn(
                name: "slotId",
                table: "terms",
                newName: "slot_id");

            migrationBuilder.RenameColumn(
                name: "scheduleId",
                table: "terms",
                newName: "schedule_id");

            migrationBuilder.RenameColumn(
                name: "numberOfLectures",
                table: "terms",
                newName: "number_of_lectures");

            migrationBuilder.RenameColumn(
                name: "numberOfLabExercises",
                table: "terms",
                newName: "number_of_lab_exercises");

            migrationBuilder.RenameColumn(
                name: "numberOfExercises",
                table: "terms",
                newName: "number_of_exercises");

            migrationBuilder.RenameColumn(
                name: "classroomId",
                table: "terms",
                newName: "classroom_id");

            migrationBuilder.RenameIndex(
                name: "IX_terms_weekdayId",
                table: "terms",
                newName: "IX_terms_weekday_id");

            migrationBuilder.RenameIndex(
                name: "IX_terms_slotId",
                table: "terms",
                newName: "IX_terms_slot_id");

            migrationBuilder.RenameIndex(
                name: "IX_terms_scheduleId",
                table: "terms",
                newName: "IX_terms_schedule_id");

            migrationBuilder.RenameIndex(
                name: "IX_terms_classroomId",
                table: "terms",
                newName: "IX_terms_classroom_id");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "time",
                table: "terms",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddForeignKey(
                name: "FK_terms_classrooms_classroom_id",
                table: "terms",
                column: "classroom_id",
                principalTable: "classrooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_terms_weekdays_weekday_id",
                table: "terms",
                column: "weekday_id",
                principalTable: "weekdays",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
