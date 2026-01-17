using Scarecrow.Domain.Common.Messaging;

namespace Scarecrow.Domain.Catalogs.Events
{
    public record ProductOutOfStockEvent(long ProductId) : IDomainEvent;
}
