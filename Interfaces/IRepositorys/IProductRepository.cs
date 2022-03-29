namespace PurpleHardware;
    public interface IProductRepository
    {
        List<Product> GetProducts();
        void NewProduct(Product product);
        void DeleteProduct(int id);
        Task<string> UpdateProduct(Product product, int id);

        Product GetProduct(int id);
    }