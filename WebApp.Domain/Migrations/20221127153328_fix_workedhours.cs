using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class fixworkedhours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkedHours_Employees_EmployeeId",
                table: "WorkedHours");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "WorkedHours",
                newName: "ScheduleId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkedHours_EmployeeId",
                table: "WorkedHours",
                newName: "IX_WorkedHours_ScheduleId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovalTime",
                table: "WorkedHours",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "Department", "EmployeeId", "EndTime", "StartTime" },
                values: new object[,]
                {
                    { 5, "Vers", 1, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Vers", 1, new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Kassa", 2, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "VKK", 3, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApprovalTime", "ClockedTimeEnd", "ClockedTimeStart", "ScheduleId" },
                values: new object[] { null, new DateTime(2022, 11, 22, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 32, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApprovalTime", "ClockedTimeEnd", "ClockedTimeStart", "ScheduleId" },
                values: new object[] { null, new DateTime(2022, 11, 24, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 8, 31, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApprovalTime", "ClockedTimeEnd", "ClockedTimeStart", "ScheduleId" },
                values: new object[] { null, new DateTime(2022, 11, 22, 15, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 28, 0, 0, DateTimeKind.Unspecified), 7 });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApprovalTime", "ClockedTimeEnd", "ClockedTimeStart", "ScheduleId" },
                values: new object[] { null, new DateTime(2022, 11, 22, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 34, 0, 0, DateTimeKind.Unspecified), 8 });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkedHours_Schedules_ScheduleId",
                table: "WorkedHours",
                column: "ScheduleId",
                principalTable: "Schedules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkedHours_Schedules_ScheduleId",
                table: "WorkedHours");

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

            migrationBuilder.RenameColumn(
                name: "ScheduleId",
                table: "WorkedHours",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_WorkedHours_ScheduleId",
                table: "WorkedHours",
                newName: "IX_WorkedHours_EmployeeId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ApprovalTime",
                table: "WorkedHours",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ApprovalTime", "ClockedTimeEnd", "ClockedTimeStart", "EmployeeId" },
                values: new object[] { new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ApprovalTime", "ClockedTimeEnd", "ClockedTimeStart", "EmployeeId" },
                values: new object[] { new DateTime(2022, 11, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 24, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ApprovalTime", "ClockedTimeEnd", "ClockedTimeStart", "EmployeeId" },
                values: new object[] { new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "WorkedHours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ApprovalTime", "ClockedTimeEnd", "ClockedTimeStart", "EmployeeId" },
                values: new object[] { new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkedHours_Employees_EmployeeId",
                table: "WorkedHours",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
