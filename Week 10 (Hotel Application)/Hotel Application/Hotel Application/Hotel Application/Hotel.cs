using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Application
{
    internal class hotel
    {

        // attributes

        Dictionary<int, Room> rooms = new Dictionary<int, Room>();


        // Constuctor 
        public hotel()
        {
            // Create 40 rooms and put them in the hotel's dictionary
            for (int roomNumber = 1; roomNumber <= 40; roomNumber++)
            {
                // Create Room
                Room room = new Room(roomNumber);

                // Put it in the Dictionary 
                rooms[roomNumber] = room;
            }
        }

        public void ReportOnRooms()
        {

        }

        public void BookRoom(string customerName, int roomNumber)
        {
            // Get the room from the dictionary

            Room room = rooms[roomNumber];

            // Occupy the room
            room.OccupyRoom();
        }


        public void VacateRoom(int roomNumber)
        {
            Room room = rooms[roomNumber];

            // Vacate Room
            room.Vacate();
        }

        public void CountCustomers()
        {

        }

        public void ShowIncome(bool IsOccupied)
        {
            
        }

        public Dictionary<int, Room>GetRooms()
        {
            return rooms;
        }

    }

        
}
