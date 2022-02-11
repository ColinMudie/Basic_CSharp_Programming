namespace QuickKartBL
{
    public class Seller
    {
        public Seller(string p_sellerId, string p_sellerName)
        {
            this.sellerId = p_sellerId;
            this.sellerName = p_sellerName;
        }

        public string sellerId { get; set; }
        public string sellerName { get; set; }
    }
}