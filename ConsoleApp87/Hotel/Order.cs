using ConsoleApp87.Hotel.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87.Hotel
{
    class Order
    {
        public Users user { get; set; }
        public int DayCount { get; set; }
        public Rooms Room { get; set; }

    }
}
