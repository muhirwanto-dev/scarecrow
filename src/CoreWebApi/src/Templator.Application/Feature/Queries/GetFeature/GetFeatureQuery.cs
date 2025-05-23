using ErrorOr;
using MediatR;

namespace Templator.Application.Feature.Queries.GetFeature
{
    public record GetFeatureQuery : IRequest<ErrorOr<Success>>;
}
