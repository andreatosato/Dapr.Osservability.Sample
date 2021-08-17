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
