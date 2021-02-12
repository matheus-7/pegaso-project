using PegasoModels.DAO;
using PegasoModels.Models;
using System.Data.SqlClient;

namespace PegasoModels.Database.Versions
{
    public static class DBVersion1_0_0_0
    {
        private static void CreateAdminUser()
        {
            User user = new User(
                0,
                "admin",
                "admin",
                "Administrador",
                null,
                true
            );

            new UserDAO().Insert(user);
        }

        private static void CreateCompanyTable(DBUtils database)
        {
            SqlCommand command = new SqlCommand(@"CREATE TABLE [Company] (
	                                                 [Id][int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                                                 [Name][varchar](100) NOT NULL
                                                  )");

            database.SQLCommand(command);

            command.CommandText = @"CREATE TABLE [Log_Company] (
	                                   [Id][int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
                                       [CompanyId][int] NOT NULL FOREIGN KEY REFERENCES [Company](Id),
	                                   [Name][varchar](100) NOT NULL,
                                       [LogType][varchar](20) NOT NULL,
                                       [LogUserId][int] NOT NULL FOREIGN KEY REFERENCES [User](Id),
                                       [LogDate][datetime] NOT NULL
                                    )";

            database.SQLCommand(command);
        }

        private static void CreateUserTable(DBUtils database)
        {
            SqlCommand command = new SqlCommand(@"CREATE TABLE [User] (
	                                                 [Id][int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                                                 [Username][varchar](50) NOT NULL,
	                                                 [Password][varchar](512) NOT NULL,
	                                                 [Name][varchar](80) NOT NULL,
	                                                 [Email][varchar](100) NULL,
                                                     [Active][bit] NOT NULL
                                                  )");

            database.SQLCommand(command);

            command.CommandText = @"CREATE TABLE [Log_User] (
	                                   [Id][int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	                                   [UserId][int] NOT NULL FOREIGN KEY REFERENCES [User](Id),
                                       [Username][varchar](50) NOT NULL,
	                                   [Password][varchar](512) NOT NULL,
	                                   [Name][varchar](80) NOT NULL,
	                                   [Email][varchar](100) NULL,
                                       [Active][bit] NOT NULL,
                                       [LogType][varchar](20) NOT NULL,
                                       [LogUserId][int] NOT NULL FOREIGN KEY REFERENCES [User](Id),
                                       [LogDate][datetime] NOT NULL
                                    )";

            database.SQLCommand(command);
        }

        public static void UpdateDatabase(DBUtils database)
        {
            CreateUserTable(database);
            CreateCompanyTable(database);

            CreateAdminUser();

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
