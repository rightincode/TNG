using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public abstract class Person
    {        
        public abstract decimal GetTax();
    }

    public class USPerson : Person
    {
        private OCP_TaxCalculator.TaxCalculatorBase _myCalculator;

        public USPerson()
        {
            _myCalculator = new OCP_TaxCalculator.USATax();
        }

        public override decimal GetTax()
        {
            return _myCalculator.CalculateTax();
        }
    }
}
