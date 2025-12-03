using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Application
{
    internal class Room
    {

        // attributes 

        int roomNumber;
        bool occupied;

        // Constructors 

        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }

        // Methods 
        public void GetCustomerName()
        {

        }

        public int GetRoomNumber()
        {
            return roomNumber;
        }

        public bool IsOccupied()
        {
            return occupied;
        }

        public void OccupyRoom()
        {
            occupied = true;
        }

        public void Vacate()
        {
            occupied = false;
        }

    }

        
}
