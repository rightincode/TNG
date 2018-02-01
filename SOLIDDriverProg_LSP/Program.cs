using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.LSP.Violation;

namespace SOLIDDriverProg_LSP_Violation
{
    class Program
    {
        static void Main(string[] args)
        {
            SpecialCustomers sc = null;
            sc = new TopNCustomers();
            for (int i = 0; i < 10; i++)
            {
                Customer obj = new Customer();
                sc.AddCustomer(obj);
            }
        }
    }
}
