using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Holidays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CAOBonuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidSince = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HolidayBonus = table.Column<double>(type: "float", nullable: false),
                    SundayBonus = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAOBonuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicHolidays",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicHolidays", x => x.Date);
                });

            migrationBuilder.InsertData(
                table: "CAOBonuses",
                columns: new[] { "Id", "HolidayBonus", "SundayBonus", "ValidSince" },
                values: new object[] { 1, 1.0, 0.5, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "PublicHolidays",
                column: "Date",
                values: new object[]
                {
                    new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                    new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CAOBonuses");

            migrationBuilder.DropTable(
                name: "PublicHolidays");
        }
    }
}
