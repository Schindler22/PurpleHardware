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
    public List<Product> Get()
    {
        return _service.GetProducts();
    }

    [HttpPost]
    public string Post(Product product)
    {                            
        _service.NewProduct(product);

        return "Produto adicionado com sucesso!";
    }

    [HttpDelete]
    public string Delete(int id)
    {
        _service.DeleteProduct(id);

        return "Produto removido com sucesso!";
    }

    [HttpPut]
    public async Task<string> Update(Product product)
    {
        return await _service.UpdateProduct(product);
    }

}
