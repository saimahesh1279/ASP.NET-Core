using EntityFrameWorkCore.Data;
using EntityFrameWorkCore.Domain;
using EntityFrameWorkCore.Domain.models;
using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Linq;

namespace EntityFrameWorkCore.ConsoleApp
{ 
    class Program
    {
        private static readonly FootballLeageDbContext context = new FootballLeageDbContext();
        static async Task Main(string[] args)
        {
            //await context.Leagues.AddAsync(new League { Name = "English Premiere league" });
            //await context.SaveChangesAsync();



            //var league = new League { Name = "series A" };
            //await context.Leagues.AddAsync(league);
            //await context.SaveChangesAsync();

            //await AddNewLeague();
            ////await AddNewLeagueWithTeams();


            //await AddTeamWithLeague(league);
            //await context.SaveChangesAsync();




            //await simpleSelectQuery();

            //await QueryFilters();
            //await AdditionalExecutionMethods();
            //await AlternativeLinqSyntax();

            //await UpdateRecord();
            //await SimpleUpdateLeagueRecord();

            //await SimpleDelete();
            //await DeleteWithRelationshiop();

            //await TrackingVsNoTracking();
            //AddNewMatches();
            //await addNewCoaches();
            //await QueryRelatedRecords();

            //await SelectOneProperty();
            //await AnonimousProjection();
            //await StronglyTypedProjection();

            //await FilteringWithRelatedData();

            //await QueryView();

            //await RawSqlQueries();

            //await ExecuteNonQueryCommand();


            Console.WriteLine("Press any key to End....");
            Console.ReadKey();
        }

        //async static Task ExecuteNonQueryCommand()
        //{
        //    var teamId = 2;
        //        var affectedRows = await context.Database.ExecuteSqlRawAsync("exec sp_DeleteTeamId{0}", teamId);

        //    var teamId2 = 3;
        //        var affectedRows2 = await context.Database.ExecuteSqlRawAsync($"exec sp_DeleteTeamId{teamId2}");
        //}



        //async static Task RawSqlQueries()
        //{
        //    var team1 = await context.Teams.FromSqlRaw("SELECT * FROM Teams ").ToListAsync();
           
        //}








        //async static Task QueryView()
        //{
        //    var details = await context.TeamsCoachesLeagues.ToListAsync();
        //    //foreach (var team in teams)
        //    //{
        //    //    Console.WriteLine($"{team.Name} - {team.CoachName} - {team.LeagueName}");
        //    //}
        //}




        private static async Task FilteringWithRelatedData()
        {
            var l = await context.Leagues.Where(q => q.Teams.Any(x => x.Name.Contains("mah"))).ToListAsync();
        }


        //private static async Task StronglyTypedProjection()
        //{
        //    var teams = await context.Teams.Include(q => q.Coach).Include(q=>q.League).Select(
        //        q =>
        //        new TeamDetails
        //        { 
        //            Name = q.Name,
        //            CoachName = q.Coach.Name,
        //            LeagueName= q.League.Name
        //        }
        //        ).ToListAsync();
        //}









        //private static async Task AnonimousProjection()
        //{

        //    var teams = await context.Teams.Include(q=>q.Coach).Select(q =>new { TeamName = q.Name,CoachName= q.Coach.Name }).ToListAsync();
        //    foreach (var team in teams)
        //    {
        //        Console.WriteLine($"{team.TeamName} - {team.CoachName}");
        //    }
        //}





        //private static async Task SelectOneProperty()
        //{
        //    var teams = await context.Teams.Select(q => q.Name).ToListAsync();

        //    foreach(var team in teams)
        //    {
        //        Console.WriteLine($"{team}");
        //    }
        //}










        //private static async Task QueryRelatedRecords()
        //{
        //    // Get Many Related records from League and Teams
        //    var leagues = await context.Leagues.Include(q => q.Teams).ToListAsync();

        //    // get one Related record from Team and Coach
        //    var Team = await context.Teams.Include(q => q.Coach).FirstOrDefaultAsync(q => q.Id == 3);

        //    //Get GrandChildren Related data from Team- maches--> home away Teams
        //    var TeamsWithMachesAndOpponents = await context.Teams
        //                                      .Include(q => q.AwayMatches).ThenInclude(q => q.HomeTeam)
        //                                      .Include(q => q.HomeMatches).ThenInclude(q => q.AwayTeam)
        //                                      .FirstOrDefaultAsync(q => q.Id == 1);

        //    //get Includes with filters
        //    var Teams = await context.Teams
        //               .Where(q => q.HomeMatches == null)
        //               .Include(q => q.Coach)
        //               .ToListAsync();

        //    foreach(var team in Teams)
        //    {
        //        Console.WriteLine($"{team.Id} - {team.Name} - {team.HomeMatches} -{team.AwayMatches} ");
        //    }

        //}


        //private static async Task addNewCoaches()
        //{
        //    var coach01 = new Coach { Name = "susheel", TeamId = 3 };
        //    await context.AddAsync(coach01);

        //    var coach02 = new Coach { Name = "CHakri" };
        //    await context.AddAsync(coach02);
        //    await context.SaveChangesAsync();
        //}



        //private static async Task TrackingVsNoTracking()
        //{
        //    var withTracking = await context.Teams.FirstOrDefaultAsync(q => q.Id == 2);
        //    var withNoTracking = await context.Teams.AsNoTracking().FirstOrDefaultAsync(q => q.Id == 3);

