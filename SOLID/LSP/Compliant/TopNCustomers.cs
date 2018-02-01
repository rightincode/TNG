using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Compliant
{
    public class TopNCustomers : CustomerCollection
    {
        private int _count = 0;
        Customer[] list = new Customer[5];

        public override int Count
        {
            get { return list.Length; }
        }

        public override void AddCustomer(Customer obj)
        {
            if (_count < 5)
            {
                list[_count] = obj;
                _count++;
            }
            else
            {
                throw new Exception("Only " + _count + " customers can be added.");
            }
        }
    }
}
