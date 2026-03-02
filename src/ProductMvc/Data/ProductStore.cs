using ProductMvc.Models;

namespace ProductMvc.Data;

public static class ProductStore
{
    public static IReadOnlyList<Product> Create() =>
        new List<Product>
        {
            new(
                Id: 1,
                Sku: "SKU-COFFEE-001",
                Name: "Coffee Beans (1kg)",
                Description: "Medium roast whole coffee beans.",
                Price: 24.99m,
                Currency: "USD",
                InStock: true,
                Tags: new[] { "grocery", "coffee", "beverage" }
            ),
            new(
                Id: 2,
                Sku: "SKU-MUG-010",
                Name: "Ceramic Mug (350ml)",
                Description: "Dishwasher-safe ceramic mug.",
                Price: 12.50m,
                Currency: "USD",
                InStock: true,
                Tags: new[] { "kitchen", "mug" }
            ),
            new(
                Id: 3,
                Sku: "SKU-GRINDER-100",
                Name: "Burr Grinder",
                Description: "Conical burr grinder with 40 grind settings.",
                Price: 89.00m,
                Currency: "USD",
                InStock: false,
                Tags: new[] { "coffee", "appliance" }
            ),
        };
}

