using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "classrooms",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    label = table.Column<string>(maxLength: 255, nullable: false),
                    location = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classrooms", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "schedules",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    department = table.Column<string>(maxLength: 255, nullable: false),
                    semester = table.Column<short>(nullable: false),
                    year = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schedules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subjects",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    name = table.Column<string>(maxLength: 255, nullable: false),
                    optional_id = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subjects", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lecturers",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    first_name = table.Column<string>(maxLength: 255, nullable: false),
                    last_name = table.Column<string>(maxLength: 255, nullable: false),
                    vocation = table.Column<string>(maxLength: 255, nullable: true),
                    subject_id = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lecturers", x => x.id);
                    table.ForeignKey(
                        name: "FK_lecturers_subjects_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "terms",
                columns: table => new
                {
                    id = table.Column<short>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(nullable: false),
                    updated_at = table.Column<DateTime>(nullable: false),
                    weekday = table.Column<string>(maxLength: 255, nullable: false),
                    time = table.Column<string>(maxLength: 255, nullable: false),
                    number_of_lectures = table.Column<short>(nullable: false),
                    number_of_exercises = table.Column<short>(nullable: false),
                    number_of_lab_exercises = table.Column<short>(nullable: false),
                    group = table.Column<short>(nullable: false),
                    module = table.Column<string>(nullable: true),
                    subject_id = table.Column<short>(nullable: false),
                    classroom_id = table.Column<short>(nullable: false),
                    schedule_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_terms", x => x.id);
                    table.ForeignKey(
                        name: "FK_terms_classrooms_classroom_id",
                        column: x => x.classroom_id,
                        principalTable: "classrooms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_terms_schedules_schedule_id",
                        column: x => x.schedule_id,
                        principalTable: "schedules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_terms_subjects_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subjects",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_lecturers_subject_id",
                table: "lecturers",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "IX_terms_classroom_id",
                table: "terms",
                column: "classroom_id");

            migrationBuilder.CreateIndex(
                name: "IX_terms_schedule_id",
                table: "terms",
                column: "schedule_id");

            migrationBuilder.CreateIndex(
                name: "IX_terms_subject_id",
                table: "terms",
                column: "subject_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lecturers");

            migrationBuilder.DropTable(
                name: "terms");

            migrationBuilder.DropTable(
                name: "classrooms");

            migrationBuilder.DropTable(
                name: "schedules");

            migrationBuilder.DropTable(
                name: "subjects");
        }
    }
}
