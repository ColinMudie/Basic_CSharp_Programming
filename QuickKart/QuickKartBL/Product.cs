using System;

namespace QuickKartBL
{
    public class Product
    {
        static Product()
        {
            currentProductId = 100;
        }
        public Product( string p_productName, string p_description, double p_price, int p_quantityAvailable)
        {
            this.ProductId = $"P{++currentProductId}";
            this.ProductName = p_productName;
            this.Description = p_description;
            this.Price = p_price;
            this.QuantityAvailable = p_quantityAvailable;
        }
        private static int currentProductId;
        public int QuantityAvailable { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        public bool CheckAvailability(int quantityPurchased)
        {
            return (quantityPurchased <= this.QuantityAvailable);
        }

        public string UpdateDiscount(ref int discount, out int min, out int max)
        {
            string result = "Eligible for discount";
            if (this.Price <= 500)
            {
                min = 1;
                max = 500;
                result = "Not eligible for discount";
            }
            else if (this.Price > 500 && this.Price <= 1000)
            {
                discount = 5;
                min = 501;
                max = 1000;
            }
            else if (this.Price > 1000 && this.Price <= 5000)
            {
                discount = 10;
                min = 1001;
                max = 5000;
            }
            else if (this.Price > 5000 && this.Price <= 10000)
            {
                discount = 15;
                min = 5001;
                max = 10000;
            }
            else
            {
                discount = 20;
                min = 10001;
                max = Int32.MaxValue;
            }
            return result;
        }


    }
}