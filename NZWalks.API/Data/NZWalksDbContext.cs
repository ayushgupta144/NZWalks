using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for difficulties
            // Easy, medium, hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty() 
                {
                    Id = Guid.Parse("551729f4-2d1c-4853-9d33-7cdb3bb2f8c8"),
                    Name="Easy" 
                },
                new Difficulty()
                {
                    Id = Guid.Parse("a14bb17f-e16e-44af-93fe-20693e217ee8"),
                    Name="Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("56185277-278e-4634-a1b2-ef0903e37b00"),
                    Name="Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>()
            {
                new Region() 
                {
                    Id = Guid.Parse("d92147a8-2164-495c-a03d-d7d018e4e713"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/13268478/pexels-photo-13268478.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region()
                {
                    Id = Guid.Parse("d21302b4-9682-4c14-bb98-bfc4e5c83ac8"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = "https://images.pexels.com/photos/13268478/pexels-photo-13268478.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                 new Region()
                {
                    Id = Guid.Parse("f43d6735-0707-48d3-afa9-5c561fa199c7"),
                    Name = "Bay of Plenty",
                    Code = "BOP",
                    RegionImageUrl = "https://images.pexels.com/photos/13268478/pexels-photo-13268478.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                  new Region
                {
                    Id = Guid.Parse("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
