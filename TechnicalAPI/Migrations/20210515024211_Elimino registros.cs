using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalAPI.Migrations
{
    public partial class Eliminoregistros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [User]", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
