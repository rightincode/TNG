using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Compliant
{
    public class SpecialCustomers : CustomerCollection
    {
        List<Customer> list = new List<Customer>();

        public override void AddCustomer(Customer obj)
        {
            list.Add(obj);
        }

        public override int Count
        {
            get { return list.Count; }
        }
    }
}
