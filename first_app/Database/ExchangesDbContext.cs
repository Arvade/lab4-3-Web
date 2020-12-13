using first_app.Entities;
using Microsoft.EntityFrameworkCore;

namespace first_app.Database {
    public class ExchangesDbContext : DbContext {
        public ExchangesDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<ItemEntity> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            // fluent configuration ...
        }
    }
}
