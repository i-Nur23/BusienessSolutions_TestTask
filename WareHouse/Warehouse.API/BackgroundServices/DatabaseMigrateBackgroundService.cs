using Warehouse.Infrastructure.Persistance.Interfaces;

namespace Warehouse.API.BackgroundServices
{
    public class DatabaseMigrateBackgroundService : BackgroundService
    {
        private readonly IServiceProvider _servicesProvider;

        public DatabaseMigrateBackgroundService(
            IServiceProvider serviceProvider
            )
        {
            _servicesProvider = serviceProvider;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.CompletedTask;
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            using (IServiceScope scope = _servicesProvider.CreateScope())
            {
                using (IApplicationDbContext dbContext = scope.ServiceProvider.GetRequiredService<IApplicationDbContext>())
                {
                    await dbContext.MigrateDatabaseAsync(cancellationToken);
                }
            }
        }
    }
}
