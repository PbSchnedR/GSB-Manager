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
    internal class PatientDAO
    {

        private readonly Database db = new Database();

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
                        p.patients_id, 
                        p.users_id, 
                        p.name, 
                        p.firstname, 
                        p.age, 
                        p.gender, 
                        u.name as user_name, 
                        u.firstname as user_firstname
                        FROM `Patients` as p 
                        inner join Users as u on p.users_id = u.users_id
";

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("patients_id");
                            user_id = myReader.GetInt32("users_id");
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
                    myCommand.CommandText = @"SELECT * FROM Patients WHERE patients_id = @patient_id;";
                    myCommand.Parameters.AddWithValue("@patient_id", patientId);

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("patients_id");
                            user_id = myReader.GetInt32("users_id");
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
            var connection = db.GetConnection();
            connection.Open();
            {
                try
                {
                    // create a MySQL command and set the SQL statement with parameters
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"INSERT INTO Patients (users_id, name, firstName, age, gender) VALUES (@user_id, @name, @firstName, @age, @gender);";
                    myCommand.Parameters.AddWithValue("@user_id", user_id);
                    myCommand.Parameters.AddWithValue("@name", name);
                    myCommand.Parameters.AddWithValue("@firstName", firstName);
                    myCommand.Parameters.AddWithValue("@age", age);
                    myCommand.Parameters.AddWithValue("@gender", gender);

                    // execute the command and read the results
                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            user_id = myReader.GetInt32("users_id");
                            name = myReader.GetString("name");
                            firstName = myReader.GetString("firstname");
                            gender = myReader.GetString("gender");
                            age = myReader.GetInt32("age");
                        }
                    }
                    Patient patient = new Patient(0, user_id, name, firstName, age, gender);


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
                SET users_id = @user_id,
                    name = @name,
                    firstname = @firstName,
                    age = @age,
                    gender = @gender
                WHERE patients_id = @patient_id;
            ";

                    myCommand.Parameters.AddWithValue("@patient_id", patient_id);
                    myCommand.Parameters.AddWithValue("@user_id", user_id);
                    myCommand.Parameters.AddWithValue("@name", name);
                    myCommand.Parameters.AddWithValue("@firstName", firstName);
                    myCommand.Parameters.AddWithValue("@age", age);
                    myCommand.Parameters.AddWithValue("@gender", gender);

                    int rowsAffected = myCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans EditPatient : " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public bool DeletePatient(int patient_id)
        {
            using (var connection = db.GetConnection())
            {
                connection.Open();
                try
                {
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"DELETE FROM Patients WHERE patients_id = @patient_id;";
                    myCommand.Parameters.AddWithValue("@patient_id", patient_id);

                    int rowsAffected = myCommand.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur dans DeletePatient : " + ex.Message);
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

