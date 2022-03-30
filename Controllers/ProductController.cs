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

    [HttpGet]
    public async Task<List<Product>> Get()
    {
        return await _service.GetProducts();
    }

    [HttpPost]
    public async Task<string> Post(Product product)
    {                            
        return await _service.NewProduct(product);
    }

    [HttpDelete]
    public async Task<string> Delete(int id)
    {
        return await _service.DeleteProduct(id);
    }

    [HttpPut]
    public async Task<string> Update(Product product)
    {
        return await _service.UpdateProduct(product);
    }

}
