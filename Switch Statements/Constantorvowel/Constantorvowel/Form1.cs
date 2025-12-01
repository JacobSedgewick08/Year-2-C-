using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constantorvowel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnletter_Click(object sender, EventArgs e)
        {
            // Variable

            string letter;

            // Get Letter from TextBox

            letter = (txtLetter.Text);

            // Switch Statements

            switch (letter)
            {
                case "a":
                    txtMessage.Text = letter + " is a vowel";
                break;

                case "e":
                    txtMessage.Text = letter + " is a vowel";
                break;

                case "i":
                    txtMessage.Text = letter + " is a vowel";
                break;

                case "o":
                    txtMessage.Text = letter + " is a vowel";
                break;

                case "u":
                    txtMessage.Text = letter + "is a vowel";
                break;

                case "y":
                    txtMessage.Text = letter + " is a constant and a vowel";
                break;

                default:
                    txtMessage.Text = letter + " is a constant";
                break;
            }
        }
    }
}
