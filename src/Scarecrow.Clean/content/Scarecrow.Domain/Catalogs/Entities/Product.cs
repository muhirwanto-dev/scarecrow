using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Scarecrow.Domain.Catalogs.Events;
using Scarecrow.Domain.Common.Entities;

namespace Scarecrow.Domain.Catalogs.Entities
{
    [Table(nameof(Product))]
    public class Product : RecoverableEntity
    {
        [StringLength(256)]
        public string Name { get; set; } = string.Empty;

        public int Stock { get; set; } = 0;

        public string Category { get; set; } = string.Empty;

        [Required]
        public double Price { get; set; } = 0.0;

        [Required]
        public double CapitalPrice { get; set; } = 0.0;

        public double Margin => Price - CapitalPrice;

        public void Added()
        {
            AddDomainEvent(new ProductAddedEvent(Id));
        }

        public void OutOfStock()
        {
            AddDomainEvent(new ProductOutOfStockEvent(Id));
        }
    }
}
