using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoFrame01.Migrations
{
    /// <inheritdoc />
    public partial class ManyToManyRS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Dep_id",
                table: "students");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "students");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "students");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "EmployeeName");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "stud_ID",
                table: "Stud_Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "instructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeName",
                table: "Employees",
                type: "varchar(50)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_Country",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmpAddress_Street",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EmpDeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "inst_ID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses",
                columns: new[] { "stud_ID", "Course_ID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts",
                columns: new[] { "inst_ID", "Course_ID" });

            migrationBuilder.CreateTable(
                name: "coursses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coursses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Dep_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_students_departments_Id",
                        column: x => x.Id,
                        principalTable: "departments",
                        principalColumn: "DepId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoursseStudent",
                columns: table => new
                {
                    CourseesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursseStudent", x => new { x.CourseesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CoursseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursseStudent_coursses_CourseesId",
                        column: x => x.CourseesId,
                        principalTable: "coursses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmpDeptId",
                table: "Employees",
                column: "EmpDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_courses_Top_ID",
                table: "courses",
                column: "Top_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_Course_ID",
                table: "Course_Insts",
                column: "Course_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CoursseStudent_StudentsId",
                table: "CoursseStudent",
                column: "StudentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_courses_Course_ID",
                table: "Course_Insts",
                column: "Course_ID",
                principalTable: "courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_instructors_inst_ID",
                table: "Course_Insts",
                column: "inst_ID",
                principalTable: "instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_courses_topics_Top_ID",
                table: "courses",
                column: "Top_ID",
                principalTable: "topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_departments_EmpDeptId",
                table: "Employees",
                column: "EmpDeptId",
                principalTable: "departments",
                principalColumn: "DepId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_instructors_departments_ID",
                table: "instructors",
                column: "ID",
                principalTable: "departments",
                principalColumn: "DepId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_courses_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID",
                principalTable: "courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_students_stud_ID",
                table: "Stud_Courses",
                column: "stud_ID",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_courses_Course_ID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_instructors_inst_ID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_courses_topics_Top_ID",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_departments_EmpDeptId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_instructors_departments_ID",
                table: "instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_courses_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_students_stud_ID",
                table: "Stud_Courses");

            migrationBuilder.DropTable(
                name: "CoursseStudent");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "coursses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmpDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_courses_Top_ID",
                table: "courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_Course_ID",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "EmpAddress_City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpAddress_Country",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpAddress_Street",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmpDeptId",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "students");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employees",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dep_id",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "stud_ID",
                table: "Stud_Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "instructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "inst_ID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stud_Courses",
                table: "Stud_Courses",
                column: "stud_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Insts",
                table: "Course_Insts",
                column: "inst_ID");
        }
    }
}
