using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWorkCore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingTeamDetailsViewAndEarlyMatchFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE FUNCTION [dbo].[GetEarlyMatches](@teamId int)
                                  RETURNS datetime
                                  BEGIN
                                       DECLARE @result datetime
                                       SELECT TOP 1 @result = date
                                        FROM [dbo].[Matches]
                                        ORDER By Date
                                          RETURN @result
                                         END");
            migrationBuilder.Sql(@"CREATE VIEW [dbo].[TeamsCoachesLeagues]
                                  AS
                                  SELECT t.Name AS TeamName, c.Name AS CoachName, l.Name AS LeagueName
                                  FROM [dbo].[Teams] AS t LEFT OUTER JOIN
                                    [dbo].[Coaches] AS c ON t.Id = c.TeamId INNER JOIN
                                    [dbo].[Leagues] AS l ON t.LeagueId = l.Id");
                                       
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW [dbo].[TeamsCoachesLeagues]");
            migrationBuilder.Sql(@"DROP FUNCTION [dbo].[GetEarlyMatches]");
        }
    }
}
