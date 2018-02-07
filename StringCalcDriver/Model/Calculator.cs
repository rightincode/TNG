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
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            string[] numberArray = numbers.Split(",");
            return numberArray.Sum(x => int.Parse(x));
        }
    }
}
