namespace QuickKartBL
{
    public class Seller
    {
        public Seller(string p_sellerId, string p_sellerName)
        {
            this.SellerId = p_sellerId;
            this.SellerName = p_sellerName;
        }

        public string SellerId { get; set; }
        public string SellerName { get; set; }
    }
}