﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Domain;

#nullable disable

namespace WebApp.Domain.Migrations
{
    [DbContext(typeof(BumboDbContext))]
    partial class BumboDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApp.Domain.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("WeekDay")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Availabilities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            EndTime = new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekDay = 0
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 1,
                            EndTime = new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekDay = 3
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 2,
                            EndTime = new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekDay = 1
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 3,
                            EndTime = new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekDay = 1
                        });
                });

            modelBuilder.Entity("WebApp.Domain.Department", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Name = "Verkoop"
                        },
                        new
                        {
                            Name = "Magazijn"
                        });
                });

            modelBuilder.Entity("WebApp.Domain.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HourSalary")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NFCToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Birthdate = new DateTime(2000, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tester1@mail.com",
                            FirstName = "testUser1FirstName",
                            HourSalary = 0.0,
                            LastName = "testUser1LastName",
                            MiddelName = "",
                            NFCToken = "Token1"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Birthdate = new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tester2@mail.com",
                            FirstName = "testUser2FirstName",
                            HourSalary = 0.0,
                            LastName = "testUser2LastName",
                            MiddelName = "",
                            NFCToken = "Token2"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Birthdate = new DateTime(1985, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tester3@mail.com",
                            FirstName = "testUser3FirstName",
                            HourSalary = 0.0,
                            LastName = "testUser3LastName",
                            MiddelName = "testUser3MiddelName",
                            NFCToken = "Token3"
                        });
                });

            modelBuilder.Entity("WebApp.Domain.Prognosis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalColli")
                        .HasColumnType("int");

                    b.Property<int>("TotalCustomers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Prognosis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "Verkoop",
                            TotalColli = 3,
                            TotalCustomers = 10
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "Magazijn",
                            TotalColli = 10,
                            TotalCustomers = 15
                        });
                });

            modelBuilder.Entity("WebApp.Domain.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = "Magazijn",
                            EmployeeId = 1,
                            EndTime = new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Department = "Verkoop",
                            EmployeeId = 1,
                            EndTime = new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Department = "Verkoop",
                            EmployeeId = 2,
                            EndTime = new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Department = "Magazijn",
                            EmployeeId = 3,
                            EndTime = new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WebApp.Domain.SchoolSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("WeekDay")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SchoolSchedules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            EndTime = new DateTime(2022, 11, 21, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 21, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekDay = 0
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 1,
                            EndTime = new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            WeekDay = 2
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 2,
                            EndTime = new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 25, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekDay = 4
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 3,
                            EndTime = new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 24, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            WeekDay = 1
                        });
                });

            modelBuilder.Entity("WebApp.Domain.WorkedHour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ApprovalTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("WorkedHours");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApprovalTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            Department = "Magazijn",
                            EmployeeId = 1,
                            EndTime = new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            ApprovalTime = new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Department = "Verkoop",
                            EmployeeId = 1,
                            EndTime = new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            ApprovalTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            Department = "Verkoop",
                            EmployeeId = 2,
                            EndTime = new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            ApprovalTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            Department = "Magazijn",
                            EmployeeId = 3,
                            EndTime = new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("WebApp.Domain.Availability", b =>
                {
                    b.HasOne("WebApp.Domain.Employee", "Employee_Id")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee_Id");
                });
#pragma warning restore 612, 618
        }
    }
}
