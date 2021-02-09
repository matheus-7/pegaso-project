using System;

namespace PegasoModels.Models
{
    public class Company
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime DateRegister { get; private set; }
        public User User { get; private set; }


        public Company(int id, string name, DateTime dateRegister, User user)
        {
            Id = id;
            Name = name;
            DateRegister = dateRegister;
            User = user;
        }

    }
}
