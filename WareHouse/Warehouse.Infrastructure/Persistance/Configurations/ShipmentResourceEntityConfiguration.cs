using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain.Entities;

namespace Warehouse.Infrastructure.Persistance.Configurations
{
    class ShipmentResourceEntityConfiguration : IEntityTypeConfiguration<ShipmentResource>
    {
        public void Configure(EntityTypeBuilder<ShipmentResource> builder)
        {
            builder
                .HasOne(r => r.Measure)
                .WithMany(m => m.ShipmentResources)
                .HasForeignKey(r => r.MeasureId);

            builder
                .HasOne(r => r.Resource)
                .WithMany(r => r.ShipmentResources)
                .HasForeignKey(r => r.ResourceId);
        }
    }
}
