using Microsoft.EntityFrameworkCore.Migrations;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class AddSlotForeignKeyToTerm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_terms_slots_SlotId",
                table: "terms");

            migrationBuilder.RenameColumn(
                name: "SlotId",
                table: "terms",
                newName: "slot_id");

            migrationBuilder.RenameIndex(
                name: "IX_terms_SlotId",
                table: "terms",
                newName: "IX_terms_slot_id");

            migrationBuilder.AlterColumn<long>(
                name: "slot_id",
                table: "terms",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_terms_slots_slot_id",
                table: "terms",
                column: "slot_id",
                principalTable: "slots",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_terms_slots_slot_id",
                table: "terms");

            migrationBuilder.RenameColumn(
                name: "slot_id",
                table: "terms",
                newName: "SlotId");

            migrationBuilder.RenameIndex(
                name: "IX_terms_slot_id",
                table: "terms",
                newName: "IX_terms_SlotId");

            migrationBuilder.AlterColumn<long>(
                name: "SlotId",
                table: "terms",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_terms_slots_SlotId",
                table: "terms",
                column: "SlotId",
                principalTable: "slots",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
