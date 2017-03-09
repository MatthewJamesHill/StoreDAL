namespace StoreDAL.Models
{
    public partial class Product
    {
        public override string ToString()
        {
            return $"Name: {Name}\nSKU: {SKU}\nPrice: £{Price}";
        }
    }
}
