using System;
using System.Linq;

namespace PurpleHardware;
    public class ProductRepository: IProductRepository
    {
        private readonly ApiContext _context;
        public ProductRepository(ApiContext context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
