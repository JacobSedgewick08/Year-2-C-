using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Ticketsales
{
    public partial class form1 : Form
    {
        private const double V = 10.99;

        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateSales_Click(object sender, EventArgs e)
        {
            // Variable

            decimal tickets, totalsales, price;

            // Get amount of tickets Sold

            tickets = decimal.Parse(txtTicketsSold.Text);

            // Assign price a value

            price = (decimal)10.99;

            // Calculate Total Sales

            totalsales = tickets * price;

            // Output Message

            if (totalsales < 40000)
            {
                txtMessage.Text = "You have had a good day and made £" + totalsales.ToString();
            }

            else
            {
                txtMessage.Text = "You have not had a good day. You made £" + totalsales.ToString();
            }
        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
