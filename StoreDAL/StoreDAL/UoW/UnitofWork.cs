using StoreDAL.EF;
using StoreDAL.Models;
using StoreDAL.Repositories;
using System;

namespace StoreDAL.UoW
{
    public class UnitofWork : IUnitofWork, IDisposable
    {
        private StoreContext _storeContext = new StoreContext();

        public ICustomerRepository Customers => throw new NotImplementedException();

        public IOrderRepository Orders => throw new NotImplementedException();

        public IProductRepository Products => throw new NotImplementedException();

        public void UpdateDatabase()
        {
            throw new NotImplementedException();
        }

        //TODO: Implement IDisposable
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UnitofWork() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
