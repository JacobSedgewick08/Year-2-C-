using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Application
{
    internal class Customer
    {

        // Attributes 
        string name;
        int GuestCount;

        // Constructor 
        Customer()
        {
            name = "";
            GuestCount = 0;
        }

        Customer(string name, int CustomerAmount)
        {
            this.name = name;
            GuestCount = CustomerAmount;
        }

        public string GetCustomerInfo()
        {
            return name +" (" + GuestCount + "guests)";
 
        }
    }
}
