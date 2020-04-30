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
                ModuleId = 1
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
        }
    }
}
