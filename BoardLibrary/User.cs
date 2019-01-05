using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardLibrary
{
    public class User : Person
    {

        public string email { get; private set; }

        // default value is null
        public User(string email, string firstName, string lastName, DateTime birthDate)
            : base(firstName, lastName, birthDate)
        {

            this.email = email;
        }
    }
}
