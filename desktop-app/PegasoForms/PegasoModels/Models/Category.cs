using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasoModels.Models
{
    public class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime DateRegister { get; private set; }
        public User User { get; private set; }


        public Category(int id, string name, DateTime dateRegister, User user)
        {
            Id = id;
            Name = name;
            DateRegister = dateRegister;
            User = user;
        }

    }
}
