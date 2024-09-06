﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Instructors",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Dept_Id",
                table: "Students",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Courses_CourseId",
                table: "Student_Courses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_Id",
                table: "Instructors",
                column: "Dept_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                unique: true,
                filter: "[Ins_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses",
                column: "Top_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Instructors_Ins_Id",
                table: "Course_Instructors",
                column: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructors_Courses_Course_Id",
                table: "Course_Instructors",
                column: "Course_Id",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructors_Instructors_Ins_Id",
                table: "Course_Instructors",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_Top_Id",
                table: "Courses",
                column: "Top_Id",
                principalTable: "Topics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments",
                column: "Ins_Id",
                principalTable: "Instructors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Courses_Courses_CourseId",
                table: "Student_Courses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Courses_Students_StudentId",
                table: "Student_Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_Dept_Id",
                table: "Students",
                column: "Dept_Id",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructors_Courses_Course_Id",
                table: "Course_Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructors_Instructors_Ins_Id",
                table: "Course_Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_Top_Id",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_Id",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_Id",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Courses_Courses_CourseId",
                table: "Student_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Courses_Students_StudentId",
                table: "Student_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_Dept_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Dept_Id",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Student_Courses_CourseId",
                table: "Student_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_Dept_Id",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_Id",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_Id",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_Instructors_Ins_Id",
                table: "Course_Instructors");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Instructors",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");
        }
    }
}
