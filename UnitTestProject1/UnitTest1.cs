using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddOneTwoComma()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(myCalculations.Add("1,2"), 3);
        }

        [TestMethod]
        public void AddOneTwoSpaceComma()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(myCalculations.Add("1 , 2"), 3);
        }

        [TestMethod]
        public void AddOneNumberSingleDigit()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(myCalculations.Add("5"), 5);
        }

        [TestMethod]
        public void AddOneNumberMultipleDigits()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(myCalculations.Add("123"), 123);
        }

        [TestMethod]
        public void AddMoreThanTwoNumbers()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(myCalculations.Add("1,2,3"), -1);
        }





    }
}
