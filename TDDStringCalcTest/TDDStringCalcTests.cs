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

            Assert.AreEqual(0, calculator.AddTwoOrLessInputs(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithEmptyString()
        {
            var calculator = new Calculator()
            {
                Equation = ""
            };

            Assert.AreEqual(0, calculator.AddTwoOrLessInputs(calculator.Equation));

        }

        [TestMethod]
        public void AdditionWithOneNumber()
        {
            var calculator = new Calculator()
            {
                Equation = "1"
            };

            Assert.AreEqual(1, calculator.AddTwoOrLessInputs(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithTwoNumbers()
        {
            var calculator = new Calculator()
            {
                Equation = "1,2"
            };

            Assert.AreEqual(3, calculator.AddTwoOrLessInputs(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithZeroAsANumber()
        {
            var calculator = new Calculator()
            {
                Equation = "0,2"
            };

            Assert.AreEqual(2, calculator.AddTwoOrLessInputs(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithMultipleDigitNumber()
        {
            var calculator = new Calculator()
            {
                Equation = "10,2"
            };

            Assert.AreEqual(12, calculator.AddTwoOrLessInputs(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithTooManyInputs()
        {
            var calculator = new Calculator()
            {
                Equation = "1,2,3"
            };

            Assert.ThrowsException<Exception>(() => calculator.AddTwoOrLessInputs(calculator.Equation));
        }

        [TestMethod]
        public void AdditionWithLetters()
        {
            var calculator = new Calculator()
            {
                Equation = "a,b,c"
            };

            Assert.ThrowsException<Exception>(() => calculator.AddTwoOrLessInputs(calculator.Equation));
        }
    }
}
