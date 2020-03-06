using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEducationService.Migrations
{
    public partial class detailsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Major",
                table: "Student");

            migrationBuilder.AddColumn<float>(
                name: "GPA",
                table: "Student",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "MajorID",
                table: "Student",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SAT",
                table: "Student",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GPA",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "MajorID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "SAT",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
