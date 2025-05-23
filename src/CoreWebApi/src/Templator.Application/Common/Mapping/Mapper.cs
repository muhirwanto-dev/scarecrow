using Riok.Mapperly.Abstractions;
using Templator.Application.Interfaces;

namespace Templator.Application.Common.Mapping
{
    [Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
    public partial class Mapper : IMapper
    {
        public partial TTarget Map<TSource, TTarget>(TSource source);
    }
}
