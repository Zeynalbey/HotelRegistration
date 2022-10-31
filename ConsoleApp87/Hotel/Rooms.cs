using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp87.Hotel
{
    class Rooms
    {
        public int RoomNumber { get; set; }
        public int RoomPrice { get; set; }

        public int RoomCount { get; set; }
        public static int Count { get; set; } = 1;

        public bool IsEmpty { get; set; }

        public Rooms(int roomNumber, int roomPrice)
        {
            RoomNumber = roomNumber;
            RoomPrice = roomPrice;
            RoomCount = Count++;

        }



    }
}
