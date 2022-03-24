using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public List<Product> Get()
    {
        return _service.GetProducts();
    }

    [HttpPost]
    public string Post(Product product)
    {                            
        _service.NewProduct(product);

        return $"{product.Name}-{product.Description}-{product.Brand}-{product.BuyPrice}-{product.SellPrice}";
    }

}
