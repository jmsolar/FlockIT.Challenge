using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalAPI.Migrations
{
    public partial class ActualizaciondeSPparaobtenerusuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetUserByFilter]
                        @username varchar(100), @email varchar(50) AS
                        BEGIN
                            SELECT Id, username, email
                            FROM [dbo].[User]
	                        WHERE username = @username AND email = @email
                        END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var sp = @"DROP PROCEDURE [dbo].[GetUserByFilter]";

            migrationBuilder.Sql(sp);
        }
    }
}
