using Microsoft.EntityFrameworkCore;
using StockManager.Modules.Stock.Infrastructure.Entity;

namespace StockManager.Modules.Stock.Infrastructure.Data
{
    public class StockDbContext: DbContext
    {
        public DbSet<CustomerEntity> Customers { get; set; }

        public StockDbContext(DbContextOptions<StockDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
