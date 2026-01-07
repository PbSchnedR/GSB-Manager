using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using GSB_Manager.Models;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GSB_Manager.DAO
{
    public class PatientDAO
    {

        private readonly Database db = new Database();
        private LogDAO logDAO = new LogDAO();

        public List<Patient> GetAllPatients()
        {
            List<Patient> medicines = new List<Patient>();

            int id = 0;
            int user_id = 0;
            string name = string.Empty;
            string firstName = string.Empty;
            string lastName = string.Empty;
            string email = string.Empty;
            string gender = "helicoptère";
            int age = 0;
            string full_name = string.Empty;
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
                        p.patient_id, 
                        p.user_id, 
                        p.name, 
                        p.firstname, 
                        p.age, 
                        p.gender, 
                        u.name as user_name, 
                        u.firstname as user_firstname
                        FROM `Patients` as p 
                        inner join Users as u on p.user_id = u.user_id
";

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("patient_id");
                            user_id = myReader.GetInt32("user_id");
                            name = myReader.GetString("name");
                            firstName = myReader.GetString("firstname");
                            gender = myReader.GetString("gender");
                            age = myReader.GetInt32("age");
                            full_name = myReader.GetString("firstname") + " " + myReader.GetString("name");
                            user_full_name = "Dr. " + myReader.GetString("user_firstname") + " " + myReader.GetString("user_name");

                            medicines.Add(new Patient(id, user_id, name, firstName, age, gender, full_name, user_full_name));
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

        public Patient GetPatientById(int patientId)
        {
            int id = 0;
            int user_id = 0;
            string name = string.Empty;
            int age = 0;
            string gender = "helicoptère";
            string firstName = string.Empty;

            var connection = db.GetConnection();
            connection.Open();
            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM Patients WHERE patient_id = @patient_id;";
                    myCommand.Parameters.AddWithValue("@patient_id", patientId);

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("patient_id");
                            user_id = myReader.GetInt32("user_id");
                            name = myReader.GetString("name");
                            firstName = myReader.GetString("firstname");
                            gender = myReader.GetString("gender");
                            age = myReader.GetInt32("age");
                        }
                    }
                    Patient patient = new Patient(id, user_id, name, firstName, age, gender);


                    connection.Close();
                    return patient;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return null;
                }
            }


        }



        public Patient CreatePatient(int user_id, string name, string firstName, int age, string gender)
        {
            int patient_id = 0;
            var connection = db.GetConnection();
            connection.Open();
            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"INSERT INTO Patients (user_id, name, firstName, age, gender) 
                                     VALUES (@user_id, @name, @firstName, @age, @gender);
                                     SELECT LAST_INSERT_ID() as patient_id;";
                    myCommand.Parameters.AddWithValue("@user_id", user_id);
                    myCommand.Parameters.AddWithValue("@name", name);
                    myCommand.Parameters.AddWithValue("@firstName", firstName);
                    myCommand.Parameters.AddWithValue("@age", age);
                    myCommand.Parameters.AddWithValue("@gender", gender);

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        if (myReader.Read())
                        {
                            patient_id = myReader.GetInt32("patient_id");
                        }
                    }

                    Patient patient = new Patient(patient_id, user_id, name, firstName, age, gender);
                    connection.Close();

                    // Créer un log pour l'ajout du patient
                    if (patient_id > 0)
                    {
                        try
                        {
                            logDAO.CreateLog(
                                origin_user_id: user_id,
                                field: "Patient",
                                element_id: patient_id,
                                description: $"Patient created: {name} {firstName}, {age} years old, {gender}",
                                action_type: "CREATE"
                            );
                        }
                        catch (Exception logEx)
                        {
                            Console.WriteLine($"Erreur lors de la création du log: {logEx.Message}");
                        }
                    }

                    return patient;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    connection.Close();
                    return null;
                }
            }
        }

        public bool EditPatient(int patient_id, int user_id, string name, string firstName, int age, string gender)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                try
                {
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"
        UPDATE Patients
        SET user_id = @user_id,
            name = @name,
            firstname = @firstName,
            age = @age,
            gender = @gender
        WHERE patient_id = @patient_id;
    ";

                    myCommand.Parameters.AddWithValue("@patient_id", patient_id);
                    myCommand.Parameters.AddWithValue("@user_id", user_id);
                    myCommand.Parameters.AddWithValue("@name", name);
                    myCommand.Parameters.AddWithValue("@firstName", firstName);
                    myCommand.Parameters.AddWithValue("@age", age);
                    myCommand.Parameters.AddWithValue("@gender", gender);

                    int rowsAffected = myCommand.ExecuteNonQuery();

                    connection.Close();

                    // Créer un log pour la modification du patient
                    if (rowsAffected > 0)
                    {
                        try
                        {
                            logDAO.CreateLog(
                                origin_user_id: user_id,
                                field: "Patient",
                                element_id: patient_id,
                                description: $"Patient modified: {name} {firstName}, {age} years old, {gender}",
                                action_type: "UPDATE"
                            );
                        }
                        catch (Exception logEx)
                        {
                            Console.WriteLine($"Erreur lors de la création du log: {logEx.Message}");
                        }
                    }

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans EditPatient : " + ex.Message);
                    return false;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }

        public bool DeletePatient(int patient_id, int user_id, string patient_full_name)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                try
                {
                    var prescriptionDAO = new PrescriptionDAO();
                    var prescriptions = prescriptionDAO.GetPrescriptionIdForPatient(patient_id);
                    foreach (var item in prescriptions)
                    {
                        MySqlCommand deleteRelationsAppartient = new MySqlCommand();
                        deleteRelationsAppartient.Connection = connection;
                        deleteRelationsAppartient.CommandText = @"DELETE FROM Appartient WHERE prescription_id = @prescription_id;";
                        deleteRelationsAppartient.Parameters.AddWithValue("@prescription_id", item);
                        deleteRelationsAppartient.ExecuteNonQuery();
                    }

                    MySqlCommand deleteRelations = new MySqlCommand();
                    deleteRelations.Connection = connection;
                    deleteRelations.CommandText = @"DELETE FROM Prescription WHERE patient_id = @patient_id;";
                    deleteRelations.Parameters.AddWithValue("@patient_id", patient_id);
                    deleteRelations.ExecuteNonQuery();

                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"DELETE FROM Patients WHERE patient_id = @patient_id;";
                    myCommand.Parameters.AddWithValue("@patient_id", patient_id);

                    int rowsAffected = myCommand.ExecuteNonQuery();

                    connection.Close();

                    // Créer un log pour la suppression du patient
                    if (rowsAffected > 0)
                    {
                        try
                        {
                            logDAO.CreateLog(
                                origin_user_id: user_id,
                                field: "Patient",
                                element_id: patient_id,
                                description: $"Patient deleted: {patient_full_name} (ID: {patient_id})",
                                action_type: "DELETE"
                            );
                        }
                        catch (Exception logEx)
                        {
                            Console.WriteLine($"Erreur lors de la création du log: {logEx.Message}");
                        }
                    }

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans DeletePatient : " + ex.Message);
                    return false;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }


    }
}

