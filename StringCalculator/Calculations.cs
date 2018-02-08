using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Calculations
    {
        Parser parser = new Parser();
        public int Add(string numbers)
        {
            if (numbers == null)
            {
                return -1;
            }else if(numbers == "")
            {
                return 0;
            }
            else
            {
                int[] myAddArray = parser.StringParser(numbers);
                if(myAddArray == null || myAddArray.Length == 0)
                {
                    return -1;
                }
                int sum = 0;
                foreach(int currentValue in myAddArray)
                {
                    sum = sum + currentValue;
                }
                return sum;
            }
        }
    }
}

