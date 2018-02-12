using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {                 
                Calculator calc = new Calculator();
                string input = Console.ReadLine();
                Console.WriteLine("Calculated a sum total of : " + calc.Add(input));
                Console.WriteLine();
            }
            
        }
    }
}
