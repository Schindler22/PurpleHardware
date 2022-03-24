using System;
using System.Linq;

namespace PurpleHardware;
    public class ProductRepository: IProductRepository
    {
    private readonly ApiContext _context;
    public ProductRepository(ApiContext context)
    {
        _context = context;
    }

    public List<Product> GetProducts()
    {
        return _context.Products.ToList<Product>();
    }

    public void NewProduct(Product product)
    {
        var data = new Product(product.Name, product.Description, product.Brand, product.BuyPrice, product.SellPrice);
        _context.Products.Add(data);
    }
}
