namespace QuickKartBL
{
    public class Category
    {
        public Category(int p_categoryId, string p_categoryName)
        {
            this.CategoryId = p_categoryId;
            this.CategoryName = p_categoryName;
        }
        private int _categoryId;
        //private string _categoryName;

        public int CategoryId
        {
            get { return _categoryId; }
            set
            {
                if (value > 0)
                {
                    _categoryId = value;
                }
            }
        }

        public string CategoryName { get; set; }

        // ---- Indexer ----
        /*public object this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0:
                        this._categoryId = (int)value;
                        break;

                    case 1:
                        this._categoryName = value.ToString();
                        break;

                    default:
                        break;
                }
            }

            get
            {
                switch (index)
                {
                    case 0:
                        return this._categoryId;

                    case 1:
                        return this._categoryName;

                    default:
                        return 0;
                }
            }
        }*/
    }
}