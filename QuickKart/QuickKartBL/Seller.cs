namespace QuickKartBL
{
    public class Seller
    {
        static Seller()
        {
            sellerIdCount = 1000;
        }

        public Seller(string p_sellerName)
        {
            this.SellerId = $"S{++sellerIdCount}";
            this.SellerName = p_sellerName;
        }
        public Seller(int p_maxSize)
        {
            this.SellerLocations = new string[p_maxSize];
        }
        private static int sellerIdCount;
        public string SellerId { get; set; }
        public string SellerName { get; set; }

        public string[] SellerLocations { get; set; }

        public bool AddLocations(params string[] p_sellerLocations)
        {
            if (p_sellerLocations.Length > 0)
            {
                for (int i = 0; i < p_sellerLocations.Length; i++)
                {
                    this.SellerLocations[i] = p_sellerLocations[i];
                }
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}