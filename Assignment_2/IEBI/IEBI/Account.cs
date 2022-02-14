using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEBI
{
    public class Account
    {
        public long AccountNo { get; set; }
        public double Balance { get; set; }
        public string[] Payees { get; set; }
        public long[] PayeesAccount { get; set; }

        public Account()
        {
        }

        public Account(long p_accountNo, double p_balance)
        {
            this.AccountNo = p_accountNo;
            this.Balance = p_balance;
        }

        public Account(long p_accountNo, double p_balance, string[] p_payees, long[] p_payeesAccount)
        {
            this.AccountNo = p_accountNo;
            this.Balance = p_balance;
            this.Payees = p_payees;
            this.PayeesAccount = p_payeesAccount;
        }

        public int DebitAmount(double p_amount)
        {
            if (p_amount <= this.Balance)
            {
                this.Balance -= p_amount;
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int TransferMoney(long p_payeeAccountNo, double p_amount)
        {
            foreach(long acc in this.PayeesAccount)
            {
                if (acc == p_payeeAccountNo)
                {
                    return DebitAmount(p_amount);
                }
            }
            return -1;
        }

        public int TransferMoney(string p_nickname, double p_amount)
        {
            foreach (string nickname in this.Payees)
            {
                if (nickname == p_nickname)
                {
                    return DebitAmount(p_amount);
                }
            }
            return -1;
        }
    }
}
