using QuickKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuickKartTestApp
{
    public class Program
    {
        static void Main()
        {
            Cart shoppingCart = new Cart();
            shoppingCart.DisplayItems();

            Customer custObj = new Customer(101, "Peter", "Street 5, Old Woodside Drive, New York",
                                            new DateTime(1990, 11, 09), "peter@gmail.com", "Male", "Peter@123", "Privileged", CustomerCardType.Platinum);
            Console.WriteLine("Hi " + custObj.CustomerName + ", your age is " + custObj.CalculateAge());

            CustomerDateOfBirth cust;
            cust.custDoBDate = 01;
            cust.custDoBMonth = 08;
            cust.custDoBYear = 1995;
        }
    }
}