        //    withTracking.Name = "Inter Milan";
        //    withNoTracking.Name = "Rivoli United";

        //    var entriesBeforeSave = context.ChangeTracker.Entries();

        //    Console.WriteLine(entriesBeforeSave);

        //    await context.SaveChangesAsync();

        //    var entriesAfterSave = context.ChangeTracker.Entries();

        //    Console.WriteLine("---------------------------",entriesBeforeSave);

        //}

        //we use CASCADE for Relational DELETEEEEEEEEE..........
        //private static async Task DeleteWithRelationshiop()
        //{
        //    var league = await context.Leagues.FindAsync(5);
        //    context.Leagues.Remove(league);
        //    await context.SaveChangesAsync();
        //}

        //private static async Task SimpleDelete()
        //{
        //    var league = await context.Leagues.FindAsync(4);
        //    context.Leagues.Remove(league);
        //    await context.SaveChangesAsync();
        //}

        //private static async Task GetRecords()
        //{
        //    var league = await context.Leagues.FindAsync(3);
        //    Console.WriteLine($"{league.Id} - {league.Name}");
        //}
        //private static async Task SimpleUpdateLeagueRecord()
        //{


        //    var team = new Team
        //    {
        //        Id = 7,
        //        Name = "Scottish Premiership",
        //        LeagueId = 2
        //    };
        //    context.Teams.Update(team);
        //    //////Retrieve Record
        //    //var league = await context.Leagues.FindAsync(20);
        //    /////Make Record Changes
        //    //league.Name = "Scottish Premiership";
        //    /////Save Changes
        //    await context.SaveChangesAsync();

        //    await GetRecords();

        //}



        //private static async Task UpdateRecord()
        //{
        //    //Retrieve Record
        //    var league = await context.Leagues.FindAsync(3);
        //    //Make Record Changes
        //    league.Name = "SRH";
        //    //Save Changes
        //    await context.SaveChangesAsync();

        //    await GetRecords();
        //}




        //static async Task AlternativeLinqSyntax()
        //{
        //    Console.WriteLine("enter team name or part of team Name: ");
        //    var TeamName = Console.ReadLine();
        //    var teams = await (from i in context.Teams
        //                       where EF.Functions.Like(i.Name, $"%{TeamName}%")
        //                       select i).ToListAsync();
        //    foreach(var team in teams)
        //    {
        //        Console.WriteLine($"{team.Id} - {team.Name}");
        //    }
        //}




        //static async Task AdditionalExecutionMethods()
        //{
        //    //var l = await context.Leagues.FirstOrDefaultAsync(q => q.Name.Contains("A"));
        //    var leagues = context.Leagues;
        //    var List = await leagues.ToListAsync();
        //    var first = await leagues.FirstAsync();
        //    var firstofDefault = await leagues.FirstOrDefaultAsync();
        //    var single = await leagues.SingleAsync();
        //    var singleorDefault = await leagues.SingleOrDefaultAsync();

        //    var count = await leagues.CountAsync();
        //    var longCount = await leagues.LongCountAsync();
        //    var min = await leagues.MinAsync();
        //    var max = await leagues.MaxAsync();

        //    var find = await leagues.FindAsync(1);
        //    Console.WriteLine($"1.{List} 2.{first} 3.{firstofDefault} 4.{single} 5.{singleorDefault} 3.{firstofDefault}")
        //}


        //static async Task QueryFilters()
        //{
        //    Console.WriteLine("Enter League Name: ");
        //    //var LeagueName = Console.ReadLine();
        //    //var leagues = await context.Leagues.Where(q => q.Name.Equals(LeagueName)).ToListAsync();
        //    //foreach (var league in leagues)
        //    //{
        //    //    Console.WriteLine($"{league.Id} - {league.Name}");
        //    //}


        //    var partialLeagueName = Console.ReadLine();
        //    //var partialleagues = await context.Leagues.Where(q => q.Name.Contains(partialLeagueName)).ToListAsync();
        //    //like in EfCore it accepts 2 parameters , 2nd one should be only in string****
        //    var partialLeague = await context.Leagues.Where(q => EF.Functions.Like(q.Name, $"{partialLeagueName}")).ToListAsync();
        //    foreach (var league in partialLeague)
        //    {
        //        Console.WriteLine($"{league.Id} - {league.Name}");
        //    }
        //}

        //static async Task simpleSelectQuery()
        //{
        //    var leagues = await context.Leagues.ToListAsync();

        //    foreach (var league in leagues)
        //    {
        //        Console.WriteLine($"{league.Id} - {league.Name}");
        //    }
        //}

        //static async Task AddNewLeague()
        //{
        //    //// Adding a new League Object
        //    var league = new League { Name = "Audit Testing League" };
        //    await context.Leagues.AddAsync(league);
        //    await context.SaveChangesAsync("Test Audit Create User");

        //    //// Function To add new teams related to the new league object. 
        //    await AddTeamsWithLeague(league);
        //    await context.SaveChangesAsync();

        //}

        ////static async Task AddNewLeagueWithTeams()
        ////{
        ////    var teams = new List<Team> { 
        ////        new Team 
        ////        { 
        ////            Name = "Rivoli United"
        ////        },
        ////        new Team
        ////        {
        ////            Name = "Waterhouse FC"
        ////        },
        ////    };
        ////    var league = new League { Name = "CIFA", Teams = teams };
        ////    await context.AddAsync(league);
        ////    await context.SaveChangesAsync();
        ////}

    }
}