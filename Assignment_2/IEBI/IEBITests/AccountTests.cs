using Microsoft.VisualStudio.TestTools.UnitTesting;
using IEBI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEBI.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]

        public void CtorTest()
        {
            Account testA = new Account();
            Account testB = new Account();
            Assert.AreEqual(testA.AccountNo, testB.AccountNo);
        }

        // The constructor should initialize the ‘accountNo’ and ‘balance’
        // member variables with appropriate values
        [TestMethod()]
        public void Ctor2ParamsTest()
        {
            long accNum = 10;
            double balance = 5.27;
            Account test = new Account(accNum, balance);
            Assert.AreEqual(accNum, test.AccountNo);
            Assert.AreEqual(balance, test.Balance);
        }

        // The constructor should initialize ‘payees’ and ‘payeesAccount’
        // member variables. ‘accountNo’ and ‘balance’ member variables
        // should be initialized by calling the appropriate constructor
        [TestMethod()]
        public void Ctor4ParamsTest()
        {
            long accNum = 10;
            double balance = 5.27;
            string[] payees = { "billy", "bob", "person" };
            long[] payeesAcc = { 9, 10, 11 };
            Account test = new Account(accNum, balance, payees, payeesAcc);
            Assert.AreEqual(accNum, test.AccountNo);
            Assert.AreEqual(balance, test.Balance);
            Assert.AreEqual(payees, test.Payees);
            Assert.AreEqual(payeesAcc, test.PayeesAccount);
        }

        // This method debits the amount from user’s account only if the
        // amount is less than or equal to balance and returns 1 on success

        // If there is no sufficient balance, the method should return 0
        [TestMethod()]
        public void DebitAmountTest()
        {
            long accNum = 10;
            double balance = 5.27;
            Account test = new Account(accNum, balance);

            int result = test.DebitAmount(4.01);
            Assert.AreEqual(1, result);
            Assert.AreEqual(5.27 - 4.01, test.Balance);

            result = test.DebitAmount(20.00);
            Assert.AreEqual(0, result);
        }

        // Check if the payee’s account number is present
        // in the available payees’ account list

        // Call ‘DebitAmount’ method if the payee’s
        // account number is present and return the return
        // value of the DebitAmount method

        // Return -1 if the account number is not present in the
        // available payees’ account list
        [TestMethod()]
        public void TransferMoneyAccountNumberTest()
        {
            long accNum = 10;
            double balance = 5.27;
            string[] payees = { "billy", "bob", "person" };
            long[] payeesAcc = { 9, 10, 11 };
            Account test = new Account(accNum, balance, payees, payeesAcc);

            // match and correct amt - pass
            int result = test.TransferMoney(9, 4.00);
            Assert.AreEqual(1, result);
            Assert.AreEqual(5.27 - 4.00, test.Balance);

            // match and incorrect amt - fail
            test = new Account(accNum, balance, payees, payeesAcc);
            result = test.TransferMoney(9, 20.00);
            Assert.AreEqual(0, result);
            Assert.AreEqual(5.27, test.Balance);

            // incorrect match - fail
            test = new Account(accNum, balance, payees, payeesAcc);
            result = test.TransferMoney(4, 4.00);
            Assert.AreEqual(-1, result);
            Assert.AreEqual(5.27, test.Balance);
        }

        // Check if nickName is present in the available payees’ list

        // Call ‘DebitAmount’ method if the payee’s name is
        // present and return the return value of the DebitAmount method

        // Return -1 if the name is not present in the
        // available payees’ name list
        [TestMethod()]
        public void TransferMoneyNicknameTest()
        {
            long accNum = 10;
            double balance = 5.27;
            string[] payees = { "billy", "bob", "person" };
            long[] payeesAcc = { 9, 10, 11 };
            Account test = new Account(accNum, balance, payees, payeesAcc);

            // match and correct amt - pass
            int result = test.TransferMoney("billy", 4.00);
            Assert.AreEqual(1, result);
            Assert.AreEqual(5.27 - 4.00, test.Balance);

            // match and incorrect amt - fail
            test = new Account(accNum, balance, payees, payeesAcc);
            result = test.TransferMoney("billy", 20.00);
            Assert.AreEqual(0, result);
            Assert.AreEqual(5.27, test.Balance);

            // incorrect match - fail
            test = new Account(accNum, balance, payees, payeesAcc);
            result = test.TransferMoney("not match", 4.00);
            Assert.AreEqual(-1, result);
            Assert.AreEqual(5.27, test.Balance);
        }
    }
}