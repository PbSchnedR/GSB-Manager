using System;
using MySql.Data.MySqlClient;

namespace GSB_Manager.DAO
{
    public class Database
    {
        private readonly string myConnectionString;

        public Database()
        {
#if DEBUG
            const string host = "localhost";
            const string port = "3311";
            const string user = "root";
            const string password = "root";
#else
            string host = AWS_HOST;
            string port = "3306";  
            string user = AWS_USER;
            string password = AWS_PASSWORD;
#endif

            myConnectionString =
                $"server={host};PORT={port};uid={user};pwd={password};database=GSB-Manager;";
        }

#if !DEBUG
        private const string AWS_HOST = "__AWS_HOST__";
        private const string AWS_USER = "__AWS_USER__";
        private const string AWS_PASSWORD = "__AWS_PASSWORD__";
#endif

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(myConnectionString);
        }
    }
}
