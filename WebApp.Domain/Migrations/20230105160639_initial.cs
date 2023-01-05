using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CAOBonuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HolidayBonus = table.Column<double>(type: "float", nullable: false),
                    SundayBonus = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAOBonuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CAORegulations",
                columns: table => new
                {
                    Age = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowedHoursSchoolDay = table.Column<int>(type: "int", nullable: false),
                    AllowedHoursSchoolWeek = table.Column<int>(type: "int", nullable: false),
                    AllowedHoursNotSchoolDay = table.Column<int>(type: "int", nullable: false),
                    AllowedHoursNotSchoolWeek = table.Column<int>(type: "int", nullable: false),
                    AllowedHours4Weeks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAORegulations", x => x.Age);
                });

            migrationBuilder.CreateTable(
                name: "DataSets",
                columns: table => new
                {
                    DepartmentName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MinimumEmployees = table.Column<int>(type: "int", nullable: false),
                    DepartmentStartHour = table.Column<int>(type: "int", nullable: false),
                    DepartmentEndHour = table.Column<int>(type: "int", nullable: false),
                    EmployeeWorkLoad = table.Column<int>(type: "int", nullable: false),
                    ShouldEstimateValue = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSets", x => x.DepartmentName);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PredictionValueName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimumAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "Date", nullable: false),
                    NFCToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: false),
                    Rejected = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prognosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prognosis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicHolidays",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicHolidays", x => x.Date);
                });

            migrationBuilder.CreateTable(
                name: "SchoolHolidays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolHolidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataPoints",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsHoliday = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPoints", x => new { x.Date, x.DepartmentName });
                    table.ForeignKey(
                        name: "FK_DataPoints_DataSets_DepartmentName",
                        column: x => x.DepartmentName,
                        principalTable: "DataSets",
                        principalColumn: "DepartmentName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HourlyPoints",
                columns: table => new
                {
                    DepartmentName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hour = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourlyPoints", x => new { x.DepartmentName, x.Hour });
                    table.ForeignKey(
                        name: "FK_HourlyPoints_DataSets_DepartmentName",
                        column: x => x.DepartmentName,
                        principalTable: "DataSets",
                        principalColumn: "DepartmentName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Availabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Weekday = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Availabilities_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Weekday = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolSchedules_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkedHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ClockedTimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClockedTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedTimeStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkedHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkedHours_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CAOBonuses",
                columns: new[] { "Id", "HolidayBonus", "SundayBonus", "ValidSince" },
                values: new object[] { 1, 1.0, 0.5, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "CAORegulations",
                columns: new[] { "Age", "AllowedHours4Weeks", "AllowedHoursNotSchoolDay", "AllowedHoursNotSchoolWeek", "AllowedHoursSchoolDay", "AllowedHoursSchoolWeek" },
                values: new object[,]
                {
                    { 13, 140, 7, 35, 2, 12 },
                    { 15, 160, 8, 40, 2, 12 },
                    { 16, 160, 9, 45, 9, 45 }
                });

            migrationBuilder.InsertData(
                table: "DataSets",
                columns: new[] { "DepartmentName", "DepartmentEndHour", "DepartmentStartHour", "EmployeeWorkLoad", "MinimumEmployees", "ShouldEstimateValue" },
                values: new object[,]
                {
                    { "Kassa", 22, 8, 25, 2, true },
                    { "Vers", 22, 6, 1, 2, false },
                    { "VKK", 22, 7, 2, 2, false }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Name", "MinimumAge", "PredictionValueName" },
                values: new object[,]
                {
                    { "Kassa", 16, "Bezoekers" },
                    { "Vers", 16, "Colli" },
                    { "VKK", 13, "Colli" }
                });

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                column: "Date",
                values: new object[]
                {
                    new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                });

            migrationBuilder.InsertData(
                table: "SchoolHolidays",
                columns: new[] { "Id", "EndDate", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DataPoints",
                columns: new[] { "Date", "DepartmentName", "IsHoliday", "Value" },
                values: new object[,]
                {
                    { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", true, 2718 },
                    { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", true, 135 },
                    { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", true, 271 },
                    { new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1543 },
                    { new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 77 },
                    { new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 154 },
                    { new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1137 },
                    { new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 56 },
                    { new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 113 },
                    { new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1103 },
                    { new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 55 },
                    { new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 110 },
                    { new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1014 },
                    { new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 101 },
                    { new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1127 },
                    { new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 56 },
                    { new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 112 },
                    { new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1081 },
                    { new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 108 },
                    { new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1476 },
                    { new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 73 },
                    { new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 147 },
                    { new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1638 },
                    { new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 81 },
                    { new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 163 },
                    { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1067 },
                    { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 53 },
                    { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 106 },
                    { new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1108 },
                    { new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 55 },
                    { new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 110 },
                    { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 990 },
                    { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 49 },
                    { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 99 },
                    { new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1084 },
                    { new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 108 },
                    { new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1030 },
                    { new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 103 },
                    { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1479 },
                    { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 73 },
                    { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 147 },
                    { new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1567 },
                    { new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 78 },
                    { new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 156 },
                    { new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1198 },
                    { new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 119 },
                    { new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1145 },
                    { new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 114 },
                    { new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 872 },
                    { new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1039 },
                    { new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 103 },
                    { new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1194 },
                    { new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 119 },
                    { new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1322 },
                    { new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 132 },
                    { new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1578 },
                    { new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 78 },
                    { new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 157 },
                    { new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1156 },
                    { new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 115 },
                    { new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1095 },
                    { new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 109 },
                    { new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1027 },
                    { new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 102 },
                    { new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1024 },
                    { new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 102 },
                    { new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1119 },
                    { new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 55 },
                    { new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 111 },
                    { new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1436 },
                    { new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 71 },
                    { new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 143 },
                    { new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1571 },
                    { new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 78 },
                    { new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 157 },
                    { new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1050 },
                    { new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 52 },
                    { new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 105 },
                    { new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 991 },
                    { new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 49 },
                    { new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 99 },
                    { new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 898 },
                    { new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 89 },
                    { new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1003 },
                    { new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 934 },
                    { new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 93 },
                    { new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1253 },
                    { new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 62 },
                    { new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 125 },
                    { new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1345 },
                    { new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 67 },
                    { new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 134 },
                    { new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 964 },
                    { new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 48 },
                    { new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 96 },
                    { new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 900 },
                    { new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 45 },
                    { new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 90 },
                    { new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 821 },
                    { new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 41 },
                    { new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 82 },
                    { new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 968 },
                    { new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 48 },
                    { new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 96 },
                    { new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 876 },
                    { new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1263 },
                    { new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 63 },
                    { new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 126 },
                    { new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1411 },
                    { new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 70 },
                    { new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 141 },
                    { new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 938 },
                    { new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 93 },
                    { new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 929 },
                    { new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 92 },
                    { new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 868 },
                    { new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 86 },
                    { new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 976 },
                    { new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 48 },
                    { new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 97 },
                    { new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 918 },
                    { new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 45 },
                    { new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 91 },
                    { new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1209 },
                    { new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 60 },
                    { new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 120 },
                    { new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1425 },
                    { new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 71 },
                    { new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 142 },
                    { new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 909 },
                    { new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 45 },
                    { new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 90 },
                    { new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 927 },
                    { new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 92 },
                    { new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 884 },
                    { new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 88 },
                    { new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 902 },
                    { new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 45 },
                    { new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 90 },
                    { new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 924 },
                    { new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 92 },
                    { new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1264 },
                    { new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 63 },
                    { new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 126 },
                    { new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1419 },
                    { new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 70 },
                    { new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 141 },
                    { new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 994 },
                    { new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 49 },
                    { new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 99 },
                    { new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 762 },
                    { new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 38 },
                    { new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 76 },
                    { new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 917 },
                    { new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 45 },
                    { new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 91 },
                    { new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1005 },
                    { new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1170 },
                    { new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 58 },
                    { new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 117 },
                    { new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 833 },
                    { new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 41 },
                    { new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 83 },
                    { new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 767 },
                    { new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 38 },
                    { new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 76 },
                    { new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 751 },
                    { new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 37 },
                    { new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 75 },
                    { new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 791 },
                    { new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 39 },
                    { new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 79 },
                    { new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 775 },
                    { new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 38 },
                    { new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 77 },
                    { new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1009 },
                    { new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1087 },
                    { new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 108 },
                    { new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 817 },
                    { new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 40 },
                    { new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 81 },
                    { new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 856 },
                    { new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 42 },
                    { new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 85 },
                    { new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 779 },
                    { new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 38 },
                    { new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 77 },
                    { new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 877 },
                    { new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 733 },
                    { new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 36 },
                    { new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 73 },
                    { new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1064 },
                    { new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 53 },
                    { new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 106 },
                    { new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1275 },
                    { new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 63 },
                    { new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 127 },
                    { new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 875 },
                    { new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 756 },
                    { new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 37 },
                    { new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 75 },
                    { new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 632 },
                    { new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 31 },
                    { new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 63 },
                    { new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 811 },
                    { new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 40 },
                    { new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 81 },
                    { new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 881 },
                    { new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 88 },
                    { new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1119 },
                    { new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 55 },
                    { new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 111 },
                    { new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1122 },
                    { new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 56 },
                    { new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 112 },
                    { new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 893 },
                    { new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 89 },
                    { new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 903 },
                    { new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 45 },
                    { new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 90 },
                    { new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 740 },
                    { new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 37 },
                    { new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 74 },
                    { new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 835 },
                    { new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 41 },
                    { new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 83 },
                    { new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 871 },
                    { new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1002 },
                    { new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1304 },
                    { new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 65 },
                    { new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 130 },
                    { new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 988 },
                    { new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 49 },
                    { new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 98 },
                    { new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1002 },
                    { new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 865 },
                    { new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 86 },
                    { new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 983 },
                    { new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 49 },
                    { new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 98 },
                    { new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 947 },
                    { new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 47 },
                    { new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 94 },
                    { new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1270 },
                    { new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 63 },
                    { new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 127 },
                    { new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1419 },
                    { new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 70 },
                    { new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 141 },
                    { new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 898 },
                    { new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 89 },
                    { new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 980 },
                    { new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 49 },
                    { new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 98 },
                    { new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 766 },
                    { new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 38 },
                    { new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 76 },
                    { new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 923 },
                    { new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 92 },
                    { new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 969 },
                    { new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 48 },
                    { new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 96 },
                    { new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1271 },
                    { new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 63 },
                    { new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 127 },
                    { new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1455 },
                    { new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 72 },
                    { new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 145 },
                    { new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 971 },
                    { new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 48 },
                    { new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 97 },
                    { new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 938 },
                    { new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 93 },
                    { new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 913 },
                    { new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 45 },
                    { new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 91 },
                    { new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 886 },
                    { new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 88 },
                    { new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1010 },
                    { new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 101 },
                    { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1265 },
                    { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 63 },
                    { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 126 },
                    { new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1350 },
                    { new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 67 },
                    { new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 135 },
                    { new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 935 },
                    { new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 93 },
                    { new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 894 },
                    { new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 89 },
                    { new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", true, 1808 },
                    { new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", true, 90 },
                    { new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", true, 180 },
                    { new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1038 },
                    { new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 103 },
                    { new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 962 },
                    { new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 48 },
                    { new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 96 },
                    { new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1253 },
                    { new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 62 },
                    { new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 125 },
                    { new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1464 },
                    { new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 73 },
                    { new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 146 },
                    { new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 955 },
                    { new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 47 },
                    { new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 95 },
                    { new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1026 },
                    { new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 102 },
                    { new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 763 },
                    { new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 38 },
                    { new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 76 },
                    { new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", true, 2040 },
                    { new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", true, 102 },
                    { new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", true, 204 },
                    { new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1032 },
                    { new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 103 },
                    { new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1196 },
                    { new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 119 },
                    { new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1452 },
                    { new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 72 },
                    { new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 145 },
                    { new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 896 },
                    { new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 89 },
                    { new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 917 },
                    { new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 45 },
                    { new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 91 },
                    { new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 877 },
                    { new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1015 },
                    { new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 101 },
                    { new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1006 },
                    { new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1265 },
                    { new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 63 },
                    { new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 126 },
                    { new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1444 },
                    { new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 72 },
                    { new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 144 },
                    { new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 895 },
                    { new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 89 },
                    { new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 972 },
                    { new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 48 },
                    { new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 97 },
                    { new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 918 },
                    { new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 45 },
                    { new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 91 },
                    { new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 872 },
                    { new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1002 },
                    { new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1198 },
                    { new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 119 },
                    { new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1365 },
                    { new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 68 },
                    { new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 136 },
                    { new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1018 },
                    { new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 101 },
                    { new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1048 },
                    { new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 52 },
                    { new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 104 },
                    { new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 872 },
                    { new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", true, 1948 },
                    { new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", true, 97 },
                    { new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", true, 194 },
                    { new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 874 },
                    { new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1299 },
                    { new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 64 },
                    { new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 129 },
                    { new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1299 },
                    { new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 64 },
                    { new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 129 },
                    { new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1053 },
                    { new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 52 },
                    { new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 105 },
                    { new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 887 },
                    { new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 88 },
                    { new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 991 },
                    { new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 49 },
                    { new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 99 },
                    { new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1109 },
                    { new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 55 },
                    { new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 110 },
                    { new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1033 },
                    { new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 103 },
                    { new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1331 },
                    { new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 133 },
                    { new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1644 },
                    { new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 82 },
                    { new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 164 },
                    { new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1103 },
                    { new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 55 },
                    { new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 110 },
                    { new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1194 },
                    { new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 119 },
                    { new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1007 },
                    { new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1058 },
                    { new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 52 },
                    { new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 105 },
                    { new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1013 },
                    { new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 101 },
                    { new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1477 },
                    { new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 73 },
                    { new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 147 },
                    { new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1500 },
                    { new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 75 },
                    { new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 150 },
                    { new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1140 },
                    { new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 114 },
                    { new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1151 },
                    { new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 115 },
                    { new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 928 },
                    { new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 92 },
                    { new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1198 },
                    { new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 119 },
                    { new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1044 },
                    { new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 52 },
                    { new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 104 },
                    { new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1320 },
                    { new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 132 },
                    { new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1626 },
                    { new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 81 },
                    { new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 162 },
                    { new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1094 },
                    { new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 109 },
                    { new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1039 },
                    { new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 103 },
                    { new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1019 },
                    { new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 101 },
                    { new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1023 },
                    { new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 102 },
                    { new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1199 },
                    { new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 119 },
                    { new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1339 },
                    { new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 133 },
                    { new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1624 },
                    { new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 81 },
                    { new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 162 },
                    { new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1202 },
                    { new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 60 },
                    { new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 120 },
                    { new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1071 },
                    { new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 53 },
                    { new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 107 },
                    { new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 929 },
                    { new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 92 },
                    { new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1084 },
                    { new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 108 },
                    { new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1137 },
                    { new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 56 },
                    { new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 113 },
                    { new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1371 },
                    { new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 68 },
                    { new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 137 },
                    { new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1675 },
                    { new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 83 },
                    { new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 167 },
                    { new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1021 },
                    { new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 102 },
                    { new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1141 },
                    { new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 114 },
                    { new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 945 },
                    { new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 47 },
                    { new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 94 },
                    { new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1191 },
                    { new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 119 },
                    { new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1130 },
                    { new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 56 },
                    { new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 113 },
                    { new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1385 },
                    { new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 69 },
                    { new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 138 },
                    { new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1604 },
                    { new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 80 },
                    { new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 160 },
                    { new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1096 },
                    { new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 109 },
                    { new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1051 },
                    { new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 52 },
                    { new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 105 },
                    { new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 928 },
                    { new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 92 },
                    { new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1010 },
                    { new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 101 },
                    { new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1024 },
                    { new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 102 },
                    { new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1428 },
                    { new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 71 },
                    { new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 142 },
                    { new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1493 },
                    { new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 74 },
                    { new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 149 },
                    { new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1016 },
                    { new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 101 },
                    { new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1117 },
                    { new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 55 },
                    { new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 111 },
                    { new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 954 },
                    { new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 47 },
                    { new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 95 },
                    { new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1019 },
                    { new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 101 },
                    { new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1138 },
                    { new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 56 },
                    { new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 113 },
                    { new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1369 },
                    { new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 68 },
                    { new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 136 },
                    { new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1476 },
                    { new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 73 },
                    { new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 147 },
                    { new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1052 },
                    { new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 52 },
                    { new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 105 },
                    { new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1122 },
                    { new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 56 },
                    { new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 112 },
                    { new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1001 },
                    { new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1201 },
                    { new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 60 },
                    { new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 120 },
                    { new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1106 },
                    { new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 55 },
                    { new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 110 },
                    { new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1342 },
                    { new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 67 },
                    { new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 134 },
                    { new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1484 },
                    { new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 74 },
                    { new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 148 },
                    { new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1185 },
                    { new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 118 },
                    { new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1150 },
                    { new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 115 },
                    { new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1152 },
                    { new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 115 },
                    { new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1243 },
                    { new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 62 },
                    { new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 124 },
                    { new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1336 },
                    { new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 133 },
                    { new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1580 },
                    { new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 79 },
                    { new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 158 },
                    { new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1766 },
                    { new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 88 },
                    { new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 176 },
                    { new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1284 },
                    { new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 64 },
                    { new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 128 },
                    { new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1264 },
                    { new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 63 },
                    { new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 126 },
                    { new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1150 },
                    { new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 115 },
                    { new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1255 },
                    { new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 62 },
                    { new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 125 },
                    { new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1244 },
                    { new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 62 },
                    { new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 124 },
                    { new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1543 },
                    { new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 77 },
                    { new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 154 },
                    { new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1673 },
                    { new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 83 },
                    { new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 167 },
                    { new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1199 },
                    { new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 119 },
                    { new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1159 },
                    { new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 115 },
                    { new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1143 },
                    { new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 114 },
                    { new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1337 },
                    { new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 133 },
                    { new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1339 },
                    { new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 133 },
                    { new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1576 },
                    { new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 78 },
                    { new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 157 },
                    { new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1862 },
                    { new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 93 },
                    { new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 186 },
                    { new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1339 },
                    { new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 133 },
                    { new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1150 },
                    { new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 115 },
                    { new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1120 },
                    { new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 56 },
                    { new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 112 },
                    { new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1213 },
                    { new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 60 },
                    { new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 121 },
                    { new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1163 },
                    { new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 58 },
                    { new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 116 },
                    { new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1633 },
                    { new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 81 },
                    { new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 163 },
                    { new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1765 },
                    { new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 88 },
                    { new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 176 },
                    { new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1179 },
                    { new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 58 },
                    { new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 117 },
                    { new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1320 },
                    { new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 132 },
                    { new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1153 },
                    { new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 115 },
                    { new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1060 },
                    { new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 53 },
                    { new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 106 },
                    { new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1161 },
                    { new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 58 },
                    { new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 116 },
                    { new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1509 },
                    { new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 75 },
                    { new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 150 },
                    { new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1491 },
                    { new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 74 },
                    { new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 149 },
                    { new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1091 },
                    { new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 109 },
                    { new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1159 },
                    { new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 115 },
                    { new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 956 },
                    { new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 47 },
                    { new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 95 },
                    { new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1005 },
                    { new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1037 },
                    { new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 103 },
                    { new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1390 },
                    { new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 69 },
                    { new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 139 },
                    { new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1531 },
                    { new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 76 },
                    { new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 153 },
                    { new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1131 },
                    { new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 56 },
                    { new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 113 },
                    { new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1049 },
                    { new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 52 },
                    { new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 104 },
                    { new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1007 },
                    { new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1089 },
                    { new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 108 },
                    { new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1078 },
                    { new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 53 },
                    { new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 107 },
                    { new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1351 },
                    { new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 67 },
                    { new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 135 },
                    { new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1545 },
                    { new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 77 },
                    { new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 154 },
                    { new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1145 },
                    { new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 114 },
                    { new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1047 },
                    { new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 52 },
                    { new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 104 },
                    { new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 861 },
                    { new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 86 },
                    { new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1084 },
                    { new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 108 },
                    { new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1201 },
                    { new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 60 },
                    { new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 120 },
                    { new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1440 },
                    { new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 72 },
                    { new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 144 },
                    { new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1527 },
                    { new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 76 },
                    { new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 152 },
                    { new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1024 },
                    { new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 102 },
                    { new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1102 },
                    { new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 55 },
                    { new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 110 },
                    { new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1002 },
                    { new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1079 },
                    { new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 53 },
                    { new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 107 },
                    { new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1095 },
                    { new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 109 },
                    { new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1684 },
                    { new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 84 },
                    { new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 168 },
                    { new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1748 },
                    { new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 87 },
                    { new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 174 },
                    { new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1253 },
                    { new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 62 },
                    { new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 125 },
                    { new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1141 },
                    { new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 114 },
                    { new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1073 },
                    { new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 53 },
                    { new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 107 },
                    { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1144 },
                    { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 114 },
                    { new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1210 },
                    { new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 60 },
                    { new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 121 },
                    { new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1556 },
                    { new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 77 },
                    { new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 155 },
                    { new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1761 },
                    { new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 88 },
                    { new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 176 },
                    { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1142 },
                    { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 114 },
                    { new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1330 },
                    { new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 133 },
                    { new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1018 },
                    { new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 101 },
                    { new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1164 },
                    { new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 58 },
                    { new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 116 },
                    { new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1143 },
                    { new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 114 },
                    { new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1680 },
                    { new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 84 },
                    { new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 168 },
                    { new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1855 },
                    { new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 92 },
                    { new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 185 },
                    { new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1226 },
                    { new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 61 },
                    { new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 122 },
                    { new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1229 },
                    { new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 61 },
                    { new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 122 },
                    { new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 989 },
                    { new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 49 },
                    { new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 98 },
                    { new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1158 },
                    { new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 57 },
                    { new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 115 },
                    { new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1298 },
                    { new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 64 },
                    { new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 129 },
                    { new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1527 },
                    { new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 76 },
                    { new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 152 },
                    { new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1805 },
                    { new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 90 },
                    { new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 180 },
                    { new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1310 },
                    { new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 65 },
                    { new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 131 },
                    { new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1295 },
                    { new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 64 },
                    { new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 129 },
                    { new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1084 },
                    { new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 54 },
                    { new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 108 },
                    { new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1330 },
                    { new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 66 },
                    { new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 133 },
                    { new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1317 },
                    { new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 65 },
                    { new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 131 },
                    { new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1624 },
                    { new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 81 },
                    { new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 162 },
                    { new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1841 },
                    { new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 92 },
                    { new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 184 },
                    { new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", true, 2466 },
                    { new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", true, 123 },
                    { new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", true, 246 },
                    { new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 752 },
                    { new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 37 },
                    { new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 75 },
                    { new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 764 },
                    { new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 38 },
                    { new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 76 },
                    { new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 761 },
                    { new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 38 },
                    { new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 76 },
                    { new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 876 },
                    { new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1004 },
                    { new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 50 },
                    { new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 100 },
                    { new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1194 },
                    { new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 59 },
                    { new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 119 },
                    { new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 872 },
                    { new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 787 },
                    { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 39 },
                    { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 78 },
                    { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 727 },
                    { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 36 },
                    { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 72 },
                    { new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 880 },
                    { new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 44 },
                    { new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 88 },
                    { new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 866 },
                    { new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 86 },
                    { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 986 },
                    { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 49 },
                    { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 98 },
                    { new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1161 },
                    { new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 58 },
                    { new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 116 },
                    { new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 923 },
                    { new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 92 },
                    { new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 814 },
                    { new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 40 },
                    { new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 81 },
                    { new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 738 },
                    { new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 36 },
                    { new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 73 },
                    { new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 876 },
                    { new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 43 },
                    { new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 87 },
                    { new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 764 },
                    { new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 38 },
                    { new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 76 },
                    { new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1029 },
                    { new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 51 },
                    { new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 102 },
                    { new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1231 },
                    { new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 61 },
                    { new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 123 },
                    { new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 920 },
                    { new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 92 },
                    { new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 922 },
                    { new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 46 },
                    { new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 92 },
                    { new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 706 },
                    { new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 35 },
                    { new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 70 },
                    { new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 743 },
                    { new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 37 },
                    { new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 74 },
                    { new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 813 },
                    { new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 40 },
                    { new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 81 },
                    { new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1068 },
                    { new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 53 },
                    { new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 106 },
                    { new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1170 },
                    { new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 58 },
                    { new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 117 },
                    { new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 809 },
                    { new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 40 },
                    { new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 80 },
                    { new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 782 },
                    { new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 39 },
                    { new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 78 },
                    { new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 743 },
                    { new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 37 },
                    { new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 74 },
                    { new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1530 },
                    { new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 76 },
                    { new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 153 },
                    { new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1517 },
                    { new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 75 },
                    { new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 151 },
                    { new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1966 },
                    { new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 98 },
                    { new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 196 },
                    { new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 2138 },
                    { new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 106 },
                    { new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 213 },
                    { new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1602 },
                    { new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 80 },
                    { new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 160 },
                    { new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1479 },
                    { new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 73 },
                    { new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 147 },
                    { new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1313 },
                    { new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 65 },
                    { new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 131 },
                    { new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1571 },
                    { new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 78 },
                    { new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 157 },
                    { new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1601 },
                    { new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 80 },
                    { new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 160 },
                    { new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1903 },
                    { new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 95 },
                    { new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 190 },
                    { new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 2179 },
                    { new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 108 },
                    { new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 217 },
                    { new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1424 },
                    { new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 71 },
                    { new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 142 },
                    { new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1448 },
                    { new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 72 },
                    { new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 144 },
                    { new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1345 },
                    { new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 67 },
                    { new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 134 },
                    { new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1529 },
                    { new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 76 },
                    { new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 152 },
                    { new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1572 },
                    { new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 78 },
                    { new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 157 },
                    { new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1971 },
                    { new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 98 },
                    { new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 197 },
                    { new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 2225 },
                    { new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 111 },
                    { new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 222 },
                    { new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1462 },
                    { new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 73 },
                    { new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 146 },
                    { new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1598 },
                    { new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 79 },
                    { new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 159 },
                    { new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1281 },
                    { new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 64 },
                    { new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 128 },
                    { new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1560 },
                    { new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 78 },
                    { new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 156 },
                    { new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1612 },
                    { new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 80 },
                    { new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 161 },
                    { new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", true, 3744 },
                    { new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", true, 187 },
                    { new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", true, 374 },
                    { new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", true, 4392 },
                    { new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", true, 219 },
                    { new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", true, 439 },
                    { new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", true, 3154 },
                    { new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", true, 157 },
                    { new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", true, 315 },
                    { new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1551 },
                    { new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 77 },
                    { new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 155 },
                    { new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1250 },
                    { new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 62 },
                    { new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 125 },
                    { new DateTime(2021, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1589 },
                    { new DateTime(2021, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 79 },
                    { new DateTime(2021, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 158 },
                    { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", false, 1482 },
                    { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", false, 74 },
                    { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", false, 148 },
                    { new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kassa", true, 3788 },
                    { new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers", true, 189 },
                    { new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "VKK", true, 378 }
                });

            migrationBuilder.InsertData(
                table: "HourlyPoints",
                columns: new[] { "DepartmentName", "Hour", "Value" },
                values: new object[,]
                {
                    { "Kassa", 8, 0.038668899999999999 },
                    { "Kassa", 9, 0.065572599999999995 },
                    { "Kassa", 10, 0.0825322 },
                    { "Kassa", 11, 0.087778499999999995 },
                    { "Kassa", 12, 0.090937400000000002 },
                    { "Kassa", 13, 0.091897699999999999 },
                    { "Kassa", 14, 0.085618200000000005 },
                    { "Kassa", 15, 0.079271800000000003 },
                    { "Kassa", 16, 0.082291500000000004 },
                    { "Kassa", 17, 0.081609000000000001 },
                    { "Kassa", 18, 0.057628600000000002 },
                    { "Kassa", 19, 0.028573600000000001 },
                    { "Kassa", 20, 0.029882800000000001 },
                    { "Kassa", 21, 0.045992499999999999 },
                    { "Kassa", 22, 0.051744699999999998 },
                    { "Vers", 6, 0.13 },
                    { "Vers", 7, 0.11 },
                    { "Vers", 8, 0.10000000000000001 },
                    { "Vers", 12, 0.13 },
                    { "Vers", 13, 0.11 },
                    { "Vers", 14, 0.089999999999999997 },
                    { "Vers", 18, 0.13 },
                    { "Vers", 19, 0.11 },
                    { "Vers", 20, 0.089999999999999997 },
                    { "VKK", 7, 0.20000000000000001 },
                    { "VKK", 8, 0.10000000000000001 },
                    { "VKK", 9, 0.10000000000000001 },
                    { "VKK", 14, 0.14999999999999999 },
                    { "VKK", 15, 0.14999999999999999 },
                    { "VKK", 20, 0.14999999999999999 },
                    { "VKK", 21, 0.14999999999999999 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_EmployeeId",
                table: "Availabilities",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DataPoints_DepartmentName",
                table: "DataPoints",
                column: "DepartmentName");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_EmployeeId",
                table: "Schedules",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolSchedules_EmployeeId",
                table: "SchoolSchedules",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkedHours_ScheduleId",
                table: "WorkedHours",
                column: "ScheduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Availabilities");

            migrationBuilder.DropTable(
                name: "CAOBonuses");

            migrationBuilder.DropTable(
                name: "CAORegulations");

            migrationBuilder.DropTable(
                name: "DataPoints");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "HourlyPoints");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "Prognosis");

            migrationBuilder.DropTable(
                name: "PublicHolidays");

            migrationBuilder.DropTable(
                name: "SchoolHolidays");

            migrationBuilder.DropTable(
                name: "SchoolSchedules");

            migrationBuilder.DropTable(
                name: "WorkedHours");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "DataSets");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
