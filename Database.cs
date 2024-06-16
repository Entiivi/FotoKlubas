using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace FotoKlubas
{
    public class Database
    {
        private readonly string connectionString = "server=localhost;database=fotoklubas2;uid=root";

        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }

        private MySqlConnection OpenConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        // Method to execute a query and return a DataTable
        public DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // Method to execute a non-query (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteNonQuery();
                }
            }
        }

        // Method to execute a scalar query
        public object ExecuteScalar(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection connection = OpenConnection())
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteScalar();
                }
            }
        }

        // Method to fetch NarysID based on username and password
        public int GetNarysId(string username, string password)
        {
            string query = "SELECT NarysID FROM Narys WHERE Username = @Username AND Slap = @Slap";
            MySqlParameter[] parameters = {
                new MySqlParameter("@Username", username),
                new MySqlParameter("@Slap", password)
            };

            object result = ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                throw new Exception("User not found or invalid credentials.");
            }
        }
    }
}
