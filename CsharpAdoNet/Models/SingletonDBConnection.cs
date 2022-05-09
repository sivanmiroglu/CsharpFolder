using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpAdoNet.Env;
using System.Data.SqlClient;


namespace CsharpAdoNet.Models
{
    public class SingletonDBConnection
    {
        private static SingletonDBConnection dbInstance;

        private readonly SqlConnection sqlConnection = new SqlConnection(Connection.ConnectionString);


        private SingletonDBConnection()
        {

        }

        public static SingletonDBConnection getDbInstance()
        {
            if (dbInstance == null)
            {
                dbInstance = new SingletonDBConnection();
            }

            return dbInstance;
        }



        public SqlConnection GetDbConnection()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {

            }

            return sqlConnection;
        }
    }
}
