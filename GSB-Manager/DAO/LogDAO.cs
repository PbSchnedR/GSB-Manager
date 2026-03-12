using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GSB_Manager.DAO;
using GSB_Manager.Models;
using MySql.Data.MySqlClient;

namespace GSB_Manager.DAO
{
    public class LogDAO
    {
        private readonly Database db;

        public LogDAO()
        {
            db = new Database();
        }

        /// <summary>
        /// Insère un nouveau log dans la base de données
        /// </summary>
        public Log CreateLog(int origin_user_id, string field, int element_id, string description, string action_type)
        {
            int id = 0;
            DateTime date = DateTime.Now;
            var connection = db.GetConnection();
            connection.Open();
            {
                try
                {
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"INSERT INTO Log (origin_user_id, date, field, action_type, element_id, description) 
                                             VALUES (@origin_user_id, @date, @field, @action_type, @element_id, @description);
                                             SELECT LAST_INSERT_ID() as log_id;";

                    myCommand.Parameters.AddWithValue("@origin_user_id", origin_user_id);
                    myCommand.Parameters.AddWithValue("@date", date);
                    myCommand.Parameters.AddWithValue("@field", field);
                    myCommand.Parameters.AddWithValue("@element_id", element_id);
                    myCommand.Parameters.AddWithValue("@description", description ?? "");
                    myCommand.Parameters.AddWithValue("@action_type", action_type ?? "");


                    using var myReader = myCommand.ExecuteReader();
                    {
                        if (myReader.Read())
                        {
                            id = myReader.GetInt32("log_id");
                        }
                    }

                   Log log = new Log
                   {
                       log_id = id,
                       origin_user_id = origin_user_id,
                       date = date,
                       field = field,
                       element_id = element_id,
                       description = description,
                       action_type = action_type
                   };

                    connection.Close();
                    return log;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    connection.Close();
                    return null;
                }
            }
        }

        /// <summary>
        /// Récupère tous les logs de la base de données
        /// </summary>
        public List<Log> GetAllLogs()
        {
            List<Log> logs = new List<Log>();
            int id = 0;


            int origin_user_id = 0;
            DateTime date = DateTime.Now;
            string field = string.Empty;
            string action_type = string.Empty;
            int element_id = 0;
            string description = string.Empty;

            var connection = db.GetConnection();
            connection.Open();
            {
                try
                {
                    MySqlCommand myCommand = new MySqlCommand();
                    myCommand.Connection = connection;
                    myCommand.CommandText = @"SELECT log_id, origin_user_id, date, field, action_type, element_id, description 
                                     FROM Log ORDER BY date DESC";

                    using var myReader = myCommand.ExecuteReader();
                    {
                        while (myReader.Read())
                        {
                            id = myReader.GetInt32("log_id");
                            origin_user_id = myReader.GetInt32("origin_user_id");
                            date = myReader.GetDateTime("date");
                            field = myReader.GetString("field");
                            action_type = myReader.IsDBNull(myReader.GetOrdinal("action_type"))
                                        ? ""
                                        : myReader.GetString("action_type");  // 👈 VÉRIFIER ICI
                            element_id = myReader.GetInt32("element_id");
                            description = myReader.IsDBNull(myReader.GetOrdinal("description"))
                                        ? ""
                                        : myReader.GetString("description");

                            logs.Add(new Log
                            {
                                log_id = id,
                                origin_user_id = origin_user_id,
                                date = date,
                                field = field,
                                action_type = action_type,  // 👈 VÉRIFIER ICI
                                element_id = element_id,
                                description = description
                            });
                        }
                    }
                    connection.Close();
                    return logs;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    connection.Close();
                    return null;
                }
            }
        }
    }
}