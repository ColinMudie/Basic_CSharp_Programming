namespace QuickKartBL
{
    public class productInventory
    {
        public productInventory(int p_inventoryId, int p_quantityInHand)
        {
            this.p_inventoryId = p_inventoryId;
            this.p_quantityInHand = p_quantityInHand;
        }
        public int inventoryId { get; set; }
        public int quantityInHand { get; set; }
    }
}