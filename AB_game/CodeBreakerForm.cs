using CIS3433;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AB_game
{
    public partial class CodeBreakerForm : Form
    {
        private CodeBreakerGame codeBreakerGame;
        private bool timerPaused;
        private int elapsedSeconds;
        private string groupValue;
        private int numberOfGuesses;
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
            numberOfGuesses = 0;

            this.groupValue = groupValue;
            GroupLabel.Text += " vs. Group " + groupValue;
            timerPaused = false;
            elapsedSeconds = 0;

            codeBreakerGame.GenerateInitialGuess();

            menuStrip1.BackColor = Color.FromArgb(72, 77, 99);
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
        private void Win_Conditions(int numberOfGuesses)
        {
            int Score = 10 * (10 - numberOfGuesses + 1) - (elapsedSeconds / 10);

            TimerButton.Visible = false;
            CodeBreakerTimer.Stop();

            hintTextBox_1.Enabled = false;
            hintTextBox_2.Enabled = false;

            winLabel.Visible = true;
            winLabel.Text = $"Congratulations! Score: {Score} - {numberOfGuesses}";
        }

        private void SubmitHintButton_Click(object sender, EventArgs e)
        {
            int bulls, cows;

            if (!int.TryParse(hintTextBox_1.Text, out bulls))
            {
                return;
            }

            if (!int.TryParse(hintTextBox_2.Text, out cows))
            {
                return;
            }

            if (!CodeBreakerTimer.Enabled)
            {
                CodeBreakerTimer.Start();
                TimerButton.Visible = true;
            }

            // Make guess and check if the game is finished
            (string nextGuess, bool isGameFinished) = codeBreakerGame.MakeGuess(bulls, cows);

            string currentGuess = GuessLabel_1.Text + GuessLabel_2.Text + GuessLabel_3.Text + GuessLabel_4.Text;

            // Add the current guess and hint to the DataGridView
            string hint = $"{bulls}A{cows}B";
            AddGuessToDataGridView(currentGuess, hint);
            PopulateGuessLabels(nextGuess);
            numberOfGuesses++;

            // If the game is finished, do something
            if (isGameFinished)
            {
                // Do something when the game is finished, such as displaying a message or updating UI
                Win_Conditions(numberOfGuesses);

            }

            // Clear the input fields
            hintTextBox_1.Text = string.Empty;
            hintTextBox_2.Text = string.Empty;

            hintTextBox_1.Focus();
        }



        private void AddGuessToDataGridView(string guess, string hint)
        {
            int rowNumber = dataGridView1.Rows.Count;
            dataGridView1.Rows.Add(rowNumber, guess, hint);
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            hintTextBox_1.Text = "";
            hintTextBox_2.Text = "";

            hintTextBox_1.Enabled = true;
            hintTextBox_2.Enabled = true;

            CodeBreakerTimer.Stop();
            timerPaused = false;
            TimerButton.Text = "Pause";
            TimerButton.Visible = false;
            elapsedSeconds = 0;
            TimerLabel.Text = "Timer: 00:00";
            numberOfGuesses = 0;

            winLabel.Visible = false;

            dataGridView1.Rows.Clear();

            codeBreakerGame = new CodeBreakerGame();

            string newInitialGuess = codeBreakerGame.GenerateInitialGuess();
            PopulateGuessLabels(newInitialGuess);
        }
        private void hintTextBox_1_TextChanged(object sender, EventArgs e)
        {
            if (hintTextBox_1.Text.Length == 1 && char.IsDigit(hintTextBox_1.Text[0]))
            {
                hintTextBox_2.Focus();
            }
        }

        private void hintTextBox_2_TextChanged(object sender, EventArgs e)
        {
            if (hintTextBox_2.Text.Length == 1 && char.IsDigit(hintTextBox_2.Text[0]))
            {
                SubmitHintButton.Focus();
            }
        }
        private void hintTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox? currentTextBox = sender as TextBox;
            if (e.KeyCode == Keys.Back && currentTextBox != null && currentTextBox.Text.Length == 0)
            {
                if (currentTextBox == hintTextBox_2)
                {
                    hintTextBox_1.Focus();
                    hintTextBox_1.Text = "";
                }
            }
        }
        private void SubmitHintButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                hintTextBox_2.Focus();
                hintTextBox_2.Text = "";
            }
        }


        // Timer Logic
        private void CodeBreakerTimer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            int minutes = elapsedSeconds / 60;
            int seconds = elapsedSeconds % 60;
            TimerLabel.Text = $"Timer: {minutes:D2}:{seconds:D2}";
        }
        private void TimerButton_Click(object sender, EventArgs e)
        {
            if (!TimerButton.Visible)
            {
                return;
            }

            if (timerPaused)
            {
                CodeBreakerTimer.Start();
                timerPaused = false;
                TimerButton.Text = "Pause";
                pauseToolStripMenuItem.Text = "Pause";
                pauseStripMenuItem1.Text = "Pause";
                hintTextBox_1.Enabled = true;
                hintTextBox_2.Enabled = true;
            }
            else
            {
                CodeBreakerTimer.Stop();
                timerPaused = true;
                TimerButton.Text = "Play";
                pauseToolStripMenuItem.Text = "Play";
                pauseStripMenuItem1.Text = "Play";
                hintTextBox_1.Enabled = false;
                hintTextBox_2.Enabled = false;
            }
        }






        // UI Logic
        public class CustomMenuRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(86, 92, 118)), e.Item.ContentRectangle);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(72, 77, 99)), e.Item.ContentRectangle);
                }
            }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                e.TextColor = Color.White;
                base.OnRenderItemText(e);
            }
        }
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
        private void pauseStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimerButton_Click(sender, e);
        }
        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmitHintButton_Click(sender, e);
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGameBtn_Click(sender, e);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitButton_Click(sender, e);
        }
        private void submitHintToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SubmitHintButton_Click(sender, e);
        }
        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newGameBtn_Click(sender, e);
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExitButton_Click(sender, e);
        }
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerButton_Click(sender, e);
        }
    }
}