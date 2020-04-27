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
                Id = (short) Modules.IM_Global,
                Name = Modules.IM_Global.ToString(),
                DepartmentId = (short) Departments.IM
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.PM_Global,
                Name = Modules.PM_Global.ToString(),
                DepartmentId = (short) Departments.PM
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.TI_Global,
                Name = Modules.TI_Global.ToString(),
                DepartmentId = (short) Departments.TI
            }).InsertSql);

            migrationBuilder.Sql((new Module()
            {
                Id = (short) Modules.MEH_Global,
                Name = Modules.MEH_Global.ToString(),
                DepartmentId = (short) Departments.MEH
            }).InsertSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
