using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

        public List<object> GetAllPatients()
        {
            var patients = new List<object>();

            using (var connection = db.GetConnection())
            {
                connection.Open();

                try
                {
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT * FROM Patients";

                    using var myReader = myCommand.ExecuteReader();
                    while (myReader.Read())
                    {
                        var item = new
                        {
                            id = myReader.GetInt32("patients_id"),
                            user_id = myReader.GetInt32("users_id"),
                            name = myReader.GetString("name"),
                            firstName = myReader.GetString("firstname"),
                            gender = myReader.GetString("gender"),
                            age = myReader.GetInt32("age"),
                            FullName = myReader.GetString("firstname") + " " + myReader.GetString("name")
                        };

                        patients.Add(item);
                    }

                    return patients;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
    }
}

