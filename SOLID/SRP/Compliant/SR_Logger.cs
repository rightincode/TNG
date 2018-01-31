using System;

namespace SOLID.SRP.Compliant
{
    public class SR_Logger
    {
        public void LogIntResult(int result)
        {
            Console.WriteLine("The result of the operation is " + result.ToString());
        }
    }
}
