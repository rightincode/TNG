using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Calculations
    {
        Parser parser = new Parser();
        int[] myAddArray;
        public int Add(string numbers)
        {
            if (numbers == null)
            {
                return -1;
            }
            else if (numbers == "")
            {
                return 0;
            }
            else
            {
                if (parser.IsCustomDelimeter(numbers))
                {
                    myAddArray = parser.StringParserDefault(numbers.Substring(5, numbers.Length - 5), numbers[2]);
                }
                else
                {
                    myAddArray = parser.StringParserDefault(numbers);
                }
                if (myAddArray == null || myAddArray.Length == 0)
                {
                    return -1;
                }
                int sum = 0;
                foreach(int currentValue in myAddArray)
                {
                    if (currentValue > 999)
                    {
                        continue;
                    }
                    else
                    {
                        sum = sum + currentValue;
                    }
                }
                return sum;
            }
        }
    }
}

