using Microsoft.VisualStudio.TestTools.UnitTesting;
using Corporada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporada.Tests
{
    [TestClass()]
    public class LoanCalculationTests
    {
        [TestMethod()]
        public void ApplyForLoanTest()
        {
            LoanCalculation test = new LoanCalculation();
            int loanAmount;
            int interest;
            bool result = test.ApplyForLoan(10000, out loanAmount, out interest, "Passport", "Drivers License");
            Assert.IsTrue(result);
            Assert.AreEqual(25000, loanAmount);
            Assert.AreEqual(4, interest);

            result = test.ApplyForLoan(13000, out loanAmount, out interest, "Passport", "Drivers License");
            Assert.IsTrue(result);
            Assert.AreEqual(50000, loanAmount);
            Assert.AreEqual(6, interest);

            result = test.ApplyForLoan(55000, out loanAmount, out interest, "Passport", "Drivers License");
            Assert.IsTrue(result);
            Assert.AreEqual(100000, loanAmount);
            Assert.AreEqual(8, interest);

            result = test.ApplyForLoan(10000, out loanAmount, out interest, "library card", "Drivers License");
            Assert.IsFalse(result);

            result = test.ApplyForLoan(10000, out loanAmount, out interest, "Passport");
            Assert.IsFalse(result);


        }

        [TestMethod()]
        public void Emi_DiscountTest()
        {
            LoanCalculation test = new LoanCalculation();
            int loanAmount;
            int interest;
            test.ApplyForLoan(10000, out loanAmount, out interest, "Passport", "Drivers License");
            int emi;
            test.Emi_Discount(loanAmount, 1, 2, interest, out emi);

            Assert.AreEqual(23400, emi);

        }

        [TestMethod()]
        public void SalaryDeductionTest()
        {
            LoanCalculation test = new LoanCalculation();
            int loanAmount;
            int interest;
            float salary = 10000;
            bool result = test.ApplyForLoan(salary, out loanAmount, out interest, "Passport", "Drivers License");
            int emi;
            test.SalaryDeduction(ref salary, 1, loanAmount, 2, interest, out emi);
            Assert.AreEqual(25000, salary);
            Assert.AreEqual(23400, emi);
        }

        
    }
}