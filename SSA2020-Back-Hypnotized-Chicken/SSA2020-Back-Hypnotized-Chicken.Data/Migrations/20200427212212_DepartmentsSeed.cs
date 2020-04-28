using Microsoft.EntityFrameworkCore.Migrations;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class DepartmentsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Department()
            {
                Id = (short) Departments.IT,
                Name = Departments.IT.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Department()
            {
                Id = (short) Departments.IM,
                Name = Departments.IM.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Department()
            {
                Id = (short) Departments.ERI,
                Name = Departments.ERI.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Department()
            {
                Id = (short) Departments.MEH,
                Name = Departments.MEH.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Department()
            {
                Id = (short) Departments.PM,
                Name = Departments.PM.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Department()
            {
                Id = (short) Departments.TI,
                Name = Departments.TI.ToString()
            }).InsertSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Department() { Id = (short)Departments.IT}).DeleteSql);

            migrationBuilder.Sql((new Department() { Id = (short)Departments.IM}).DeleteSql);

            migrationBuilder.Sql((new Department() { Id = (short)Departments.ERI}).DeleteSql);

            migrationBuilder.Sql((new Department() { Id = (short)Departments.MEH}).DeleteSql);

            migrationBuilder.Sql((new Department() { Id = (short)Departments.PM}).DeleteSql);

            migrationBuilder.Sql((new Department() { Id = (short)Departments.TI}).DeleteSql);
        }
    }
}
