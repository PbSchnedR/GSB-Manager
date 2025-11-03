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

        public List<object> GetAllPrescription()
        {
            var prescriptions = new List<object>();

            using (var connection = db.GetConnection())
            {
                connection.Open();

                try
                {
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"
                SELECT 
                    pr.Prescription_id,
                    pr.users_id,
                    pr.patients_id,
                    p.name AS patient_name,
                    p.firstname AS patient_firstname,
                    u.name AS user_name,
                    u.firstname AS user_firstname
                FROM Prescription AS pr
                INNER JOIN Patients AS p ON p.patients_id = pr.patients_id
                INNER JOIN Users AS u ON u.users_id = pr.users_id;
            ";

                    using var myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        var item = new
                        {
                            PrescriptionId = myReader.GetInt32("Prescription_id"),
                            UserId = myReader.GetInt32("users_id"),
                            PatientId = myReader.GetInt32("patients_id"),
                            PatientFirstName = myReader.GetString("patient_firstname"),
                            PatientName = myReader.GetString("patient_name"),
                            UserFirstName = myReader.GetString("user_firstname"),
                            UserName = myReader.GetString("user_name"),

                            FullLine =
                                $"Prescription #{myReader.GetInt32("Prescription_id")} — " +
                                $"Patient: {myReader.GetString("patient_firstname")} {myReader.GetString("patient_name")} | " +
                                $"Médecin: Dr. {myReader.GetString("user_firstname")} {myReader.GetString("user_name")}"
                        };

                        prescriptions.Add(item);
                    }

                    return prescriptions;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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


        public Prescription CreatePrescription(int user_id, int patient_id, int quantity, DateTime validity)
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
                    myCommand.CommandText = @"INSERT INTO Prescription (users_id, patients_id, quantity, validity) VALUES (@user_id, @patient_id, @quantity, @validity);";
                    myCommand.Parameters.AddWithValue("@user_id", user_id);
                    myCommand.Parameters.AddWithValue("@patient_id", user_id);
                    myCommand.Parameters.AddWithValue("@quantity", quantity);
                    myCommand.Parameters.AddWithValue("@validity", validity);

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
    }
}

