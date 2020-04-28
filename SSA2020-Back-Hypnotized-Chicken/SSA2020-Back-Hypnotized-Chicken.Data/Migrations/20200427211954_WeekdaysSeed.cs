using Microsoft.EntityFrameworkCore.Migrations;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class WeekdaysSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Weekday()
            {
                Id = (short) Weekdays.Monday,
                Name = Weekdays.Monday.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Weekday()
            {
                Id = (short) Weekdays.Tuesday,
                Name = Weekdays.Tuesday.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Weekday()
            {
                Id = (short) Weekdays.Wednesday,
                Name = Weekdays.Wednesday.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Weekday()
            {
                Id = (short) Weekdays.Thursday,
                Name = Weekdays.Thursday.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Weekday()
            {
                Id = (short) Weekdays.Friday,
                Name = Weekdays.Friday.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Weekday()
            {
                Id = (short) Weekdays.Saturday,
                Name = Weekdays.Saturday.ToString()
            }).InsertSql);
            
            migrationBuilder.Sql((new Weekday()
            {
                Id = (short) Weekdays.Sunday,
                Name = Weekdays.Sunday.ToString()
            }).InsertSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Weekday() { Id = (short)Weekdays.Monday}).DeleteSql);

            migrationBuilder.Sql((new Weekday() { Id = (short)Weekdays.Tuesday}).DeleteSql);

            migrationBuilder.Sql((new Weekday() { Id = (short)Weekdays.Wednesday}).DeleteSql);

            migrationBuilder.Sql((new Weekday() { Id = (short)Weekdays.Thursday}).DeleteSql);

            migrationBuilder.Sql((new Weekday() { Id = (short)Weekdays.Friday}).DeleteSql);

            migrationBuilder.Sql((new Weekday() { Id = (short)Weekdays.Saturday}).DeleteSql);

            migrationBuilder.Sql((new Weekday() { Id = (short)Weekdays.Sunday}).DeleteSql);
        }
    }
}
