namespace QuickKartBL
{
    public class Category
    {
        public Category(int p_categoryId, string p_categoryName)
        {
            this.categoryId = p_categoryId;
            this.categoryName = p_categoryName;
        }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
    }
}