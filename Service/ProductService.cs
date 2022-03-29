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

    public async Task<string> UpdateProduct(Product product)
    {
        var data = _repository.GetProduct(product.Id);

        if(data != null){
            
            var newName = data.Name == product.Name ? data.Name : product.Name;
            var newDescription = data.Description == product.Description ? data.Description : product.Description;
            var newBrand = data.Brand == product.Brand ? data.Brand : product.Brand;
            var newBuyPrice = data.BuyPrice == product.BuyPrice ? data.BuyPrice : product.BuyPrice;
            var newSellPrice = data.SellPrice == product.SellPrice ? data.SellPrice : product.SellPrice;

            var UpdateProduct = new Product(name: newName, description: newDescription, 
                                            brand:newBrand, buyPrice:newBuyPrice, sellPrice:newSellPrice);

            return await _repository.UpdateProduct(UpdateProduct, product.Id);
        } else {
            return "Produto não encontrado!";
        }
    }

}
