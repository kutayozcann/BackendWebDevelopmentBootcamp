using Microsoft.EntityFrameworkCore;
using CodeFirstBasic.Entities;

namespace CodeFirstBasic.Data;
// DbContext class representing the database context for the application
public class PatikaFirstDbContext : DbContext
{
    public DbSet<MovieEntity> Movies { get; set; }

    public DbSet<GameEntity> Games { get; set; }

    // Configures the database connection settings
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=localhost,1433;Database=PatikaFirstDb1;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<MovieEntity>().HasData(
            new MovieEntity { Id = 1, Genre = "Sci-Fi", Title = "Dune", ReleaseYear = 2021 },
            new MovieEntity { Id = 2, Genre = "Sci-Fi", Title = "Avengers", ReleaseYear = 2012 });

        modelBuilder.Entity<GameEntity>().HasData(
            new GameEntity { Id = 1, Name = "Mario", Platform = "Nintendo", Rating = 10 },
            new GameEntity { Id = 2, Name = "Guitar Hero", Platform = "XBOX", Rating = 8 }
        );
    }
}