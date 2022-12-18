using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentPortal.Database.Migrations
{
    public partial class associationRelationWithCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentE_modelId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DepartmentE_modelId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DepartmentE_modelId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Departments_DepartmentId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_DepartmentId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentE_modelId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DepartmentE_modelId",
                table: "Courses",
                column: "DepartmentE_modelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DepartmentE_modelId",
                table: "Courses",
                column: "DepartmentE_modelId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
