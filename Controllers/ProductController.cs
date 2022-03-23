using Microsoft.AspNetCore.Mvc;

namespace PurpleHardware.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductService _service;

    public ProductController(ILogger<ProductController> logger, IProductService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet]
    public string Get()
    {
        var produtos = new List<Product>();

        Product notebook = new Product(name: "Air 13", description: "Design moderno e custa bastante",
                                      brand: "Apple", buyPrice: 5.999, sellPrice: 6.699);
        Product smartphone = new Product(name: "S22", description: "Design moderno e esquenta bastante",
                                      brand: "Samsung", buyPrice: 7.999, sellPrice: 9.399);
        Product console = new Product(name: "PS5", description: "Design moderno e menos que os outros",
                                      brand: "Sony", buyPrice: 3.999, sellPrice: 4.699);

        produtos.Add(notebook);
        produtos.Add(smartphone);
        produtos.Add(console);

        return _service.GetProducts(produtos);
    }

    [HttpPost]
    public string Post(Product product)
    {                            
        var produto = new Product(name:product.Name, description:product.Description, brand:product.Brand, 
                                    buyPrice:product.BuyPrice, sellPrice:product.SellPrice);
        return $"{produto.Name};{produto.Description};{produto.Brand};{produto.BuyPrice};{produto.SellPrice};{produto.Id}";
    }

}
