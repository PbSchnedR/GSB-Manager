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
    public class PrescriptionDAO
    {

        private readonly Database db = new Database();

        public List<Prescription> GetAllPrescription()
        {
            List<Prescription> medicines = new List<Prescription>();

            int id = 0;
            int user_id = 0;
            int patient_id = 0;
            string patient_full_name = string.Empty;
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
                    pr.user_id,
                    pr.patient_id,
                    pr.validity,
                    p.name AS patient_name,
                    p.firstname AS patient_firstname,
                    u.name AS user_name,
                    u.firstname AS user_firstname
                FROM Prescription AS pr
                INNER JOIN Patients AS p ON p.patient_id = pr.patient_id
                INNER JOIN Users AS u ON u.user_id = pr.user_id;
";

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("prescription_id");
                            user_id = myReader.GetInt32("user_id");
                            patient_id = myReader.GetInt32("patient_id");
                            patient_full_name = myReader.GetString("patient_firstname") + " " + myReader.GetString("patient_name");
                            validity = myReader.GetDateTime("validity");
                            user_full_name = $"Dr. {myReader.GetString("user_firstname")} {myReader.GetString("user_name")}";

                            full_line =
                                $"Prescription #{myReader.GetInt32("Prescription_id")} — " +
                                $"Patient: {myReader.GetString("patient_firstname")} {myReader.GetString("patient_name")} | " +
                                $"Médecin: Dr. {myReader.GetString("user_firstname")} {myReader.GetString("user_name")}";

                            medicines.Add(new Prescription(id, user_id, patient_id, validity, full_line, user_full_name, patient_full_name));
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
                            user_id = myReader.GetInt32("user_id");
                            patient_id = myReader.GetInt32("patient_id");
                            validity = myReader.GetDateTime("validity");
                        }
                    }
                    Prescription Prescription = new Prescription(id, user_id, patient_id, validity);


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


        public int CreatePrescription(int user_id, int patient_id, DateTime validity)
        {
            int newId = 0;
            var connection = db.GetConnection();
            connection.Open();

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = @"
            INSERT INTO Prescription (user_id, patient_id,  validity)
            VALUES (@user_id, @patient_id,  @validity);
            SELECT LAST_INSERT_ID();
        ";

                myCommand.Parameters.AddWithValue("@user_id", user_id);
                myCommand.Parameters.AddWithValue("@patient_id", patient_id);
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

        public List<Medicine> GetPrescriptionMedicines(int PrescriptionId)
        {

            var medicines = new List<Medicine>();
            var connection = db.GetConnection();

            string name = string.Empty;
            int quantity = 0;
            connection.Open();
            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"
                        SELECT m.name, a.quantity 
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
                            quantity = myReader.GetInt32("quantity");

                            medicines.Add(new Medicine(quantity, name));
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

        public void AddMedicineToPrescription(int prescription_id, int medicine_id, int quantity)
        {
            var connection = db.GetConnection();
            connection.Open();

            try
            {
                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = @"
            INSERT INTO Appartient (prescription_id, medicine_id, quantity)
            VALUES (@prescription_id, @medicine_id, @quantity);";

                myCommand.Parameters.AddWithValue("@prescription_id", prescription_id);
                myCommand.Parameters.AddWithValue("@medicine_id", medicine_id);
                myCommand.Parameters.AddWithValue("@quantity", quantity);

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

        public bool EditPrescription(int prescription_id, int user_id, int patient_id, DateTime validity)
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
                SET user_id = @user_id,
                    patient_id = @patient_id,
                    validity = @validity
                WHERE prescription_id = @prescription_id;
            ";

                    myCommand.Parameters.AddWithValue("@prescription_id", prescription_id);
                    myCommand.Parameters.AddWithValue("@user_id", user_id);
                    myCommand.Parameters.AddWithValue("@patient_id", patient_id);
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
                    MySqlCommand deleteRelations = new MySqlCommand();
                    deleteRelations.Connection = connection;
                    deleteRelations.CommandText = @"DELETE FROM Appartient WHERE prescription_id = @prescription_id;";
                    deleteRelations.Parameters.AddWithValue("@prescription_id", prescription_id);
                    deleteRelations.ExecuteNonQuery();

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

        public void EditMedicineToPrescription(int prescription_id, Dictionary<int, int> pairs)
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
                    foreach (var p in pairs)
                    {
                        MySqlCommand insertCmd = new MySqlCommand();
                        insertCmd.Connection = connection;
                        insertCmd.CommandText = @"
                            INSERT INTO Appartient (prescription_id, medicine_id, quantity)
                            VALUES (@prescription_id, @medicine_id, @quantity);
                        ";
                        insertCmd.Parameters.AddWithValue("@prescription_id", prescription_id);
                        insertCmd.Parameters.AddWithValue("@medicine_id", p.Key);
                        insertCmd.Parameters.AddWithValue("@quantity", p.Value);
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

        public List<int> GetPrescriptionIdForPatient(int patient_id)
        {
            var connection = db.GetConnection();
            connection.Open();
            var ids = new List<int>();

            try
            {

                MySqlCommand myCommand = new MySqlCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = @"
                SELECT prescription_id FROM Prescription WHERE patient_id = @patient_id;";
                myCommand.Parameters.AddWithValue("@patient_id", patient_id);
                using var myReader = myCommand.ExecuteReader();
                {
                    while (myReader.Read())
                    {
                        int prescription_id = myReader.GetInt32("prescription_id");
                        ids.Add(prescription_id);
                    }
                }
                return ids;
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

        public int GetSelectedMedicineQuantity(string medicineName, int prescriptionId)
        {
            var connection = db.GetConnection();
            connection.Open();
            int quantity = 0;

            try
            {
                int medicineId = 0;

                using (var getMedicineIdCommand = new MySqlCommand(
                    "SELECT medicine_id FROM Medicine WHERE name = @medicine_name;",
                    connection))
                {
                    getMedicineIdCommand.Parameters.AddWithValue("@medicine_name", medicineName);

                    using (var reader = getMedicineIdCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            medicineId = reader.GetInt32("medicine_id");
                        }
                    }
                } 

                using (var myCommand = new MySqlCommand(
                    @"SELECT quantity FROM Appartient 
              WHERE medicine_id = @medicine_id AND prescription_id = @prescription_id;",
                    connection))
                {
                    myCommand.Parameters.AddWithValue("@medicine_id", medicineId);
                    myCommand.Parameters.AddWithValue("@prescription_id", prescriptionId);

                    using (var myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.Read())
                        {
                            quantity = myReader.GetInt32("quantity");
                        }
                    }
                }

                return quantity;
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

        public void AddQuantityToAppartient(int medicineId, int prescriptionId, int quantity)
        {
            var connection = db.GetConnection();
            connection.Open();

            try
            {

                using (var myCommand = new MySqlCommand(
                    @"UPDATE Appartient 
              SET quantity = @quantity 
              WHERE medicine_id = @medicine_id AND prescription_id = @prescription_id;",
                    connection))
                {
                    myCommand.Parameters.AddWithValue("@quantity", quantity);
                    myCommand.Parameters.AddWithValue("@medicine_id", medicineId);
                    myCommand.Parameters.AddWithValue("@prescription_id", prescriptionId);

                    myCommand.ExecuteNonQuery();
                }
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

        public int GetMedicineQuantity(int prescriptionId, int medicineId)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();

                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = @"
                SELECT quantity
                FROM Appartient
                WHERE prescription_id = @prescription_id
                AND medicine_id = @medicine_id;
            ";

                    cmd.Parameters.AddWithValue("@prescription_id", prescriptionId);
                    cmd.Parameters.AddWithValue("@medicine_id", medicineId);

                    object result = cmd.ExecuteScalar();

                    // Si aucune ligne trouvée → renvoyer 0
                    if (result == null || result == DBNull.Value)
                        return 0;

                    return Convert.ToInt32(result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur GetMedicineQuantityInPrescription : " + ex.Message);
                    return 0;
                }
            }
        }

        public List<(Medicine, int)> GetPairsMedicineQuantity(int prescriptionId)
        {
            string name = string.Empty;
            int dosage = 0;

            var pairs = new List<(Medicine, int)>();
            using (var connection = db.GetConnection())
            {
                connection.Open();

                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = @"
                SELECT m.medicine_id, m.name, m.dosage, a.quantity
                FROM Appartient AS a
                INNER JOIN Medicine AS m ON a.medicine_id = m.medicine_id
                WHERE a.prescription_id = @prescription_id;
            ";

                    cmd.Parameters.AddWithValue("@prescription_id", prescriptionId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int medId = reader.GetInt32("medicine_id");
                            name = reader.GetString("name");
                            dosage = reader.GetInt32("dosage");
                            int quantity = reader.GetInt32("quantity");

                            Medicine med = new Medicine(medId, dosage, name);
                            pairs.Add((med, quantity));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur GetPairsMedicineQuantity : " + ex.Message);
                }
            }
            return pairs;
        }

    }
}

