using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Calculations
    {
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
                int[] myAddArray = Parser(numbers);
                if(myAddArray == null || myAddArray.Length == 0)
                {
                    return -1;
                }

                int count = 0;
                foreach(int index in myAddArray)
                {
                    count = count + index;

                }
                return count;
            }
        }
        /// <summary>
        /// Parser Method
        /// Takes in one string parameter "numbers". This is the same value as the calling method's string parameter. This method is responsible for parsing that string and populating an array with the comma delimited integer values, which it returns to the caller. 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns> int array </returns>
        public int[] Parser(string numbers)
        {

            int[] numList;

            if (numbers.Contains(",") || numbers.Contains("\n"))
            {
                string[] stringArr = numbers.Split(new char[] { ',', '\n' });

                if(stringArr.Length < 1)
                {
                    return new int[0];
                }
                else
                {
                    try
                    {
                        numList = new int[stringArr.Length];
                        int i = 0;
                        foreach(string index in stringArr)
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

