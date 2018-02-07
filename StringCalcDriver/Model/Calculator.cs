using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDStringCalcDriver
{
    public class Calculator
    {
        public string equation;

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

            var equation = numbers.Split(",");
            return equation.Sum(x => int.Parse(x));
        }
    }
}
