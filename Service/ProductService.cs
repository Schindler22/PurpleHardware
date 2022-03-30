namespace PurpleHardware;
    public class ProductService: IProductService
    {
        private readonly IProductRepository _repository;
        
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _repository.GetProducts();
        }

        public async Task<string> NewProduct(Product product)
        {
            return await _repository.NewProduct(product);
        }

        public async Task<string> DeleteProduct(int id)
        {
            return await _repository.DeleteProduct(id);
        }

        public async Task<string> UpdateProduct(Product product)
        {
            var data = _repository.GetProduct(product.Id);

            if(data != null){

                var newName = data.Result.Name == product.Name ? data.Result.Name : product.Name;
                var newDescription = data.Result.Description == product.Description ? data.Result.Description : product.Description;
                var newBrand = data.Result.Brand == product.Brand ? data.Result.Brand : product.Brand;
                var newBuyPrice = data.Result.BuyPrice == product.BuyPrice ? data.Result.BuyPrice : product.BuyPrice;
                var newSellPrice = data.Result.SellPrice == product.SellPrice ? data.Result.SellPrice : product.SellPrice;

                var UpdateProduct = new Product(name: newName, description: newDescription, 
                                                brand:newBrand, buyPrice:newBuyPrice, sellPrice:newSellPrice);

                await _repository.UpdateProduct(UpdateProduct, product.Id);
                return "Produto atualizado com sucesso!";
            } else {
                return "Produto não encontrado!";
            }
        }

}
