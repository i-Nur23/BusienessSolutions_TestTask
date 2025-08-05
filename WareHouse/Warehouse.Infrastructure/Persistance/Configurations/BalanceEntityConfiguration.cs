using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain.Entities;

namespace Warehouse.Infrastructure.Persistance.Configurations
{
    class BalanceEntityConfiguration : IEntityTypeConfiguration<Balance>
    {
        public void Configure(EntityTypeBuilder<Balance> builder)
        {
            builder
                .HasOne(b => b.Measure)
                .WithMany(m => m.Balances)
                .HasForeignKey(b => b.MeasureId);

            builder
                .HasOne(b => b.Resource)
                .WithMany(r => r.Balances)
                .HasForeignKey(b => b.ResourceId);
        }
    }
}
