using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechWorldBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechWorldBL.Tests
{
    [TestClass()]
    public class InstructorTests
    {
        [TestMethod()]
        public void CheckSkillTest()
        {
            Instructor _instructor1 = new Instructor("Colin", 5, 3, new string[]{ "SQL", "C#", "Angular"});

            // Test 1
            bool result = _instructor1.CheckSkill("SQL");
            Assert.IsTrue(result);

            // Test 2
            result = _instructor1.CheckSkill("Jenkins");
            Assert.IsFalse(result);

            // Test 3 - should check eligibility
            _instructor1 = new Instructor("Bad Trainer", 1, 2, new string[] { "SQL", "C#", "Angular" });
            result = _instructor1.CheckSkill("SQL");
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ValidateEligibilityTest()
        {
            // Test 1
            Instructor _instructor1 = new Instructor("Colin", 5, 3, new string[] { "SQL", "C#", "Angular" });
            bool result = _instructor1.ValidateEligibility();
            Assert.IsTrue(result);

            // Test 2
            _instructor1 = new Instructor("Bad Trainer", 1, 2, new string[] { "Word", "Excel" });
            result = _instructor1.ValidateEligibility();
            Assert.IsFalse(result);

            


        }

        [TestMethod()]
        public void InstructorTest()
        {
            Instructor _instructor1 = new Instructor("Colin", 5, 3, new string[] { "SQL", "C#", "Angular" });
            Instructor _instructor2 = new Instructor("Carl", 7, 4, new string[] { "Java", "React", "Spring" });
            Assert.AreNotEqual(_instructor1, _instructor2);
        }
    }
}