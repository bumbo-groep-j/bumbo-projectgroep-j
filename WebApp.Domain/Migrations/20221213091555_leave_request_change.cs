using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class leaverequestchange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeaveRequestStatus",
                table: "LeaveRequests");

            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "LeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Rejected",
                table: "LeaveRequests",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "LeaveRequests");

            migrationBuilder.DropColumn(
                name: "Rejected",
                table: "LeaveRequests");

            migrationBuilder.AddColumn<int>(
                name: "LeaveRequestStatus",
                table: "LeaveRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
