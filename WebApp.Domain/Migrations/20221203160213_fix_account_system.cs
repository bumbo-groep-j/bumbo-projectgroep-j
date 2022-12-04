using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class fixaccountsystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "EmployeeId", "Id", "Weekday" },
                keyValues: new object[] { 1, 1, 0 });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "EmployeeId", "Id", "Weekday" },
                keyValues: new object[] { 1, 2, 3 });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "EmployeeId", "Id", "Weekday" },
                keyValues: new object[] { 2, 3, 1 });

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumns: new[] { "EmployeeId", "Id", "Weekday" },
                keyValues: new object[] { 3, 4, 1 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SchoolSchedules",
                keyColumns: new[] { "EmployeeId", "Id", "Weekday" },
                keyValues: new object[] { 1, 1, 0 });

            migrationBuilder.DeleteData(
                table: "SchoolSchedules",
                keyColumns: new[] { "EmployeeId", "Id", "Weekday" },
                keyValues: new object[] { 1, 2, 2 });

            migrationBuilder.DeleteData(
                table: "SchoolSchedules",
                keyColumns: new[] { "EmployeeId", "Id", "Weekday" },
                keyValues: new object[] { 2, 3, 4 });

            migrationBuilder.DeleteData(
                table: "SchoolSchedules",
                keyColumns: new[] { "EmployeeId", "Id", "Weekday" },
                keyValues: new object[] { 3, 4, 1 });

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Inactive",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inactive",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "FirstName", "HourlyWage", "LastName", "MiddleName", "NFCToken", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2000, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "testUser1FirstName", 0.0, "testUser1LastName", "", "Token1", null },
                    { 2, new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "testUser2FirstName", 0.0, "testUser2LastName", "", "Token2", null },
                    { 3, new DateTime(1985, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "testUser3FirstName", 0.0, "testUser3LastName", "testUser3MiddelName", "Token3", null }
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
                    { 1, "VKK", 1, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Kassa", 1, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Kassa", 2, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Vers", 3, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Vers", 1, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Vers", 1, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Kassa", 2, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "VKK", 3, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) }
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
                columns: new[] { "Id", "ApprovalTime", "ApprovedTimeEnd", "ApprovedTimeStart", "ClockedTimeEnd", "ClockedTimeStart", "Department", "ScheduleId" },
                values: new object[,]
                {
                    { 1, null, null, null, new DateTime(2022, 11, 22, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 32, 0, 0, DateTimeKind.Unspecified), "Vers", 5 },
                    { 2, null, null, null, new DateTime(2022, 11, 24, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 8, 31, 0, 0, DateTimeKind.Unspecified), "Vers", 6 },
                    { 3, null, null, null, new DateTime(2022, 11, 22, 15, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 28, 0, 0, DateTimeKind.Unspecified), "Kassa", 7 },
                    { 4, null, null, null, new DateTime(2022, 11, 22, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 34, 0, 0, DateTimeKind.Unspecified), "VKK", 8 }
                });
        }
    }
}
