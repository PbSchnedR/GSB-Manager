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
    internal class PrescriptionDAO
    {

        private readonly Database db = new Database();

        public List<Prescription> GetAllPrescription()
        {
            List<Prescription> medicines = new List<Prescription>();

            int id = 0;
            int user_id = 0;
            int patient_id = 0;
            string patient_full_name = string.Empty;
            int quantity = 0;
            DateTime validity = DateTime.MinValue;
            string full_line = string.Empty;
            string user_full_name = string.Empty;

            var connection = db.GetConnection();
            connection.Open();

            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"
                        SELECT 
                    pr.Prescription_id,
                    pr.users_id,
                    pr.patients_id,
                    pr.quantity,
                    pr.validity,
                    p.name AS patient_name,
                    p.firstname AS patient_firstname,
                    u.name AS user_name,
                    u.firstname AS user_firstname
                FROM Prescription AS pr
                INNER JOIN Patients AS p ON p.patients_id = pr.patients_id
                INNER JOIN Users AS u ON u.users_id = pr.users_id;
";

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("prescription_id");
                            user_id = myReader.GetInt32("users_id");
                            patient_id = myReader.GetInt32("patients_id");
                            patient_full_name = myReader.GetString("patient_firstname") + " " + myReader.GetString("patient_name");
                            quantity = myReader.GetInt32("quantity");
                            validity = myReader.GetDateTime("validity");
                            user_full_name = $"Dr. {myReader.GetString("user_firstname")} {myReader.GetString("user_name")}";

                            full_line =
                                $"Prescription #{myReader.GetInt32("Prescription_id")} — " +
                                $"Patient: {myReader.GetString("patient_firstname")} {myReader.GetString("patient_name")} | " +
                                $"Médecin: Dr. {myReader.GetString("user_firstname")} {myReader.GetString("user_name")}";

                            medicines.Add(new Prescription(id, user_id, patient_id, quantity, validity, full_line, user_full_name, patient_full_name));
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



        public Prescription GetPrescriptionById(int PrescriptionId)
        {
            int id = 0;
            int user_id = 0;
            int patient_id = 0;
            int quantity = 0;
            DateTime validity = DateTime.MinValue;

            var connection = db.GetConnection();
            connection.Open();
            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM Prescription WHERE prescription_id = @prescription_id;";
                    myCommand.Parameters.AddWithValue("@prescription_id", PrescriptionId);

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("Prescription_id");
                            user_id = myReader.GetInt32("users_id");
                            patient_id = myReader.GetInt32("patients_id");
                            quantity = myReader.GetInt32("quantity");
                            validity = myReader.GetDateTime("validity");
                        }
                    }
                    Prescription Prescription = new Prescription(id, user_id, patient_id, quantity, validity);


                    connection.Close();
                    return Prescription;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }


        }


        public int CreatePrescription(int user_id, int patient_id, int quantity, DateTime validity)
        {
            int newId = 0;
            var connection = db.GetConnection();
            connection.Open();

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = @"
            INSERT INTO Prescription (users_id, patients_id, quantity, validity)
            VALUES (@user_id, @patient_id, @quantity, @validity);
            SELECT LAST_INSERT_ID();
        ";

                myCommand.Parameters.AddWithValue("@user_id", user_id);
                myCommand.Parameters.AddWithValue("@patient_id", patient_id);
                myCommand.Parameters.AddWithValue("@quantity", quantity);
                myCommand.Parameters.AddWithValue("@validity", validity);

                // ExecuteScalar récupère directement la première valeur (ici le nouvel ID)
                object result = myCommand.ExecuteScalar();

                if (result != null)
                    newId = Convert.ToInt32(result);

                return newId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }



        public List<string> GetPrescriptionMedicines(int PrescriptionId)
        {

            var medicines = new List<string>();
            var connection = db.GetConnection();

            string name = string.Empty;
            connection.Open();
            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"
                        SELECT m.name 
                        FROM `Appartient` as a
                        INNER JOIN Medicine as m on a.medicine_id = m.medicine_id
                        INNER JOIN Prescription as p on a.prescription_id = p.prescription_id
                        WHERE p.prescription_id = @prescription_id
";
                    myCommand.Parameters.AddWithValue("@prescription_id", PrescriptionId);

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            name = myReader.GetString("name");

                            medicines.Add(name);
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

        public void AddMedicineToPrescription(int prescription_id, int medicine_id)
        {
            var connection = db.GetConnection();
            connection.Open();

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = @"
            INSERT INTO Appartient (prescription_id, medicine_id)
            VALUES (@prescription_id, @medicine_id);";

                myCommand.Parameters.AddWithValue("@prescription_id", prescription_id);
                myCommand.Parameters.AddWithValue("@medicine_id", medicine_id);

                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        public bool EditPrescription(int prescription_id, int user_id, int patient_id, int quantity, DateTime validity)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                try
                {
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"
                UPDATE Prescription
                SET users_id = @user_id,
                    patients_id = @patient_id,
                    quantity = @quantity,
                    validity = @validity
                WHERE prescription_id = @prescription_id;
            ";

                    myCommand.Parameters.AddWithValue("@prescription_id", prescription_id);
                    myCommand.Parameters.AddWithValue("@user_id", user_id);
                    myCommand.Parameters.AddWithValue("@patient_id", patient_id);
                    myCommand.Parameters.AddWithValue("@quantity", quantity);
                    myCommand.Parameters.AddWithValue("@validity", validity);

                    int rowsAffected = myCommand.ExecuteNonQuery();
                    return rowsAffected > 0; // true si au moins une ligne a été mise à jour
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans EditPrescription : " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool DeletePrescription(int prescription_id)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                try
                {
                    // D’abord, on supprime les associations dans la table Appartient
                    // pour éviter les erreurs de clé étrangère
                    MySqlCommand deleteRelations = new MySqlCommand();
                    deleteRelations.Connection = connection;
                    deleteRelations.CommandText = @"DELETE FROM Appartient WHERE prescription_id = @prescription_id;";
                    deleteRelations.Parameters.AddWithValue("@prescription_id", prescription_id);
                    deleteRelations.ExecuteNonQuery();

                    // Ensuite, on supprime la prescription
                    MySqlCommand deletePrescription = new MySqlCommand();
                    deletePrescription.Connection = connection;
                    deletePrescription.CommandText = @"DELETE FROM Prescription WHERE prescription_id = @prescription_id;";
                    deletePrescription.Parameters.AddWithValue("@prescription_id", prescription_id);

                    int rowsAffected = deletePrescription.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans DeletePrescription : " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public void EditMedicineToPrescription(int prescription_id, List<int> medicine_ids)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                try
                {
                    // Supprimer tous les anciens liens
                    MySqlCommand deleteCmd = new MySqlCommand();
                    deleteCmd.Connection = connection;
                    deleteCmd.CommandText = @"DELETE FROM Appartient WHERE prescription_id = @prescription_id;";
                    deleteCmd.Parameters.AddWithValue("@prescription_id", prescription_id);
                    deleteCmd.ExecuteNonQuery();

                    // Réinsérer chaque médicament
                    foreach (int medicine_id in medicine_ids)
                    {
                        MySqlCommand insertCmd = new MySqlCommand();
                        insertCmd.Connection = connection;
                        insertCmd.CommandText = @"
                            INSERT INTO Appartient (prescription_id, medicine_id)
                            VALUES (@prescription_id, @medicine_id);
                        ";
                        insertCmd.Parameters.AddWithValue("@prescription_id", prescription_id);
                        insertCmd.Parameters.AddWithValue("@medicine_id", medicine_id);
                        insertCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans EditMedicineToPrescription : " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }



    }
}

