using Warehouse.Domain.Enums;

namespace Warehouse.Domain.Entities
{
    public class Resource : BaseEntity
    {
        public string Name { get; set; }

        public ArchiveStatus Status { get; set; }

        public ICollection<Balance> Balances { get; set; }

        public ICollection<IncomeResource> IncomeResorces { get; set; }

        public ICollection<ShipmentResource> ShipmentResources { get; set; }
    }
}
