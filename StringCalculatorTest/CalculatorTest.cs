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
        public void AddWithEmptyValue_NewLineDelimited()
        {
            string input = "10/n,10/n/n10";
            int result = calc.Add(input);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void AddWithEmptyValue_CommaDelimited()
        {
            string input = "10,10,,10";
            int result = calc.Add(input);
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void AddManyValues_CommaDelimited()
        {
            string input = "1,2,3,4,5";
            int result = calc.Add(input);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void AddManyValues_NewLineDelimited()
        {
            string input = "1/n2/n3/n4/n5";
            int result = calc.Add(input);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void AddManyValues_NewLineAndCommaDelimited()
        {
            string input = "1,2/n3/n4,5";
            int result = calc.Add(input);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void AddCrazyParameters()
        {
            string input = "asdf;lkjai1 , asld;fkjso10";
            Assert.ThrowsException<FormatException>(() => calc.Add(input));
        }

        [TestMethod]
        public void AddWithZeros()
        {
            string input = "0,1";
            int result = calc.Add(input);
            Assert.AreEqual(1, result);

            input = "0,0";
            result = calc.Add(input);
            Assert.AreEqual(0, result);

            input = "0,0/n0";
            result = calc.Add(input);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AddWithNegatives()
        {
            string input = "-10,-10";
            int result = calc.Add(input);
            Assert.AreEqual(-20, result);

            input = "10,-10";
            result = calc.Add(input);
            Assert.AreEqual(0, result);

            input = "-10/n10,10";
            result = calc.Add(input);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void AddWithNegatives_BadFormat()
        {
            string input = "10,10-10";
            Assert.ThrowsException<FormatException>(() => calc.Add(input));
        }
    }
}
