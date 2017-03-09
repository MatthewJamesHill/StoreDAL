using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreDAL.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public List<Product> Products { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
