using SOLID.LSP;
using SOLID.LSP.Compliant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLIDDriverProg_LSP_Compliant
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerCollection collection = null;
            //collection = new SpecialCustomers();
            //Console.WriteLine("The account rep is " + collection.AccountRep);
            //for (int i = 0; i < 10; i++)
            //{
            //    Customer obj = new Customer();
            //    collection.AddCustomer(obj);
            //}

            //collection = new TopNCustomers();
            //Console.WriteLine("The account rep is " + collection.AccountRep);
            //for (int i = 0; i < 10; i++)
            //{
            //    Customer obj = new Customer();
            //    collection.AddCustomer(obj);
            //}

            Car myMustang = null;
            myMustang = new MustangGT();

            myMustang.Break();

            if (myMustang.Stopped == true)
            {
                Console.WriteLine("Yeah, we didn't hit the wall!");
            }
            else
            {
                Console.WriteLine("Dang, we died!");
            }
        }
    }
}
