﻿using System;

namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculations myCalculations = new Calculations();
            int answer = myCalculations.Add("1\n2");
            Console.WriteLine(answer.ToString());
            Console.ReadKey();

        }
    }
}