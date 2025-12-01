using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Input length 
            // Input Width
            // Calculate Area
            // Output the Area

            // Variables
            double length, width, area;

            // Input the length
            length = double.Parse(txtLength.Text);

            // Input Width
            width = double.Parse(txtWidth.Text);

            // Calculate Area
            area = length * width;

            //Output Area
            txtArea.Text = area.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWidth_Click(object sender, EventArgs e)
        {

        }

        private void lblCalculateVolume_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateVolume_Click(object sender, EventArgs e)
        {
            // Input lenght
            // Input Width
            // Input Height
            // Calculate Volume 
            // Output Volume

            // Variables
            double length, width, height, volume;

            // Input the Length
            length = double.Parse(txtLength.Text);

            // Input Width
            width = double.Parse(txtWidth.Text);

            // Input Height
            height = double.Parse(txtHeight.Text);

            // Calculate Volume 
            volume = length * width * height;

            //Output Volume
            txtVolume.Text = volume.ToString();
        }
    }
}
