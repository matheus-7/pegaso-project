using PegasoModels.Database;
using PegasoModels.Models;
using System;
using System.Data.SqlClient;

namespace PegasoModels.DAO
{
    public class UserDAO
    {
        public DBUtils database;

        public UserDAO()
        {
            try
            {
                database = new DBUtils();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static User ConvertDRToUser(SqlDataReader DR)
        {
            if (!DR.Read()) return null;

            return new User(
                Convert.ToInt32(DR["Id"]),
                DR["Username"].ToString(),
                DR["Password"].ToString(),
                DR["Name"].ToString(),
                DR["Email"].ToString()
            );
        }

        public void Insert(User user)
        {
            try
            {
                SqlCommand command = new SqlCommand(@"INSERT INTO [User] (Username,  Password,  Name,  Email )
                                                                  VALUES (@Username, @Password, @Name, @Email)");

                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Email", user.Email);

                database.SQLCommand(command);
                database.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User Select(string username, string password)
        {
            User user;

            try
            {
                SqlCommand command = new SqlCommand(@"SELECT Id, 
                                                             Username, 
                                                             Password, 
                                                             Name, 
                                                             Email
                                                      FROM [User]
                                                      WHERE Username = @Username
                                                         AND Password = @Password");

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader DR = database.SQLQuery(command);

                user = ConvertDRToUser(DR);

                database.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return user;
        }

    }
}
