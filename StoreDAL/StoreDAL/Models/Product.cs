using System.ComponentModel.DataAnnotations;

namespace StoreDAL.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
