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
        public readonly string DelimiterExceptionMessage = "Invalid Input: Delimiter can not be characters associated with numeric values";

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
                    result = Parse(numbers).Where(x => x < 1001).Sum();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result = new int();
            }

            return result;
        }

        private int[] Parse(string fullInput)
        {
            int[] numArray;
            string[] parseValue;
            string varyInput;

            try
            {
                fullInput.Replace(" ", string.Empty);

                if (fullInput.Length > 1 && fullInput.Substring(0,2) == "//")
                {
                    int lineIndex = fullInput.IndexOf(@"\n") + 1;
                    varyInput = fullInput.Substring(lineIndex, fullInput.Length - lineIndex);
                    parseValue = new string[] { fullInput.Substring(2, 1) };

                    if (parseValue.First().Equals("-") || int.TryParse(parseValue.First(), out int temp))
                        throw new FormatException(DelimiterExceptionMessage);

                }
                else
                {
                    parseValue = new string[] { ",", @"\n" };
                    varyInput = fullInput;
                }

                string[] parsedNumbers;
                parsedNumbers = varyInput.Split(parseValue, StringSplitOptions.None);
                numArray = parsedNumbers.Where(x => x.Length > 0).Select(int.Parse).ToArray();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return numArray;
        }
    }
}
