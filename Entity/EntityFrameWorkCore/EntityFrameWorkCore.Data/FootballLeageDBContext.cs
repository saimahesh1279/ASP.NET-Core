using EntityFrameWorkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Polly;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameWorkCore.Data;

public class FootballLeageDBContext:DbContext
{

    //public FootballLeageDBContext()
    //{
    //    var folder = Environment.SpecialFolder.LocalApplicationData;
    //    var path = Environment.GetFolderPath(folder);
    //    DbPath = Path.Combine(path, "FootballLeage_EfCore.db");

    //    System.Diagnostics.Debug.WriteLine(DbPath);
    //}


    public virtual DbSet<Team> Teams { get; set; }
    public virtual DbSet<Coach> Coaches { get; set; }

    //public virtual DbSet<Audit> Audits { get; set; }
    //public virtual DbSet<Coach> Coaches { get; set; }

    //public virtual DbSet<Team> Teams { get; set; }
    //public virtual DbSet<Coach> Coaches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //UsingSQLServer
        //optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=FootballLeage_EfCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30 ");
        //optionsBuilder.UseSqlite($"Data Source=FootballLeage_EfCore.db");
        optionsBuilder.UseSqlServer("Data Sourse=(localdb)\\MSSQLLocalDB; Initial Catalog=FootballLeage_EfCore; Encrypt=False");
    }
}
