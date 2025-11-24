using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSB_Manager.Models;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GSB_Manager.DAO
{
    internal class MedicineDAO
    {

        private readonly Database db = new Database();

        public List<Medicine> GetAllMedicine()
        {
            List<Medicine> medicines = new List<Medicine>();

            int id = 0;
            int user_id = 0;
            int dosage = 0;
            string name = string.Empty;
            string description = "helicoptère";
            string molecule = string.Empty;

            var connection = db.GetConnection();
            connection.Open();

            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM Medicine";

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("medicine_id");
                            user_id = myReader.GetInt32("user_id");
                            name = myReader.GetString("name");
                            description = myReader.GetString("description");
                            molecule = myReader.GetString("molecule");
                            dosage = myReader.GetInt32("dosage");

                            medicines.Add(new Medicine(id, user_id, dosage, name, description, molecule));
                        }
                    }


                    connection.Close();
                    return medicines;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }
        }

        public Medicine GetMedicineById(int medicineId)
        {
            int id = 0;
            int user_id = 0;
            int dosage = 0;
            string name = string.Empty;
            string description = "helicoptère";
            string molecule = string.Empty;

            var connection = db.GetConnection();
            connection.Open();
            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM Medicine WHERE medicine_id = @medicine_id;";
                    myCommand.Parameters.AddWithValue("@medicine_id", medicineId);

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("medicine_id");
                            user_id = myReader.GetInt32("user_id");
                            name = myReader.GetString("name");
                            description = myReader.GetString("description");
                            molecule = myReader.GetString("molecule");
                            dosage = myReader.GetInt32("dosage");
                        }
                    }
                    Medicine medicine = new Medicine(id, user_id, dosage, name, description, molecule);


                    connection.Close();
                    return medicine;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }


        }


        public Medicine CreateMedicine(int user_id, string name, string description, string molecule, int dosage)
        {
            int id = 0;
            var connection = db.GetConnection();
            connection.Open();
            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"INSERT INTO Medicine (user_id, name, description, molecule, dosage) VALUES (@user_id, @name, @description, @molecule, @dosage);";
                    myCommand.Parameters.AddWithValue("@user_id", user_id);
                    myCommand.Parameters.AddWithValue("@name", name);
                    myCommand.Parameters.AddWithValue("@description", description);
                    myCommand.Parameters.AddWithValue("@molecule", molecule);
                    myCommand.Parameters.AddWithValue("@dosage", dosage);

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("medicine_id");
                            user_id = myReader.GetInt32("user_id");
                            name = myReader.GetString("name");
                            description = myReader.GetString("description");
                            molecule = myReader.GetString("molecule");
                            dosage = myReader.GetInt32("dosage");
                        }
                    }
                    Medicine medicine = new Medicine(id, user_id, dosage, name, description, molecule);


                    connection.Close();
                    return medicine;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }
        }

        public int FindMedicineIdByName(string name)
        {
            int id = -1;

            using (var connection = db.GetConnection())
            {
                connection.Open();

                try
                {
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT medicine_id FROM Medicine WHERE name = @name LIMIT 1;";
                    myCommand.Parameters.AddWithValue("@name", name);

                    object result = myCommand.ExecuteScalar(); // renvoie la première colonne du premier résultat

                    if (result != null && result != DBNull.Value)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans FindMedicineIdByName : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return id;
        }

        public bool EditMedicine(int medicine_id, int user_id, string name, string description, string molecule, int dosage)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                try
                {
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"
                UPDATE Medicine 
                SET user_id = @user_id, 
                    name = @name, 
                    description = @description, 
                    molecule = @molecule, 
                    dosage = @dosage
                WHERE medicine_id = @medicine_id;
            ";

                    myCommand.Parameters.AddWithValue("@medicine_id", medicine_id);
                    myCommand.Parameters.AddWithValue("@user_id", user_id);
                    myCommand.Parameters.AddWithValue("@name", name);
                    myCommand.Parameters.AddWithValue("@description", description);
                    myCommand.Parameters.AddWithValue("@molecule", molecule);
                    myCommand.Parameters.AddWithValue("@dosage", dosage);

                    int rowsAffected = myCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans EditMedicine : " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool DeleteMedicine(int medicine_id)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                try
                {
                    MySqlCommand deleteRelations = new MySqlCommand();
                    deleteRelations.Connection = connection;
                    deleteRelations.CommandText = @"DELETE FROM Appartient WHERE medicine_id = @medicine_id;";
                    deleteRelations.Parameters.AddWithValue("@medicine_id", medicine_id);
                    deleteRelations.ExecuteNonQuery();

                    MySqlCommand deleteRelatedPrescriptions = new MySqlCommand();
                    deleteRelatedPrescriptions.Connection = connection;
                    deleteRelatedPrescriptions.CommandText = @"
                    DELETE p, a
                    FROM Prescription p
                    JOIN Appartient a ON a.prescription_id = p.prescription_id
                    WHERE a.medicine_id = @medicine_id;

                    ";
                    deleteRelatedPrescriptions.Parameters.AddWithValue("@medicine_id", medicine_id);
                    deleteRelatedPrescriptions.ExecuteNonQuery();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"DELETE FROM Medicine WHERE medicine_id = @medicine_id;";
                    myCommand.Parameters.AddWithValue("@medicine_id", medicine_id);

                    int rowsAffected = myCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans DeleteMedicine : " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }



    }
}

