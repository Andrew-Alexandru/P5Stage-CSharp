using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    interface IUsersService
    {
        User AddUser(string email, string firstName, string lastName, DateTime birthDate);
        List<User> GetUsers();
        User GetUserByEmail(string email);
        bool DeleteUserByEmail(string email);
        bool UpdateUser(string email, string newFirstName, string newLastName);
    }
}
