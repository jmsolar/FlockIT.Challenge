using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalAPI.Migrations
{
    public partial class ModificomodelodedatosdeUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "User",
                nullable: false);
            migrationBuilder.DropColumn(
                name: "email",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
