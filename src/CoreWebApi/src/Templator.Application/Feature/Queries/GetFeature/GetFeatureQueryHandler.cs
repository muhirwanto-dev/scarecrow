using ErrorOr;
using MediatR;

namespace Templator.Application.Feature.Queries.GetFeature
{
    public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQuery, ErrorOr<Success>>
    {
        public Task<ErrorOr<Success>> Handle(GetFeatureQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
