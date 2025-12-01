using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBanking
{
    public partial class Form1 : Form
    {


        //Make a reference for our bank account object
        BankAccount account;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            //Input customer name
            string customerName = txtName.Text;
            //Input balance
            decimal initialBalance = decimal.Parse(txtInitialBalance.Text);

            //Create the bank account object
            account = new BankAccount(initialBalance, customerName);



        }

        private void btnDisplayBalance_Click(object sender, EventArgs e)
        {
            //Use the account object's getBalance method to get the balance
            //Display balance in a Message Box

           decimal bal = account.getBalance();

            MessageBox.Show("Balance is " + bal);

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //Input amount to withdraw
            decimal amount = decimal.Parse(txtAmount.Text);

            //Use the account object's makeWithdrawal method to withdraw the
            //amount from the balance
            account.makeWithdrawal(amount);

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Input amount to deposit
            decimal amount = decimal.Parse(txtAmount.Text);

            //Use the account object's makeDeposit method to deposit the
            //amount in the account
            account.makeDeposit (amount);
        }
    }
}
