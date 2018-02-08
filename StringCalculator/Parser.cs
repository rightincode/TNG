using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    class Parser
    {
        /// <summary>
        /// Parser Method
        /// Takes in one string parameter "numbers". This is the same value as the calling method's string parameter. This method is responsible for parsing that string and populating an array with the comma delimited integer values, which it returns to the caller. 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns> int array </returns>
        public int[] StringParser(string numbers)
        {

            int[] numList;

            if (numbers.Contains(",") || numbers.Contains("\n"))
            {
                string[] stringArr = numbers.Split(new char[] { ',', '\n' });

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
            else
            {
                try
                {
                    int singleNumber = Int32.Parse(numbers);
                    numList = new int[1];
                    numList[0] = singleNumber;
                    return numList;
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");
                    return new int[0];
                }

            }

        }
    }

}
