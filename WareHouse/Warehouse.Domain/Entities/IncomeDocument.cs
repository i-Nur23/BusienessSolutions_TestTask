namespace Warehouse.Domain.Entities
{
    public class IncomeDocument : BaseEntity
    {
        public string Number { get; set; }

        public DateTime Date { get; set; }

        public ICollection<IncomeResource> IncomeResources { get; set; }
    }
}
