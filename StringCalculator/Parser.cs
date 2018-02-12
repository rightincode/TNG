using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Parser
    {
        /// <summary>
        /// Parser Method
        /// Takes in one string parameter "numbers". This is the same value as the calling method's string parameter. This method is responsible for parsing that string and populating an array with the comma delimited integer values, which it returns to the caller. 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns> int array </returns>
        public int[] StringParserDefault(string numbers, char delimiter = '1')
        {
            int[] numList;
            string[] stringArr;
            if(delimiter == '1')
            {
                stringArr = numbers.Split(new char[] { ',', '\n' });

            }
            else
            {
                stringArr = numbers.Split(delimiter);
            }

            if (stringArr.Length < 1)
            {
                return new int[0];
            }
            else
            {
                try
                {
                    numList = new int[stringArr.Length];
                    int i = 0;
                    foreach (string index in stringArr)
                    {
                        numList[i] = Int32.Parse(index);
                        i++;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid Entry!");
                    return new int[0];
                }
                return numList;
            }
        }






        public bool IsCustomDelimeter(string numbers)
        {
            bool isCustomDelimetor;
            try
            {
                if (numbers.Length >= 4 && numbers.Substring(0, 2).Equals("//") && numbers.Substring(3, 2).Equals(@"\n") && !Char.IsNumber(numbers[2]))
                {
                    isCustomDelimetor = true;
                }
                else
                {
                    isCustomDelimetor = false;
                }
                return isCustomDelimetor;
            }
            catch
            {
                return false;
            }
        }
    }

}

