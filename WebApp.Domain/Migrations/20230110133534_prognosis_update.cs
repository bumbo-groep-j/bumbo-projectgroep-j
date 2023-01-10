using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class prognosisupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 21 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 22 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 6 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 7 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 7 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 21 });

            migrationBuilder.DropColumn(
                name: "DepartmentEndHour",
                table: "DataSets");

            migrationBuilder.DropColumn(
                name: "DepartmentStartHour",
                table: "DataSets");

            migrationBuilder.AddColumn<int>(
                name: "EndHourSaturday",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndHourSunday",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EndHourWeekday",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartHourSaturday",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartHourSunday",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartHourWeekday",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 2718);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1543);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1137);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1103);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1014);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1127);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1081);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1476);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1638);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1067);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1108);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 990);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1084);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1030);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1479);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1567);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1198);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1145);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 872);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1039);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1194);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1322);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1578);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1156);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1095);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1027);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1024);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1119);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1436);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1571);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1050);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 991);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 898);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1003);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 934);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1253);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1345);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 964);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 900);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 821);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 968);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 876);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1263);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1411);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 938);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 929);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 868);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 976);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 918);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1209);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1425);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 909);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 927);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 884);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 902);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 924);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1264);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1419);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 994);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 762);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 917);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1005);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1170);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 833);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 767);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 751);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 791);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 775);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1009);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1087);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 817);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 856);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 779);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 877);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 733);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1064);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1275);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 875);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 756);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 632);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 811);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 881);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1119);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1122);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 893);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 903);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 740);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 835);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 871);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1002);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1304);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 988);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1002);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 865);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 983);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 947);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1270);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1419);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 898);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 980);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 766);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 923);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 969);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1271);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1455);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 971);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 938);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 913);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 886);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1010);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1265);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1350);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 935);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 894);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1808);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1038);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 962);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1253);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1464);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 955);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1026);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 763);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 2040);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1032);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1196);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1452);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 896);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 917);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 877);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1015);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1006);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1265);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1444);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 895);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 972);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 918);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 872);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1002);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1198);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1365);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1018);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1048);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 872);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1948);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 874);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1299);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1299);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1053);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 887);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 991);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1109);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1033);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1331);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1644);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1103);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1194);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1007);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1058);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1013);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1477);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1500);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1140);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1151);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 928);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1198);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1044);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1320);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1626);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1094);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1039);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1019);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1023);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1199);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1339);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1624);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1202);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1071);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 929);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1084);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1137);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1371);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1675);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1021);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1141);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 945);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1191);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1130);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1385);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1604);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1096);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1051);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 928);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1010);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1024);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1428);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1493);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1016);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1117);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 954);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1019);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1138);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1369);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1476);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1052);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1122);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1001);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1201);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1106);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1342);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1484);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1185);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1150);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1152);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1243);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1336);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1580);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1766);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1284);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1264);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1150);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1255);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1244);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1543);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1673);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1199);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1159);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1143);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1337);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1339);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1576);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1862);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1339);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1150);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1120);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1213);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1163);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1633);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1765);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1179);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1320);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1153);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1060);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1161);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1509);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1491);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1091);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1159);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 956);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1005);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1037);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1390);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1531);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1131);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1049);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1007);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1089);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1078);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1351);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1545);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1145);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1047);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 861);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1084);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1201);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1440);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1527);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1024);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1102);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1002);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1079);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1095);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1684);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1748);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1253);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1141);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1073);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1144);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1210);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1556);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1761);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1142);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1330);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1018);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1164);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1143);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1680);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1855);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1226);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1229);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 989);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1158);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1298);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1527);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1805);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1310);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1295);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1084);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1330);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1317);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1624);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1841);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 2466);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 752);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 764);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 761);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 876);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1004);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1194);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 872);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 787);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 727);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 880);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 866);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 986);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1161);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 923);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 814);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 738);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 876);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 764);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1029);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1231);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 920);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 922);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 706);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 743);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 813);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1068);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1170);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 809);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 782);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 743);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1530);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1517);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1966);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 2138);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1602);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1479);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1313);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1571);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1601);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1903);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 2179);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1424);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1448);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1345);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1529);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1572);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1971);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 2225);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1462);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1598);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1281);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1560);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1612);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 3744);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 4392);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 3154);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1551);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1250);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1589);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 1482);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 3788);

            migrationBuilder.UpdateData(
                table: "DataSets",
                keyColumn: "DepartmentName",
                keyValue: "Kassa",
                columns: new[] { "MinimumEmployees", "EmployeeWorkLoad" },
                values: new object[] { 1, 30 });

            migrationBuilder.UpdateData(
                table: "DataSets",
                keyColumn: "DepartmentName",
                keyValue: "Vers",
                columns: new[] { "MinimumEmployees", "EmployeeWorkLoad", "ShouldEstimateValue" },
                values: new object[] { 1, 100, true });

            migrationBuilder.UpdateData(
                table: "DataSets",
                keyColumn: "DepartmentName",
                keyValue: "VKK",
                columns: new[] { "MinimumEmployees", "ShouldEstimateValue" },
                values: new object[] { 1, true });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Kassa",
                columns: new[] { "EndHourSaturday", "EndHourSunday", "EndHourWeekday", "StartHourSaturday", "StartHourSunday", "StartHourWeekday" },
                values: new object[] { 21, 19, 21, 8, 9, 8 });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Vers",
                columns: new[] { "EndHourSaturday", "EndHourSunday", "EndHourWeekday", "PredictionValueName", "StartHourSaturday", "StartHourSunday", "StartHourWeekday" },
                values: new object[] { 21, 19, 21, "Bezoekers", 8, 9, 8 });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "VKK",
                columns: new[] { "EndHourSaturday", "EndHourSunday", "EndHourWeekday", "StartHourSaturday", "StartHourSunday", "StartHourWeekday" },
                values: new object[] { 21, 19, 21, 8, 9, 8 });

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 8 },
                column: "Value",
                value: 0.042857699999999999);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 9 },
                column: "Value",
                value: 0.072675699999999996);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 10 },
                column: "Value",
                value: 0.091472399999999995);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 11 },
                column: "Value",
                value: 0.097287100000000001);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 12 },
                column: "Value",
                value: 0.100788);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 13 },
                column: "Value",
                value: 0.101852);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 14 },
                column: "Value",
                value: 0.094892799999999999);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 15 },
                column: "Value",
                value: 0.087858900000000004);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 16 },
                column: "Value",
                value: 0.091205700000000001);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 17 },
                column: "Value",
                value: 0.090449199999999993);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 18 },
                column: "Value",
                value: 0.0638711);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 19 },
                column: "Value",
                value: 0.031668799999999997);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 20 },
                column: "Value",
                value: 0.033119799999999998);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 8 },
                column: "Value",
                value: 0.042857699999999999);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 12 },
                column: "Value",
                value: 0.100788);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 13 },
                column: "Value",
                value: 0.101852);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 14 },
                column: "Value",
                value: 0.094892799999999999);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 18 },
                column: "Value",
                value: 0.0638711);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 19 },
                column: "Value",
                value: 0.031668799999999997);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 20 },
                column: "Value",
                value: 0.033119799999999998);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 8 },
                column: "Value",
                value: 0.076923099999999994);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 9 },
                column: "Value",
                value: 0.076923099999999994);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 14 },
                column: "Value",
                value: 0.076923099999999994);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 15 },
                column: "Value",
                value: 0.076923099999999994);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 20 },
                column: "Value",
                value: 0.076923099999999994);

            migrationBuilder.InsertData(
                table: "HourlyPoints",
                columns: new[] { "DepartmentName", "Hour", "Value" },
                values: new object[,]
                {
                    { "Vers", 9, 0.072675699999999996 },
                    { "Vers", 10, 0.091472399999999995 },
                    { "Vers", 11, 0.097287100000000001 },
                    { "Vers", 15, 0.087858900000000004 },
                    { "Vers", 16, 0.091205700000000001 },
                    { "Vers", 17, 0.090449199999999993 },
                    { "VKK", 10, 0.076923099999999994 },
                    { "VKK", 11, 0.076923099999999994 },
                    { "VKK", 12, 0.076923099999999994 },
                    { "VKK", 13, 0.076923099999999994 },
                    { "VKK", 16, 0.076923099999999994 },
                    { "VKK", 17, 0.076923099999999994 },
                    { "VKK", 18, 0.076923099999999994 },
                    { "VKK", 19, 0.076923099999999994 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DataSets_Departments_DepartmentName",
                table: "DataSets",
                column: "DepartmentName",
                principalTable: "Departments",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataSets_Departments_DepartmentName",
                table: "DataSets");

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 9 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 10 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 11 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 15 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 16 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 17 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 10 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 11 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 12 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 13 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 16 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 17 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 18 });

            migrationBuilder.DeleteData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 19 });

            migrationBuilder.DropColumn(
                name: "EndHourSaturday",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "EndHourSunday",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "EndHourWeekday",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "StartHourSaturday",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "StartHourSunday",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "StartHourWeekday",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentEndHour",
                table: "DataSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartmentStartHour",
                table: "DataSets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 135);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 77);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 56);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 55);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 56);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 73);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 81);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 53);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 55);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 49);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 73);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 78);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 78);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 55);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 71);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 78);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 52);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 49);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 62);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 67);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 48);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 45);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 41);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 48);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 63);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 70);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 48);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 45);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 60);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 71);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 45);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 45);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 63);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 70);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 49);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 38);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 45);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 58);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 41);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 38);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 37);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 39);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 38);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 40);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 42);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 38);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 36);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 53);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 63);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 37);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 31);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 40);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 55);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 56);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 45);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 37);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 41);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 65);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 49);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 49);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 47);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 63);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 70);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 49);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 38);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 48);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 63);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 72);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 48);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 45);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 63);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 67);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 90);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 48);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 62);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 73);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 47);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 38);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 102);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 72);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 45);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 63);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 72);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 48);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 45);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 68);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 52);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 97);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 64);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 64);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 52);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 49);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 55);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 82);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 55);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 52);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 73);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 75);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 52);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 81);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 81);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 60);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 53);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 56);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 68);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 83);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 47);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 56);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 69);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 80);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 52);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 71);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 74);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 55);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 47);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 56);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 68);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 73);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 52);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 56);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 60);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 55);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 67);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 74);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 62);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 79);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 88);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 64);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 63);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 62);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 62);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 77);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 83);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 78);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 93);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 56);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 60);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 58);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 81);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 88);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 58);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 53);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 58);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 75);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 74);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 47);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 69);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 76);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 56);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 52);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 53);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 67);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 77);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 52);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 60);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 72);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 76);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 55);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 53);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 84);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 87);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 62);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 53);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 60);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 77);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 88);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 58);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 84);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 92);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 61);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 61);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 49);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 57);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 64);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 76);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 90);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 65);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 64);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 54);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 66);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 65);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 81);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 92);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 123);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 37);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 38);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 38);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 50);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 59);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 39);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 36);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 44);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 49);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 58);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 40);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 36);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 43);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 38);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 61);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 46);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 35);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 37);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 40);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 53);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 58);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 40);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 39);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 37);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 76);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 75);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 98);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 106);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 80);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 73);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 65);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 78);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 80);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 95);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 108);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 71);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 72);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 67);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 76);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 78);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 98);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 111);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 73);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 79);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 64);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 78);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 80);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 187);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 219);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 157);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 77);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 62);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 79);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 74);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumns: new[] { "Date", "DepartmentName" },
                keyValues: new object[] { new DateTime(2021, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vers" },
                column: "Value",
                value: 189);

            migrationBuilder.UpdateData(
                table: "DataSets",
                keyColumn: "DepartmentName",
                keyValue: "Kassa",
                columns: new[] { "DepartmentEndHour", "DepartmentStartHour", "EmployeeWorkLoad" },
                values: new object[] { 22, 8, 25 });

            migrationBuilder.UpdateData(
                table: "DataSets",
                keyColumn: "DepartmentName",
                keyValue: "Vers",
                columns: new[] { "DepartmentEndHour", "DepartmentStartHour", "EmployeeWorkLoad", "ShouldEstimateValue" },
                values: new object[] { 22, 6, 1, false });

            migrationBuilder.UpdateData(
                table: "DataSets",
                keyColumn: "DepartmentName",
                keyValue: "VKK",
                columns: new[] { "DepartmentEndHour", "DepartmentStartHour", "ShouldEstimateValue" },
                values: new object[] { 22, 7, false });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Vers",
                column: "PredictionValueName",
                value: "Colli");

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 8 },
                column: "Value",
                value: 0.038668899999999999);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 9 },
                column: "Value",
                value: 0.065572599999999995);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 10 },
                column: "Value",
                value: 0.0825322);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 11 },
                column: "Value",
                value: 0.087778499999999995);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 12 },
                column: "Value",
                value: 0.090937400000000002);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 13 },
                column: "Value",
                value: 0.091897699999999999);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 14 },
                column: "Value",
                value: 0.085618200000000005);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 15 },
                column: "Value",
                value: 0.079271800000000003);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 16 },
                column: "Value",
                value: 0.082291500000000004);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 17 },
                column: "Value",
                value: 0.081609000000000001);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 18 },
                column: "Value",
                value: 0.057628600000000002);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 19 },
                column: "Value",
                value: 0.028573600000000001);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Kassa", 20 },
                column: "Value",
                value: 0.029882800000000001);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 8 },
                column: "Value",
                value: 0.10000000000000001);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 12 },
                column: "Value",
                value: 0.13);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 13 },
                column: "Value",
                value: 0.11);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 14 },
                column: "Value",
                value: 0.089999999999999997);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 18 },
                column: "Value",
                value: 0.13);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 19 },
                column: "Value",
                value: 0.11);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "Vers", 20 },
                column: "Value",
                value: 0.089999999999999997);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 8 },
                column: "Value",
                value: 0.10000000000000001);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 9 },
                column: "Value",
                value: 0.10000000000000001);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 14 },
                column: "Value",
                value: 0.14999999999999999);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 15 },
                column: "Value",
                value: 0.14999999999999999);

            migrationBuilder.UpdateData(
                table: "HourlyPoints",
                keyColumns: new[] { "DepartmentName", "Hour" },
                keyValues: new object[] { "VKK", 20 },
                column: "Value",
                value: 0.14999999999999999);

            migrationBuilder.InsertData(
                table: "HourlyPoints",
                columns: new[] { "DepartmentName", "Hour", "Value" },
                values: new object[,]
                {
                    { "Kassa", 21, 0.045992499999999999 },
                    { "Kassa", 22, 0.051744699999999998 },
                    { "Vers", 6, 0.13 },
                    { "Vers", 7, 0.11 },
                    { "VKK", 7, 0.20000000000000001 },
                    { "VKK", 21, 0.14999999999999999 }
                });
        }
    }
}
