using ErrorOr;
using MediatR;
using Templator.Contracts.Dtos.Feature;

namespace Templator.Application.Feature.Commands.AddFeature
{
    public record AddFeatureCommand(
        string Arg
        ) : IRequest<ErrorOr<FeatureResponseDto>>;
}
