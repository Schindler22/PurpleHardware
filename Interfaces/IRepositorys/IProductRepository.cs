namespace PurpleHardware;
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<string> NewProduct(Product product);
        Task<string> DeleteProduct(int id);
        Task<string> UpdateProduct(Product product, int id);

        Task<Product> GetProduct(int id);
    }