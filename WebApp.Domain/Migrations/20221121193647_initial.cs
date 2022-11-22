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
                name: "Departments",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "Date", nullable: false),
                    NFCToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourSalary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Prognosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalColli = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCustomers = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prognosis", x => x.Id);
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
                });

            migrationBuilder.CreateTable(
                name: "SchoolSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeekDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolSchedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkedHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkedHours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Availabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WeekDay = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Availabilities_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                column: "Name",
                values: new object[]
                {
                    "Magazijn",
                    "Verkoop"
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Birthdate", "Email", "FirstName", "HourSalary", "LastName", "MiddelName", "NFCToken" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "tester1@mail.com", "testUser1FirstName", 0.0, "testUser1LastName", "", "Token1" },
                    { 2, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "tester2@mail.com", "testUser2FirstName", 0.0, "testUser2LastName", "", "Token2" },
                    { 3, new DateTime(1985, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "tester3@mail.com", "testUser3FirstName", 0.0, "testUser3LastName", "testUser3MiddelName", "Token3" }
                });

            migrationBuilder.InsertData(
                table: "Prognosis",
                columns: new[] { "Id", "Date", "Department", "TotalColli", "TotalCustomers" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Verkoop", 3, 10 },
                    { 2, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magazijn", 10, 15 }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Department", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, "Magazijn", 1, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Verkoop", 1, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Verkoop", 2, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Magazijn", 3, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SchoolSchedules",
                columns: new[] { "Id", "EmployeeId", "EndTime", "StartTime", "WeekDay" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 11, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 8, 30, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 1, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, 2, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 8, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 4, 3, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 8, 30, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "WorkedHours",
                columns: new[] { "Id", "ApprovalTime", "Department", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), "Magazijn", 1, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "Verkoop", 1, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), "Verkoop", 2, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), "Magazijn", 3, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "EmployeeId", "EndTime", "StartTime", "WeekDay" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, 1, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, 2, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, 3, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_EmployeeId",
                table: "Availabilities",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Availabilities");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Prognosis");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "SchoolSchedules");

            migrationBuilder.DropTable(
                name: "WorkedHours");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
