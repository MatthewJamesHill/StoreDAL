using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDAL.Models
{
    public partial class Customer
    {
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{CustomerId}: {FullName}";
        }
    }
}
