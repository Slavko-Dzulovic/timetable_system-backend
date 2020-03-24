using Microsoft.EntityFrameworkCore.Migrations;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class MoveOptionalIdToTermEntityAndRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "optional_id",
                table: "subjects");

            migrationBuilder.AddColumn<short>(
                name: "optional_subject_number",
                table: "terms",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "optional_subject_number",
                table: "terms");

            migrationBuilder.AddColumn<short>(
                name: "optional_id",
                table: "subjects",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);
        }
    }
}
