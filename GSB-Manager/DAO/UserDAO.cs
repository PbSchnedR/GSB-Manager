using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSB_Manager.Models;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace GSB_Manager.DAO
{
    public class UserDAO
    {
        private readonly Database db = new Database();

        public User Login(string email, string password)
        {
            int id = 0;
            string name = string.Empty;
            string firstName = string.Empty;
            bool role = false;

            var connection = db.GetConnection();
            connection.Open();

            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM Users WHERE email = @email AND password = SHA2(@password, 256);";
                    myCommand.Parameters.AddWithValue("@email", email);
                    myCommand.Parameters.AddWithValue("@password", password);

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                             id = myReader.GetInt32("users_id");
                             name = myReader.GetString("name");
                             firstName = myReader.GetString("firstname");
                             role = myReader.GetBoolean("role");
                        }
                    }
                    User user = new User(id, name, firstName, role);


                    connection.Close();
                    return user;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }
        }
    }
}
