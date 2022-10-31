using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp87.Hotel.User
{
    class UserRepository
    {
        public List<Users> users { get; set; } = new List<Users>
        {
            new Users("Zeynal","Mikayilli", "zeze"),
            new Users("Zeynal","Mikayilli", "zeze"),
            new Users("Zeynal","Mikayilli", "zeze"),
            new Users("Zeynal","Mikayilli", "zeze")
        };


        public void AddUsers(Users user)
        {
            users.Add(user);
        }
    }
}
