﻿using GamesWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "RPG", DisplayOrder = 1},
                new Category { Id = 2, Name = "Sports", DisplayOrder = 2 },
                new Category { Id = 3, Name = "FPS", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Strategy", DisplayOrder = 4 }
                );
        }
    }
}
