using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankwithdrawal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // Variables
            
            decimal bankbalance, withdrawamount, totalbalance;

            // Get Bank Balance
            
            bankbalance = decimal.Parse(txtBankBalance.Text);

            // Get amount of money user would like to withdraw
            
            withdrawamount = decimal.Parse(txtWithdrawAmount.Text);

            // Calculate Final sum of money

            totalbalance = bankbalance - withdrawamount;

            // IF statement
            if (totalbalance >= 0)
            {
                txtMessage.Text = "Transaction completed Your new balance is £" + totalbalance;
            }

            else
            {
                txtMessage.Text = "Transaction Not complete you do not have enough money in your account";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
