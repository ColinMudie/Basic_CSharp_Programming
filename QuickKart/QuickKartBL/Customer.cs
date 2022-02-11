using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        public Customer()
        {
        }

        public Customer(int p_customerId, string p_customerName, string p_address, DateTime p_dateOfBirth, string p_emailId, string p_gender, string p_password, string p_customerType)
        {
            this.customerId = p_customerId;
            this.customerName = p_customerName;
            this.address = p_address;
            this.dateOfBirth = p_dateOfBirth;
            this.emailId = p_emailId;
            this.gender = p_gender;
            this.password = p_password;
            this.customerType = p_customerType;
        }
        public string address { get; set; }
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string customerType { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string emailId { get; set; }
        public string gender { get; set; }
        public string password { get; set; }

        public double GetDiscount()
        {
            switch (this.customerType)
            {
                case "Privileged":
                    return 2;

                case "Regular":
                    return 5;

                case "Elite":
                    return 7;

                default:
                    return 0;
            }
        }

        public int CalculateAge()
        {
            int age = 0;
            age = Convert.ToInt32(DateTime.Now.Year - this.dateOfBirth.Year);
            Console.WriteLine("Calculation completed successfully");
            return age;
        }

    }
}
