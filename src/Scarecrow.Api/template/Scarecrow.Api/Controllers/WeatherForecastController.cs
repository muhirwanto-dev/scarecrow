using Asp.Versioning;
using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Scarecrow.Application.Catalogs;
using Scarecrow.Application.Catalogs.Commands.AddProduct;
using Wolverine;

namespace Scarecrow.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class WeatherForecastController(
        IMessageBus _bus
        ) : ApiController
    {
        [HttpGet("products/{name}")]
        public async Task<IActionResult> AddProductAsync(
            [FromRoute] string name,
            CancellationToken cancellationToken = default)
        {
            var command = new AddProductCommand(name);
            var result = await _bus.InvokeAsync<ErrorOr<AddProductResponseDto>>(command, cancellationToken);

            return result.Match(
                onValue: Ok,
                onError: Problem
                );
        }
    }
}
