using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardApplication;
using BoardLibrary;

namespace BoardApplication
{
    class Program
    {
        private static UsersService users; 
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
        private static void DisplayUser(User user)
        {
            Console.WriteLine("{0} {1} (email={2}) - {3}",
                user.FirstName, user.LastName, user.email, user.BirthDate);
        }
        private static void DisplayAllUsers()
        {
            Console.WriteLine("All users:");
            foreach (User user in users.GetUsers())
            {
                DisplayUser(user);
            }

        }
        private static User ReadUser()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter email: ");
            string UserEmail = Console.ReadLine();
            Console.Write("Enter year of birth (yyyy): ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter month of birth (1-12): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter day of birth (1-31): ");
            int day = int.Parse(Console.ReadLine());
            return users.AddUser(UserEmail, firstName, lastName, new DateTime(year, month, day));
        }
        static void Main(string[] args)
        {
            users = new UsersService();
            users.AddUser("nadia.comanici@pentalog.ro", "Nadia", "Comanici", new DateTime(1986, 01, 24));
            users.AddUser("radu.popescu@nttdata.ro", "Radu", "Popescu", new DateTime(1990, 10, 13));
            while (true)
            {
                DisplayMenu();
                Console.Write("Your option is: ");
                int option = 0;
                int.TryParse(Console.ReadLine(), out option);
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                       DisplayAllUsers();
                       break;
                    case 2:
                        ReadUser();
                        break;
                   /*case 3:
                       SearchStudentById();
                       break;
                    case 4:
                        DeleteStudentById();
                        break;
                    case 5:
                        UpdateStudentById();
                        break;
                        */
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again!");
                        break;
                   
                }
                Console.WriteLine();

            }

        }
    }
}