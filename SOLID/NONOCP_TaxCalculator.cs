using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class NONOCP_TaxCalculator
    {
        public decimal CalculateTax(decimal amount, string country)
        {
            decimal taxAmount = 0;
            switch (country)
            {
                case "USA":
                    //calculate tax as per USA rules
                    break;
                case "UK":
                    //calculate tax as per UK rules
                    break;
                case "IN":
                    //calculate tax as per India rules
                    break;
            }
            return taxAmount;
        }
    }
}
