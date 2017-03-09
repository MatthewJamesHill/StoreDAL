using StoreDAL.EF;
using StoreDAL.Models;
using Microsoft.EntityFrameworkCore;

namespace StoreDAL.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context)
        {
        }

        private StoreContext StoreContext
        {
            get { return Context as StoreContext; }
        }
    }
}
