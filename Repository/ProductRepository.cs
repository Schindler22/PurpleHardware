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

    public List<Product> GetProducts()
    {
        return _context.Products.ToList();
    }

    public void NewProduct(Product product)
    {
        //var data = new Product(product.Name, product.Description, product.Brand, product.BuyPrice, product.SellPrice);
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void UpdateProduct(Product product)
    {
        var data = _context.Products.Where(w => w.Id == product.Id).SingleOrDefault();
        if(data != null){
            
            var newName = data.Name == product.Name ? data.Name : product.Name;
            var newDescription = data.Description == product.Description ? data.Description : product.Description;
            var newBrand = data.Brand == product.Brand ? data.Brand : product.Brand;
            var newBuyPrice = data.BuyPrice == product.BuyPrice ? data.BuyPrice : product.BuyPrice;
            var newSellPrice = data.SellPrice == product.SellPrice ? data.SellPrice : product.SellPrice;

            var UpdateProduct = new Product(name: newName, description: newDescription, 
                                            brand:newBrand, buyPrice:newBuyPrice, sellPrice:newSellPrice);

            _context.Products.Update(UpdateProduct);
        }
    }
}
