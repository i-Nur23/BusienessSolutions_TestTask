using Microsoft.EntityFrameworkCore;
using Warehouse.Domain.Entities;

namespace Warehouse.Infrastructure.Persistance
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Balance> Balances { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<IncomeDocument> Documents { get; set; }

        public DbSet<IncomeResource> IncomeResources { get; set; }

        public DbSet<Measure> Measures { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<ShipmentDocument> ShipmentDocuments { get; set; }

        public DbSet<ShipmentResource> ShipmentResources { get; set; }
    }
}
