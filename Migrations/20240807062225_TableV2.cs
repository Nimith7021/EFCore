using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class TableV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "workstattions",
                columns: table => new
                {
                    WorkStationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WSCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workstattions", x => x.WorkStationId);
                    table.ForeignKey(
                        name: "FK_workstattions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_workstattions_EmployeeId",
                table: "workstattions",
                column: "EmployeeId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "workstattions");
        }
    }
}
