using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Application
{
    internal class Room
    {

        // Attributes 
        private int roomNumber;
        public int RoomNumber { get { return  roomNumber; } }

        // Constructor
        public Room()
        {
            roomNumber = 0;
        }

        // Second Constructor 
        public Room(int RoomNumber)
        {
            roomNumber = RoomNumber;
        }


        // Is room Occupied or not 
        private Customer occupant;

        public bool IsOccupied()
        {
            return occupant != null;
        }

        public string GetOccupancyInfo()
        {
            if (occupant == null)
                return "Room " + roomNumber + " Is Empty";
            else
                return "Room " + roomNumber + " is occupied";

            
        }
    }

        
}
