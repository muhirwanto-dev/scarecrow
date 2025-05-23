using System.ComponentModel.DataAnnotations.Schema;
using SingleScope.Persistence.Entities;

namespace Templator.Domain.Common
{
    public abstract class NoKeyEntity : Entity, IEntity<int>
    {
        [NotMapped]
        public int Id { get; set; }
    }
}
