using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Violation
{
    public class TopNCustomers : SpecialCustomers
    {
        private int maxCount = 5;

        public override void AddCustomer(Customer obj)
        {
            if (Count < maxCount)
            {
                AddCustomer(obj);
            }
            else
            {
                throw new Exception("Only " + maxCount + " customers can be added.");
            }
        }
    }
}
