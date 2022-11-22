using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NguyenDuyenCuongBTH3.Migrations
{
    public partial class Create_Foreignkey_Student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FacultyID",
                table: "Student",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FacultyID",
                table: "Student",
                column: "FacultyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Faculty_FacultyID",
                table: "Student",
                column: "FacultyID",
                principalTable: "Faculty",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Faculty_FacultyID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_FacultyID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "FacultyID",
                table: "Student");
        }
    }
}
