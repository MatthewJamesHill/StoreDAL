using System.ComponentModel.DataAnnotations;

namespace StoreDAL.Models
{
    public partial class Product
    {
        [Key]
        public int SKU { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
