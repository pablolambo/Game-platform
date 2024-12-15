using System.Transactions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VgcZeroGamePlatform.Infrastructure.Data
{
        public class GameStoreContext : IdentityDbContext<ApplicationUser>
        {
            public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options) { }

            public DbSet<Game> Games { get; set; }
            public DbSet<Ownership> Ownerships { get; set; }
            public DbSet<Transaction> Transactions { get; set; }
            public DbSet<Offer> Offers { get; set; }
            public DbSet<Vendor> Vendors { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                // Enum Mapping
                modelBuilder.Entity<Game>()
                    .Property(g => g.Genre)
                    .HasConversion<string>();

                // Configurations (add relationships and constraints as needed)
            }
        }
  
}
