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
                            user_id = myReader.GetInt32("users_id");
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
                            user_id = myReader.GetInt32("users_id");
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
                    myCommand.CommandText = @"INSERT INTO Medicine (users_id, name, description, molecule, dosage) VALUES (@user_id, @name, @description, @molecule, @dosage);";
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
                            user_id = myReader.GetInt32("users_id");
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
    }
}

