using System.ComponentModel.DataAnnotations.Schema;
using Warehouse.Domain.Enums;

namespace Warehouse.Domain.Entities
{
    public class ShipmentDocument : BaseEntity
    {
        public Guid ClientId { get; set; }

        public int Number { get; set; }

        public DateTime Date { get; set; }

        public DocumentStatus Status { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; }
    }
}
