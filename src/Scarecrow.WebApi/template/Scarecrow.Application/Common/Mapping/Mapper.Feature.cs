﻿using Riok.Mapperly.Abstractions;
using Scarecrow.Contracts.Dtos.Feature;
using Scarecrow.Domain.Feature.Entities;

namespace Scarecrow.Application.Common.Mapping
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
