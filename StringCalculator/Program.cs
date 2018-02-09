using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations myCalculations = new Calculations();
            int answer = myCalculations.Add(@"//!\n1!34!12!5");
            Console.WriteLine(answer.ToString());
            Console.ReadKey();
        }
    }
}
