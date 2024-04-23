using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3433
{
    public class DatabaseConnection
    {
        String ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AB_Game_Database.mdf;Integrated Security=True;";

        public void UpdateTable(string playerName, string playingMode, DateTime gameDate, TimeSpan gameTime, int totalTries, int totalSeconds, string secretNumber, decimal gameScore, string guessDetails)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO GamePlay (PlayerName, PlayingMode, GameDate, GameTime, TotalTries, TotalSeconds, SecretNumber, GameScore, GuessDetails) " +
                                   "VALUES (@PlayerName, @PlayingMode, @GameDate, @GameTime, @TotalTries, @TotalSeconds, @SecretNumber, @GameScore, @GuessDetails)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PlayerName", playerName);
                        command.Parameters.AddWithValue("@PlayingMode", playingMode);
                        command.Parameters.AddWithValue("@GameDate", gameDate);
                        command.Parameters.AddWithValue("@GameTime", gameTime);
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
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}