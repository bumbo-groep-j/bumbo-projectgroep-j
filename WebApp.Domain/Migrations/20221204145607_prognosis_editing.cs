using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class prognosisediting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PredictionValueName",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShouldEstimateValue",
                table: "DataSets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "DataSets",
                keyColumn: "DepartmentName",
                keyValue: "Kassa",
                column: "ShouldEstimateValue",
                value: true);

            migrationBuilder.UpdateData(
                table: "DataSets",
                keyColumn: "DepartmentName",
                keyValue: "Vers",
                column: "ShouldEstimateValue",
                value: false);

            migrationBuilder.UpdateData(
                table: "DataSets",
                keyColumn: "DepartmentName",
                keyValue: "VKK",
                column: "ShouldEstimateValue",
                value: false);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Kassa",
                column: "PredictionValueName",
                value: "Bezoekers");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "Vers",
                column: "PredictionValueName",
                value: "Colli");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Name",
                keyValue: "VKK",
                column: "PredictionValueName",
                value: "Colli");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PredictionValueName",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "ShouldEstimateValue",
                table: "DataSets");
        }
    }
}
