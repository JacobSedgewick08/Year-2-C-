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
        hotel eagleHotel = new hotel();
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

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            // Input Customer name and room number required

            string customerName = txtName.Text;

            int roomNumber = int.Parse(txtRoomNumber.Text);

            eagleHotel.BookRoom(customerName, roomNumber);
        }

        private void btnVacateRoom_Click(object sender, EventArgs e)
        {
            int roomNumber = int.Parse(txtRoomNumber.Text);

            eagleHotel.VacateRoom(roomNumber);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            // Get Dictionary from Hotel Class 
            
            Dictionary<int, Room> hotelRooms = eagleHotel.GetRooms();
            string customerName = txtName.Text;

            foreach (var entry in hotelRooms)
            {
                int roomNumber = entry.Key;
                Room room = entry.Value;
                // Output into textbox 
                txtReport.AppendText($"Room {roomNumber}  Occupied = {room.IsOccupied()}\r\n");
            }
        }

        private void btnShowIncome_Click(object sender, EventArgs e)
        {
            // Attributes 
            int cost = 0;

            // Get Dictionary from Hotel class
            Dictionary<int, Room> hotelRooms = eagleHotel.GetRooms();

            foreach (var entry in hotelRooms)
            {
                Room room = entry.Value;
                if (room.IsOccupied())
                {
                    cost += 20;
                }
            }

            MessageBox.Show($"The Total income for the night is {cost}");
        }
    }
}