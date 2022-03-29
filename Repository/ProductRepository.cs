using System;
using System.Linq;

namespace PurpleHardware;
    public class ProductRepository: IProductRepository
    {
    private readonly ProductContext _context;
    public ProductRepository(ProductContext context)
    {
        _context = context;
    }

    public void DeleteProduct(int id)
    {
        var data = _context.Products.Where(w => w.Id == id).SingleOrDefault();
        if(data != null){
            _context.Products.Remove(data);
        }
        _context.SaveChanges();
    }

    public Product GetProduct(int id)
    {
        return _context.Products.Where(s => s.Id == id).FirstOrDefault();
    }

    public List<Product> GetProducts()
    {
        return _context.Products.ToList();
    }

    public void NewProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public async Task<string> UpdateProduct(Product product, int id)
    {
            var data = GetProduct(id);
            data.Name = product.Name;
            data.Brand = product.Brand;
            data.Description = product.Description;
            data.BuyPrice = product.BuyPrice;
            data.SellPrice = product.SellPrice;

            var result = await _context.SaveChangesAsync();
  
            return "Update realizado com sucesso!";
    }

}
