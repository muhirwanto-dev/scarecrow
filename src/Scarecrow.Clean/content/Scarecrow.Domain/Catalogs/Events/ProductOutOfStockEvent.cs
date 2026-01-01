using Scarecrow.Domain.Common;

namespace Scarecrow.Domain.Catalogs.Events
{
    public record ProductOutOfStockEvent(long ProductId) : IDomainEvent;
}
