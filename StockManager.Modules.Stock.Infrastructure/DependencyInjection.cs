using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockManager.Modules.Stock.Infrastructure.Data;

namespace StockManager.Modules.Stock.Infrastructure
{   
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration["ConnectionStrings:DefaultConnection"];

            services.AddDbContext<StockDbContext>(o =>
                o.UseSqlServer(connectionString, option =>
                    option.MigrationsAssembly(typeof(StockDbContext).Assembly.GetName().Name)
                )
            );

            return services;
        }
    }
}
