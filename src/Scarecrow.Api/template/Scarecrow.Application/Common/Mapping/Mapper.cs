using Riok.Mapperly.Abstractions;

namespace Scarecrow.Application.Common.Mapping
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class Mapper : IMapper
    {
        public partial TResult Map<TSource, TResult>(TSource source);
    }
}
