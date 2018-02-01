using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Compliant
{
    public abstract class CustomerCollection
    {
        public abstract void AddCustomer(Customer obj);
        public abstract int Count { get; }

        public string AccountRep = "Richard";

    }
}
