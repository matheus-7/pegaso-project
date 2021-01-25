using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasoModels
{
    public class User
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }


        public User(int id, string username, string password, string name, string email)
        {
            Id = id;
            Username = username;
            Password = password;
            Name = name;
            Email = email;
        }

    }
}
