using Riok.Mapperly.Abstractions;
using Scarecrow.Application.Interfaces;

namespace Scarecrow.Application.Common.Mapping
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class Mapper : IMapper
    {
        public partial TTarget Map<TSource, TTarget>(TSource source);
    }
}
