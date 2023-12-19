using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatedBaseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "LeaveTypes",
                newName: "DateMofified");

            migrationBuilder.RenameColumn(
                name: "Employeeid",
                table: "LeaveAllocations",
                newName: "EmployeeId");

            migrationBuilder.RenameColumn(
                name: "DateModified",
                table: "LeaveAllocations",
                newName: "DateMofified");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateMofified",
                table: "LeaveTypes",
                newName: "DateModified");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "LeaveAllocations",
                newName: "Employeeid");

            migrationBuilder.RenameColumn(
                name: "DateMofified",
                table: "LeaveAllocations",
                newName: "DateModified");
        }
    }
}
