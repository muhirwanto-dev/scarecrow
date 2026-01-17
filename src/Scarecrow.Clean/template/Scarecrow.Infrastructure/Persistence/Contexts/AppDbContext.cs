using Microsoft.EntityFrameworkCore;
using Scarecrow.Domain.Catalogs.Entities;

namespace Scarecrow.Infrastructure.Persistence.Contexts
{
    public class AppDbContext(DbContextOptions _options) : DbContext(_options)
    {
        public DbSet<Product> Products { get; set; }
    }
}
