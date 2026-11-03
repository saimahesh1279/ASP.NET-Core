using EntityFrameWorkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkCore.Data;

public class FootballLeageDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=FootballLeage_EfCore")
        .LogTo(Console.WriteLine, [DbLoggerCategory.Database.Command.Name], LogLevel.Information)
        .EnableSensitiveDataLogging();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Team>()
       .HasMany(m => m.HomeMatches)
       .WithOne(m => m.HomeTeam)
       .HasForeignKey(m => m.HomeTeamId)
       .IsRequired()
       .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Team>()
            .HasMany(m => m.AwayMatches)
            .WithOne(m => m.AwayTeam)
            .HasForeignKey(m => m.AwayTeamId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Team>()
            .HasOne(t => t.Coach)
            .WithOne(c => c.Team)
            .HasForeignKey<Coach>(c => c.TeamId);

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TeamsCoachesLeaguesView>().HasNoKey().ToView("TeamsCoachesLeagues");
    }



    public DbSet<Team> Teams { get; set; }
    public DbSet<League> Leagues { get; set; }

    public DbSet<Match> Matches { get; set; }
    public DbSet<Coach> Coaches { get; set; }
    public DbSet<TeamsCoachesLeaguesView> TeamsCoachesLeagues { get; set; }


}
