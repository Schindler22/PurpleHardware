namespace PurpleHardware;
    public interface IProductRepository
    {
        List<Product> GetProducts();
        void NewProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);
    }