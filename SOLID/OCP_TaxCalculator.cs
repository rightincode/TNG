using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class OCP_TaxCalculator
    {
        public OCP_TaxCalculator()
        {
        }

        public abstract class TaxCalculatorBase
        {
            public decimal TotalAmount { get; set; }
            public abstract decimal CalculateTax();
        }

        public class USATax : TaxCalculatorBase
        {
            public override decimal CalculateTax()
            {
                //calculate tax as per USA rules
                return 0;
            }
        }

        public class UKTax : TaxCalculatorBase
        {
            public override decimal CalculateTax()
            {
                //calculate tax as per UK rules
                return 0;
            }
        }

        public class IndiaTax : TaxCalculatorBase
        {
            public override decimal CalculateTax()
            {
                //calculate tax as per India rules
                return 0;
            }
        }
    }
}
