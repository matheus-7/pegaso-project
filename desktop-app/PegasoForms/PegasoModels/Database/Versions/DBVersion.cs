using System;
using System.Data.SqlClient;
using System.Reflection;

namespace PegasoModels.Database.Versions
{
    public class DBVersion
    {
        public DBUtils database;

        public DBVersion()
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


        private void CheckVersionsToUpdate(string databaseVersion)
        {
            Version softwareVersion = Assembly.GetExecutingAssembly().GetName().Version;

            if (String.IsNullOrEmpty(databaseVersion)) throw new Exception("Impossível determinar a versão do banco de dados!");
            if (String.IsNullOrEmpty(softwareVersion.ToString())) throw new Exception("Impossível determinar a versão do software!");
            
            if (databaseVersion.Equals(softwareVersion.ToString())) return;
        }

        public void UpdateVersion()
        {
            try
            {
                string databaseVersion = "";

                SqlCommand command = new SqlCommand(@"IF NOT EXISTS (SELECT name 
                                                                     FROM SYSOBJECTS 
                                                                     WHERE name = 'Version' 
                                                                        AND xtype = 'U')
                                                      BEGIN
                                                        
                                                         CREATE TABLE [Version] (
												            [ProductVersion][varchar](15) NOT NULL DEFAULT ''
											             )

                                                      END

                                                      SELECT ProductVersion
                                                      FROM [Version]");

                SqlDataReader DR = database.SQLQuery(command);

                if (DR.Read())
                {
                    databaseVersion = DR["ProductVersion"].ToString();
                    
                    DR.Close();

                    CheckVersionsToUpdate(databaseVersion);
                }
                else
                {
                    DR.Close();

                    DBVersion1_0_0_0.UpdateDatabase(database);

                    UpdateVersion();
                }

                database.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
