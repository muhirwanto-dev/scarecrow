using Scarecrow.Domain.Catalogs.Entities;
using SingleScope.Persistence.Repository;

namespace Scarecrow.Application.Persistence.Repositories
{
    public interface IProductRepository : IReadWriteRepository<Product>
    {
        Task<List<Product>> SearchAsync(string query, CancellationToken cancellationToken = default);
    }
}
