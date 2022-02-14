using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL
{
    public class Customer
    {
        static Customer()
        {
            currentValueForCustomerId = 1000;
        }

        public Customer(string p_customerName, string p_address, DateTime p_dateOfBirth, string p_emailId, string p_gender, string p_password, string p_customerType, CustomerCardType p_cardType)
        {
            this.CustomerId = ++currentValueForCustomerId;
            this.CustomerName = p_customerName;
            this.Address = p_address;
            this.DateOfBirth = p_dateOfBirth;
            this.EmailId = p_emailId;
            this.Gender = p_gender;
            this.Password = p_password;
            this.CustomerType = p_customerType;
            this.CardType = p_cardType;
        }
        private static int currentValueForCustomerId;
        public string Address { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerType { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailId { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public CustomerCardType CardType { get; set; }
        public long[] CustomerContact { get; set; }


        public double GetDiscount()
        {
            switch (this.CustomerType)
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
            int age = Convert.ToInt32(DateTime.Now.Year - this.DateOfBirth.Year);
            Console.WriteLine("Calculation completed successfully");
            return age;
        }
        public void AddContactDetails(string emailId, params long[] customerContact)
        {
            this.EmailId = emailId;
            this.CustomerContact = customerContact;
        }
    }
}
