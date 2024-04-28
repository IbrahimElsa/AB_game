using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB_game
{
    public partial class GameResult : Form
    {
        public GameResult(Dictionary<string, string> labelData, string guessDetails)
        {
            InitializeComponent();
            PopulateLabels(labelData);
            PopulateDataGridView(ParseGuessDetails(guessDetails));  // Ensure this method is defined
        }

        private void PopulateLabels(Dictionary<string, string> data)
        {
            GroupName.Text = "Group Name: " + data["GroupName"];
            GameMode.Text = "Game Mode: " + data["GameMode"];
            Date.Text = "Date: " + data["Date"];
            Time.Text = "Time: " + data["Time"];
            TotalSeconds.Text = "Total Seconds: " + data["TotalSeconds"];
            SecretNumber.Text = "Secret Number: " + data["SecretNumber"];
            GameScore.Text = "Game Score: " + data["GameScore"];
        }

        // Define the PopulateDataGridView method
        private void PopulateDataGridView(DataTable details)
        {
            dataGridView1.DataSource = details;  // Set the DataTable as the DataSource for your DataGridView
        }

        private DataTable ParseGuessDetails(string guessDetails)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("#", typeof(int));
            dt.Columns.Add("Guess", typeof(string));
            dt.Columns.Add("Hint", typeof(string));

            var guesses = guessDetails.TrimEnd(',', ' ').Split(',');

            foreach (var guess in guesses)
            {
                var parts = guess.Split(':');
                var indexAndGuess = parts[1].Trim().Split('(');
                var hint = indexAndGuess[1].TrimEnd(')', ' ');
                var index = int.Parse(parts[0].Split(' ')[1]);
                var guessValue = indexAndGuess[0].Trim();

                DataRow dr = dt.NewRow();
                dr["#"] = index;
                dr["Guess"] = guessValue;
                dr["Hint"] = hint;
                dt.Rows.Add(dr);
            }

            return dt;
        }

        // Event Handlers for UI Elements like ExitButton, etc.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitButton_Click(sender, e);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExitButton_Click(sender, e);
        }
    }
}
