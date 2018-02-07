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

        public int[] Parser(string numbers)
        {
            int[] numList = new int[2];
            
            if (numbers.Contains(","))
            {
                string[] stringArr = numbers.Split(',');

                if(stringArr.Length > 2)
                {
                    return new int[0];
                }
                else
                {
                    try
                    {
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
                        return numList;
                    }
                    return numList;
                   
                }
            }
            else
            {
                try
                {
                    int singleNumber = Int32.Parse(numbers);
                    numList[0] = singleNumber;
                    return numList;
                }
                catch
                {
                    Console.WriteLine("Invalid Input!");
                    return numList;

                }

            }
        }

    }
}

