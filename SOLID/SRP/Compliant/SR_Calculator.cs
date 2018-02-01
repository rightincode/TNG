
namespace SOLID.SRP.Compliant
{
    public class SR_Calculator
    {
        public SR_Calculator()
        {
        }

        public int Add(int param1, int param2)
        {
            var result = param1 + param2;
            return result;
        }

        public int Subtract(int param1, int param2)
        {
            var result = param1 - param2;
            return result;
        }
    }    
}
