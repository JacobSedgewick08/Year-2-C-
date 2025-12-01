using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        Calc Calculating;
        public Form1()
        {
            InitializeComponent();
            Calculating = new Calc();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2 = decimal.Parse(txtNum2.Text);
            decimal ans = Calculating.Addition(num1, num2);
            MessageBox.Show(num1 + " + " + num2 + " = " + ans);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2 = decimal.Parse(txtNum2.Text);
            decimal ans = Calculating.Multiply(num1, num2);
            MessageBox.Show(num1 + " x " + num2 + " = " + ans);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2 = decimal.Parse(txtNum2.Text);
            decimal ans = Calculating.Subtract(num1, num2);
            MessageBox.Show(num1 + " - " + num2 + " = " + ans);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(txtNum1.Text);
            decimal num2 = decimal.Parse(txtNum2.Text);
            decimal ans = Calculating.Divide(num1, num2);
            MessageBox.Show(num1 + " / " + num2 + " = " + ans);
        }
    }
}
