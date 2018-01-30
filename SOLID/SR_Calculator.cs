using System.Diagnostics;

namespace SOLID
{
    class SR_Calculator
    {
        private Logger _logger;

        public SR_Calculator(Logger logger)
        {
            _logger = logger;
        }

        public int Add(int param1, int param2)
        {
            var result = param1 + param2;
            _logger.LogIntResult(result);


            return result;
        }

        public int Subtract(int param1, int param2)
        {
            var result = param1 - param2;
            _logger.LogIntResult(result);


            return result;
        }
    }

    class Logger
    {
        public void LogIntResult(int result)
        {
            Debug.WriteLine("The result of the operation is " + result.ToString());
        }
    }
}
