using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Purchase
    {
        static Purchase()
        {
            purchaseCounter = 1000;
        }

        public Purchase( int p_quantityOrdered, string p_shippingAddress, DateTime p_dateOfPurchase, string p_paymentType)
        {
            this.PurchaseId = $"B{++purchaseCounter}";
            this.QuantityOrdered = p_quantityOrdered;
            this.ShippingAddress = p_shippingAddress;
            this.DateOfPurchase = p_dateOfPurchase;
            this.PaymentType = p_paymentType;
        }
        private static int purchaseCounter;

        public DateTime DateOfPurchase { get; set; }
        public string PaymentType { get; set; }
        public string PurchaseId { get; set; }
        public int QuantityOrdered { get; set; }
        public string ShippingAddress { get; set; }

        public double CalculateBillAmount(double p_price)
        {
            return this.QuantityOrdered * p_price;
        }

        public double CalculateBillAmount(double p_price, double p_discountPercentage)
        {
            double amount = CalculateBillAmount(p_price);
            amount -= (amount * (p_discountPercentage / 100));
            return amount;
        }

        /// <summary>
        /// This method returns the amount rounded up to two decimal places.
        /// </summary>
        /// <param name="p_amount">amount needing to be rounded</param>
        /// <returns>result rounded to up to 2 decimal places</returns>
        public static double RoundOffBill(double p_amount)
        {
            return Math.Ceiling(p_amount * 100) / 100;
        }

        /// <summary>
        /// Calculate the purchase percentage for the ‘dateForReport’ 
        /// passed as a parameter using the formula: 
        /// Purchase percentage = No. of purchases made on the particular 
        /// date / Total no. of purchases *100
        /// </summary>
        /// <param name="p_transactionDates">an array of all those dates on which purchases have been made</param>
        /// <param name="p_dateForReport"></param>
        /// <returns>purchase percentage.</returns>
        public static double GetPurchasePercentage(DateTime[] p_transactionDates, DateTime p_dateForReport)
        {
            return p_transactionDates.Where(x => x.Date == p_dateForReport.Date).Count() / p_transactionDates.Count() * 100;   
        }
    }
}
