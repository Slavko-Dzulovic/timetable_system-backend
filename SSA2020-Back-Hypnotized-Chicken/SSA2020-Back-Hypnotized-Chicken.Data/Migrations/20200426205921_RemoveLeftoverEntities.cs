using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class RemoveLeftoverEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "module_subjects");

            migrationBuilder.DropTable(
                name: "semester_subjects");

            migrationBuilder.DropTable(
                name: "subject_lecturers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "module_subjects",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    is_optional = table.Column<bool>(type: "boolean", nullable: false),
                    module_id = table.Column<short>(type: "smallint", nullable: false),
                    subject_id = table.Column<short>(type: "smallint", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "semester_subjects",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    semester_id = table.Column<short>(type: "smallint", nullable: false),
                    subject_id = table.Column<short>(type: "smallint", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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
                name: "subject_lecturers",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    lecturer_id = table.Column<short>(type: "smallint", nullable: false),
                    subject_id = table.Column<short>(type: "smallint", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_module_subjects_module_id",
                table: "module_subjects",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "IX_module_subjects_subject_id",
                table: "module_subjects",
                column: "subject_id");

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
        }
    }
}
