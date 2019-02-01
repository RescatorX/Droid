using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

using DroidWeb.Data.Entities;

namespace DroidWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Module> Modules { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Module>().ToTable("Module");
            modelBuilder.Entity<Position>().ToTable("Position");
            modelBuilder.Entity<Vehicle>().ToTable("Vehicle");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseLoggerFactory(new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) }))
                .UseMySQL(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, providerOptions => providerOptions.CommandTimeout(60))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
        }
/*
        public async Task SeedDatabase()
        {
            Path currentPath = null;
            try
            {
                currentPath = new Path() { Name = "Plesná - Bukovinka" };
                this.Paths.Add(currentPath);

                await this.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("PrefillDatabase - Paths table prefill error: " + e.Message, e);
            }

            try
            {
                this.WayPoints.Add(new WayPoint() { Name = "Plesná", Order = 1, Latitude = 3.14, Longitude = 51.5, Altitude = 0.4, Path = currentPath });
                this.WayPoints.Add(new WayPoint() { Name = "Plzeň", Order = 2, Latitude = 3.24, Longitude = 51.3, Altitude = 0.2, Path = currentPath });
                this.WayPoints.Add(new WayPoint() { Name = "Praha", Order = 3, Latitude = 3.34, Longitude = 51.5, Altitude = 0.1, Path = currentPath });
                this.WayPoints.Add(new WayPoint() { Name = "Brno", Order = 4, Latitude = 3.44, Longitude = 51.4, Altitude = 0.1, Path = currentPath });
                this.WayPoints.Add(new WayPoint() { Name = "Bukovinka", Order = 5, Latitude = 3.54, Longitude = 51.5, Altitude = 0.5, Path = currentPath });

                await this.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("PrefillDatabase - WayPoints table prefill error: " + e.Message, e);
            }

            try
            {
                this.Movements.Add(new Movement() { Path = currentPath, StartTime = DateTime.Now });

                await this.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("PrefillDatabase - Movements table prefill error: " + e.Message, e);
            }
        }
*/
    }
}
