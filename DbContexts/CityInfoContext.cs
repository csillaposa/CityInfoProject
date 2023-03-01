using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.DbContexts
{
    public class CityInfoContext : DbContext
    {
        // null forgiving operator to surpress all nullable warnings
        public DbSet<City> Cities { get; set; } = null!;
        public DbSet<PointOfInterest> PointsOfInterest { get; set; } = null!;

        // we need DbContext to know where to find the database
        // one way to do it:
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}

        // the other way:
        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            : base(options)
        {

        }

        // seeding the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasData(
                new City("New York City")
                {
                    Id = 1,
                    Description = "The one with the big park."
                },
                new City("Antwerp")
                {
                    Id = 2,
                    Description = "The one with the cathedral that was never really finished."
                },
                new City("Copenhagen")
                {
                    Id = 3,
                    Description = "The one with the Little Mermaid."
                });

            modelBuilder.Entity<PointOfInterest>()
                .HasData(
                new PointOfInterest("Central Park")
                {
                    Id = 1,
                    CityId = 1,
                    Description = "The most visited urban park in the US."
                },
                new PointOfInterest("Empire State Building")
                {
                    Id = 2,
                    CityId = 1,
                    Description = "A 102-story skyscraper located in Midtown Manhattan."
                },
                new PointOfInterest("Cathedral of Our Lady")
                {
                    Id = 3,
                    CityId = 2,
                    Description = "A gothic style cathedral"
                },
                new PointOfInterest("Antwerp Central Station")
                {
                    Id = 4,
                    CityId = 2,
                    Description = "The finest exampe of railway architecture in Belgium."
                },
                new PointOfInterest("The Little Mermaid")
                {
                    Id = 5,
                    CityId = 3,
                    Description = "Small bronze statue gazing out to sea has been one of Copenhagen's top tourist attractions."
                },
                new PointOfInterest("Tivoli")
                {
                    Id = 6,
                    CityId = 3,
                    Description = "Tivoli Gardens, also known simply as Tivoli, is an amusement park and pleasure garden."
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
