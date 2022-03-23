namespace PurpleHardware;
    public class ProductService: IProductService
    {
        private readonly IProductRepository _repository;
        
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }
        public string GetProducts(List<Product> products)
        {
            return _repository.GetProducts(products);
        }
    }
