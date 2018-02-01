using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Exercises
{
    class Customer
    {
        string _FirstName;
        string _Lastname;

        public string FirstName {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        public string LastName
        {
            get { return _Lastname; }
            set { _Lastname = value; }
        }

        private string _customerType;

        public string CustomerType
        {
            get { return _customerType; }
            set { _customerType = value; }
        }


        public Customer()
        {
        }

        public CalculateCustomerDiscount()
        {

        }


    }
}
