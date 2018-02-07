using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;
using System;

namespace StringCalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        static Calculator calc;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            calc = new Calculator();
        }

        [TestMethod]
        public void AddNullParameter()
        {
            string input = null;

            Action<string> action = (string num) => calc.Add(num);
            Assert.ThrowsException<NullReferenceException>(() => calc.Add(input));
        }

        [TestMethod]
        public void AddEmptyString()
        {
            string input = "";
            int result = calc.Add(input);

            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void AddSingleValue()
        {
            string input = "1";
            int result = calc.Add(input);

            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void AddTwoValues()
        {
            string input = "1,2";
            int result = calc.Add(input);

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void AddTwoValues_WithSpace()
        {
            string input = "1, 2";
            int result = calc.Add(input);

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void AddTooManyValues()
        {
            string input = "1,2,3";

            Assert.ThrowsException<Exception>(() => calc.Add(input));
        }
    }
}
