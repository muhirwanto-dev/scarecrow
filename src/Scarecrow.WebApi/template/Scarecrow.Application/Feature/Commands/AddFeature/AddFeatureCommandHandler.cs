using ErrorOr;
using MediatR;
using Scarecrow.Application.Interfaces;
using Scarecrow.Contracts.Dtos.Feature;
using Scarecrow.Domain.Feature.Entities;

namespace Scarecrow.Application.Feature.Commands.AddFeature
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
