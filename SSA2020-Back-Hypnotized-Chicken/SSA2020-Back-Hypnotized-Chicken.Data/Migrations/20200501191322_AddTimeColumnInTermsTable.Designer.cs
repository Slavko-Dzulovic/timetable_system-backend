﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SSA2020_Back_Hypnotized_Chicken.Data;

namespace SSA2020_Back_Hypnotized_Chicken.Data.Migrations
{
    [DbContext(typeof(TimetableDbContext))]
    [Migration("20200501191322_AddTimeColumnInTermsTable")]
    partial class AddTimeColumnInTermsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Classroom", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasColumnName("label")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Location")
                        .HasColumnName("location")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("classrooms");
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Department", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Lecturer", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Vocation")
                        .HasColumnName("vocation")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("lecturers");
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Module", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<short>("DepartmentId")
                        .HasColumnName("department_id")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("modules");
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Schedule", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<short>("DepartmentId")
                        .HasColumnName("department_id")
                        .HasColumnType("smallint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.Property<short>("SemesterId")
                        .HasColumnName("semester_id")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.HasIndex("DepartmentId", "SemesterId")
                        .IsUnique();

                    b.ToTable("schedules");
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Semester", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("semesters");
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Slot", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsOptional")
                        .HasColumnName("is_optional")
                        .HasColumnType("boolean");

                    b.Property<short>("LecturerId")
                        .HasColumnName("lecturer_id")
                        .HasColumnType("smallint");

                    b.Property<short>("ModuleId")
                        .HasColumnName("module_id")
                        .HasColumnType("smallint");

                    b.Property<short>("SemesterId")
                        .HasColumnName("semester_id")
                        .HasColumnType("smallint");

                    b.Property<short>("SubjectId")
                        .HasColumnName("subject_id")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("LecturerId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("SubjectId");

                    b.ToTable("slots");
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Subject", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("subjects");
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Term", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<short>("ClassroomId")
                        .HasColumnName("classroom_id")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<short>("Group")
                        .HasColumnName("group")
                        .HasColumnType("smallint");

                    b.Property<string>("Module")
                        .HasColumnName("module")
                        .HasColumnType("text");

                    b.Property<short>("NumberOfExercises")
                        .HasColumnName("number_of_exercises")
                        .HasColumnType("smallint");

                    b.Property<short>("NumberOfLabExercises")
                        .HasColumnName("number_of_lab_exercises")
                        .HasColumnType("smallint");

                    b.Property<short>("NumberOfLectures")
                        .HasColumnName("number_of_lectures")
                        .HasColumnType("smallint");

                    b.Property<short>("OptionalSubjectNumber")
                        .HasColumnName("optional_subject_number")
                        .HasColumnType("smallint");

                    b.Property<short>("ScheduleId")
                        .HasColumnName("schedule_id")
                        .HasColumnType("smallint");

                    b.Property<long>("SlotId")
                        .HasColumnName("slot_id")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Time")
                        .HasColumnName("time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<short>("WeekdayId")
                        .HasColumnName("weekday_id")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("SlotId");

                    b.HasIndex("WeekdayId");

                    b.ToTable("terms");
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Weekday", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("smallint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnName("updated_at")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("weekdays");
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Module", b =>
                {
                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Department", "Department")
                        .WithMany("Modules")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Schedule", b =>
                {
                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Department", "Department")
                        .WithMany("Schedules")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Semester", "Semester")
                        .WithMany("Schedules")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Slot", b =>
                {
                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Lecturer", "Lecturer")
                        .WithMany("Slots")
                        .HasForeignKey("LecturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Module", "Module")
                        .WithMany("Slots")
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Semester", "Semester")
                        .WithMany("Slots")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Subject", "Subject")
                        .WithMany("Slots")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Term", b =>
                {
                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Classroom", "Classroom")
                        .WithMany("Terms")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Schedule", "Schedule")
                        .WithMany("Terms")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Slot", "Slot")
                        .WithMany("Terms")
                        .HasForeignKey("SlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SSA2020_Back_Hypnotized_Chicken.Data.Entities.Weekday", "Weekday")
                        .WithMany("Terms")
                        .HasForeignKey("WeekdayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
