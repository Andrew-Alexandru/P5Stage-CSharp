using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardApplication;

namespace BoardApplication
{
    class Program
    {
        private static void DisplayMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Display all users");
            Console.WriteLine("2 - Add a new user");
            Console.WriteLine("3 - Get a user by message");
            Console.WriteLine("4 - Delete a user by message");
            Console.WriteLine("5 - Update a user");
            Console.WriteLine("6 - Exit");
        }
        static void Main(string[] args)
        {
            DisplayMenu();
        }
    }
}




