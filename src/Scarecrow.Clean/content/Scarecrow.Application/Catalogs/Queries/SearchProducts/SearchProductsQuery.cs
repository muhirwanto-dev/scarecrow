using Wolverine;

namespace Scarecrow.Application.Catalogs.Queries.GetProducts
{
    public record SearchProductsQuery(string Query) : IMessage;
}
