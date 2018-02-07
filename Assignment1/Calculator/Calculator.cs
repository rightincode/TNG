using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProgram
{
    public class Calculator
    {
        public int Add(string stuffToAdd)
        //obviously not SOLID, minimum done to get tests green
        {
            int param1;
            int param2;
            //business rule: if empty string return 0
            if (stuffToAdd.Length == 0)
            {
                return 0;
            }
            //business rule: if single number, return that number
            else if (!stuffToAdd.Contains(","))
            {
                bool result = Int32.TryParse(stuffToAdd, out param1);
                if (result)
                {
                    return param1;
                }
                else
                {
                    throw new ArgumentException("Invalid user input");
                }
            }
            //otherwise add two numbers (and throw out if either is not a number)
            else
            {
                string[] splitParams = stuffToAdd.Split(",");
                if(splitParams.Length > 2)
                {
                    throw new ArgumentException("Invalid user input");
                }
                else
                {
                    bool result = Int32.TryParse(splitParams[0], out param1);
                    if(!result)
                    {
                        throw new ArgumentException("Invalid user input");
                    }
                    bool result1 = Int32.TryParse(splitParams[1], out param2);
                    if (!result1)
                    {
                        throw new ArgumentException("Invalid user input");
                    }
                    int sum = param1 + param2;
                    return sum;
                }
            }
            
        }
    }
}
