using System;
using MySql.Data.MySqlClient;

namespace GSB_Manager.DAO
{
    public class Database
    {
        private readonly string myConnectionString;

        public Database()
        {
            const string host = "localhost";
            const string port = "3311";
            const string user = "root";
            const string password = "root";

            myConnectionString =
                $"server={host};PORT={port};uid={user};pwd={password};database=GSB-Manager;";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(myConnectionString);
        }
    }
}
