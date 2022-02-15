using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporada
{
    public class LoanCalculation
    {
        public LoanCalculation()
        {
        }

        public bool ApplyForLoan(float salary, out int loanAmount, out int interest, params string[] doc)
        {
            if(doc.Length > 1 && doc.Contains("Passport"))
            {
                if (salary < 12000)
                {
                    loanAmount = 25000;
                    interest = 4;
                }
                else if (salary >= 12000 && salary <= 50000)
                {
                    loanAmount = 50000;
                    interest = 6;
                }
                else
                {
                    loanAmount = 100000;
                    interest = 8;
                }
                return true;
            }

            loanAmount = 0;
            interest = 0;
            return false;
        }

        public void Emi_Discount(int loanAmount, int relativeMarking, int tenure, int interest, out int emi)
        {
            emi = (loanAmount + (loanAmount * interest / 100));
            int discount;
            switch (relativeMarking)
            {
                case 1:
                    discount = 10;
                    break;

                case 2:
                    discount = 8;
                    break;

                case 3:
                    discount = 6;
                    break;

                default:
                    discount = 4;
                    break;
            }
            emi -= emi * discount / 100;
        }

        public void SalaryDeduction(ref float salary, int relativeMarking, int loanAmount, int tenure, int interest, out int emi)
        {
            this.Emi_Discount(loanAmount, relativeMarking, tenure, interest, out emi);
            salary -= emi;
        }
    }
}
