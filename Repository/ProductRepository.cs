using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PurpleHardware;
    public class ProductRepository: IProductRepository
    {
    private readonly ProductContext _context;
    public ProductRepository(ProductContext context)
    {
        _context = context;
    }

    public async Task<string> DeleteProduct(int id)
    {
        var data = _context.Products.Where(w => w.Id == id).SingleOrDefault();
        if(data != null){
            _context.Products.Remove(data);
            await _context.SaveChangesAsync();
            return "Produto removido com sucesso!";
        } else {
            return "Produto não encontrado!";
        }
    }

    public async Task<Product> GetProduct(int id)
    {
        var result = await _context.Products.Where(s => s.Id == id).FirstOrDefaultAsync();
        if(result == null){
            return new Product(name: "name", description: "description", brand: "brand", buyPrice: 0, sellPrice: 0);
        } else {
            return result;
        }
    }

    public async Task<List<Product>> GetProducts()
    {
        var result = await _context.Products.ToListAsync();
        if(result == null){
            return new List<Product>();
        } else{
            return result;
        }
    }

    public async Task<string> NewProduct(Product product)
    {
        var result = await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return "Produto adicionado com sucesso!";
    }

    public async Task<string> UpdateProduct(Product product, int id)
    {
            var data = GetProduct(id);

            if(data.Result.Name == ""){
                return "Erro ao buscar produto!";
            } else {
                data.Result.Name = product.Name;
                data.Result.Brand = product.Brand;
                data.Result.Description = product.Description;
                data.Result.BuyPrice = product.BuyPrice;
                data.Result.SellPrice = product.SellPrice;
                var result = await _context.SaveChangesAsync();
                return "Update realizado com sucesso!";
            }
    }

}
