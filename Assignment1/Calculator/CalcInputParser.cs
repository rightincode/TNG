using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProgram
{
    public class CalcInputParser
    {
        private int[] addends;

        public int[] Addends
        {
            get { return addends; }
            set { addends = value; }
        }

        public int[] ParseStringInputToAddends(string input = "")
        {
            if (input == "")
            {
                addends = new int[] { 0 };
            }
            else if (!input.Contains(",") && !input.Contains("\n"))
            {
                addends = new int[1];
                bool result = Int32.TryParse(input, out addends[0]);
                if (!result)
                {
                    throw new ArgumentException("Invalid user input");
                }
            }
            else
            {

                if (input.Contains("\n"))
                {
                    input = input.Replace("\n", ",");
                }

                string[] splitParams = input.Split(",");
                addends = new int[splitParams.Length];

                for (int i = 0; i < splitParams.Length; i++)
                {
                    if (splitParams[i] == "")
                    {
                        splitParams[i] = "0";
                    }
                    bool result = Int32.TryParse(splitParams[i], out addends[i]);
                    if (!result)
                    {
                        throw new ArgumentException("Invalid user input");
                    }
                }
            }

            Console.WriteLine("The addends are: " + addends);
            return addends;
        }
    }
}
