using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickKartBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickKartBL.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        [TestMethod()]
        public void HasCapitalLetterTest()
        {
            Validator test = new();
            bool result = test.HasCapitalLetter("Has Capital Letters");
            Assert.IsTrue(result);

            result = test.HasCapitalLetter("no capital letters");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void HasDigitTest()
        {
            Validator test = new();
            bool result = test.HasDigit("Test123");
            Assert.IsTrue(result);

            result = test.HasDigit("no numbers");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void HasLengthTest()
        {
            Validator test = new();
            // true
            bool result = test.HasLength("test123", 6, 10);
            Assert.IsTrue(result);

            // fail, below minimum
            result = test.HasLength("test", 6, 10);
            Assert.IsFalse(result);

            // fail, above maximum 
            result = test.HasLength("reall long string, like way too long", 6, 10);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void HasSmallLetterTest()
        {
            Validator test = new();
            bool result = test.HasSmallLetter("Has Small Letters");
            Assert.IsTrue(result);

            result = test.HasSmallLetter("NO SMALL LETTERS");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void HasSpecialCharacterTest()
        {
            Validator test = new();
            bool result = test.HasSpecialCharacter("Has $pecial Ch@racter!");
            Assert.IsTrue(result);

            result = test.HasSpecialCharacter("No special character");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsAlphabetTest()
        {
            Validator test = new();
            bool result = test.IsAlphabet("Is Alphabet");
            Assert.IsTrue(result);

            result = test.IsAlphabet("Not Only Alphabet 123!");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsAlphaNumericTest()
        {
            Validator test = new();
            bool result = test.IsAlphaNumeric("Is AlphaNumeric 123");
            Assert.IsTrue(result);

            result = test.IsAlphaNumeric("Not Only @lpha Numeric 123!!");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsEmailIdTest()
        {
            Validator test = new();
            bool result = test.IsEmailId("Username@test.com");
            Assert.IsTrue(result);

            result = test.IsEmailId("not a valid email 123 @");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsIntegerTest()
        {
            Validator test = new();
            bool result = test.IsInteger("123456");
            Assert.IsTrue(result);

            result = test.IsInteger("not only integers 123");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsNameTest()
        {
            Validator test = new();
            bool result = test.IsName("Liam Neeson");
            Assert.IsTrue(result);

            result = test.IsName("Cr@sh 0verride");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void IsNullOrEmptyTest()
        {
            Validator test = new();
            bool result = test.IsNullOrEmpty("");
            Assert.IsTrue(result);

            result = test.IsNullOrEmpty("     ");
            Assert.IsTrue(result);

            result = test.IsNullOrEmpty("Not Empty");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ValidateAgeTest()
        {
            Validator test = new();
            DateTime testDoB = new(2000, 01, 01);

            bool result = test.ValidateAge(testDoB, 18);
            Assert.IsTrue(result);

            result = test.ValidateAge(testDoB, 30);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ValidateAgeTestOverload1()
        {
            Validator test = new();
            DateTime testDoB = new(2000, 01, 01);

            bool result = test.ValidateAge(testDoB, 18, 30);
            Assert.IsTrue(result);

            // fail minimum
            result = test.ValidateAge(testDoB, 30, 32);
            Assert.IsFalse(result);

            // fail maximum
            result = test.ValidateAge(testDoB, 18, 20);
            Assert.IsFalse(result);
        }
    }
}