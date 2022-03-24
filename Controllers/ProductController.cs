using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

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

    [HttpGet("produtos")]
    public async Task<List<Product>> Get()
    {
        return _service.GetProducts();
    }

    // [HttpPost]
    // public string Post(Product product)
    // {                            
    //     var produto = new Product(name:product.Name, description:product.Description, brand:product.Brand, 
    //                                 buyPrice:product.BuyPrice, sellPrice:product.SellPrice);
    //     return $"{produto.Name};{produto.Description};{produto.Brand};{produto.BuyPrice};{produto.SellPrice};{produto.Id}";
    // }

}
