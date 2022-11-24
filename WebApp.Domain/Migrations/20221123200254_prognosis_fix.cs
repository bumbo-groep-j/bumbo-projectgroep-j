using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Domain.Migrations
{
    /// <inheritdoc />
    public partial class prognosisfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalColli",
                table: "Prognosis");

            migrationBuilder.RenameColumn(
                name: "TotalCustomers",
                table: "Prognosis",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Prognosis",
                newName: "DepartmentName");

            migrationBuilder.CreateIndex(
                name: "IX_DataPoints_DepartmentName",
                table: "DataPoints",
                column: "DepartmentName");

            migrationBuilder.AddForeignKey(
                name: "FK_DataPoints_DataSets_DepartmentName",
                table: "DataPoints",
                column: "DepartmentName",
                principalTable: "DataSets",
                principalColumn: "DepartmentName",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataPoints_DataSets_DepartmentName",
                table: "DataPoints");

            migrationBuilder.DropIndex(
                name: "IX_DataPoints_DepartmentName",
                table: "DataPoints");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "Prognosis",
                newName: "TotalCustomers");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "Prognosis",
                newName: "Department");

            migrationBuilder.AddColumn<int>(
                name: "TotalColli",
                table: "Prognosis",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
