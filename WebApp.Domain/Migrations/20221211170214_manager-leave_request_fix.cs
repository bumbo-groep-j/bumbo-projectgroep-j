using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class managerleaverequestfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "LeaveRequests");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "LeaveRequests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "LeaveRequestStatus",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "LeaveRequestStatus",
                table: "LeaveRequests");

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "LeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
