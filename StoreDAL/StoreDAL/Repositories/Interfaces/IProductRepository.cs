using StoreDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDAL.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsMaxPrice(double maxPrice);
        IEnumerable<Product> GetProductsMinPrice(double minPrice);
        IEnumerable<Product> GetProductsInPriceRange(double minPrice, double maxPrice);
    }
}
