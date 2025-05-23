using Riok.Mapperly.Abstractions;
using Templator.Contracts.Dtos.Feature;
using Templator.Domain.Feature.Entities;

namespace Templator.Application.Common.Mapping
{
    public partial class Mapper
    {
        [MapProperty(nameof(Template.Description), nameof(FeatureResponseDto.Result))]
        [MapperIgnoreSource(nameof(Template.IsDeleted))]
        [MapperIgnoreSource(nameof(Template.Id))]
        [MapperIgnoreSource(nameof(Template.CreatedAt))]
        [MapperIgnoreSource(nameof(Template.UpdatedAt))]
        private partial FeatureResponseDto MapToFeature(Template source);
    }
}
