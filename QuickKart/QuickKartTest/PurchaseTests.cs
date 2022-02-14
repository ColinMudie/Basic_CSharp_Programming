using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickKartBL;

namespace QuickKartTest
{
    [TestClass]
    public class ProductTests
    {
        [TestMethod]
        public void ProductTest()
        {
            Product _obj1 = new ("Motorola G3 Turbo", "new phone", 18000, 3);
            Product _obj2 = new ("Nike Shoes", "new pair of shoes", 2500, 3);
            Assert.AreNotSame(_obj1, _obj2);
        }

        [TestMethod()]
        public void CheckAvailabilityTest()
        {
            // Test 1
            Product _target = new ("Motorola G3 Turbo", "new phone", 18000, 3);
            int quantityPurchased = 10;
            bool actual = _target.CheckAvailability(quantityPurchased);
            Assert.AreEqual(false, actual);

            // Test 2
            _target = new ("Motorola G3 Turbo", "new phone", 18000, 3);
            quantityPurchased = 2;
            actual = _target.CheckAvailability(quantityPurchased);
            Assert.AreEqual(true, actual);
        }
    }
}
