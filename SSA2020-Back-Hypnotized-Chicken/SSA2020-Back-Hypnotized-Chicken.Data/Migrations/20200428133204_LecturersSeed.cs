using Microsoft.EntityFrameworkCore.Migrations;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class LecturersSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Lecturer()
            {
                Id = 1,
                FirstName = "Vera",
                LastName = "Lazarevic",
                Vocation = "Professor"
            }).InsertSql);
            
            migrationBuilder.Sql((new Lecturer()
            {
                Id = 2,
                FirstName = "Olga",
                LastName = "Ristić",
                Vocation = "Professor"
            }).InsertSql);
            
            migrationBuilder.Sql((new Lecturer()
            {
                Id = 3,
                FirstName = "Marjan",
                LastName = "Milosevic",
                Vocation = "Professor"
            }).InsertSql);
            
            migrationBuilder.Sql((new Lecturer()
            {
                Id = 4,
                FirstName = "Katarina",
                LastName = "Mitrovic",
                Vocation = "Assistant"
            }).InsertSql);
            
            migrationBuilder.Sql((new Lecturer()
            {
                Id = 5,
                FirstName = "Danijela",
                LastName = "Milosevic",
                Vocation = "Professor"
            }).InsertSql);
            
            migrationBuilder.Sql((new Lecturer()
            {
                Id = 6,
                FirstName = "Maja",
                LastName = "Radovic",
                Vocation = "Assistant"
            }).InsertSql);
            
            migrationBuilder.Sql((new Lecturer()
            {
                Id = 7,
                FirstName = "Vlade",
                LastName = "Urosevic",
                Vocation = "Professor"
            }).InsertSql);
            
            migrationBuilder.Sql((new Lecturer()
            {
                Id = 8,
                FirstName = "Mladen",
                LastName = "Janjic",
                Vocation = "Professor"
            }).InsertSql);
            
            migrationBuilder.Sql((new Lecturer()
            {
                Id = 9,
                FirstName = "Aleksandar",
                LastName = "Sebekovic",
                Vocation = "Professor"
            }).InsertSql);
            
            migrationBuilder.Sql((new Lecturer()
            {
                Id = 10,
                FirstName = "Marija",
                LastName = "Blagojevic",
                Vocation = "Professor"
            }).InsertSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Lecturer() { Id = 1}).DeleteSql);

            migrationBuilder.Sql((new Lecturer() { Id = 2}).DeleteSql);

            migrationBuilder.Sql((new Lecturer() { Id = 3}).DeleteSql);

            migrationBuilder.Sql((new Lecturer() { Id = 4}).DeleteSql);

            migrationBuilder.Sql((new Lecturer() { Id = 5}).DeleteSql);

            migrationBuilder.Sql((new Lecturer() { Id = 6}).DeleteSql);

            migrationBuilder.Sql((new Lecturer() { Id = 7}).DeleteSql);

            migrationBuilder.Sql((new Lecturer() { Id = 8}).DeleteSql);
            
            migrationBuilder.Sql((new Lecturer() { Id = 9}).DeleteSql);
            
            migrationBuilder.Sql((new Lecturer() { Id = 10}).DeleteSql);
        }
    }
}
