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
    /// Data Access Object (DAO) permettant de gérer les opérations sur les spécialités.
    /// </summary>
    public class SpecialityDAO
    {
        /// <summary>
        /// Instance de la classe <see cref="Database"/> permettant d'obtenir une connexion MySQL.
        /// </summary>
        private readonly Database db = new Database();

        /// <summary>
        /// Récupère la liste de toutes les spécialités présentes dans la base de données.
        /// </summary>
        /// <returns>
        /// Une liste d'objets <see cref="Speciality"/>,
        /// ou <c>null</c> en cas d'erreur.
        /// </returns>
        public List<Speciality> GetAllSpecialities()
        {
            List<Speciality> specialities = new List<Speciality>();
            var connection = db.GetConnection();
            connection.Open();

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = @"SELECT * FROM `Speciality` ORDER BY name;";

                using var myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int specialityId = myReader.GetInt32("speciality_id");
                    string name = myReader.GetString("name");

                    specialities.Add(new Speciality(specialityId, name));
                }

                return specialities;
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
    }
}
