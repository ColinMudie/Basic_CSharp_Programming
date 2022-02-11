namespace QuickKartBL
{
    public class productInventory
    {
        public productInventory(int p_inventoryId, int p_quantityInHand)
        {
            this.inventoryId = p_inventoryId;
            this.quantityInHand = p_quantityInHand;
        }
        public int inventoryId { get; set; }
        public int quantityInHand { get; set; }
    }
}