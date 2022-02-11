namespace QuickKartBL
{
    public class Product
    {
        public Product(string p_productId, string p_productName, string p_description, double p_price, int p_quantityAvailable)
        {
            this.ProductId = p_productId;
            this.ProductName = p_productName;
            this.Description = p_description;
            this.Price = p_price;
            this.QuantityAvailable = p_quantityAvailable;
        }
        public int QuantityAvailable { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        public bool CheckAvailability(int quantityPurchased)
        {
            return (quantityPurchased <= this.QuantityAvailable);
        }
    }
}