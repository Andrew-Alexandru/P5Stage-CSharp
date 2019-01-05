using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class UsersService : IUsersService
    {
        private List<User> users;
        public UsersService()
        {
            this.users = new List<User>();
            //AddUser("vasile.pop@gmail.com", "Vasile", "Popescu", new DateTime(1990, 03, 02));
            //AddUser("maria.ionescu@yahoo.com", "Maria", "Ionescu", new DateTime(1988, 02, 24));
            //AddUser("ionel.georg@gmail.com", "Ionel", "Georgescu", new DateTime(1991, 11, 13));
        }



        public User AddUser(string email,string firstName, string lastName, DateTime birthDate)
        {

            User user = new User(email, firstName, lastName, birthDate);
            this.users.Add(user);
            return user;

        }



        public List<User> GetUsers()
        {
            return this.users;
        }

        public User GetUserByEmail(string email)
        {
            foreach (User user in this.users)

            {

                if (user.email == email)

                {

                    return user;

                }

            }

            return null;

        }

       public bool DeleteUserByEmail(string email)
        {

            User user = GetUserByEmail(email);
            if (user != null)
            {

                users.Remove(user);

                return true;

            }

            return false;

        }
        public bool UpdateUser(string email, string newFirstName, string newLastName)
        {
            User user = GetUserByEmail(email);
            if (user != null)
            {
                user.FirstName = newFirstName;
                user.LastName = newLastName;
                return true;
            }
            return false;
        }

    }
}
