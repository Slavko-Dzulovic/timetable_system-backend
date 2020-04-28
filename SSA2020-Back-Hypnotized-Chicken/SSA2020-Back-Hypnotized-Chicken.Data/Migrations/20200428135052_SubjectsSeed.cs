using Microsoft.EntityFrameworkCore.Migrations;
using SSA2020_Back_Hypnotized_Chicken.Data.Entities;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    public partial class SubjectsSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Subject()
            {
                Id = 1,
                Name = "Matematika 1"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 2,
                Name = "Programski jezici"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 3,
                Name = "Bezbednost i zastita mreža"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 4,
                Name = "Objektno-orijentisano programiranje"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 5,
                Name = "Racunarske mreze i komunikacije"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 6,
                Name = "Baze podataka"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 7,
                Name = "Programiranje baza podataka"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 8,
                Name = "Racunarske mreze i komunikacije"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 9,
                Name = "Verovatnoca i statistika"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 10,
                Name = "Softversko inzenjerstvo"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 11,
                Name = "Uvod u programiranje"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 12,
                Name = "Softversko inzenjerstvo"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 13,
                Name = "Matematika 2"
            }).InsertSql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql((new Subject() {Id = 1}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 2}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 3}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 4}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 5}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 6}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 7}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 8}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 9}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 10}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 11}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 12}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 13}).DeleteSql);
        }
    }
}
