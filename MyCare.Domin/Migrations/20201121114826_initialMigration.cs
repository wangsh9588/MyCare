using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCare.Domin.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MyCare");

            migrationBuilder.CreateTable(
                name: "People",
                schema: "MyCare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                schema: "MyCare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                schema: "MyCare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Venue_Id = table.Column<int>(type: "int", nullable: true),
                    People_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_People_People_Id",
                        column: x => x.People_Id,
                        principalSchema: "MyCare",
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_Venue_Venue_Id",
                        column: x => x.Venue_Id,
                        principalSchema: "MyCare",
                        principalTable: "Venue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Timesheet",
                schema: "MyCare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Task_Id = table.Column<int>(type: "int", nullable: true),
                    People_Id = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timesheet_People_People_Id",
                        column: x => x.People_Id,
                        principalSchema: "MyCare",
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Timesheet_Task_Task_Id",
                        column: x => x.Task_Id,
                        principalSchema: "MyCare",
                        principalTable: "Task",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Task_People_Id",
                schema: "MyCare",
                table: "Task",
                column: "People_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Task_Venue_Id",
                schema: "MyCare",
                table: "Task",
                column: "Venue_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheet_People_Id",
                schema: "MyCare",
                table: "Timesheet",
                column: "People_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Timesheet_Task_Id",
                schema: "MyCare",
                table: "Timesheet",
                column: "Task_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Timesheet",
                schema: "MyCare");

            migrationBuilder.DropTable(
                name: "Task",
                schema: "MyCare");

            migrationBuilder.DropTable(
                name: "People",
                schema: "MyCare");

            migrationBuilder.DropTable(
                name: "Venue",
                schema: "MyCare");
        }
    }
}
