using Microsoft.EntityFrameworkCore;
using Survivor.Data.Entities;

namespace Survivor.Data;

public class SurvivorDbContext : DbContext
{
    public DbSet<CategoryEntity> Categories { get; set; }
    public DbSet<CompetitorEntity> Competitors { get; set; }

    public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompetitorEntity>()
                    .HasOne(co => co.Category)
                    .WithMany(co => co.Competitors)
                    .HasForeignKey(co => co.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);
    }
    
}