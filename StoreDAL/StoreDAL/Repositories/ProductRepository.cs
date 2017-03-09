using StoreDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            return Context.Set<Product>().Where(p => p.Price <= maxPrice);
        }

        public IEnumerable<Product> GetProductsMinPrice(double minPrice)
        {
            return Context.Set<Product>().Where(p => p.Price >= minPrice);
        }

        public IEnumerable<Product> GetProductsInPriceRange(double minPrice, double maxPrice)
        {
            return Context.Set<Product>().Where(p => p.Price >= minPrice)
                                         .Where(p => p.Price <= maxPrice);
        }
    }
}
