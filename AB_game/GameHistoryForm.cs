using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS3433;

namespace AB_game
{
    public partial class GameHistoryForm : Form
    {
        private DatabaseConnection databaseConnection;
        private string groupValue;
        private string gameMode;
        private bool isDragging;
        private Point lastCursor;
        private Point lastForm;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public GameHistoryForm(string groupValue, string gameMode)
        {
            InitializeComponent();
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            databaseConnection = new DatabaseConnection();

            this.groupValue = groupValue;
            this.gameMode = gameMode;

            menuStrip1.BackColor = Color.FromArgb(36, 42, 59);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }

            CustomMenuRenderer renderer = new CustomMenuRenderer();
            menuStrip1.Renderer = renderer;

            // Attach mouse event handlers to ExitPanel, NamePanel, and GroupLabel
            ExitPanel.MouseDown += PanelMouseDown;
            ExitPanel.MouseMove += PanelMouseMove;
            ExitPanel.MouseUp += PanelMouseUp;
            NamePanel.MouseDown += PanelMouseDown;
            NamePanel.MouseMove += PanelMouseMove;
            NamePanel.MouseUp += PanelMouseUp;
            GroupLabel.MouseDown += PanelMouseDown;
            GroupLabel.MouseMove += PanelMouseMove;
            GroupLabel.MouseUp += PanelMouseUp;

        }

        private void GameHistoryForm_Load(object sender, EventArgs e)
        {
            PopulateGamePlayDataGridView();
        }

        private void PopulateGamePlayDataGridView()
        {
            try
            {
                DataTable dataTable = databaseConnection.GetGamePlayData();
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // Inside GameHistoryForm class

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure that the header row isn't triggering this
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                var labelData = new Dictionary<string, string>
                {
                    { "GroupName", row.Cells["GroupName"].Value?.ToString() ?? string.Empty },
                    { "GameMode", row.Cells["GameMode"].Value?.ToString() ?? string.Empty },
                    { "Date", row.Cells["Date"].Value?.ToString() ?? string.Empty },
                    { "Time", row.Cells["Time"].Value?.ToString() ?? string.Empty },
                    { "TotalSeconds", row.Cells["TotalSeconds"].Value?.ToString() ?? string.Empty },
                    { "SecretNumber", row.Cells["SecretNumber"].Value?.ToString() ?? string.Empty },
                    { "GameScore", row.Cells["GameScore"].Value?.ToString() ?? string.Empty }
                };

                string guessDetails = FormatGuessDetails(row);

                GameResult gameResultForm = new GameResult(labelData, guessDetails);
                gameResultForm.Show();
            }
        }

        private string FormatGuessDetails(DataGridViewRow row)
        {
            // Example: Guess 1: ABCD (hint1), Guess 2: EFGH (hint2), ...
            // Implement this based on your actual data and format requirements
            StringBuilder details = new StringBuilder();
            // Assuming each guess is in a separate cell and hints in the adjacent cells.
            for (int i = 0; i < row.Cells.Count; i += 2) // Adjust loop step depending on your data structure
            {
                details.AppendFormat("Guess {0}: {1} ({2}), ", i / 2 + 1, row.Cells[i].Value, row.Cells[i].Value);
            }
            return details.ToString().TrimEnd(',', ' ');
        }








        // UI Logic
        public class CustomMenuRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(43, 50, 70)), e.Item.ContentRectangle);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(36, 42, 59)), e.Item.ContentRectangle);
                }
            }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                e.TextColor = Color.White;
                base.OnRenderItemText(e);
            }
        }

        // Rename the mouse event handlers to be more generic
        private void PanelMouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void PanelMouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point deltaCursor = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(deltaCursor));
            }
        }

        private void PanelMouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void ExitPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = this.Location;
            }
        }

        private void ExitPanel_MouseMove(object? sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point deltaCursor = Point.Subtract(Cursor.Position, new Size(lastCursor));
                this.Location = Point.Add(lastForm, new Size(deltaCursor));
            }
        }

        private void ExitPanel_MouseUp(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (gameMode == "codemaker")
            {
                base.OnFormClosing(e);
                CodeMakerForm codeMakerForm = new CodeMakerForm(groupValue);
                codeMakerForm.Show();
            }
            else if (gameMode == "codebreaker")
            {
                base.OnFormClosing(e);
                CodeBreakerForm codeBreakerForm = new CodeBreakerForm(groupValue);
                codeBreakerForm.Show();
            }
            else
            {
                base.OnFormClosing(e);
                WelcomeForm welcomeForm = new WelcomeForm();
                welcomeForm.Show();
            }
        }
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
