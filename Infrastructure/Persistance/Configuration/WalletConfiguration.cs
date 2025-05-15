using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Configuration
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder) 
        {
            builder.ToTable("Wallets");

            builder.HasKey(w => w.Id);

            builder.Property(w => w.WalletName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(w => w.Balance)
                .IsRequired()
                .HasPrecision(18, 2);

            builder.Property(w => w.Note)
                .HasMaxLength(500);
        }
    }
}
