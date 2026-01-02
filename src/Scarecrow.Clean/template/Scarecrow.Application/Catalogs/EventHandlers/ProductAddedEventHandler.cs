using Scarecrow.Domain.Catalogs.Events;
using Wolverine.Attributes;

namespace Scarecrow.Application.Catalogs.EventHandlers
{
    [WolverineHandler]
    public class ProductAddedEventHandler
    {
        protected Task HandleAsync(ProductAddedEvent message, CancellationToken cancellation = default)
        {
            return Task.CompletedTask;
        }
    }
}
