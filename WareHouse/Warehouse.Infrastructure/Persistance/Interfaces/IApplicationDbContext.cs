using Microsoft.EntityFrameworkCore;
using Warehouse.Domain.Entities;

namespace Warehouse.Infrastructure.Persistance.Interfaces
{
    public interface IApplicationDbContext : IDisposable
    {
        public DbSet<Balance> Balances { get; }

        public DbSet<Client> Clients { get; }

        public DbSet<IncomeDocument> Documents { get; }

        public DbSet<IncomeResource> IncomeResources { get; }

        public DbSet<Measure> Measures { get; }

        public DbSet<Resource> Resources { get; }

        public DbSet<ShipmentDocument> ShipmentDocuments { get; }

        public DbSet<ShipmentResource> ShipmentResources { get; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        public Task MigrateDatabaseAsync(CancellationToken cancellationToken = default);
    }
}
