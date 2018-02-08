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

        public int Add(string numbers)
        {
            int isValid;
            string[] numberArray;

            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }
             numberArray = numbers.Split(new char[] { ',', '\n' });

            bool containOnlyNumbers = int.TryParse(numberArray[0], out isValid);
            if (!containOnlyNumbers)
            {
                throw new Exception("Invalid user input.");
            }
            else
            {
                return numberArray.Sum(x => int.Parse(x));
            }
        }
    }
}
