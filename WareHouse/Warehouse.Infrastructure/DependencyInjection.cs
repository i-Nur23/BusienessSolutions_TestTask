using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Warehouse.Infrastructure.Persistance;
using Warehouse.Infrastructure.Persistance.Interfaces;

namespace Warehouse.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDatabase(
           this IServiceCollection services,
           IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            return services;
        }
    }
}
