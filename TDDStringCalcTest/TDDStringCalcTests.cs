using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDStringCalcDriver;

namespace TDDStringCalcTest
{
    [TestClass]
    public class TDDStringCalcTests
    {
        [TestMethod]
        public void AdditionWithNullString()
        {
            var calculator = new Calculator()
            {
                equation = null
            };

            Assert.AreEqual(0, calculator.Add(calculator.equation));
        }

        [TestMethod]
        public void AdditionWithEmptyString()
        {
            var calculator = new Calculator()
            {
                equation = ""
            };

            Assert.AreEqual(0, calculator.Add(calculator.equation));

        }

        [TestMethod]
        public void AdditionWithOneNumber()
        {
            var calculator = new Calculator()
            {
                equation = "1"
            };

            Assert.AreEqual(1, calculator.Add(calculator.equation));
        }

        [TestMethod]
        public void AdditionWithTwoNumbers()
        {
            var calculator = new Calculator()
            {
                equation = "1,2"
            };

            Assert.AreEqual(3, calculator.Add(calculator.equation));
        }
    }
}
