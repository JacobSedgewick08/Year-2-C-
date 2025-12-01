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

        // Make a referance for our Bank Account object 
        BankAccount Account;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Input Customer Name 
            string customerName = (txtName.Text);

            //Input Balance
            decimal initialBalance = decimal.Parse(txtInitialBalance.Text);

            // Create Bank Acount object
            Account = new BankAccount(initialBalance, customerName);
        }

        private void btnDisplayBalance_Click(object sender, EventArgs e)
        {
            // Use the account object's GetBalance method to get the balance 
            // Display balance in a message box 

            decimal bal = Account.GetBalance();

            MessageBox.Show("Balance is £" + bal);
        }

    }
}
