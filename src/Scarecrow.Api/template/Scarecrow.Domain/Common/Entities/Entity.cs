using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Scarecrow.Domain.Common.Messaging;
using SingleScope.Persistence.Abstraction;

namespace Scarecrow.Domain.Common.Entities
{
    public abstract class Entity : Entity<long>;

    public abstract class Entity<TKey> : DomainEntity, IEntity<TKey>
        where TKey : notnull, IEquatable<TKey>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual TKey Id { get; set; } = default!;
    }
}
