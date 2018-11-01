using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SafariApi.Models;

namespace SafariAPI
{
  public partial class SafariAPIContext : DbContext
  {
    public SafariAPIContext()
    {
    }

    public SafariAPIContext(DbContextOptions<SafariAPIContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        optionsBuilder.UseNpgsql("server=localhost;database=SafariAPI");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<SeenAnimals>().HasData(
        new SeenAnimals { Id = -1, Species = "Springbok", CountOfTimesSeen = 3, LocationOfLastSeen = "Umbrella Acacias" },
        new SeenAnimals { Id = -2, Species = "Spotted Hyena", CountOfTimesSeen = 5, LocationOfLastSeen = "Watering Hole" },
        new SeenAnimals { Id = -3, Species = "Meerkat", CountOfTimesSeen = 6, LocationOfLastSeen = "Rock Outcrop" },
        new SeenAnimals { Id = -4, Species = "Aardvark", CountOfTimesSeen = 1, LocationOfLastSeen = "Termite Mound" },
        new SeenAnimals { Id = -5, Species = "Wildebeest", CountOfTimesSeen = 3, LocationOfLastSeen = "Watering Hole" },
        new SeenAnimals { Id = -6, Species = "African Rock Python", CountOfTimesSeen = 2, LocationOfLastSeen = "Rock Outcrop" },
        new SeenAnimals { Id = -7, Species = "Grant's Gazelle", CountOfTimesSeen = 4, LocationOfLastSeen = "Umbrella Acacias" }
      );
    }

    public DbSet<SeenAnimals> SeenAnimals { get; set; }
  }
}
