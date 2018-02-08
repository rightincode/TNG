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
            Assert.AreEqual(3, myCalculations.Add("1,2"));
        }

        [TestMethod]
        public void AddOneTwoSpaceComma()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(3, myCalculations.Add("1 , 2"));
        }

        public void AddTwoNumbersMultipleDigits()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(-1 , myCalculations.Add("123,234"));
        }


        [TestMethod]
        public void AddOneNumberSingleDigit()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(5, myCalculations.Add("5"));
        }

        [TestMethod]
        public void AddOneNumberMultipleDigits()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(123, myCalculations.Add("123"));
        }

        [TestMethod]
        public void AddMoreThanTwoNumbers()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(6, myCalculations.Add("1,2,3"));
        }

        [TestMethod]
        public void AddNull()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(-1,myCalculations.Add(null));
        }

        [TestMethod]
        public void AddEmptyString()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(0, myCalculations.Add(""));
        }


        /// ASSIGNMENT 2 TEST SUITE ///


        [TestMethod]
        public void AddMultipleNumbers()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(10, myCalculations.Add("1,2,3,4"));
        }

        [TestMethod]
        public void AddMultipleNumbersWithNewLineAndComma()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(6, myCalculations.Add("1\n2,3"));
        }

        [TestMethod]
        public void AddTwoNumbersWithNewLine()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(3, myCalculations.Add("1\n2"));
        }
        [TestMethod]
        public void AddMultipleNumbersWithNewLineAndCommaExtreme()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(136, myCalculations.Add("2,4\n2\n2,3,4,2\n5,56\n56"));
        }

        [TestMethod]
        public void AddInvalidString()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(-1, myCalculations.Add("TYLER"));
        }

        [TestMethod]
        public void AddNegativeValuesWithCommasAndNewLines()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(-5, myCalculations.Add("5,5\n5\n5,-5,-5\n-5,-5\n-5,0\n0"));
        }
        [TestMethod]
        public void AddInvalidStringAfterValidString()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(-1, myCalculations.Add("20,20,tyler"));
        }

        /// TEST SUITE 3 ///

        [TestMethod]
        public void AddNumberGreaterThanOneThousand()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(111, myCalculations.Add("1,10,100,1000"));
        }

        [TestMethod]
        public void AddCustomDelimiter()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(42, myCalculations.Add("//!\n1!34!12!5"));
        }

        [TestMethod]
        public void InvalidCustomDelimiter()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(-1, myCalculations.Add("//5\n656526"));
        }

        [TestMethod]
        public void CustomDelimeterAndCommaImproperUsage()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(-1, myCalculations.Add("//!\n5,5,5,5,5"));
        }

        [TestMethod]
        public void CustomDelimeterAddingOneThousand()
        {
            Calculations myCalculations = new Calculations();
            Assert.AreEqual(15, myCalculations.Add("//[\n5[5[1000[5"));
        }
    }
}
