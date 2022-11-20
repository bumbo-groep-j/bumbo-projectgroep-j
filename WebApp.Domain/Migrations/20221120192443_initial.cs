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
                name: "Divisions",
                columns: table => new
                {
                    DivisionName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.DivisionName);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Insertion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateTime>(type: "Date", nullable: false),
                    NFCToken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    TotalCustomers = table.Column<int>(type: "int", nullable: true),
                    DivisionName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prognosis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prognosis_Divisions_DivisionName",
                        column: x => x.DivisionName,
                        principalTable: "Divisions",
                        principalColumn: "DivisionName",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Availabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ScheduledServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DivisionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduledServices_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schoolmoments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    TotalHour = table.Column<int>(type: "int", nullable: true),
                    date = table.Column<DateTime>(type: "Date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schoolmoments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schoolmoments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkedServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ApprovalMoment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkedServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkedServices_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Divisions",
                column: "DivisionName",
                values: new object[]
                {
                    "Magazijn",
                    "Verkoop"
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Birthdate", "Email", "FirstName", "Insertion", "LastName", "NFCToken" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "tester1@mail.com", "testUser1FirstName", "", "testUser1LastName", "Token1" },
                    { 2, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "tester2@mail.com", "testUser2FirstName", "", "testUser2LastName", "Token2" },
                    { 3, new DateTime(1985, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "tester3@mail.com", "testUser3FirstName", "", "testUser3LastName", "Token3" }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Prognosis",
                columns: new[] { "Id", "Date", "DivisionName", "TotalColli", "TotalCustomers" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Verkoop", 3, 10 },
                    { 2, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magazijn", 10, 15 }
                });

            migrationBuilder.InsertData(
                table: "ScheduledServices",
                columns: new[] { "Id", "DivisionName", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, "Magazijn", 1, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Verkoop", 1, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Verkoop", 2, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Magazijn", 3, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Schoolmoments",
                columns: new[] { "Id", "EmployeeId", "TotalHour", "date" },
                values: new object[,]
                {
                    { 1, 1, 20, new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, 20, new DateTime(2022, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, 20, new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, 20, new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WorkedServices",
                columns: new[] { "Id", "ApprovalMoment", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_EmployeeId",
                table: "Availabilities",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Prognosis_DivisionName",
                table: "Prognosis",
                column: "DivisionName");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledServices_EmployeeId",
                table: "ScheduledServices",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Schoolmoments_EmployeeId",
                table: "Schoolmoments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkedServices_EmployeeId",
                table: "WorkedServices",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Availabilities");

            migrationBuilder.DropTable(
                name: "Prognosis");

            migrationBuilder.DropTable(
                name: "ScheduledServices");

            migrationBuilder.DropTable(
                name: "Schoolmoments");

            migrationBuilder.DropTable(
                name: "WorkedServices");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
