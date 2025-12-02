using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Attributes
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userName = "admin";
            string passWord = "12345";
            
            // If statement to only allow staff with correct cresedentials
            if (username == userName && password == passWord)
            {
                grpInfo.Visible = true;
            }

            else
            {
                MessageBox.Show("Invalid Cresedentials");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            grpInfo.Visible = false;
        }
    }
}
