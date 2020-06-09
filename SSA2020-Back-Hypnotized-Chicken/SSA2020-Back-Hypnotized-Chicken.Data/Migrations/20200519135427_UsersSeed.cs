using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class UsersSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "created_at", "first_name", "last_name", "password_hash", "password_salt", "role", "token", "updated_at", "username" },
                values: new object[] { (short)1, new DateTime(2020, 5, 19, 13, 54, 26, 532, DateTimeKind.Utc).AddTicks(7020), "admin", "admin", new byte[] { 138, 155, 2, 205, 152, 169, 245, 130, 253, 38, 159, 69, 101, 238, 245, 212, 140, 99, 163, 27, 105, 225, 51, 28, 116, 231, 84, 29, 35, 128, 58, 126, 201, 81, 209, 82, 217, 134, 111, 233, 197, 7, 97, 3, 177, 66, 88, 62, 141, 129, 7, 65, 51, 94, 146, 126, 156, 76, 159, 67, 181, 83, 190, 40 }, new byte[] { 104, 240, 165, 21, 76, 62, 228, 178, 15, 24, 32, 207, 63, 41, 21, 139, 28, 219, 12, 30, 199, 205, 77, 54, 98, 226, 103, 236, 130, 67, 126, 120, 74, 31, 191, 137, 156, 21, 219, 100, 8, 123, 163, 225, 183, 143, 84, 230, 35, 226, 109, 182, 102, 136, 122, 146, 92, 196, 183, 85, 71, 151, 56, 18, 58, 232, 220, 216, 154, 183, 216, 160, 248, 58, 196, 63, 188, 97, 242, 95, 117, 131, 243, 70, 252, 37, 177, 204, 251, 163, 114, 74, 46, 146, 63, 217, 121, 79, 121, 168, 39, 185, 64, 128, 191, 8, 196, 159, 136, 18, 122, 38, 137, 41, 48, 84, 220, 75, 120, 242, 27, 116, 250, 60, 233, 151, 226, 67 }, "Admin", "", new DateTime(2020, 5, 19, 13, 54, 26, 532, DateTimeKind.Utc).AddTicks(7020), "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "id",
                keyValue: (short)1);
        }
    }
}
