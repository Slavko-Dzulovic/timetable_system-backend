using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Migrations;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;
using SSA2020_Back_Hypnotized_Chicken.Data.Helpers;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class ClassroomsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Classroom()
            {
                Id = (short) ClassroomSeed.u21,
                Label = EnumHelper.GetAttributeValue<DisplayAttribute>(ClassroomSeed.u21).Name
            }).InsertSql);
            
            migrationBuilder.Sql((new Classroom()
            {
                Id = (short) ClassroomSeed.u15,
                Label = EnumHelper.GetAttributeValue<DisplayAttribute>(ClassroomSeed.u15).Name
            }).InsertSql);
            
            migrationBuilder.Sql((new Classroom()
            {
                Id = (short) ClassroomSeed.u16,
                Label = EnumHelper.GetAttributeValue<DisplayAttribute>(ClassroomSeed.u16).Name
            }).InsertSql);
            
            migrationBuilder.Sql((new Classroom()
            {
                Id = (short) ClassroomSeed.u17,
                Label = EnumHelper.GetAttributeValue<DisplayAttribute>(ClassroomSeed.u17).Name
            }).InsertSql);
            
            migrationBuilder.Sql((new Classroom()
            {
                Id = (short) ClassroomSeed.u212,
                Label = EnumHelper.GetAttributeValue<DisplayAttribute>(ClassroomSeed.u212).Name
            }).InsertSql);
            
            migrationBuilder.Sql((new Classroom()
            {
                Id = (short) ClassroomSeed.u214,
                Label = EnumHelper.GetAttributeValue<DisplayAttribute>(ClassroomSeed.u214).Name
            }).InsertSql);
            
            migrationBuilder.Sql((new Classroom()
            {
                Id = (short) ClassroomSeed.u215,
                Label = EnumHelper.GetAttributeValue<DisplayAttribute>(ClassroomSeed.u215).Name
            }).InsertSql);
            
            migrationBuilder.Sql((new Classroom()
            {
                Id = (short) ClassroomSeed.u217,
                Label = EnumHelper.GetAttributeValue<DisplayAttribute>(ClassroomSeed.u217).Name
            }).InsertSql);
            
            migrationBuilder.Sql((new Classroom()
            {
                Id = (short) ClassroomSeed.u218,
                Label = EnumHelper.GetAttributeValue<DisplayAttribute>(ClassroomSeed.u218).Name
            }).InsertSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Classroom() { Id = (short)ClassroomSeed.u21}).DeleteSql);
            
            migrationBuilder.Sql((new Classroom() { Id = (short)ClassroomSeed.u15}).DeleteSql);
            
            migrationBuilder.Sql((new Classroom() { Id = (short)ClassroomSeed.u16}).DeleteSql);
            
            migrationBuilder.Sql((new Classroom() { Id = (short)ClassroomSeed.u17}).DeleteSql);
            
            migrationBuilder.Sql((new Classroom() { Id = (short)ClassroomSeed.u212}).DeleteSql);
            
            migrationBuilder.Sql((new Classroom() { Id = (short)ClassroomSeed.u214}).DeleteSql);
            
            migrationBuilder.Sql((new Classroom() { Id = (short)ClassroomSeed.u215}).DeleteSql);
            
            migrationBuilder.Sql((new Classroom() { Id = (short)ClassroomSeed.u217}).DeleteSql);
            
            migrationBuilder.Sql((new Classroom() { Id = (short)ClassroomSeed.u218}).DeleteSql);
        }
    }
}
