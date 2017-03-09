using StoreDAL.EF;
using StoreDAL.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StoreDAL.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext context) : base(context)
        {
        }
        
        public IEnumerable<Product> GetProductsMaxPrice(double maxPrice)
        {
            return StoreContext.Products.Where(p => p.Price <= maxPrice);
        }

        public IEnumerable<Product> GetProductsMinPrice(double minPrice)
        {
            return StoreContext.Products.Where(p => p.Price >= minPrice);
        }

        public IEnumerable<Product> GetProductsInPriceRange(double minPrice, double maxPrice)
        {
            return StoreContext.Products.Where(p => p.Price >= minPrice)
                                        .Where(p => p.Price <= maxPrice);
        }

        private StoreContext StoreContext
        {
            get { return Context as StoreContext; }
        }
    }
}
