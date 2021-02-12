using System;
using System.Data.SqlClient;
using System.Configuration;
using PegasoModels.Models;

namespace PegasoModels.Database
{
    public class DBUtils
    {
        public SqlConnection dbConnection;

        public DBUtils()
        {
            try
            {
                string dbName = ConfigurationManager.AppSettings["DATABASE_NAME"];

                dbConnection = LocalDB.GetLocalDB(dbName, false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        public void Close()
        {
            dbConnection.Close();
        }

        public void SQLCommand(SqlCommand command)
        {
            try
            {
                command.Connection = dbConnection;
                command.CommandTimeout = 0;

                SQLCheckNullParameters(command);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void SQLCheckNullParameters(SqlCommand command)
        {
            foreach (SqlParameter parameter in command.Parameters)
            {
                if (parameter.Value == null) parameter.Value = DBNull.Value;
            }
        }

        public SqlDataReader SQLQuery(SqlCommand command)
        {
            SqlDataReader DR;
            
            try
            {
                command.Connection = dbConnection;
                command.CommandTimeout = 0;

                SQLCheckNullParameters(command);

                DR = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DR;
        }

    }
}
