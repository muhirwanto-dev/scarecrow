using Microsoft.EntityFrameworkCore;
using Scarecrow.Domain.Catalogs.Entities;
using Wolverine;

namespace Scarecrow.Infrastructure.Persistence.Contexts
{
    public class AppDbContext(
        DbContextOptions _options,
        IMessageBus _bus
        ) : DbContext(_options)
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(new DomainEventsDbInterceptor(_bus));
        }
    }
}
