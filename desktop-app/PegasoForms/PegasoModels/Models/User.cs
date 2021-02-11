using PegasoModels.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasoModels.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool Ativo { get; private set; }

         
        public User(int id, string username, string password, string name, string email, bool ativo)
        {
            Id = id;
            Username = username;
            Password = password;
            Name = name;
            Email = email;
            Ativo = ativo;
        }


        private void Insert()
        {
            new UserDAO().Insert(this);
        }

        public void Save()
        {
            try
            {
                if (this.Id == 0) this.Insert();
                else this.Update();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static User Select(string username, string password)
        {
            try
            {
                return new UserDAO().Select(username, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void Update()
        {
            
        }

    }
}
