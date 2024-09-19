using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
namespace DAL
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seed default data
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Description = "Product 1", Price = 100.5M, IsActive = true });
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 2, Description = "Product 2", Price = 150.5M, IsActive = true });
        }
    }
}
