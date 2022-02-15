using Microsoft.VisualStudio.TestTools.UnitTesting;
using Corporate_Training_Center;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corporate_Training_Center.Tests
{
    [TestClass()]
    public class TraineeTests
    {
        [TestMethod()]
        public void CalculateScoreTest()
        {

            Trainee test = new Trainee(new string[] { "SQL", "C#" }, new float[] { 85, 95, 93 });
            float percentage;
            char grade;
            string message;


            test.CalculateScore(out percentage, out grade, out message);
            Assert.AreEqual(91, percentage);
            Assert.AreEqual('A', grade);
            Assert.AreEqual("Qualified", message);

            //retest 
            test.CalculateScore(out percentage, out grade, out message, true);
            Assert.AreEqual(81, percentage);
            Assert.AreEqual('B', grade);
            Assert.AreEqual("Qualified", message);

            // b - qualified
            test = new Trainee(new string[] { "SQL", "C#" }, new float[] { 75, 76, 77 });
            test.CalculateScore(out percentage, out grade, out message);
            Assert.AreEqual(76, percentage);
            Assert.AreEqual('B', grade);
            Assert.AreEqual("Qualified", message);

            // c - qualified
            test = new Trainee(new string[] { "SQL", "C#" }, new float[] { 50, 51, 52 });
            test.CalculateScore(out percentage, out grade, out message);
            Assert.AreEqual(51, percentage);
            Assert.AreEqual('C', grade);
            Assert.AreEqual("Qualified", message);

            // c - not qualifies
            test = new Trainee(new string[] { "SQL", "C#" }, new float[] { 40, 35, 24 });
            test.CalculateScore(out percentage, out grade, out message);
            Assert.AreEqual(33, percentage);
            Assert.AreEqual('C', grade);
            Assert.AreEqual("Not Qualified", message);

            

            
        }
    }
}