using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Domain.Entities
{
    public class Balance : BaseEntity
    {
        public int Amount { get; set; }

        public Guid ResourceId { get; set; }

        public Guid MeasureId { get; set; }

        [ForeignKey(nameof(MeasureId))]
        public Measure Measure { get; set; }

        [ForeignKey(nameof(ResourceId))]
        public Resource Resource { get; set; }
    }
}
