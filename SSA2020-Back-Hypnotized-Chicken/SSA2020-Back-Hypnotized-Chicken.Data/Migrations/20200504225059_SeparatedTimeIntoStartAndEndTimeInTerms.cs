using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class SeparatedTimeIntoStartAndEndTimeInTerms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "endTime",
                table: "terms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "startTime",
                table: "terms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "endTime",
                table: "terms");

            migrationBuilder.DropColumn(
                name: "startTime",
                table: "terms");
        }
    }
}
