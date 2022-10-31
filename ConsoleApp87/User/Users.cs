using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87.Hotel.User
{
    class Users
    {
        public int Id { get; set; }
        public static int Count { get; set; } = 1;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Finkod { get; set; }
        public DateTime RegisterTime { get; set; } = DateTime.Now;


        public Users(string firstName, string lastName, string finkod)
        {
            Id = Count++;
            FirstName = firstName;
            LastName = lastName;
            Finkod = finkod;
        }

    }
}
