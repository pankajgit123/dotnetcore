using Microsoft.AspNetCore.Mvc;
using ProductMvc.Data;
using ProductMvc.Models;

namespace ProductMvc.Controllers;

[ApiController]
[Route("products")]
public class ProductsController : ControllerBase
{
    private static readonly IReadOnlyList<Product> Products = ProductStore.Create();

    [HttpGet]
    public ActionResult<IEnumerable<ProductListItem>> GetAll()
    {
        var list = Products.Select(p => new ProductListItem(
            p.Id,
            p.Sku,
            p.Name,
            p.Price,
            p.Currency,
            p.InStock
        ));

        return Ok(list);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = Products.FirstOrDefault(p => p.Id == id);
        return product is null ? NotFound() : Ok(product);
    }
}

public record ProductListItem(
    int Id,
    string Sku,
    string Name,
    decimal Price,
    string Currency,
    bool InStock);

