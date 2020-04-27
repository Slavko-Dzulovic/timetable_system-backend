using Microsoft.EntityFrameworkCore.Migrations;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class SemestersSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Semester()
            {
                Id = (short) Semesters.I,
                Name = Semesters.I.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Semester()
            {
                Id = (short) Semesters.II,
                Name = Semesters.II.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Semester()
            {
                Id = (short) Semesters.III,
                Name = Semesters.III.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Semester()
            {
                Id = (short) Semesters.IV,
                Name = Semesters.IV.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Semester()
            {
                Id = (short) Semesters.V,
                Name = Semesters.V.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Semester()
            {
                Id = (short) Semesters.VI,
                Name = Semesters.VI.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Semester()
            {
                Id = (short) Semesters.VII,
                Name = Semesters.VII.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Semester()
            {
                Id = (short) Semesters.VIII,
                Name = Semesters.VIII.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Semester()
            {
                Id = (short) Semesters.IX,
                Name = Semesters.IX.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Semester()
            {
                Id = (short) Semesters.X,
                Name = Semesters.X.ToString()
            }).InsertSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Semester() { Id = (short)Semesters.I}).DeleteSql);
            
            migrationBuilder.Sql((new Semester() { Id = (short)Semesters.II}).DeleteSql);
            
            migrationBuilder.Sql((new Semester() { Id = (short)Semesters.III}).DeleteSql);
            
            migrationBuilder.Sql((new Semester() { Id = (short)Semesters.IV}).DeleteSql);
            
            migrationBuilder.Sql((new Semester() { Id = (short)Semesters.V}).DeleteSql);
            
            migrationBuilder.Sql((new Semester() { Id = (short)Semesters.VI}).DeleteSql);
            
            migrationBuilder.Sql((new Semester() { Id = (short)Semesters.VII}).DeleteSql);
            
            migrationBuilder.Sql((new Semester() { Id = (short)Semesters.VIII}).DeleteSql);
            
            migrationBuilder.Sql((new Semester() { Id = (short)Semesters.IX}).DeleteSql);
            
            migrationBuilder.Sql((new Semester() { Id = (short)Semesters.X}).DeleteSql);
        }
    }
}
