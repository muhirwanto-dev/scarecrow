using Riok.Mapperly.Abstractions;
using Scarecrow.Application.Catalogs;
using Scarecrow.Domain.Catalogs.Entities;

namespace Scarecrow.Application.Common.Mapping
{
    public partial class Mapper
    {
        [MapProperty(nameof(Product.Id), nameof(AddProductResponseDto.ProductId))]
        [MapperIgnoreSource(nameof(Product.CapitalPrice))]
        [MapperIgnoreSource(nameof(Product.Category))]
        [MapperIgnoreSource(nameof(Product.CreatedAt))]
        [MapperIgnoreSource(nameof(Product.IsDeleted))]
        [MapperIgnoreSource(nameof(Product.Margin))]
        [MapperIgnoreSource(nameof(Product.Name))]
        [MapperIgnoreSource(nameof(Product.Price))]
        [MapperIgnoreSource(nameof(Product.Stock))]
        [MapperIgnoreSource(nameof(Product.UpdatedAt))]
        private partial AddProductResponseDto MapToResponse(Product source);
    }
}
