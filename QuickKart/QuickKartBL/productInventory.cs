namespace QuickKartBL
{
    public class ProductInventory
    {
        public ProductInventory(int p_inventoryId, int p_quantityInHand)
        {
            this.InventoryId = p_inventoryId;
            this.QuantityInHand = p_quantityInHand;
        }
        public int InventoryId { get; set; }
        public int QuantityInHand { get; set; }
    }
}