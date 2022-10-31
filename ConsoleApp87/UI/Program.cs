using System;
using System.Data;
using ConsoleApp87.Authentication;
using ConsoleApp87.Hotel.Repository;
using ConsoleApp87.Hotel.User;
using ConsoleApp87.Validations;

namespace ConsoleApp87
{
    class Program
    {
        static void Main(string[] args)
        {
            Authentications authentications = new Authentications();
            RoomRepository roomRepository = new RoomRepository();

            Console.WriteLine("Nece bos otag oldugunu oyrenmek ucun 5-i bas.");
            int command1 = int.Parse(Console.ReadLine());

            if (command1 == 5)
            {
                roomRepository.Count();
            }
            else
            {
                Console.WriteLine("sagol");
            }


            Console.WriteLine("Write '1' for Register");
            string command = Console.ReadLine();

            if (command == "1")
            {
                authentications.TextControl();
            }
            else
            {
                Console.WriteLine("command not found");
            }

        }
    }
}
