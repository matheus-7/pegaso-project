using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasoModels.Models
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Color { get; private set; }
        public Category Category { get; private set; }
        public UnitMeasurement UnitMeasurement { get; private set; }
        public double Price { get; private set; }
        public DateTime DateRegister { get; private set; }
        public User User { get; private set; }


        public Product(int id, string name, string color, Category category, UnitMeasurement unitMeasurement, double price, DateTime dateRegister, User user)
        {
            Id = id;
            Name = name;
            Color = color;
            Category = category;
            UnitMeasurement = unitMeasurement;
            Price = price;
            DateRegister = dateRegister;
            User = user;
        }

    }
}
