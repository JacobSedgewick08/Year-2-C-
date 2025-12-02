using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Application
{
    internal class Hotel
    {
        private Dictionary<string Customer> Customer = new Dictionary<string, Customer>();
        private int NextRoomNumber = 0;
        public void BookRoom(string name, int customer)
        {
            Room tempRoom = new Room(NextRoomNumber++);

            // Create Customer
            Customer tempCustomer = new Customer(name, customers);


            // Add customer to the Dictionary 
            Room.add(tempRoom, tempCustomer);
        }







    } }

