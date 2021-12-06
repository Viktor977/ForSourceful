using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    DataStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateRegistration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "in months"),
                    Role = table.Column<int>(type: "int", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "DateRegistration", "Email", "FirstName", "LastName", "Password", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "cobolev@prim.com", "Dmitry", "Cobolev", "qwerty", 1 },
                    { 2, new DateTime(2021, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "gogolev@prim.com", "Semen", "Gogolev", "asdfgh", 1 }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "DataEnd", "DataStart", "Duration", "ManagerId", "ManagerName", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, "Cobolev", "Workdays for the sprin" },
                    { 2, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 2, "Gogolev", "Workdays for the autumn" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateRegistration", "Email", "Experience", "FirstName", "LastName", "ManagerId", "Password", "Role" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 6, 13, 5, 46, 728, DateTimeKind.Local).AddTicks(98), "step@gmail.com", "36 month", "Viktor", "Stepanov", 1, "1111", 0 },
                    { 2, new DateTime(2021, 12, 6, 13, 5, 46, 730, DateTimeKind.Local).AddTicks(5906), "monov@gmail.com", "46 month", "Igor", "Pokimonov", 1, "2222", 0 },
                    { 3, new DateTime(2021, 12, 6, 13, 5, 46, 730, DateTimeKind.Local).AddTicks(5942), "ivan@gmail.com", "12 month", "Ivan", "Pervij", 2, "3333", 0 },
                    { 4, new DateTime(2021, 12, 6, 13, 5, 46, 730, DateTimeKind.Local).AddTicks(5947), "cruz@gmail.com", "28 month", "Tom", "Cruz", 2, "4444", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ManagerId",
                table: "Schedules",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ManagerId",
                table: "Users",
                column: "ManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}
