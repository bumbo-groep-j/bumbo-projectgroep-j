using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class addcaoregulations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MinimumAge",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CAORegulations",
                columns: table => new
                {
                    Age = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowedHoursSchoolDay = table.Column<int>(type: "int", nullable: false),
                    AllowedHoursSchoolWeek = table.Column<int>(type: "int", nullable: false),
                    AllowedHoursNotSchoolDay = table.Column<int>(type: "int", nullable: false),
                    AllowedHoursNotSchoolWeek = table.Column<int>(type: "int", nullable: false),
                    AllowedHours4Weeks = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAORegulations", x => x.Age);
                });

            migrationBuilder.InsertData(
                table: "CAORegulations",
                columns: new[] { "Age", "AllowedHours4Weeks", "AllowedHoursNotSchoolDay", "AllowedHoursNotSchoolWeek", "AllowedHoursSchoolDay", "AllowedHoursSchoolWeek" },
                values: new object[,]
                {
                    { 13, 140, 7, 35, 2, 12 },
                    { 15, 160, 8, 40, 2, 12 },
                    { 16, 160, 9, 45, 9, 45 }
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Kassa",
                column: "MinimumAge",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Vers",
                column: "MinimumAge",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "VKK",
                column: "MinimumAge",
                value: 13);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAORegulations");

            migrationBuilder.DropColumn(
                name: "MinimumAge",
                table: "Departments");
        }
    }
}
