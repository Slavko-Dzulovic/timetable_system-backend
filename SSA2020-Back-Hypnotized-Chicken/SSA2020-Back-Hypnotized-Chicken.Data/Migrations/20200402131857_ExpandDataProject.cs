using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class ExpandDataProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_lecturers_subjects_subject_id",
                table: "lecturers");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_subjects_subject_id",
                table: "terms");

            migrationBuilder.DropIndex(
                name: "IX_terms_subject_id",
                table: "terms");

            migrationBuilder.DropIndex(
                name: "IX_lecturers_subject_id",
                table: "lecturers");

            migrationBuilder.DropColumn(
                name: "subject_id",
                table: "terms");

            migrationBuilder.DropColumn(
                name: "time",
                table: "terms");

            migrationBuilder.DropColumn(
                name: "weekday",
                table: "terms");

            migrationBuilder.DropColumn(
                name: "department",
                table: "schedules");

            migrationBuilder.DropColumn(
                name: "semester",
                table: "schedules");

            migrationBuilder.DropColumn(
                name: "year",
                table: "schedules");

            migrationBuilder.DropColumn(
                name: "subject_id",
                table: "lecturers");

            migrationBuilder.AlterColumn<short>(
                name: "schedule_id",
                table: "terms",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<short>(
                name: "weekday_id",
                table: "terms",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AlterColumn<short>(
                name: "id",
                table: "schedules",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<short>(
                name: "department_id",
                table: "schedules",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "schedules",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "semester_id",
                table: "schedules",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "semesters",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_semesters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subject_lecturers",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    lecturer_id = table.Column<short>(nullable: false),
                    subject_id = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subject_lecturers", x => x.id);
                    table.ForeignKey(
                        name: "FK_subject_lecturers_lecturers_lecturer_id",
                        column: x => x.lecturer_id,
                        principalTable: "lecturers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_subject_lecturers_subjects_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "weekdays",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weekdays", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    department_id = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.id);
                    table.ForeignKey(
                        name: "FK_modules_departments_department_id",
                        column: x => x.department_id,
                        principalTable: "departments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "semester_subjects",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    semester_id = table.Column<short>(nullable: false),
                    subject_id = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_semester_subjects", x => x.id);
                    table.ForeignKey(
                        name: "FK_semester_subjects_semesters_semester_id",
                        column: x => x.semester_id,
                        principalTable: "semesters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_semester_subjects_subjects_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "module_subjects",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    module_id = table.Column<short>(nullable: false),
                    subject_id = table.Column<short>(nullable: false),
                    is_optional = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_module_subjects", x => x.id);
                    table.ForeignKey(
                        name: "FK_module_subjects_modules_module_id",
                        column: x => x.module_id,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_module_subjects_subjects_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_terms_weekday_id",
                table: "terms",
                column: "weekday_id");

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

            migrationBuilder.CreateIndex(
                name: "IX_module_subjects_module_id",
                table: "module_subjects",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "IX_module_subjects_subject_id",
                table: "module_subjects",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_modules_department_id",
                table: "modules",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_semester_subjects_semester_id",
                table: "semester_subjects",
                column: "semester_id");

            migrationBuilder.CreateIndex(
                name: "IX_semester_subjects_subject_id",
                table: "semester_subjects",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_subject_lecturers_lecturer_id",
                table: "subject_lecturers",
                column: "lecturer_id");

            migrationBuilder.CreateIndex(
                name: "IX_subject_lecturers_subject_id",
                table: "subject_lecturers",
                column: "subject_id");

            migrationBuilder.AddForeignKey(
                name: "FK_schedules_departments_department_id",
                table: "schedules",
                column: "department_id",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schedules_semesters_semester_id",
                table: "schedules",
                column: "semester_id",
                principalTable: "semesters",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_schedules_departments_department_id",
                table: "schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_schedules_semesters_semester_id",
                table: "schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_terms_weekdays_weekday_id",
                table: "terms");

            migrationBuilder.DropTable(
                name: "module_subjects");

            migrationBuilder.DropTable(
                name: "semester_subjects");

            migrationBuilder.DropTable(
                name: "subject_lecturers");

            migrationBuilder.DropTable(
                name: "weekdays");

            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "semesters");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropIndex(
                name: "IX_terms_weekday_id",
                table: "terms");

            migrationBuilder.DropIndex(
                name: "IX_schedules_department_id",
                table: "schedules");

            migrationBuilder.DropIndex(
                name: "IX_schedules_semester_id",
                table: "schedules");

            migrationBuilder.DropColumn(
                name: "weekday_id",
                table: "terms");

            migrationBuilder.DropColumn(
                name: "department_id",
                table: "schedules");

            migrationBuilder.DropColumn(
                name: "name",
                table: "schedules");

            migrationBuilder.DropColumn(
                name: "semester_id",
                table: "schedules");

            migrationBuilder.AlterColumn<long>(
                name: "schedule_id",
                table: "terms",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(short));

            migrationBuilder.AddColumn<short>(
                name: "subject_id",
                table: "terms",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "time",
                table: "terms",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "weekday",
                table: "terms",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "schedules",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(short))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "department",
                table: "schedules",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "semester",
                table: "schedules",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "year",
                table: "schedules",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "subject_id",
                table: "lecturers",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateIndex(
                name: "IX_terms_subject_id",
                table: "terms",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_lecturers_subject_id",
                table: "lecturers",
                column: "subject_id");

            migrationBuilder.AddForeignKey(
                name: "FK_lecturers_subjects_subject_id",
                table: "lecturers",
                column: "subject_id",
                principalTable: "subjects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_terms_subjects_subject_id",
                table: "terms",
                column: "subject_id",
                principalTable: "subjects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
