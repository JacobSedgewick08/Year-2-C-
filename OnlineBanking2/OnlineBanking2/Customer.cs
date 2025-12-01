using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking2
{
    internal class Customer
    {


        // Attributes
        string username;
        string password;
        bool isLoggedin;

        private Account account;

        public Customer(string username, string password, Account account)
        {
            this.username = username;
            this.password = password;
            this.account = account;

            // Account is created by bank and passed to Customer

        }

        
        // Methods
        public void Login()
        {
            isLoggedin = true;
        }

        public void Logout()
        {
            isLoggedin = false;
        }

        public Account GetAccount()
        {
            return account;
        }

    }
}
