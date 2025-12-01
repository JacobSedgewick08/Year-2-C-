using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking2
{
    internal class Bank
    {
        private Dictionary<string, Customer> customers = new Dictionary<string, Customer>();
        private int nextAccountNumber = 0;


        public void RegisterCustomer(string username, string password, decimal initialbalance)
        {
            // Create an account 
            Account tempAccount = new Account(initialbalance, nextAccountNumber++);

            // Create Customer
            Customer tempCustomer = new Customer(username, password, tempAccount);

            // Add the customer to the dictionary
            customers.Add(username, tempCustomer);
        }

        public Customer GetCustomer(string username)
        {
             // get customer from dictionary using their username
             return customers[username];
        }


    }
}
