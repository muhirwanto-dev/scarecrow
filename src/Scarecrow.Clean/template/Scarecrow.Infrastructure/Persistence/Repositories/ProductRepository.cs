using Microsoft.EntityFrameworkCore;
using Scarecrow.Application.Persistence.Repositories;
using Scarecrow.Domain.Catalogs.Entities;
using Scarecrow.Infrastructure.Persistence.Contexts;
using SingleScope.Persistence.EFCore.Repositories;

namespace Scarecrow.Infrastructure.Persistence.Repositories
{
    internal class ProductRepository(AppDbContext dbContext) : ReadWriteRepository<Product, AppDbContext>(dbContext),
        IProductRepository
    {
        public Task<List<Product>> SearchAsync(string query, CancellationToken cancellationToken = default)
        {
            return _context.Products
                .AsNoTracking()
                .Where(x => EF.Functions.Like(x.Name, query))
                .ToListAsync(cancellationToken);
        }
    }
}
