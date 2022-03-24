namespace PurpleHardware;
    public interface IProductRepository
    {
        List<Product> GetProducts();
        void NewProduct(Product product);
    }