using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProgram;

namespace CalculatorTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void ParamContainsJunk()
        {
            var myCalc = new CalculatorProgram.Calculator();
            myCalc.Add("1,test");
        }

        [TestMethod]
        public void ReturnZeroForNullInput()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add();
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ReturnZeroForEmptyString()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ReturnPositiveSingleParam()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("1");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ReturnZeroSingleParam()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("0");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ReturnNegativeSingleParam()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("-1");
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void AddTwoPositiveSingleDigitParams()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("1,2");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void AddTwoPositiveMultiDigitParams()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("123,22");
            Assert.AreEqual(145, result);
        }

        [TestMethod]
        public void AddOnePositiveParamToZero()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("0,22");
            Assert.AreEqual(22, result);
        }

        [TestMethod]
        public void AddPositiveAndNegativeReturnNegative()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("-123,22");
            Assert.AreEqual(-101, result);
        }

        [TestMethod]
        public void AddThreeNegativeNumbers()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("-123,-1,-54");
            Assert.AreEqual(-178, result);
        }

        [TestMethod]
        public void AddFourNumbersWithNewLineAndCommas()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("-123,22\n44,5");
            Assert.AreEqual(-52, result);
        }

        [TestMethod]
        public void AddMultipleNumbersIncludingEmptyValue()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("-123,22,\n44,5");
            Assert.AreEqual(-52, result);
        }

        [TestMethod]
        public void TestParserReturn()
        {
            int[] expected = new int[] { -123, 22, 0, 44, 5 };
            var myParser = new CalculatorProgram.CalcInputParser();
            var result = myParser.ParseStringInputToAddends("-123,22,\n44,5");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DefaultDelimiter()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("-123,22,\n44,5");
            Assert.AreEqual(-52, result);
        }

        [TestMethod]
        public void CustomDelimiter()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("//y\n-123y22y\n44y5");
            Assert.AreEqual(-52, result);
        }

        [TestMethod]
        public void AddNumberGreaterThanOneThousand()
        {
            var myCalc = new CalculatorProgram.Calculator();
            var result = myCalc.Add("1123,22,2044,5");
            Assert.AreEqual(194, result);
        }

    }
}
