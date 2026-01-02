using Ardalis.SmartEnum;

namespace Scarecrow.Domain.Catalogs.ValueObjects
{
    public class ProductCategory(string name, int value)
        : SmartEnum<ProductCategory>(name, value)
    {
        public static readonly ProductCategory Food = new(nameof(Food), 0);
        public static readonly ProductCategory Drink = new(nameof(Drink), 1);
        public static readonly ProductCategory Snack = new(nameof(Snack), 2);
    }
}
