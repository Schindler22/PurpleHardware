namespace PurpleHardware;
    public class ProductService: IProductService
    {
        private readonly IProductRepository _repository;
        
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetProducts()
        {
            return _repository.GetProducts();
        }

        public void NewProduct(Product product)
        {
            _repository.NewProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _repository.DeleteProduct(id);
        }

    public void UpdateProduct(Product product)
    {
        _repository.UpdateProduct(product);
    }
}
