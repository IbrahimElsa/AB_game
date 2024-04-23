using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3433
{
    public class DatabaseConnection
    {
        private string ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AB_Game_Database.mdf;Integrated Security=True;";

        public void UpdateTable(string groupName, string gameMode, DateTime date, TimeSpan time, int totalTries, int totalSeconds, string secretNumber, int gameScore, string guessDetails)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO GamePlay (GroupName, GameMode, Date, Time, TotalTries, TotalSeconds, SecretNumber, GameScore, GuessDetails) " +
                        "VALUES (@GroupName, @GameMode, @Date, @Time, @TotalTries, @TotalSeconds, @SecretNumber, @GameScore, @GuessDetails)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GroupName", groupName);
                        command.Parameters.AddWithValue("@GameMode", gameMode);
                        command.Parameters.AddWithValue("@Date", date);
                        command.Parameters.AddWithValue("@Time", time);
                        command.Parameters.AddWithValue("@TotalTries", totalTries);
                        command.Parameters.AddWithValue("@TotalSeconds", totalSeconds);
                        command.Parameters.AddWithValue("@SecretNumber", secretNumber);
                        command.Parameters.AddWithValue("@GameScore", gameScore);
                        command.Parameters.AddWithValue("@GuessDetails", guessDetails);

                        command.ExecuteNonQuery();
                    }
                }
                Console.WriteLine("Data inserted successfully.");
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting data into GamePlay table: " + ex.Message);
            }
        }

        public DataTable GetGamePlayData()
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM GamePlay";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving data from GamePlay table: " + ex.Message);
            }
            return dataTable;
        }
    }
}