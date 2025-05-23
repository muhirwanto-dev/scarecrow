using Scarecrow.Domain.Common;

namespace Scarecrow.Domain.Feature.Entities
{
    public class Template : RecoverableEntity
    {
        public string? Description { get; set; }
    }
}
