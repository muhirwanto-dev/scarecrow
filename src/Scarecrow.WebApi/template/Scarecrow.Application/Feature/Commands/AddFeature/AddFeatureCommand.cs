using ErrorOr;
using MediatR;
using Scarecrow.Contracts.Dtos.Feature;

namespace Scarecrow.Application.Feature.Commands.AddFeature
{
    public record AddFeatureCommand(
        string Arg
        ) : IRequest<ErrorOr<FeatureResponseDto>>;
}
