using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Warehouse.Domain.Entities;

namespace Warehouse.Infrastructure.Persistance.Configurations
{
    class ShipmentDocumentEntityConfiguration : IEntityTypeConfiguration<ShipmentDocument>
    {
        public void Configure(EntityTypeBuilder<ShipmentDocument> builder)
        {
            builder
                .HasOne(d => d.Client)
                .WithMany(c => c.ShipmentDocuments)
                .HasForeignKey(d => d.ClientId);
        }
    }
}
