namespace QuickKartBL
{
    public class Product
    {
        public Product(string p_productId, string p_productName, string p_description, double p_price)
        {
            this.productId = p_productId;
            this.productName = p_productName;
            this.description = p_description;
            this.price = p_price;
        }

        public string description { get; set; }
        public double price { get; set; }
        public string productId { get; set; }
        public string productName { get; set; }
    }
}