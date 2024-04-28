using CIS3433;
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

namespace AB_game
{
    public partial class GameResult : Form
    {
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
        public GameResult(Dictionary<string, string> labelData)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

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
            PopulateLabels(labelData);
        }
        private void PopulateLabels(Dictionary<string, string> data)
        {
            GroupLabel.Text = "Group 11 vs. Group " + data["GroupName"];
            GroupName.Text = "Group Name: " + data["GroupName"];
            GameMode.Text = "Game Mode: " + data["GameMode"];

            string dateTimeString = data["Date"];
            string[] parts = dateTimeString.Split(' ');
            string dateOnly = parts[0];
            Date.Text = "Date: " + dateOnly;

            Time.Text = "Time: " + data["Time"];
            TotalSeconds.Text = "Total Seconds: " + data["TotalSeconds"];
            SecretNumber.Text = "Secret Number: " + data["SecretNumber"];
            GameScore.Text = "Game Score: " + data["GameScore"];
            PopulateDataGridView(data["GuessDetails"]);
        }

        private void PopulateDataGridView(string guessDetails)
        {
            string[] guesses = guessDetails.Split(new string[] { ", " }, StringSplitOptions.None);
            foreach (string guess in guesses)
            {
                string[] parts = guess.Split(new char[] { ':' }, 2);
                if (parts.Length == 2)
                {
                    string guessNumber = parts[0].Replace("Guess ", "").Trim();
                    string guessValue = parts[1].Trim().Split(' ')[0];
                    string hint = parts[1].Trim().Split(' ')[1].Trim('(', ')');
                    dataGridView1.Rows.Add(int.Parse(guessNumber), guessValue, hint);
                }
            }
        }

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