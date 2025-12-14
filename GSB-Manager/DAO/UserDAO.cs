using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSB_Manager.Models;
using MySql.Data.MySqlClient;

namespace GSB_Manager.DAO
{
    /// <summary>
    /// Data Access Object (DAO) permettant de gérer les opérations CRUD sur les utilisateurs.
    /// </summary>
    public class UserDAO
    {
        /// <summary>
        /// Instance de la classe <see cref="Database"/> permettant d'obtenir une connexion MySQL.
        /// </summary>
        private readonly Database db = new Database();

        /// <summary>
        /// Authentifie un utilisateur à partir de son email et mot de passe.
        /// </summary>
        /// <param name="email">Adresse email de l'utilisateur.</param>
        /// <param name="password">Mot de passe non-hashé. Le hash SHA2 est effectué en base.</param>
        /// <returns>
        /// L'utilisateur correspondant aux identifiants fournis,
        /// ou <c>null</c> si aucun utilisateur n'est trouvé.
        /// </returns>
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

        /// <summary>
        /// Récupère la liste de tous les utilisateurs ayant le rôle de docteur.
        /// </summary>
        /// <returns>
        /// Une liste d'objets <see cref="User"/> représentant les docteurs,
        /// ou <c>null</c> si une erreur survient.
        /// </returns>
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

        /// <summary>
        /// Récupère tous les utilisateurs présents dans la base de données.
        /// </summary>
        /// <returns>
        /// Une liste de <see cref="User"/> contenant tous les utilisateurs,
        /// ou <c>null</c> en cas d'erreur.
        /// </returns>
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

        /// <summary>
        /// Crée un nouvel utilisateur dans la base de données.
        /// </summary>
        /// <param name="name">Nom de l'utilisateur.</param>
        /// <param name="firstname">Prénom de l'utilisateur.</param>
        /// <param name="email">Email de l'utilisateur.</param>
        /// <param name="password">Mot de passe non-hashé.</param>
        /// <param name="role">Rôle de l'utilisateur (true = admin, false = utilisateur normal).</param>
        /// <returns>
        /// L'ID de l'utilisateur nouvellement créé,
        /// ou 0 si l'insertion a échoué.
        /// </returns>
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

        /// <summary>
        /// Met à jour les informations d'un utilisateur existant.
        /// </summary>
        /// <param name="user_id">Identifiant unique de l'utilisateur.</param>
        /// <param name="name">Nouveau nom.</param>
        /// <param name="firstname">Nouveau prénom.</param>
        /// <param name="email">Nouvel email.</param>
        /// <returns>
        /// <c>true</c> si la mise à jour a réussi, sinon <c>false</c>.
        /// </returns>
        public bool EditUser(int user_id, string name, string firstname, string email, bool role)
        {
            var connection = db.GetConnection();
            connection.Open();

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;

                myCommand.CommandText = @"
                        UPDATE Users
                        SET name = @name,
                            firstname = @firstname,
                            email = @email,
                            role = @role
                        WHERE user_id = @user_id;
                    ";

                myCommand.Parameters.AddWithValue("@user_id", user_id);
                myCommand.Parameters.AddWithValue("@name", name);
                myCommand.Parameters.AddWithValue("@firstname", firstname);
                myCommand.Parameters.AddWithValue("@email", email);
                myCommand.Parameters.AddWithValue("@role", role);

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

        /// <summary>
        /// Supprime un utilisateur et toutes les données qui lui sont associées
        /// (Patients, Prescriptions, Appartient, Medicines liées aux prescriptions).
        /// </summary>
        /// <param name="user_id">ID de l'utilisateur à supprimer</param>
        /// <returns>True si la suppression a réussi, false sinon</returns>
        public bool DeleteUser(int userId)
        {
            using (var connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Users WHERE user_id = @Id;";
                    using var cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Id", userId);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}", "SQL Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

    }
}
