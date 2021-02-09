using System.Data.SqlClient;

namespace PegasoModels.Database.Versions
{
    public static class DBVersion1_0_0_0
    {
        private static void CreateUserTable(DBUtils database)
        {
            SqlCommand command = new SqlCommand(@"CREATE TABLE [User] (
	                                                 [Id][int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                                                 [Username][varchar](50) NOT NULL,
	                                                 [Password][varchar](512) NOT NULL,
	                                                 [Name][varchar](80) NOT NULL,
	                                                 [Email][varchar](100) NULL
                                                  )");

            database.SQLCommand(command);
        }
        
        public static void UpdateDatabase(DBUtils database)
        {
            CreateUserTable(database);

            SaveVersion(database);
        }

        private static void SaveVersion(DBUtils database)
        {
            SqlCommand command = new SqlCommand(@"INSERT INTO [Version] (ProductVersion)
                                                                 VALUES ('1.0.0.0'     )");

            database.SQLCommand(command);
        }

    }
}
