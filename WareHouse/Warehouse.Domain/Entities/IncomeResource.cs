using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Domain.Entities
{
    public class IncomeResource : BaseEntity
    {
        public Guid DocumentId { get; set; }

        public Guid ResourceId { get; set; }

        public Guid MeasureId { get; set; }

        public int Amount { get; set; }

        [ForeignKey(nameof(DocumentId))]
        public IncomeDocument Document { get; set; }

        [ForeignKey(nameof(ResourceId))]
        public Resource Resource { get; set; }

        [ForeignKey(nameof(ResourceId))]
        public Measure Measure { get; set; }

    }
}
