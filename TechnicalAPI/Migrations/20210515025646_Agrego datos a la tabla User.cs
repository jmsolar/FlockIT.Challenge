using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalAPI.Migrations
{
    public partial class AgregodatosalatablaUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "password", "username" },
                values: new object[,]
                {
                    { new Guid("0a1296e8-f3cb-4728-a2a8-f47bb2933ac7"), "juan123", "Juan" },
                    { new Guid("2a1d5df9-6325-4db0-bd33-3a3df38f8e1b"), "lucrecia123", "Lucrecia" },
                    { new Guid("71a05a97-34a0-4ad1-aad4-dd73b3b068f5"), "maria123", "Maria" },
                    { new Guid("d619e12e-f715-4685-9740-b31b2db56f8f"), "esteban123", "Esteban" },
                    { new Guid("abc7dad4-c05b-4570-a648-ad4a36693366"), "pilar123", "Pilar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
