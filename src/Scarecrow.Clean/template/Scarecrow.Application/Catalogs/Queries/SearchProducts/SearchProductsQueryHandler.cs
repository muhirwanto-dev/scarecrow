using Scarecrow.Application.Catalogs.Queries.GetProducts;
using Scarecrow.Application.Persistence.Repositories;
using Scarecrow.Domain.Catalogs.Entities;
using Wolverine.Attributes;

namespace Scarecrow.Application.Catalogs.Queries.SearchProducts
{
    [WolverineHandler]
    public class SearchProductsQueryHandler(
        IProductRepository _repository)
    {
        protected Task<List<Product>> HandleAsync(SearchProductsQuery message, CancellationToken cancellation = default)
        {
            return _repository.SearchAsync(message.Query, cancellation);
        }
    }
}
