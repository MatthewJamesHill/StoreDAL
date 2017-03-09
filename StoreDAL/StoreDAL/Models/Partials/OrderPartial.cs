namespace StoreDAL.Models
{
    public partial class Order
    {
        public override string ToString()
        {
            return $"Order: {OrderId}\nCustomer: {Customer.FullName}";
        }
    }
}
