using System.ComponentModel.DataAnnotations;

namespace StoreDAL.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Postcode { get; set; }

        [Timestamp]
        public byte[] Timestamp { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
