using Microsoft.EntityFrameworkCore.Migrations;

namespace rollBack.Migrations
{
    public partial class removelastName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lastname",
                table: "Employees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
