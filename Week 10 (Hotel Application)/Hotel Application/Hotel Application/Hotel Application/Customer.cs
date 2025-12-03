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

        
        // Constructors 

        public Customer (string customerName)
        {
            name = customerName;
        }

        // Method

        public string GetName()
        {
            return name;
        }
    }
}
