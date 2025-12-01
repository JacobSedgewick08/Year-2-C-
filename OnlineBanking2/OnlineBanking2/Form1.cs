using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBanking2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string username;
        private string password;
        private decimal initialbalance;

        private Bank natEast = new Bank();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Input new customer info

            username = txtUsernameReg.Text;
            password = txtPasswordReg.Text;
            initialbalance = decimal.Parse(txtInitialBalance.Text);

            // Create a new customer object

            natEast.RegisterCustomer(username, password, initialbalance);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;

            // Get customer object
            Customer customer = natEast.GetCustomer(username);

            customer.Login();
            grpCustomerServices.Visible = true;
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            // Display customer balance

            Customer customer = natEast.GetCustomer(username);
            Account account = customer.GetAccount();
            MessageBox.Show(account.GetBalance().ToString());
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // Make deposit to customer account
            Customer Customer = natEast.GetCustomer(username);
            Account account = Customer.GetAccount();
            account.Deposit(decimal.Parse(txtDeposit.Text));
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // Make withdrawal from customer account
            Customer Customer = natEast.GetCustomer(username);
            Account account = Customer.GetAccount();    
            account.Withdraw(decimal.Parse(txtWithdraw.Text));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Customer customer = natEast.GetCustomer(username);
            customer.Logout();
            grpCustomerServices.Visible = false;
        }
    }
}
