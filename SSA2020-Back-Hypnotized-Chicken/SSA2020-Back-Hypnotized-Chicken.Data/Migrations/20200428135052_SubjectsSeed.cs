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
                Name = "Bezbednost i zaštita mreža"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 4,
                Name = "Objektno-orijentisano programiranje"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 5,
                Name = "Računarske mreže i komunikacije"
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
                Name = "Verovatnoća i statistika"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 9,
                Name = "Softversko inženjerstvo"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 10,
                Name = "Uvod u programiranje"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 11,
                Name = "Računarske simulacije"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 12,
                Name = "Matematika 2"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 13,
                Name = "Informacione tehnologije"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 14,
                Name = "Osnove računarske tehnike"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 15,
                Name = "Strukture podataka i algoritmi"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 16,
                Name = "Arhitektura računara"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 17,
                Name = "Operativni sistemi"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 18,
                Name = "Diskretna matematika"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 19,
                Name = "Organizacija računarskih sistema"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 20,
                Name = "Operativni sistemi i održavanje"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 21,
                Name = "Internet programiranje"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 22,
                Name = "Zaštita podataka"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 23,
                Name = "Multimedijalni sistemi"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 24,
                Name = "Razvoj informacionih sistema"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 25,
                Name = "Praktikum - standardizacija i dokumentacija"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 26,
                Name = "Performanse i pouzdanost računara"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 27,
                Name = "Informaciono-ekspertni sistemi"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 28,
                Name = "Savremene softverske arhitekture"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 29,
                Name = "Organizacija rada"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 30,
                Name = "CAD/CAE konstruisanje"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 31,
                Name = "Osnove elektronike"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 32,
                Name = "Psihologija"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 33,
                Name = "Fizičke osnove elektrotehnike"
            }).InsertSql);
            
            migrationBuilder.Sql((new Subject()
            {
                Id = 34,
                Name = "Industrijski menadžment"
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

            migrationBuilder.Sql((new Subject() {Id = 14}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 15}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 16}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 17}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 18}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 19}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 20}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 21}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 22}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 23}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 24}).DeleteSql);
            
            migrationBuilder.Sql((new Subject() {Id = 25}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 26}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 27}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 28}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 29}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 30}).DeleteSql);

            migrationBuilder.Sql((new Subject() {Id = 31}).DeleteSql);
        }
    }
}
