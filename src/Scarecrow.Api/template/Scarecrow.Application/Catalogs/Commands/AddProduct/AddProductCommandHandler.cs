using ErrorOr;
using Scarecrow.Application.Persistence.Repositories;
using Scarecrow.Domain.Catalogs.Entities;
using Wolverine.Attributes;

namespace Scarecrow.Application.Catalogs.Commands.AddProduct
{
    [WolverineHandler]
    public class AddProductCommandHandler(
        IProductRepository _repository)
    {
        public async Task<ErrorOr<AddProductResponseDto>> HandleAsync(AddProductCommand message, CancellationToken cancellation = default)
        {
            var product = new Product
            {
                Name = message.Name,
            };

            await _repository.AddAsync(product, cancellation);

            product.Added();

            await _repository.SaveAsync(cancellation);

            return new ErrorOr<AddProductResponseDto>();
        }
    }
}
