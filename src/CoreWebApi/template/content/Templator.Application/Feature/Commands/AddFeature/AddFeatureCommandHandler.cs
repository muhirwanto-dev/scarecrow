using ErrorOr;
using MediatR;
using Templator.Application.Interfaces;
using Templator.Contracts.Dtos.Feature;
using Templator.Domain.Feature.Entities;

namespace Templator.Application.Feature.Commands.AddFeature
{
    public class AddFeatureCommandHandler(
        IMapper _mapper
        ) : IRequestHandler<AddFeatureCommand, ErrorOr<FeatureResponseDto>>
    {
        public Task<ErrorOr<FeatureResponseDto>> Handle(AddFeatureCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(ErrorOrFactory.From(_mapper.Map<Template, FeatureResponseDto>(new Template { Description = "Template added" })));
        }
    }
}
