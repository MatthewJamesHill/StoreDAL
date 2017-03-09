using StoreDAL.EF;
using StoreDAL.Models;
using StoreDAL.Repositories;
using System;

namespace StoreDAL.UOW
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly StoreContext _storeContext;

        public UnitOfWork(StoreContext storeContext)
        {
            _storeContext = storeContext;
            Customers = new CustomerRepository(_storeContext);
            Orders = new OrderRepository(_storeContext);
            Products = new ProductRepository(_storeContext);
        }

        public ICustomerRepository Customers { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IProductRepository Products { get; private set; }

        public int SaveChanges()
        {
            return _storeContext.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _storeContext.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion
    }
}
