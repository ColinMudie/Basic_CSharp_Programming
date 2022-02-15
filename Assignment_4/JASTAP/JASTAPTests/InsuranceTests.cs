using Microsoft.VisualStudio.TestTools.UnitTesting;
using JASTAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JASTAP.Tests
{
    [TestClass()]
    public class InsuranceTests
    {
        [TestMethod()]
        public void CheckEligibilityTest()
        {
            // should pass
            Insurance test = new Insurance("David", 50000, 23, new string[]{"doc1.pdf", "doc2.pdf" });
            bool result = test.CheckEligibility();
            Assert.IsTrue(result);

            // should pass
            test = new Insurance("Kyle", 40000, 32, new string[] { "doc1.pdf", "doc2.pdf" });
            result = test.CheckEligibility();
            Assert.IsTrue(result);

            // fail less than 18 age.
            test = new Insurance("David", 50000, 17, new string[] { "doc1.pdf", "doc2.pdf" });
            result = test.CheckEligibility();
            Assert.IsFalse(result);

            // fail credit above 60,000 when age 18 > x >= 30
            test = new Insurance("David", 70000, 23, new string[] { "doc1.pdf", "doc2.pdf" });
            result = test.CheckEligibility();
            Assert.IsFalse(result);

            // fail credit above 45,000 when age > 30
            test = new Insurance("David", 50000, 31, new string[] { "doc1.pdf", "doc2.pdf" });
            result = test.CheckEligibility();
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CheckDocumentsTest()
        {
            Insurance test = new Insurance("David", 50000, 23, new string[] { "doc1.pdf", "doc2.pdf" });
            bool result = test.CheckDocuments(new string[] { "document.pdf", "doc2.pdf" });
            Assert.IsTrue(result);

            // doc doesnt match
            test = new Insurance("David", 50000, 23, new string[] { "doc1.pdf", "doc2.pdf" });
            result = test.CheckDocuments(new string[] { "document.pdf", "ddocument2.pdf" });
            Assert.IsFalse(result);

            // eligibility failed
            test = new Insurance("David", 80000, 23, new string[] { "doc1.pdf", "doc2.pdf" });
            result = test.CheckDocuments(new string[] { "document.pdf", "doc2.pdf" });
            Assert.IsFalse(result);
        }
    }
}