using Microsoft.VisualStudio.TestTools.UnitTesting;
using WWE_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE_Game.Tests
{
    [TestClass()]
    public class PlayerTests
    {

        [TestMethod()]
        public void CalculateScoreTest()
        {
            Player test = new Player("no1", "BoneSaw", 82, 200);
            string reward;
            test.CalculateScore(out reward, 1, 1, 2, false);
            Assert.AreEqual("NA", reward);

        }

        [TestMethod()]
        public void DetermineRewardTest()
        {
            Player test = new Player("no1", "BoneSaw", 82, 200);
            string reward;
            test.CalculateScore(out reward, 80, 1);
            string result = test.DetermineReward();
            Assert.AreEqual("Cash_Coupon", result);


            test.CalculateScore(out reward, 20, 1);
            result = test.DetermineReward();
            Assert.AreEqual("Extra_Chance", result);

            test.CalculateScore(out reward, 10, 1);
            result = test.DetermineReward();
            Assert.AreEqual("Coupons", result);

            test.CalculateScore(out reward, 2, 1);
            result = test.DetermineReward();
            Assert.AreEqual("No_Reward", result);
        }

        
    }
}