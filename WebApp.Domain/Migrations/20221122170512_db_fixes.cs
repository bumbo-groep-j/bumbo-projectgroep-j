using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class dbfixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SchoolSchedules",
                table: "SchoolSchedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities");

            migrationBuilder.DropIndex(
                name: "IX_Availabilities_EmployeeId",
                table: "Availabilities");

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Availabilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prognosis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prognosis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolSchedules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SchoolSchedules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SchoolSchedules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SchoolSchedules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "WorkedHours");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "WorkedHours",
                newName: "ClockedTimeStart");

            migrationBuilder.RenameColumn(
                name: "WeekDay",
                table: "SchoolSchedules",
                newName: "Weekday");

            migrationBuilder.RenameColumn(
                name: "MiddelName",
                table: "Employees",
                newName: "MiddleName");

            migrationBuilder.RenameColumn(
                name: "HourSalary",
                table: "Employees",
                newName: "HourlyWage");

            migrationBuilder.RenameColumn(
                name: "Birthdate",
                table: "Employees",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "WeekDay",
                table: "Availabilities",
                newName: "Weekday");

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedTimeEnd",
                table: "WorkedHours",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ApprovedTimeStart",
                table: "WorkedHours",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ClockedTimeEnd",
                table: "WorkedHours",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SchoolSchedules",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "SchoolSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "SchoolSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Availabilities",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Availabilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Availabilities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchoolSchedules",
                table: "SchoolSchedules",
                columns: new[] { "EmployeeId", "Weekday", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities",
                columns: new[] { "EmployeeId", "Weekday", "Id" });

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
                table: "SchoolSchedules",
                columns: new[] { "EmployeeId", "Id", "Weekday", "EndDate", "EndTime", "StartDate", "StartTime" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 21, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 25, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApprovedTimeEnd", "ApprovedTimeStart", "ClockedTimeEnd" },
                values: new object[] { null, null, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApprovedTimeEnd", "ApprovedTimeStart", "ClockedTimeEnd" },
                values: new object[] { null, null, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApprovedTimeEnd", "ApprovedTimeStart", "ClockedTimeEnd" },
                values: new object[] { null, null, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApprovedTimeEnd", "ApprovedTimeStart", "ClockedTimeEnd" },
                values: new object[] { null, null, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_WorkedHours_EmployeeId",
                table: "WorkedHours",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_EmployeeId",
                table: "Schedules",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Employees_EmployeeId",
                table: "Schedules",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolSchedules_Employees_EmployeeId",
                table: "SchoolSchedules",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkedHours_Employees_EmployeeId",
                table: "WorkedHours",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Employees_EmployeeId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SchoolSchedules_Employees_EmployeeId",
                table: "SchoolSchedules");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkedHours_Employees_EmployeeId",
                table: "WorkedHours");

            migrationBuilder.DropIndex(
                name: "IX_WorkedHours_EmployeeId",
                table: "WorkedHours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SchoolSchedules",
                table: "SchoolSchedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_EmployeeId",
                table: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities");

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

            migrationBuilder.DropColumn(
                name: "ApprovedTimeEnd",
                table: "WorkedHours");

            migrationBuilder.DropColumn(
                name: "ApprovedTimeStart",
                table: "WorkedHours");

            migrationBuilder.DropColumn(
                name: "ClockedTimeEnd",
                table: "WorkedHours");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "SchoolSchedules");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "SchoolSchedules");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Availabilities");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Availabilities");

            migrationBuilder.RenameColumn(
                name: "ClockedTimeStart",
                table: "WorkedHours",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "Weekday",
                table: "SchoolSchedules",
                newName: "WeekDay");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Employees",
                newName: "MiddelName");

            migrationBuilder.RenameColumn(
                name: "HourlyWage",
                table: "Employees",
                newName: "HourSalary");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Employees",
                newName: "Birthdate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employees",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "Weekday",
                table: "Availabilities",
                newName: "WeekDay");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "WorkedHours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "SchoolSchedules",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Availabilities",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SchoolSchedules",
                table: "SchoolSchedules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Availabilities",
                table: "Availabilities",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "Email",
                value: "tester1@mail.com");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "Email",
                value: "tester2@mail.com");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "Email",
                value: "tester3@mail.com");

            migrationBuilder.InsertData(
                table: "Prognosis",
                columns: new[] { "Id", "Date", "Department", "TotalColli", "TotalCustomers" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Verkoop", 3, 10 },
                    { 2, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Magazijn", 10, 15 }
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

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 2,
                column: "EndTime",
                value: new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 3,
                column: "EndTime",
                value: new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 4,
                column: "EndTime",
                value: new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_EmployeeId",
                table: "Availabilities",
                column: "EmployeeId");
        }
    }
}
