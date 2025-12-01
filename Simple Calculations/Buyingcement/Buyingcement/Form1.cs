using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buyingcement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            //Get Users name
            //Get amount of cement user wants
            //Calculate price of cement
            //Output a message including users name and price they have to pay
            
            // Variables
            string name;
            decimal cost;
            int cement;

            //Get users name
            name = txtName.Text;

            //Get amount of cement user wants
            cement = int.Parse(TxtCement.Text);

            // Get cost of cement
            cost = (decimal)(cement * 0.93);

            // Output name + cost of cement
            txtPrice.Text = name + "Your cement will cost you £" + cost.ToString();
            

        }
    }
}
