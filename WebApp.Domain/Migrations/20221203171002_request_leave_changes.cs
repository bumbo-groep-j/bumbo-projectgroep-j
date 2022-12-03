using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class requestleavechanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Employees_EmployeeId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_Requests_EmployeeId",
                table: "Requests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Requests_EmployeeId",
                table: "Requests",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Employees_EmployeeId",
                table: "Requests",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
