using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Violation
{
    public class SpecialCustomers
    {
        List<Customer> list = new List<Customer>();

        public virtual void AddCustomer(Customer obj)
        {
            list.Add(obj);
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }
    }    
}
