using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator
{
    public class Calculator
    {
        public string parameterException = "Recieved more than 2 input parameters";

        public int Add(string numbers)
        {
            int result;
            try
            {
                if (string.IsNullOrEmpty(numbers))
                {
                    if (numbers.Equals(string.Empty))
                    {
                        result = 0;
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }
                }
                else
                {
                    string[] parsedNumbers;
                    numbers.Replace(" ", string.Empty);
                    char parseValue = ',';
                    parsedNumbers = numbers.Split(parseValue, StringSplitOptions.None);

                    switch (parsedNumbers.Length)
                    {
                        case 1:
                            result = int.Parse(parsedNumbers[0]);
                            break;
                        case 2:
                            result = int.Parse(parsedNumbers[0]) + int.Parse(parsedNumbers[1]);
                            break;
                        default:
                            throw new Exception(parameterException);

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            return result;
        }
    }
}
