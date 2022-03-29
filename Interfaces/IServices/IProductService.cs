namespace PurpleHardware;
    public interface IProductService
    {
        List<Product> GetProducts();
        void NewProduct(Product product);
        void DeleteProduct(int id);
        Task<string> UpdateProduct(Product product);
    }