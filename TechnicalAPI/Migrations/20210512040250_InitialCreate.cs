using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "email", "username" },
                values: new object[,]
                {
                    { new Guid("c87b48b6-0b13-4093-b188-9d3f4855416a"), "juan@juan.com", "Juan" },
                    { new Guid("d2b05267-837d-4f70-b3f7-5ef878581202"), "lucrecia@lucrecia.com", "Lucrecia" },
                    { new Guid("a460de80-0626-4ede-9124-3a5c1291e8d1"), "maria@maria.com", "Maria" },
                    { new Guid("94b38084-71bb-463c-9415-03a90d17aaa8"), "esteban@esteban.com", "Esteban" },
                    { new Guid("e9c36979-8fc4-4827-a60d-eadbb1d8ffb1"), "pilar@pilar.com", "Pilar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
