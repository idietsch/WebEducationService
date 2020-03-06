using Microsoft.EntityFrameworkCore.Migrations;

namespace WebEducationService.Migrations
{
    public partial class blarghh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Major",
                table: "Student");

            migrationBuilder.AddColumn<int>(
                name: "MajorId",
                table: "Student",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_MajorId",
                table: "Student",
                column: "MajorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Majors_MajorId",
                table: "Student",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Majors_MajorId",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_MajorId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "MajorId",
                table: "Student");

            migrationBuilder.AddColumn<string>(
                name: "Major",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
