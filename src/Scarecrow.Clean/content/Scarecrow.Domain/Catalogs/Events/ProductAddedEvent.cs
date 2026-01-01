using Scarecrow.Domain.Common;

namespace Scarecrow.Domain.Catalogs.Events
{
    public record ProductAddedEvent(long Id) : IDomainEvent;
}
