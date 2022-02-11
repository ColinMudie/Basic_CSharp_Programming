using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    class Purchase
    {
        public Purchase(string p_purchaseId, int p_quantityOrdered, string p_shippingAddress, DateTime p_dateOfPurchase, string p_paymentType)
        {
            this.purchaseId = p_purchaseId;
            this.quantityOrdered = p_quantityOrdered;
            this.shippingAddress = p_shippingAddress;
            this.dateOfPurchase = p_dateOfPurchase;
            this.paymentType = p_paymentType;
        }

        public DateTime dateOfPurchase { get; set; }
        public string paymentType { get; set; }
        public string purchaseId { get; set; }
        public int quantityOrdered { get; set; }
        public string shippingAddress { get; set; }

        public double CalculateBillAmount(double p_price)
        {
            double total = this.quantityOrdered * p_price;
            return total;
        }
    }
}
