using Scarecrow.Domain.Common.Entities;

namespace Scarecrow.Domain.Feature.Entities
{
    public class Template : RecoverableEntity
    {
        public string? Description { get; set; }
    }
}
