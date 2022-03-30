namespace PurpleHardware;
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<string> NewProduct(Product product);
        Task<string> DeleteProduct(int id);
        Task<string> UpdateProduct(Product product);
    }