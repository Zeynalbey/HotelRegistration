using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87.Hotel
{
    class Registration
    {




        public List<Order> Orders { get; set; } = new List<Order>();
        public void RegisterNewUser(Order order)
        {
            Orders.Add(order);
        }

    }
}
