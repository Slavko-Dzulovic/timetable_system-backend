using Microsoft.EntityFrameworkCore.Migrations;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class ModulesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.SI,
                Name = Modules.SI.ToString(),
                DepartmentId = (short) Departments.IT
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.ITO,
                Name = Modules.ITO.ToString(),
                DepartmentId = (short) Departments.IT
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.ITI,
                Name = Modules.ITI.ToString(),
                DepartmentId = (short) Departments.IT
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.RI,
                Name = Modules.RI.ToString(),
                DepartmentId = (short) Departments.ERI
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.EES,
                Name = Modules.EES.ToString(),
                DepartmentId = (short) Departments.ERI
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.IEE,
                Name = Modules.IEE.ToString(),
                DepartmentId = (short) Departments.ERI
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.IM,
                Name = Modules.IM.ToString(),
                DepartmentId = (short) Departments.IM
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.PM,
                Name = Modules.PM.ToString(),
                DepartmentId = (short) Departments.PM
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.TI,
                Name = Modules.TI.ToString(),
                DepartmentId = (short) Departments.TI
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.MEH,
                Name = Modules.MEH.ToString(),
                DepartmentId = (short) Departments.MEH
            }).InsertSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Module() {Id = 1}).DeleteSql);
            
            migrationBuilder.Sql((new Module() {Id = 2}).DeleteSql);
            
            migrationBuilder.Sql((new Module() {Id = 3}).DeleteSql);
            
            migrationBuilder.Sql((new Module() {Id = 4}).DeleteSql);
            
            migrationBuilder.Sql((new Module() {Id = 5}).DeleteSql);
            
            migrationBuilder.Sql((new Module() {Id = 6}).DeleteSql);
            
            migrationBuilder.Sql((new Module() {Id = 7}).DeleteSql);
            
            migrationBuilder.Sql((new Module() {Id = 8}).DeleteSql);
            
            migrationBuilder.Sql((new Module() {Id = 9}).DeleteSql);
            
            migrationBuilder.Sql((new Module() {Id = 10}).DeleteSql);
        }
    }
}
