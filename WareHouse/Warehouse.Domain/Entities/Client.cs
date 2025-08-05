using Warehouse.Domain.Enums;

namespace Warehouse.Domain.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }

        public ArchiveStatus Status { get; set; }

        public string Address { get; set; }

        public ICollection<ShipmentDocument> ShipmentDocuments { get; set; }
    }
}
