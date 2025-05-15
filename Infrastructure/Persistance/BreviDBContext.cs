using Domain.Entities;
using Infrastructure.Persistance.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance
{
    public class BreviDBContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public DbSet<Wallet> Wallets { get; set; } = null!;

        public BreviDBContext(DbContextOptions<BreviDBContext> options) : base(options)
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new WalletConfiguration());

        }
    }
}
