// <auto-generated />
using HotelLIsting_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HotelLIsting_API.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    [Migration("20220919052620_SeededCountriesAndHotels")]
    partial class SeededCountriesAndHotels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HotelLIsting_API.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Brasil",
                            ShortName = "BR"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Switzerland",
                            ShortName = "CH"
                        },
                        new
                        {
                            Id = 3,
                            Name = "United States",
                            ShortName = "US"
                        });
                });

            modelBuilder.Entity("HotelLIsting_API.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Goiânia",
                            CountryId = 1,
                            Name = "Castro's Palace Hotel",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 2,
                            Address = "Brünigstrasse",
                            CountryId = 2,
                            Name = "Gasthaus Brünig Kulm",
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            Id = 3,
                            Address = "Las Vegas",
                            CountryId = 3,
                            Name = "Luxor Hotel",
                            Rating = 4.2000000000000002
                        });
                });

            modelBuilder.Entity("HotelLIsting_API.Data.Hotel", b =>
                {
                    b.HasOne("HotelLIsting_API.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelLIsting_API.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
