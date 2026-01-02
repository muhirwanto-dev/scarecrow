using Wolverine;

namespace Scarecrow.Application.Catalogs.Commands.AddProduct
{
    public record AddProductCommand(string Name) : IMessage;
}
