using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using Scarecrow.Api.Common.Constants;

namespace Scarecrow.Api.Controllers
{
    [ApiController]
    public abstract class ApiController : ControllerBase
    {
        protected ActionResult Problem(List<Error> errors)
        {
            if (errors.Count is 0)
            {
                return Problem();
            }

            if (errors.All(error => error.Type == ErrorType.Validation))
            {
                return ValidationProblem(errors);
            }

            return Problem(errors[0]);
        }

        private ActionResult Problem(Error error) => error.Type switch
        {
            ErrorType.Conflict => Conflict(error.Description),
            ErrorType.Validation => BadRequest(error.Description),
            ErrorType.NotFound => NotFound(error.Description),
            ErrorType.Unauthorized => Unauthorized(error.Description),
            _ => Problem(
                statusCode: StatusCodes.Status500InternalServerError,
                title: Http.GeneralApiProblem,
                detail: error.Description
                ),
        };

        private ActionResult ValidationProblem(List<Error> errors)
            => BadRequest(string.Join("\n", errors.Select(x => x.Description)));
    }
}
