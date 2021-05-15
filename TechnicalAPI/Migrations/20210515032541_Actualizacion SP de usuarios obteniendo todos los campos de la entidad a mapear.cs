using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnicalAPI.Migrations
{
    public partial class ActualizacionSPdeusuariosobteniendotodosloscamposdelaentidadamapear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var spOld = @"DROP PROCEDURE [dbo].[GetUserByFilter]";

            migrationBuilder.Sql(spOld);

            var sp = @"CREATE PROCEDURE [dbo].[GetUserByFilter]
                        @username varchar(100), @password varchar(50) AS
                        BEGIN
                            SELECT Id, username, password
                            FROM [dbo].[User]
	                        WHERE username = @username AND password = @password
                        END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        }
    }
}
