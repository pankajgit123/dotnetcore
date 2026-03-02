namespace ProductMvc.Models;

public record Product(
    int Id,
    string Sku,
    string Name,
    string Description,
    decimal Price,
    string Currency,
    bool InStock,
    IReadOnlyList<string> Tags);

