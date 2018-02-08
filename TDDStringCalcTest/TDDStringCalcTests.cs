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
                Equation = null
            };

            Assert.AreEqual(0, calculator.Add(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithEmptyString()
        {
            var calculator = new Calculator()
            {
                Equation = ""
            };

            Assert.AreEqual(0, calculator.Add(calculator.Equation));

        }

        [TestMethod]
        public void AdditionWithOneNumber()
        {
            var calculator = new Calculator()
            {
                Equation = "1"
            };

            Assert.AreEqual(1, calculator.Add(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithTwoNumbers()
        {
            var calculator = new Calculator()
            {
                Equation = "1,2"
            };

            Assert.AreEqual(3, calculator.Add(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithZeroAsANumber()
        {
            var calculator = new Calculator()
            {
                Equation = "0,2"
            };

            Assert.AreEqual(2, calculator.Add(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithMultipleDigitNumbers()
        {
            var calculator = new Calculator()
            {
                Equation = "10,12"
            };

            Assert.AreEqual(22, calculator.Add(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithNewLineInEquation()
        {
            var calculator = new Calculator()
            {
                Equation = "1\n2,3"
            };

            Assert.AreEqual(6, calculator.Add(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithLetters()
        {
            var calculator = new Calculator()
            {
                Equation = "a,b,c"
            };

            Assert.ThrowsException<Exception>(() => calculator.Add(calculator.Equation));
        }
    }
}
