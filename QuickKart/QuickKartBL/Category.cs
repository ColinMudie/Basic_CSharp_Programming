namespace QuickKartBL
{
    public class Category
    {
        public Category(int p_categoryId, string p_categoryName)
        {
            this.CategoryId = p_categoryId;
            this.CategoryName = p_categoryName;
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}