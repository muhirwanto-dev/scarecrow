using ErrorOr;
using MediatR;

namespace Scarecrow.Application.Feature.Queries.GetFeature
{
    public record GetFeatureQuery : IRequest<ErrorOr<Success>>;
}
