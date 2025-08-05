using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain.Entities;

namespace Warehouse.Infrastructure.Persistance.Configurations
{
    class IncomeResourcesEntityConfiguration : IEntityTypeConfiguration<IncomeResource>
    {
        public void Configure(EntityTypeBuilder<IncomeResource> builder)
        {
            builder
                .HasOne(r => r.Measure)
                .WithMany(m => m.IncomeResorces)
                .HasForeignKey(r => r.MeasureId);

            builder
                .HasOne(r => r.Resource)
                .WithMany(r => r.IncomeResorces)
                .HasForeignKey(r => r.ResourceId);

            builder
                .HasOne(r => r.Document)
                .WithMany(d => d.IncomeResources)
                .HasForeignKey(r => r.DocumentId);
        }
    }
}
