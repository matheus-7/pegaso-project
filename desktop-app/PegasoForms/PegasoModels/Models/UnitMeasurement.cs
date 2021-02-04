using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasoModels.Models
{
    public class UnitMeasurement
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Abbreviation { get; private set; }
        public DateTime DateRegister { get; private set; }
        public User User { get; private set; }


        public UnitMeasurement(int id, string name, string abbreviation, DateTime dateRegister, User user)
        {
            Id = id;
            Name = name;
            Abbreviation = abbreviation;
            DateRegister = dateRegister;
            User = user;
        }

    }
}
