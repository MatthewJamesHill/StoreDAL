using StoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDAL.UOW
{
    interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }

        int SaveChanges();
    }
}
