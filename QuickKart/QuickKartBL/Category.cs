namespace QuickKartBL
{
    public class Category
    {
        public Category(int p_categoryId, string p_categoryName)
        {
            this.p_categoryId = p_categoryId;
            this.p_categoryName = p_categoryName;
        }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }
}