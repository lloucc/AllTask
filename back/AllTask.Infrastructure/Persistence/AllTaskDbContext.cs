using Microsoft.EntityFrameworkCore;
using AllTask.Core.Entities;

namespace AllTask.Infrastructure.Persistence;

public class AllTaskDbContext : DbContext
{
    public AllTaskDbContext(DbContextOptions<AllTaskDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Routine> Routines { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder
            .Entity<Routine>(e =>
            {
                e.HasKey(r => r.Id);
                
            });

        builder
            .Entity<Category>(e =>
            {
                e.HasKey(r => r.Id);
            });
        
        base.OnModelCreating(builder);
    }
}