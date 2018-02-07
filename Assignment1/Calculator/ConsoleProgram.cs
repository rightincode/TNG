using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProgram;

namespace Calculator
{
    class ConsoleProgram
    {
        public static int Main()
        {
            Console.WriteLine("Please enter the number(s) to add, separated by commas.");
            string input = Console.ReadLine();
            CalculatorProgram.Calculator myCalc = new CalculatorProgram.Calculator();
            int result = myCalc.Add(input);
            Console.WriteLine("The sum is " + result);
            return result;
        }
    }
}
