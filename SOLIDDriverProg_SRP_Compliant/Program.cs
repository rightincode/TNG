using SOLID.SRP.Compliant;

namespace SOLIDDriverProg_SRP_Compliant
{
    class Program
    {
        static void Main(string[] args)
        {
            SR_Logger myLogger = new SR_Logger();
            SR_Calculator mySR_Calculator = new SR_Calculator();

            int result = mySR_Calculator.Add(1, 1);
            myLogger.LogIntResult(result);
        }
    }
}
