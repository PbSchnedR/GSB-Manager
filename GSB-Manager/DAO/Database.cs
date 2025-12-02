using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace GSB_Manager.DAO
{
    public class Database
    {
        readonly string myConnectionString = "server=localhost;PORT=3311;uid=root;pwd=root;database=GSB-manager";
        
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(myConnectionString);
        }

    }
}
