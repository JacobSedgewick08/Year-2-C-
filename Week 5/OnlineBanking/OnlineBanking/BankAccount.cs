using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBanking
{
    internal class BankAccount
    {

        // Atributes 
        private decimal balance;
        private string customerName;

        //Constructor
        public BankAccount()
        {
            balance = 0;
            customerName = "";
        }

        // Second Constructor
        public BankAccount(decimal initialBalance, string custName)
        {
            balance = initialBalance;

            customerName = custName;
        }

        // Methods
        public void MakeDeposit(decimal amount)
        {
            balance = balance + amount;
        }

        public void MakeWithdrawal(decimal amount)
        {
            balance = balance - amount;
        }   

        public decimal GetBalance()
        {
            return balance; 
        }
    }
}
