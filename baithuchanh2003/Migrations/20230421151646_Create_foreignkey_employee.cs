using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace baithuchanh2003.Migrations
{
    /// <inheritdoc />
    public partial class Create_foreignkey_employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacultyID",
                table: "Employees",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FacultyID",
                table: "Employees",
                column: "FacultyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Facultys_FacultyID",
                table: "Employees",
                column: "FacultyID",
                principalTable: "Facultys",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Facultys_FacultyID",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_FacultyID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FacultyID",
                table: "Employees");
        }
    }
}
