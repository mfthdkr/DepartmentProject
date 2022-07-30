using Microsoft.EntityFrameworkCore.Migrations;

namespace DepartmentProject.Migrations
{
    public partial class DetailPropertyToDepartmentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "Departments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detail",
                table: "Departments");
        }
    }
}
