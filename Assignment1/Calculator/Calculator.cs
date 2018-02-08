using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProgram
{
    public class Calculator
    {
        private int sum;

        public int Sum
        {
            get { return sum; }
            set { sum = value; }
        }

        public int Add(string stuffToAdd = "")
        //obviously not SOLID, minimum done to get tests green
        {
            string[] splitParams;
            //business rule: if empty string return 0
            if (stuffToAdd.Length == 0)
            {
                return 0;
            }
            //business rule: if single number, return that number
            else if (!stuffToAdd.Contains(",") && !stuffToAdd.Contains("\n"))
            {
                bool result = Int32.TryParse(stuffToAdd, out sum);
                if (result)
                {
                    return sum;
                }
                else
                {
                    throw new ArgumentException("Invalid user input");
                }
            }
            //otherwise add the numbers (and throw out if contains NaN value)
            else
            {
                
                if (stuffToAdd.Contains("\n"))
                {
                    stuffToAdd = stuffToAdd.Replace("\n", ",");
                }
                splitParams = stuffToAdd.Split(",");
                for (int i = 0; i < splitParams.Length; i++)
                {
                    if(splitParams[i] == "")
                    {
                        splitParams[i] = "0";
                    }
                    bool result = Int32.TryParse(splitParams[i], out int addend);
                    if (!result)
                    {
                        throw new ArgumentException("Invalid user input");
                    }
                    sum += addend;
                }
                
                return sum;
            }
            
        }
    }
}
