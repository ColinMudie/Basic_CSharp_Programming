using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickKartBL;
using System;

namespace QuickKartTest
{
    [TestClass]
    public class PurchaseTests

    {
        [TestMethod]
        public void PurchaseTest()
        {
            Purchase _obj1 = new ("P101", 1, "112 Streets st.", DateTime.Now, "Credit Card");
            Purchase _obj2 = new ("P102", 2, "113 Never st.", DateTime.Now, "Credit Card");
            Assert.AreNotSame(_obj1, _obj2);
        }

        [TestMethod()]
        public void CheckAvailabilityTest()
        {
            Purchase _target = new ("P101", 3, "112 Streets st.", DateTime.Now, "Credit Card");
            
            // Test 1
            double actual = _target.CalculateBillAmount(2690.0, 3);
            Assert.AreEqual(7827.9, actual);

            // Test 2
            actual = _target.CalculateBillAmount(-2690.0, 3);
            Assert.AreEqual(-7827.9, actual);

            // Test 3
            actual = _target.CalculateBillAmount(0, 0);
            Assert.AreEqual(0, actual);
        }
    }
}
