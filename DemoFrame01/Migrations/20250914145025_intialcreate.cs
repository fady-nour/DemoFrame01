using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoFrame01.Migrations
{
    /// <inheritdoc />
    public partial class intialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HiringDate",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "departments");

            migrationBuilder.RenameColumn(
                name: "Ins_ID",
                table: "departments",
                newName: "ManagerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "departments",
                newName: "DepId");

            migrationBuilder.AddColumn<string>(
                name: "DepName",
                table: "departments",
                type: "varchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    SSN = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.SSN);
                });

            migrationBuilder.CreateIndex(
                name: "IX_departments_ManagerId",
                table: "departments",
                column: "ManagerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_Employees_ManagerId",
                table: "departments",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_Employees_ManagerId",
                table: "departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_departments_ManagerId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "DepName",
                table: "departments");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "departments",
                newName: "Ins_ID");

            migrationBuilder.RenameColumn(
                name: "DepId",
                table: "departments",
                newName: "ID");

            migrationBuilder.AddColumn<DateTime>(
                name: "HiringDate",
                table: "departments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "departments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
