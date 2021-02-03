using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDoUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoUsers", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "ToDoItems",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ItemCompleted = table.Column<bool>(type: "bit", nullable: false),
                    ToDoUsersDAL = table.Column<int>(type: "int", nullable: false),
                    ToDoUsersDALUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoItems", x => x.ItemID);
                    table.ForeignKey(
                        name: "FK_ToDoItems_ToDoUsers_ToDoUsersDALUserID",
                        column: x => x.ToDoUsersDALUserID,
                        principalTable: "ToDoUsers",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDoItems_ToDoUsersDALUserID",
                table: "ToDoItems",
                column: "ToDoUsersDALUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoItems");

            migrationBuilder.DropTable(
                name: "ToDoUsers");
        }
    }
}
