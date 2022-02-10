namespace QuickKartBL
{
    public class Seller
    {
        public Seller(string p_sellerId, string p_sellerName)
        {
            this.p_sellerId = p_sellerId;
            this.p_sellerName = p_sellerName;
        }

        public string sellerId { get; set; }
        public string sellerName { get; set; }
    }
}