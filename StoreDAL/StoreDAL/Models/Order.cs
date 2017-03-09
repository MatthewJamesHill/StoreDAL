using System.Collections.Generic;

namespace StoreDAL.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public List<Product> Products { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
