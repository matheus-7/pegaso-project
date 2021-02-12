using PegasoModels.Database;
using PegasoModels.Models;
using PegasoModels.Utils;
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


        private static User ConvertDRToUser(SqlDataReader DR)
        {
            if (!DR.Read()) return null;

            return new User(
                Convert.ToInt32(DR["Id"]),
                DR["Username"].ToString(),
                DR["Password"].ToString(),
                DR["Name"].ToString(),
                DR["Email"].ToString(),
                Convert.ToBoolean(DR["Active"])
            );
        }

        private void InsertLog(User user, Log.Type type)
        {
            try
            {
                SqlCommand command = new SqlCommand(@"INSERT INTO [Log_User] (UserId,  Username,  Password,  Name,  Email,  Active,  LogType,  LogUserId,  LogDate  )
                                                                      values (@UserId, @Username, @Password, @Name, @Email, @Active, @LogType, @LogUserId, GETDATE())");

                command.Parameters.AddWithValue("@UserId", user.Id);
                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Active", user.Active);
                command.Parameters.AddWithValue("@LogType", type);
                command.Parameters.AddWithValue("@LogUserId", Global.User != null ? Global.User.Id : user.Id);

                database.SQLCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(User user)
        {
            try
            {
                SqlCommand command = new SqlCommand(@"INSERT INTO [User] (Username,  Password,  Name,  Email,  Active )
                                                                  VALUES (@Username, @Password, @Name, @Email, @Active);

                                                      SELECT MAX(Id) AS Id
                                                      FROM [User]");

                command.Parameters.AddWithValue("@Username", user.Username);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Name", user.Name);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@Active", user.Active);

                SqlDataReader DR = database.SQLQuery(command);

                if (DR.Read()) user.Id = Convert.ToInt32(DR["Id"]);
                DR.Close();
                
                InsertLog(user, Log.Type.Inclusão);

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
                                                             Email,
                                                             Active
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
