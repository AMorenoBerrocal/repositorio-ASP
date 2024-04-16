using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContents
{
    public class CityInfoContext : DbContext 
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointOfInterests { get; set; }

        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().
                HasData(
                    new City("New York City")
                    {
                        Id = 1,
                        Description = "The one with that big park."
                    },
                    new City("Antwerp")
                    {
                        Id = 2,
                        Description = "The one with that big nose."
                    }, 
                    new City("Paris")
                    {
                        Id = 3,
                        Description = "The one with that big tower."
                    }
                );
            modelBuilder.Entity<PointOfInterest>().
                HasData(
                    new PointOfInterest("Central park")
                    {
                        Id = 1,
                        CityId = 1,
                        Description = "The one with that big park."
                    },
                    new PointOfInterest("Cathedral")
                    {
                        Id = 2,
                        CityId = 1,
                        Description = "The one with that big nose."
                    },
                    new PointOfInterest("Parque de patos")
                    {
                        Id = 3,
                        CityId = 2,
                        Description = "The one with that big tower."
                    }
                );
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if(!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlite("Data Source = CityInfo.db");
        //    }
        //}
    }
}
