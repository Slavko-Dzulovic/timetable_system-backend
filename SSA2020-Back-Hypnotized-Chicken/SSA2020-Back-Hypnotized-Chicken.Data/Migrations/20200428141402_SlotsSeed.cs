using Microsoft.EntityFrameworkCore.Migrations;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class SlotsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Slot()
            {
                Id = 1,
                SubjectId = 1,
                LecturerId = 1,
                SemesterId = 1,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 2,
                SubjectId = 2,
                LecturerId = 2,
                SemesterId = 2,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 3,
                SubjectId = 3,
                LecturerId = 3,
                SemesterId = 7,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 4,
                SubjectId = 4,
                LecturerId = 4,
                SemesterId = 3,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 5,
                SubjectId = 4,
                LecturerId = 7,
                SemesterId = 3,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 6,
                SubjectId = 5,
                LecturerId = 3,
                SemesterId = 4,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 7,
                SubjectId = 5,
                LecturerId = 6,
                SemesterId = 4,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 8,
                SubjectId = 6,
                LecturerId = 6,
                SemesterId = 5,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 9,
                SubjectId = 6,
                LecturerId = 5,
                SemesterId = 5,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 10,
                SubjectId = 7,
                LecturerId = 4,
                SemesterId = 6,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 11,
                SubjectId = 8,
                LecturerId = 9,
                SemesterId = 3,
                ModuleId = 1,
                IsOptional = true,
                OptionalSubjectNumber = 4
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 12,
                SubjectId = 9,
                LecturerId = 10,
                SemesterId = 7,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 13,
                SubjectId = 9,
                LecturerId = 8,
                SemesterId = 7,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 14,
                SubjectId = 10,
                LecturerId = 7,
                SemesterId = 1,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 15,
                SubjectId = 11,
                LecturerId = 7,
                SemesterId = 7,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 16,
                SubjectId = 12,
                LecturerId = 1,
                SemesterId = 2,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 17,
                SubjectId = 13,
                LecturerId = 11,
                SemesterId = 1,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 18,
                SubjectId = 13,
                LecturerId = 12,
                SemesterId = 1,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 19,
                SubjectId = 14,
                LecturerId = 15,
                SemesterId = 2,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 20,
                SubjectId = 14,
                LecturerId = 16,
                SemesterId = 2,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 21,
                SubjectId = 15,
                LecturerId = 2,
                SemesterId = 3,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 22,
                SubjectId = 16,
                LecturerId = 17,
                SemesterId = 4,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 23,
                SubjectId = 16,
                LecturerId = 18,
                SemesterId = 4,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 24,
                SubjectId = 17,
                LecturerId = 11,
                SemesterId = 4,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 25,
                SubjectId = 17,
                LecturerId = 19,
                SemesterId = 4,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 26,
                SubjectId = 18,
                LecturerId = 20,
                SemesterId = 4,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 27,
                SubjectId = 19,
                LecturerId = 17,
                SemesterId = 5,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 28,
                SubjectId = 19,
                LecturerId = 18,
                SemesterId = 5,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 29,
                SubjectId = 20,
                LecturerId = 19,
                SemesterId = 5,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 30,
                SubjectId = 20,
                LecturerId = 11,
                SemesterId = 5,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 31,
                SubjectId = 20,
                LecturerId = 17,
                SemesterId = 5,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 32,
                SubjectId = 21,
                LecturerId = 26,
                SemesterId = 6,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 33,
                SubjectId = 22,
                LecturerId = 21,
                SemesterId = 6,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 34,
                SubjectId = 22,
                LecturerId = 8,
                SemesterId = 6,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 35,
                SubjectId = 23,
                LecturerId = 21,
                SemesterId = 6,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 36,
                SubjectId = 23,
                LecturerId = 22,
                SemesterId = 7,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 37,
                SubjectId = 24,
                LecturerId = 23,
                SemesterId = 7,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 38,
                SubjectId = 24,
                LecturerId = 12,
                SemesterId = 7,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 39,
                SubjectId = 25,
                LecturerId = 24,
                SemesterId = 7,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 40,
                SubjectId = 11,
                LecturerId = 25,
                SemesterId = 7,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 41,
                SubjectId = 26,
                LecturerId = 17,
                SemesterId = 8,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 42,
                SubjectId = 26,
                LecturerId = 18,
                SemesterId = 8,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 43,
                SubjectId = 27,
                LecturerId = 11,
                SemesterId = 8,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 44,
                SubjectId = 27,
                LecturerId = 12,
                SemesterId = 8,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 45,
                SubjectId = 28,
                LecturerId = 21,
                SemesterId = 8,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 46,
                SubjectId = 28,
                LecturerId = 27,
                SemesterId = 8,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 47,
                SubjectId = 28,
                LecturerId = 8,
                SemesterId = 8,
                ModuleId = 1
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 48,
                SubjectId = 29,
                LecturerId = 28,
                SemesterId = 3,
                ModuleId = 1,
                IsOptional = true,
                OptionalSubjectNumber = 4
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 49,
                SubjectId = 30,
                LecturerId = 29,
                SemesterId = 3,
                ModuleId = 1,
                IsOptional = true,
                OptionalSubjectNumber = 5
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 50,
                SubjectId = 31,
                LecturerId = 30,
                SemesterId = 3,
                ModuleId = 1,
                IsOptional = true,
                OptionalSubjectNumber = 5
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 51,
                SubjectId = 8,
                LecturerId = 9,
                SemesterId = 3,
                ModuleId = 2,
                IsOptional = true,
                OptionalSubjectNumber = 4
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 52,
                SubjectId = 8,
                LecturerId = 9,
                SemesterId = 3,
                ModuleId = 3,
                IsOptional = true,
                OptionalSubjectNumber = 4
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 53,
                SubjectId = 30,
                LecturerId = 29,
                SemesterId = 3,
                ModuleId = 3,
                IsOptional = true,
                OptionalSubjectNumber = 5
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 54,
                SubjectId = 32,
                LecturerId = 31,
                SemesterId = 3,
                ModuleId = 3,
                IsOptional = true,
                OptionalSubjectNumber = 5
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 55,
                SubjectId = 33,
                LecturerId = 32,
                SemesterId = 3,
                ModuleId = 3,
                IsOptional = true,
                OptionalSubjectNumber = 4
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 56,
                SubjectId = 34,
                LecturerId = 32,
                SemesterId = 3,
                ModuleId = 2,
                IsOptional = true,
                OptionalSubjectNumber = 4
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 57,
                SubjectId = 4,
                LecturerId = 4,
                SemesterId = 3,
                ModuleId = 2
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 58,
                SubjectId = 4,
                LecturerId = 7,
                SemesterId = 3,
                ModuleId = 2
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 59,
                SubjectId = 4,
                LecturerId = 4,
                SemesterId = 3,
                ModuleId = 3
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 60,
                SubjectId = 4,
                LecturerId = 7,
                SemesterId = 3,
                ModuleId = 3
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 61,
                SubjectId = 15,
                LecturerId = 2,
                SemesterId = 3,
                ModuleId = 2
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 62,
                SubjectId = 15,
                LecturerId = 2,
                SemesterId = 3,
                ModuleId = 3
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 63,
                SubjectId = 30,
                LecturerId = 29,
                SemesterId = 3,
                ModuleId = 2,
                IsOptional = false
            }).InsertSql);
            
            migrationBuilder.Sql((new Slot()
            {
                Id = 64,
                SubjectId = 8,
                LecturerId = 9,
                SemesterId = 3,
                ModuleId = 8,
                IsOptional = false
            }).InsertSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Slot() {Id = 1}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 2}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 3}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 4}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 5}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 6}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 7}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 8}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 9}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 10}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 11}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 12}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 13}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 14}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 15}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 16}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 17}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 18}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 19}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 20}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 21}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 22}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 23}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 24}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 25}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 26}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 27}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 28}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 29}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 30}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 31}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 32}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 33}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 34}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 35}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 36}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 37}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 38}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 39}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 40}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 41}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 42}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 43}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 44}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 45}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 46}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 47}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 48}).DeleteSql);
            
            migrationBuilder.Sql((new Slot() {Id = 49}).DeleteSql);
        }
    }
}
