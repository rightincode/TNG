using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProgram
{
    public class CalcInputParser
    {
        private string delimiter;

        public string Delimiter
        {
            get { return delimiter; }
            set { delimiter = value; }
        }

        private int[] addends;

        public int[] Addends
        {
            get { return addends; }
            set { addends = value; }
        }

        public int[] ParseStringInputToAddends(string input = "")
        {
            //business rule: if empty string, return 0
            if(CheckForEmptyInput(input))
            {
                addends = new int[1];
                addends[0] = 0;
            }

            //business rule: if single addend (no delimiters) return that addend
            else if(!CheckForCustomDelimiter(input) && !CheckForDefaultDelimiter(input))
            {
                addends = new int[1];
                bool result = Int32.TryParse(input, out addends[0]);
                if (!result)
                {
                    throw new ArgumentException("trash input");
                }
            }

            //business rule: allow user to input custom delimiters to separate inputs
            else if (CheckForCustomDelimiter(input))
            {
                delimiter = input[2].ToString();
                input = input.Substring(4);
                string[] tempStrings = SplitOnDelimiterAndLineBreak(input, delimiter);
                addends = new int[tempStrings.Length];
                addends = ParseStringArrayAndCheckForTrash(tempStrings);

            }

            //but don't require it, set default delimiter to ";"
            else
            {
                delimiter = ",";
                string[] tempStrings = SplitOnDelimiterAndLineBreak(input, delimiter);
                addends = new int[tempStrings.Length];
                addends = ParseStringArrayAndCheckForTrash(tempStrings);
            }

            addends = ChangeAllAddendsToMaxThreeDigits(addends);
            Console.WriteLine(addends);
            return addends;
        }

        private bool CheckForEmptyInput(string input)
        {
            if(input == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private bool CheckForCustomDelimiter(string input)
        {
            if(input[0] == '/')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckForDefaultDelimiter(string input)
        {
            if (input.Contains(","))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private string[] SplitOnDelimiterAndLineBreak(string input, string delimiter)
        {
            input = input.Replace("\n", delimiter);
            return input.Split(delimiter);
        }
        private int[] ParseStringArrayAndCheckForTrash(string[] input)
        {
            int[] results = new int[input.Length];

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] == "")
                {
                    input[i] = "0";
                }

                bool success = Int32.TryParse(input[i], out results[i]);
                if (!success)
                {
                    throw new ArgumentException("trash input");
                }
            }

            return results;
        }
        
        private int[] ChangeAllAddendsToMaxThreeDigits(int[] oldAddends)
        {
            int[] newAddends = new int[oldAddends.Length];
            for(int i = 0; i < oldAddends.Length; i++)
            {
                string tempString = oldAddends[i].ToString();
                if(tempString.Length > 3)
                {
                    if (tempString.Contains("-"))
                    {
                        tempString = tempString.Substring(tempString.Length - 4);
                    }
                    else
                    {
                        tempString = tempString.Substring(tempString.Length - 3);
                    }
                    Console.WriteLine(tempString);
                }
                newAddends[i] = Int32.Parse(tempString);
            }

            Console.WriteLine(newAddends);
            return newAddends;
        }

    }
}
