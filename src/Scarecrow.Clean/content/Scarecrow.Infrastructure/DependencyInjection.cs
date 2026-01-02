using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scarecrow.Application.Persistence.Repositories;
using Scarecrow.Domain.Catalogs.Entities;
using Scarecrow.Infrastructure.Mailing;
using Scarecrow.Infrastructure.Persistence.Contexts;
using Scarecrow.Infrastructure.Persistence.Repositories;
using Serilog;
using SingleScope.Persistence;
using SingleScope.Persistence.EFCore;

namespace Scarecrow.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddLogging(configuration)
                .AddPersistence(configuration)
                .AddMailing(configuration);
        }

        private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEfCorePersistence<AppDbContext>(builder =>
                builder.UseSqlServer(configuration.GetConnectionString("SqlServerConnection"),
                    o => { }));

            services.AddScopedRepository<IProductRepository, ProductRepository, Product>();

            return services;
        }

        private static IServiceCollection AddLogging(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddLogging(builder => builder.AddSerilog(new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .CreateLogger()));

            return services;
        }

        private static IServiceCollection AddMailing(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailConfiguration>(configuration.GetSection(EmailConfiguration.Section));

            return services;
        }
    }
}
