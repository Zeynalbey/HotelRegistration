using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleApp87.Hotel.Repository;
using ConsoleApp87.Hotel.User;
using ConsoleApp87.Validations;

namespace ConsoleApp87.Authentication
{
    class Authentications
    {
        
        public void TextControl()
        {
            UserRepository userRepository = new UserRepository();
            RoomRepository roomRepository = new RoomRepository();

            Console.Write("Write name:");
            string name = Console.ReadLine();
            Console.Write("Write surname:");
            string lastName = Console.ReadLine();
            Console.Write("Write finkod:");
            string finkod = Console.ReadLine();

            if (UserValidations.IsvalidText(name) && 
                UserValidations.IsvalidText(lastName) && 
                UserValidations.IsvalidText(finkod))
            {
                //if (!(roomRepository.Count() >= 10))
                //{
                //    Users users = new Users(name, lastName, finkod);
                //    userRepository.AddUsers(users);
                //}
                //else
                //{
                //    Console.WriteLine("Otelde yer yoxdur.");
                //}
            }
        }
    }
}
