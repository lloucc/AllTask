﻿using Microsoft.EntityFrameworkCore;
using AllTask.Core.Entities;
using Task = AllTask.Core.Entities.Task;

namespace AllTask.Infrastructure.Persistence;

public class AllTaskDbContext : DbContext
{
    public AllTaskDbContext(DbContextOptions<AllTaskDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Routine> Routines { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Task> Tasks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {

        builder
            .Entity<Routine>(e =>
            {
                e.HasKey(r => r.Id);

                e.HasOne(r => r.Category)
                    .WithMany(c => c.Routines)
                    .HasForeignKey(r => r.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict);

            });

        builder
            .Entity<Category>(e =>
            {
                e.HasKey(r => r.Id);
            });

        builder
            .Entity<Task>(e =>
            {
                e.HasKey(t => t.Id);

                e.HasOne(r => r.Routine)
                    .WithMany(r => r.Tasks)
                    .HasForeignKey(t => t.RoutineId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

        base.OnModelCreating(builder);
    }
}