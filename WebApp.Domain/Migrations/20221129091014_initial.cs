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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "Date", nullable: false),
                    NFCToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HourlyWage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
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
                name: "Availabilities",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Weekday = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availabilities", x => new { x.EmployeeId, x.Weekday, x.Id });
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
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Weekday = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolSchedules", x => new { x.EmployeeId, x.Weekday, x.Id });
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
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClockedTimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClockedTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedTimeStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedTimeEnd = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkedHours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkedHours_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
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
                columns: new[] { "Id", "DateOfBirth", "FirstName", "HourlyWage", "LastName", "MiddleName", "NFCToken" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "testUser1FirstName", 0.0, "testUser1LastName", "", "Token1" },
                    { 2, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "testUser2FirstName", 0.0, "testUser2LastName", "", "Token2" },
                    { 3, new DateTime(1985, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "testUser3FirstName", 0.0, "testUser3LastName", "testUser3MiddelName", "Token3" }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "EmployeeId", "Id", "Weekday", "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) }
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
                columns: new[] { "EmployeeId", "Id", "Weekday", "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WorkedHours",
                columns: new[] { "Id", "ApprovalTime", "ApprovedTimeEnd", "ApprovedTimeStart", "ClockedTimeEnd", "ClockedTimeStart", "Department", "EmployeeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), "Magazijn", 1 },
                    { 2, new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), "Verkoop", 1 },
                    { 3, new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), "Verkoop", 2 },
                    { 4, new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), "Magazijn", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_EmployeeId",
                table: "Schedules",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkedHours_EmployeeId",
                table: "WorkedHours",
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
