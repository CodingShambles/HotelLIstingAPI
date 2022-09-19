using Microsoft.EntityFrameworkCore;

namespace HotelLIsting_API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet <Hotel> Hotels { get; set; }
        public DbSet <Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Brasil",
                    ShortName = "BR"
                },
                new Country
                {
                    Id = 2,
                    Name = "Switzerland",
                    ShortName = "CH"
                },
                new Country
                {
                    Id = 3,
                    Name = "United States",
                    ShortName = "US"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Castro's Palace Hotel",
                    Address = "Goiânia",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel { 
                    Id = 2,
                    Name = "Gasthaus Brünig Kulm",
                    Address = "Brünigstrasse",
                    CountryId = 2,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Luxor Hotel",
                    Address = "Las Vegas",
                    CountryId = 3,
                    Rating = 4.2
                }
            );
        }
    }
}