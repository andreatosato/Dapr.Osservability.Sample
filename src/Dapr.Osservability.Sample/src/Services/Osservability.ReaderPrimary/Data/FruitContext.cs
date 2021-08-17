using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Osservability.ReaderPrimary.Data.Models;

namespace Osservability.ReaderPrimary.Data
{
    public class FruitContext : DbContext
    {
        public FruitContext(DbContextOptions<FruitContext> options)
            : base(options)
        {
        }

        public DbSet<FruitEntity> Fruits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var apple = new FruitEntity()
            {
                Id = 1,
                Quantity = 100,
                Description = "We pick Fuji Melinda from mid-October onwards, when all the other apples have been picked and the highest peaks of the Trentino valleys are already covered with snow. Staying so long on the plant, it accumulates sugars: a real pleasure for the palate.",
                Name = "Mela Fuji",
                ExpirationDate = System.DateTime.UtcNow.AddDays(7),
                Temperature = 10
            };
            modelBuilder.Entity<FruitEntity>().HasData(apple);
        }
    }

    public class FruitContextDesign : IDesignTimeDbContextFactory<FruitContext>
    {
        public FruitContext CreateDbContext(string[] args)
        {
            string connectionString = "Server=sqlserver;Database=FruitDB;User Id=sa;Password=DaprSample12@=;";
            var options = new DbContextOptionsBuilder<FruitContext>()
                .UseSqlServer(connectionString)
                .Options;
            return new FruitContext(options);
        }
    }
}
