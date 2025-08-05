using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Domain.Entities
{
    public class ShipmentResource : BaseEntity
    {
        public Guid ResourceId { get; set; }

        public Guid MeasureId { get; set; }

        public int Amount { get; set; }

        [ForeignKey(nameof(ResourceId))]
        public Resource Resource { get; set; }

        [ForeignKey(nameof(MeasureId))]
        public Measure Measure { get; set; }
    }
}
