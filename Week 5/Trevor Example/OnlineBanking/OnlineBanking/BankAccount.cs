using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking
{
    internal class BankAccount
    {

        //attributes
        private decimal balance;
        private string customerName;

        //constructor
        public BankAccount()
        {
            balance = 0;
            customerName = "";

        }

        // second constructor
        public BankAccount(decimal initialBalance, string custName)
        {
            balance = initialBalance;

            customerName = custName;
        }

        //methods
        public void makeDeposit(decimal amount)
        {
            balance = balance + amount;
        }

        public void makeWithdrawal(decimal amount)
        {
            balance = balance - amount;
        }

        public decimal getBalance()
        {
                        return balance;

        }
    }
}
