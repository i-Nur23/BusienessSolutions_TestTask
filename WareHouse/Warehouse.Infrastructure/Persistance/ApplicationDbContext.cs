using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Warehouse.Domain.Entities;
using Warehouse.Infrastructure.Persistance.Interfaces;

namespace Warehouse.Infrastructure.Persistance
{
    class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Balance> Balances { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<IncomeDocument> Documents { get; set; }

        public DbSet<IncomeResource> IncomeResources { get; set; }

        public DbSet<Measure> Measures { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<ShipmentDocument> ShipmentDocuments { get; set; }

        public DbSet<ShipmentResource> ShipmentResources { get; set; }

        public async Task MigrateDatabaseAsync(CancellationToken cancellationToken = default)
        {
            await Database.MigrateAsync(cancellationToken);
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
            : base(contextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
