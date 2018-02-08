using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Calculator
    {
        public readonly string NullExceptionMessage = "Invalid Input: Input needed";
        public readonly string ParameterException = "Invalid Input: Can only be Signed Numeric characters";

        public int Add(string numbers)
        {
            int result;
            try
            {
                if (string.IsNullOrEmpty(numbers))
                {
                    result = numbers != null ? 0 : throw new NullReferenceException(NullExceptionMessage);
                }
                else
                {
                    // NOT SOLID
                    //string[] parsedNumbers;
                    //numbers.Replace(" ", string.Empty);
                    //string[] parseValue = new string[] { ",", "/n" };
                    //parsedNumbers = numbers.Split(parseValue, StringSplitOptions.None);
                    //result = parsedNumbers.Where(x => x.Length > 0).Select(int.Parse).ToArray().Sum();

                    // WITH SOLID
                    result = Parse(numbers).Sum();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public int[] Parse(string numbers)
        {
            int[] numArray;

            try
            {
                string[] parsedNumbers;
                numbers.Replace(" ", string.Empty);
                string[] parseValue = new string[] { ",", "/n" };
                parsedNumbers = numbers.Split(parseValue, StringSplitOptions.None);
                numArray = parsedNumbers.Where(x => x.Length > 0).Select(int.Parse).ToArray();

            }
            catch (FormatException)
            {
                throw new FormatException(ParameterException);
            }

            return numArray;
        }
    }
}
