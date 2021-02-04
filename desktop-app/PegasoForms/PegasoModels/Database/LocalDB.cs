using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;

namespace PegasoModels.Database
{
	public static class LocalDB
	{
        private static bool CreateDatabase(string dbName, string dbFileName)
		{
			try
			{
				if (!File.Exists(dbFileName))
                {
					string connectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");

					using (var connection = new SqlConnection(connectionString))
					{
						connection.Open();

						SqlCommand cmd = connection.CreateCommand();

						DetachDatabase(dbName);

						cmd.CommandText = String.Format("CREATE DATABASE {0} ON (NAME = N'{0}', FILENAME = '{1}')", dbName, dbFileName);
						cmd.ExecuteNonQuery();
					}
                }

				if (File.Exists(dbFileName)) return true;
				else return false;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
        
		private static void CreateDirectory(string outputFolder)
        {
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
        }
        
		private static void DeleteDatabase(string dbFileName, string logFileName, bool deleteIfExists)
        {
			if (deleteIfExists)
            {
				if (File.Exists(dbFileName))
				{
					if (File.Exists(logFileName)) File.Delete(logFileName);
                
					File.Delete(dbFileName);
				}
            }
        }
		
		private static bool DetachDatabase(string dbName)
		{
			try
			{
				string connectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True");

				using (var connection = new SqlConnection(connectionString))
				{
					connection.Open();

					SqlCommand cmd = connection.CreateCommand();
					
					cmd.CommandText = String.Format("exec sp_detach_db '{0}'", dbName);
					cmd.ExecuteNonQuery();

					return true;
				}
			}
			catch 
			{
				return false;
			}
		}
        
		private static SqlConnection GetConnection(string dbName, string dbFileName)
        {
            string connectionString = String.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDBFileName={1};Initial Catalog={0};Integrated Security=True;", dbName, dbFileName);
            
			SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            
			return connection;
        }
		
		public static SqlConnection GetLocalDB(string dbName, bool deleteIfExists)
		{
			try
            {
                string dbDirectory = ConfigurationManager.AppSettings["DATABASE_DIRECTORY"];
                string outputFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), dbDirectory);
                string mdfFilename = dbName + ".mdf";
                string dbFileName = Path.Combine(outputFolder, mdfFilename);
                string logFileName = Path.Combine(outputFolder, String.Format("{0}_log.ldf", dbName));

                CreateDirectory(outputFolder);
                DeleteDatabase(dbFileName, logFileName, deleteIfExists);
				CreateDatabase(dbName, dbFileName);
                
				return GetConnection(dbName, dbFileName);
            }
            catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
