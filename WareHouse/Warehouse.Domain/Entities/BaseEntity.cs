using System.ComponentModel.DataAnnotations;

namespace Warehouse.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
