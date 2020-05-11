using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class AddSlotRemoveDepartmentRequiredFromModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<long>(
                name: "SlotId",
                table: "terms",
                nullable: true);

            migrationBuilder.AlterColumn<short>(
                name: "DepartmentId",
                table: "modules",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.AlterColumn<string>(
                name: "location",
                table: "classrooms",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.CreateTable(
                name: "slots",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    subject_id = table.Column<short>(nullable: false),
                    module_id = table.Column<short>(nullable: false),
                    semester_id = table.Column<short>(nullable: false),
                    lecturer_id = table.Column<short>(nullable: false),
                    is_optional = table.Column<bool>(nullable: false),
                    optional_subject_number = table.Column<short>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_slots", x => x.id);
                    table.ForeignKey(
                        name: "FK_slots_lecturers_lecturer_id",
                        column: x => x.lecturer_id,
                        principalTable: "lecturers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_slots_modules_module_id",
                        column: x => x.module_id,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_slots_semesters_semester_id",
                        column: x => x.semester_id,
                        principalTable: "semesters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_slots_subjects_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_terms_SlotId",
                table: "terms",
                column: "SlotId");

            migrationBuilder.CreateIndex(
                name: "IX_slots_lecturer_id",
                table: "slots",
                column: "lecturer_id");

            migrationBuilder.CreateIndex(
                name: "IX_slots_module_id",
                table: "slots",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "IX_slots_semester_id",
                table: "slots",
                column: "semester_id");

            migrationBuilder.CreateIndex(
                name: "IX_slots_subject_id",
                table: "slots",
                column: "subject_id");

            migrationBuilder.AddForeignKey(
                name: "FK_modules_departments_DepartmentId",
                table: "modules",
                column: "DepartmentId",
                principalTable: "departments",
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
                name: "FK_modules_departments_DepartmentId",
                table: "modules");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_slots_SlotId",
                table: "terms");

            migrationBuilder.DropTable(
                name: "slots");

            migrationBuilder.DropIndex(
                name: "IX_terms_SlotId",
                table: "terms");

            migrationBuilder.DropColumn(
                name: "SlotId",
                table: "terms");

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
                type: "smallint",
                nullable: false,
                oldClrType: typeof(short),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "location",
                table: "classrooms",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_modules_departments_department_id",
                table: "modules",
                column: "department_id",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
