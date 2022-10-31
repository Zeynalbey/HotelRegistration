using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87.Hotel.Repository
{
    class RoomRepository
    {
        public List<Rooms> rooms { get; set; } = new List<Rooms>
        {
            new Rooms(1, 50),
            new Rooms(5, 60),
            new Rooms(3, 55),
            new Rooms(2, 70),
            new Rooms(6, 40),
            new Rooms(4, 80)
        };

        public void Count()
        {

            Console.WriteLine(10 - rooms.Count);
            
        }

    }
}
