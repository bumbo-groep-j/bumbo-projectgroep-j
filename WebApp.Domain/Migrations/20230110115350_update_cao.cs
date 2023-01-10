using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class updatecao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CAORegulations",
                keyColumn: "Age",
                keyValue: 15,
                column: "AllowedHoursSchoolDay",
                value: 8);

            migrationBuilder.UpdateData(
                table: "CAORegulations",
                keyColumn: "Age",
                keyValue: 16,
                columns: new[] { "AllowedHoursNotSchoolWeek", "AllowedHoursSchoolWeek" },
                values: new object[] { 40, 40 });

            migrationBuilder.InsertData(
                table: "CAORegulations",
                columns: new[] { "Age", "AllowedHours4Weeks", "AllowedHoursNotSchoolDay", "AllowedHoursNotSchoolWeek", "AllowedHoursSchoolDay", "AllowedHoursSchoolWeek" },
                values: new object[] { 18, 220, 12, 60, 12, 60 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CAORegulations",
                keyColumn: "Age",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "CAORegulations",
                keyColumn: "Age",
                keyValue: 15,
                column: "AllowedHoursSchoolDay",
                value: 2);

            migrationBuilder.UpdateData(
                table: "CAORegulations",
                keyColumn: "Age",
                keyValue: 16,
                columns: new[] { "AllowedHoursNotSchoolWeek", "AllowedHoursSchoolWeek" },
                values: new object[] { 45, 45 });
        }
    }
}
