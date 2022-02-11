namespace QuickKartBL
{
    public class Product
    {
        public Product(string p_productId, string p_productName, string p_description, double p_price, int p_quantityAvailable)
        {
            this.productId = p_productId;
            this.productName = p_productName;
            this.description = p_description;
            this.price = p_price;
            this.quantityAvailable = p_quantityAvailable;
        }
        public int quantityAvailable { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string productId { get; set; }
        public string productName { get; set; }

        public bool CheckAvailability(int quantityPurchased)
        {
            return (quantityPurchased <= this.quantityAvailable);
        }
    }
}