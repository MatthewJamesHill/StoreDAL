using StoreDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDAL.UoW
{
    interface IUnitofWork
    {
        ICustomerRepository Customers { get; }
        IOrderRepository Orders { get; }
        IProductRepository Products { get; }

        void UpdateDatabase();
    }
}
