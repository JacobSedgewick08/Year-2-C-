using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMetrestofeet_Click(object sender, EventArgs e)
        {
            // Get variables
            double metres, feet;

            // Get Input from txtmetres
            metres = double.Parse(txtMetres.Text);

            // Calculate conversion

            feet = metres * 3.28;

            // Output Conversion 

            txtFeet.Text = feet.ToString();


        }

        private void btnKilogramstopounds_Click(object sender, EventArgs e)
        {
            // Get Variables
            double kilograms, pounds;

            // Get input from txtKilograms 
            kilograms = double.Parse(txtKilograms.Text);

            // Calculate Conversion 

            pounds = kilograms * 2.2;

            // Output Conversion

            txtPounds.Text = pounds.ToString();
        }

        private void btnLitrestogallons_Click(object sender, EventArgs e)
        {
            // Get Variables 
            double litres, gallons;

            //Get input from txtLitres
            litres = double.Parse(txtLitres.Text);

            // Calculate Conversion

            gallons = litres * 0.264;

            // Output Conversion

            txtGallons.Text = gallons.ToString();
        }
    }
}
