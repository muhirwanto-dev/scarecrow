using Scarecrow.Domain.Common.Messaging;

namespace Scarecrow.Domain.Catalogs.Events
{
    public record ProductAddedEvent(long Id) : IDomainEvent;
}
