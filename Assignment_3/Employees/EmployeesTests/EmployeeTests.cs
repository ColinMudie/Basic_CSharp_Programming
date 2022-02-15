using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        [TestMethod()]
        public void EmployeeCtor3Test()
        {
            DateTime testDate = new DateTime(2000, 1, 1);
            Employee test = new Employee("Gon", testDate, true);
            Assert.AreEqual("Gon", test.EmployeeName);
            Assert.AreEqual(testDate, test.DateOfBirth);
            Assert.AreEqual(true, test.Gender);
        }

        [TestMethod()]
        public void EmployeeCtor4Test()
        {
            DateTime testDate = new DateTime(2000, 1, 1);
            Employee test = new Employee("Gon", testDate, true, 2);
            Assert.AreEqual("Gon", test.EmployeeName);
            Assert.AreEqual(testDate, test.DateOfBirth);
            Assert.AreEqual(true, test.Gender);
            Assert.AreEqual(2, test.NumberOfDependents);

            test = new Employee("Gon", testDate, true, -2);
            Assert.AreEqual(0, test.NumberOfDependents);

            test = new Employee("Gon", testDate, true, 12);
            Assert.AreEqual(3, test.NumberOfDependents);
        }

        [TestMethod()]
        public void UpdateDependentsTest()
        {
            DateTime testDate = new DateTime(2000, 1, 1);
            Employee test = new Employee("Gon", testDate, true, 2);
            test.AddDependent("Name");

            bool result = test.UpdateDependents("Updated", 1);
            Assert.IsTrue(test.Dependents.Contains("Updated"));
            Assert.AreEqual(true, result);

            // dependent id out of reach
            test = new Employee("Gon", testDate, true, 3);
            test.AddDependent("Name");
            result = test.UpdateDependents("fail", 3);
            Assert.AreEqual(false, result);
        }
        
        [TestMethod()]
        public void AddDependentTest()
        {
            DateTime testDate = new DateTime(2000, 1, 1);
            Employee test = new Employee("Gon", testDate, true, 2);

            int result = test.AddDependent("Name");
            Assert.IsTrue(test.Dependents.Contains("Name"));
            Assert.AreEqual(3, result);

            // 3 dependents already used up
            test = new Employee("Gon", testDate, true, 3);
            result = test.AddDependent("Name");
            Assert.AreEqual(0, result);
        }
    }
}