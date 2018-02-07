using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDStringCalcDriver
{
    public class Calculator
    {
        private string equation;

        public string Equation
        {
            get { return equation; }
            set { equation = value; }
        }

        public int AddTwoOrLessInputs(string numbers)
        {
            int isValid;
            string[] numberArray;

            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            numberArray = numbers.Split(",");

            bool containOnlyNumbers = int.TryParse(numberArray[0], out isValid);
            if (!containOnlyNumbers)
            {
                throw new Exception("Invalid user input.");
            }

            if (numberArray.Length > 2)
            {
                throw new Exception("Too many inputs, please limit to 2.");
            }
            else
            {
                return numberArray.Sum(x => int.Parse(x));
            }
        }
    }
}
