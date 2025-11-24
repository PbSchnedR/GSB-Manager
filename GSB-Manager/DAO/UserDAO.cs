using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSB_Manager.Models;
using MySql.Data.MySqlClient;

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

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = @"SELECT * FROM Users WHERE email = @email AND password = SHA2(@password, 256);";
                myCommand.Parameters.AddWithValue("@email", email);
                myCommand.Parameters.AddWithValue("@password", password);

                using var myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    id = myReader.GetInt32("user_id");
                    name = myReader.GetString("name");
                    firstName = myReader.GetString("firstname");
                    role = myReader.GetBoolean("role");
                }

                return new User(id, name, firstName, role);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<User> GetAllDoctors()
        {
            List<User> doctors = new List<User>();
            var connection = db.GetConnection();
            connection.Open();

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = @"SELECT * FROM `Users` WHERE role = 0";

                using var myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string name = myReader.GetString("name");
                    string firstName = myReader.GetString("firstname");

                    doctors.Add(new User(name, firstName));
                }

                return doctors;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            var connection = db.GetConnection();
            connection.Open();

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = @"SELECT * FROM `Users`";

                using var myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int user_id = myReader.GetInt32("user_id");
                    string name = myReader.GetString("name");
                    string firstName = myReader.GetString("firstname");
                    string email = myReader.GetString("email");
                    bool role = myReader.GetBoolean("role");

                    users.Add(new User(user_id, name, firstName, email, role));
                }

                return users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public int CreateUser(string name, string firstname, string email, string password, bool role)
        {
            int newId = 0;
            var connection = db.GetConnection();
            connection.Open();

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = @"
                    INSERT INTO Users (name, firstname, email, password, role)
                    VALUES (@name, @firstname, @email, SHA2(@password, 256), @role);
                    SELECT LAST_INSERT_ID();
                ";

                myCommand.Parameters.AddWithValue("@name", name);
                myCommand.Parameters.AddWithValue("@firstname", firstname);
                myCommand.Parameters.AddWithValue("@email", email);
                myCommand.Parameters.AddWithValue("@password", password);
                myCommand.Parameters.AddWithValue("@role", role);

                object result = myCommand.ExecuteScalar();
                if (result != null)
                    newId = Convert.ToInt32(result);

                return newId;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans AddUser : " + ex.Message);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool EditUser(int user_id, string name, string firstname, string email)
        {
            var connection = db.GetConnection();
            connection.Open();

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                {
                    myCommand.CommandText = @"
                        UPDATE Users
                        SET name = @name,
                            firstname = @firstname,
                            email = @email
                        WHERE user_id = @user_id;
                    ";
                }
                

                myCommand.Parameters.AddWithValue("@user_id", user_id);
                myCommand.Parameters.AddWithValue("@name", name);
                myCommand.Parameters.AddWithValue("@firstname", firstname);
                myCommand.Parameters.AddWithValue("@email", email);

                int rowsAffected = myCommand.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans EditUser : " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
