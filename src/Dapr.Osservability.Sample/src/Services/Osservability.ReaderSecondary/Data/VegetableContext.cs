using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Osservability.ReaderSecondary.Data.Models;
using System;

namespace Osservability.ReaderSecondary.Data
{
    public class VegetableContext : DbContext
    {
        public VegetableContext(DbContextOptions<VegetableContext> options)
            : base(options)
        {
        }

        public DbSet<VegetableEntity> Vegetables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var romanSalad = new VegetableEntity()
            {
                Id = 1,
                Quantity = 100,
                Description = "Upright habit with attractive pier green leaves with crisp costa. Voluminous and heavy head, but well conformed. The great rusticity, even in critical periods, the resistance to the ascent to seed and over-ripening, allow the maximum elasticity of collection, ensuring a quality product, even during the summer. In the kitchen it is used for very fresh single salads with vinegar and a pinch of oil or mixed with cherry tomatoes and corn.",
                Name = "Lattuga Romana",
                ExpirationDate = DateTime.UtcNow.AddDays(7),
                Temperature = 10
            };
            modelBuilder.Entity<VegetableEntity>().HasData(romanSalad);
        }
    }

    public class FruitContextDesign : IDesignTimeDbContextFactory<VegetableContext>
    {
        public VegetableContext CreateDbContext(string[] args)
        {
            string connectionString = "Server=sqlserver;Database=VegetableDB;User Id=sa;Password=DaprSample12@=;";
            var options = new DbContextOptionsBuilder<VegetableContext>()
                .UseSqlServer(connectionString)
                .Options;
            return new VegetableContext(options);
        }
    }
}
