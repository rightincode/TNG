using System.Diagnostics;

namespace SOLID
{
    class NONSR_Calculator
    {
        public NONSR_Calculator()
        {
        }

        public int Add(int param1, int param2)
        {
            var result = param1 + param2;
            Debug.WriteLine("The sum of the parameters = " + result.ToString());


            return result;
        }

        public int Subtract(int param1, int param2)
        {
            var result = param1 - param2;
            Debug.WriteLine("The difference of the parameters = " + result.ToString());


            return result;
        }
    }
}
