using System;
using TDDStringCalcDriver;

namespace StringCalcDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine("Please enter equation.");
            string s1 = Console.ReadLine();
            Console.WriteLine(calc.AddTwoOrLessInputs(s1));
            Console.Read();
        }
    }
}
