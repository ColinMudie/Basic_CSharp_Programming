using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Purchase
    {
        public Purchase(string p_purchaseId, int p_quantityOrdered, string p_shippingAddress, DateTime p_dateOfPurchase, string p_paymentType)
        {
            this.PurchaseId = p_purchaseId;
            this.QuantityOrdered = p_quantityOrdered;
            this.ShippingAddress = p_shippingAddress;
            this.DateOfPurchase = p_dateOfPurchase;
            this.PaymentType = p_paymentType;
        }

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
    }
}
