using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBanking2
{
    internal class Account
    {

        // Attributes
        private int accountnumber;
        private decimal balance;


        public Account() // Constructor
        {
            accountnumber = 0;
            balance = 0;
        }

        public Account(decimal initialbalance, int number)
        {
            balance = initialbalance;
            accountnumber = 0;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }

            else
            {
                return false;
            }

        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}
