using StoreDAL.EF;
using StoreDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace StoreDAL.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext context) : base(context)
        {
        }

        private StoreContext StoreContext
        {
            get { return Context as StoreContext; }
        }
    }
}
