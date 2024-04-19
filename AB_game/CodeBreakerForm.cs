﻿using CIS3433;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AB_game
{
    public partial class CodeBreakerForm : Form
    {
        private CodeBreakerGame codeBreakerGame;
        private string groupValue;
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

        public CodeBreakerForm(string groupValue)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            codeBreakerGame = new CodeBreakerGame();

            this.groupValue = groupValue;
            GroupLabel.Text += " vs. Group " + groupValue;

            menuStrip1.BackColor = Color.FromArgb(72, 77, 99);
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.FromArgb(72, 77, 99);
                item.ForeColor = Color.White;
                item.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }

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

            // Generate the initial guess
            string initialGuess = codeBreakerGame.GenerateInitialGuess();
            PopulateGuessLabels(initialGuess);
        }

        private void PopulateGuessLabels(string guess)
        {
            GuessLabel_1.Text = guess[0].ToString();
            GuessLabel_2.Text = guess[1].ToString();
            GuessLabel_3.Text = guess[2].ToString();
            GuessLabel_4.Text = guess[3].ToString();
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
            base.OnFormClosing(e);
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitHintButton_Click(object sender, EventArgs e)
        {
            int bulls, cows;

            if (!int.TryParse(hintTextBox_1.Text, out bulls))
            {
                // Handle invalid input for bulls
                MessageBox.Show("Please enter a valid number for bulls.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(hintTextBox_2.Text, out cows))
            {
                // Handle invalid input for cows
                MessageBox.Show("Please enter a valid number for cows.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string currentGuess = GuessLabel_1.Text + GuessLabel_2.Text + GuessLabel_3.Text + GuessLabel_4.Text;

            // Add the current guess and hint to the DataGridView
            string hint = $"{bulls}A{cows}B";
            AddGuessToDataGridView(currentGuess, hint);

            string nextGuess = codeBreakerGame.MakeGuess(bulls, cows);
            PopulateGuessLabels(nextGuess);

            // Clear the input fields
            hintTextBox_1.Text = string.Empty;
            hintTextBox_2.Text = string.Empty;
        }

        private void AddGuessToDataGridView(string guess, string hint)
        {
            int rowNumber = dataGridView1.Rows.Count;
            dataGridView1.Rows.Add(rowNumber, guess, hint);
        }
    }
}