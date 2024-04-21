using CIS3433;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static AB_game.CodeBreakerForm;

namespace AB_game
{
    public partial class CodeMakerForm : Form
    {
        private CodeMakerGame codeMakerGame;
        private string groupValue;
        private bool timerPaused;
        private int elapsedSeconds;

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


        public CodeMakerForm(string groupValue)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            codeMakerGame = new CodeMakerGame();

            this.groupValue = groupValue;
            GroupLabel.Text += " vs. Group " + groupValue;
            timerPaused = false;
            elapsedSeconds = 0;

            codeMakerGame.GenerateSecretNumber();

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
        }

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

        private void Win_Conditions(int GuessNumber)
        {
            int Score = 10 * (10 - GuessNumber + 1) - (elapsedSeconds / 10);

            TimerButton.Visible = false;
            CodeMakerTimer.Stop();

            SecretLabel_1.Text = codeMakerGame.SecretNumber[0].ToString();
            SecretLabel_2.Text = codeMakerGame.SecretNumber[1].ToString();
            SecretLabel_3.Text = codeMakerGame.SecretNumber[2].ToString();
            SecretLabel_4.Text = codeMakerGame.SecretNumber[3].ToString();

            guessTextBox_1.Enabled = false;
            guessTextBox_2.Enabled = false;
            guessTextBox_3.Enabled = false;
            guessTextBox_4.Enabled = false;

            winLabel.Visible = true;
            winLabel.Text = $"Congratulations! Score: {Score}";
        }
        private void SubmitGuessButton_Click(object sender, EventArgs e)
        {
            // Check if all guess text boxes are filled with valid numbers
            if (IsValidGuess())
            {
                if (!CodeMakerTimer.Enabled)
                {
                    CodeMakerTimer.Start();
                    TimerButton.Visible = true;
                }

                string guess = guessTextBox_1.Text + guessTextBox_2.Text + guessTextBox_3.Text + guessTextBox_4.Text;
                string result = codeMakerGame.EvaluateGuess(guess);

                // Get the current guess number
                int guessNumber = dataGridView1.Rows.Count;

                // Create a new row with the guess number, guess, and hint
                dataGridView1.Rows.Add(guessNumber, guess, $"{result[0]}A{result[1]}B");

                if (result[0] == '4')
                {
                    Win_Conditions(guessNumber);
                }

                // Clear the guess text boxes
                guessTextBox_1.Clear();
                guessTextBox_2.Clear();
                guessTextBox_3.Clear();
                guessTextBox_4.Clear();

                // Set focus to the first guess text box for the next guess
                guessTextBox_1.Focus();
            }
            else
            {
                MessageBox.Show("Please enter a valid guess (numbers 0-9) in all text boxes.", "Invalid Guess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool IsValidGuess()
        {
            return !string.IsNullOrEmpty(guessTextBox_1.Text) &&
                   guessTextBox_1.Text.Length == 1 &&
                   char.IsDigit(guessTextBox_1.Text[0]) &&
                   !string.IsNullOrEmpty(guessTextBox_2.Text) &&
                   guessTextBox_2.Text.Length == 1 &&
                   char.IsDigit(guessTextBox_2.Text[0]) &&
                   !string.IsNullOrEmpty(guessTextBox_3.Text) &&
                   guessTextBox_3.Text.Length == 1 &&
                   char.IsDigit(guessTextBox_3.Text[0]) &&
                   !string.IsNullOrEmpty(guessTextBox_4.Text) &&
                   guessTextBox_4.Text.Length == 1 &&
                   char.IsDigit(guessTextBox_4.Text[0]);
        }

        private void RevealButton_Click(object sender, EventArgs e)
        {
            if (codeMakerGame.SecretNumber != null)
            {
                char[] secretDigits = codeMakerGame.SecretNumber.ToCharArray();
                SecretLabel_1.Text = secretDigits[0].ToString();
                SecretLabel_2.Text = secretDigits[1].ToString();
                SecretLabel_3.Text = secretDigits[2].ToString();
                SecretLabel_4.Text = secretDigits[3].ToString();

                guessTextBox_1.Enabled = false;
                guessTextBox_2.Enabled = false;
                guessTextBox_3.Enabled = false;
                guessTextBox_4.Enabled = false;

                CodeMakerTimer.Stop();
                timerPaused = true;
                TimerButton.Text = "Play";
                TimerButton.Visible = false;
            }
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            codeMakerGame.GenerateSecretNumber();

            // Clear the secret labels
            SecretLabel_1.Text = "?";
            SecretLabel_2.Text = "?";
            SecretLabel_3.Text = "?";
            SecretLabel_4.Text = "?";

            guessTextBox_1.Enabled = true;
            guessTextBox_2.Enabled = true;
            guessTextBox_3.Enabled = true;
            guessTextBox_4.Enabled = true;

            CodeMakerTimer.Stop();
            timerPaused = false;
            TimerButton.Text = "Pause";
            TimerButton.Visible = false;
            elapsedSeconds = 0;
            TimerLabel.Text = "Timer: 00:00";

            winLabel.Visible = false;
            dataGridView1.Rows.Clear();
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            if (!TimerButton.Visible)
            {
                return;
            }

            if (timerPaused)
            {
                // Resume the timer
                CodeMakerTimer.Start();
                timerPaused = false;
                TimerButton.Text = "Pause";
                pauseToolStripMenuItem.Text = "Pause";
                pauseToolStripMenuItem1.Text = "Pause";
                guessTextBox_1.Enabled = true;
                guessTextBox_2.Enabled = true;
                guessTextBox_3.Enabled = true;
                guessTextBox_4.Enabled = true;
            }
            else
            {
                // Pause the timer
                CodeMakerTimer.Stop();
                timerPaused = true;
                TimerButton.Text = "Play";
                pauseToolStripMenuItem.Text = "Play";
                pauseToolStripMenuItem1.Text = "Play";
                guessTextBox_1.Enabled = false;
                guessTextBox_2.Enabled = false;
                guessTextBox_3.Enabled = false;
                guessTextBox_4.Enabled = false;
            }
        }

        private void CodeMakerTimer_Tick(object sender, EventArgs e)
        {
            elapsedSeconds++;
            int minutes = elapsedSeconds / 60;
            int seconds = elapsedSeconds % 60;
            TimerLabel.Text = $"Timer: {minutes:D2}:{seconds:D2}";
        }

        private void guessTextBox_1_TextChanged(object sender, EventArgs e)
        {
            if (guessTextBox_1.Text.Length == 1 && char.IsDigit(guessTextBox_1.Text[0]))
            {
                guessTextBox_2.Focus();
            }
        }
        private void guessTextBox_2_TextChanged(object sender, EventArgs e)
        {
            if (guessTextBox_2.Text.Length == 1 && char.IsDigit(guessTextBox_2.Text[0]))
            {
                guessTextBox_3.Focus();
            }
        }
        private void guessTextBox_3_TextChanged(object sender, EventArgs e)
        {
            if (guessTextBox_3.Text.Length == 1 && char.IsDigit(guessTextBox_3.Text[0]))
            {
                guessTextBox_4.Focus();
            }
        }
        private void guessTextBox_4_TextChanged(object sender, EventArgs e)
        {
            if (guessTextBox_4.Text.Length == 1 && char.IsDigit(guessTextBox_4.Text[0]))
            {
                SubmitGuessButton.Focus();
            }
        }
        private void GuessTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox? currentTextBox = sender as TextBox;
            if (e.KeyCode == Keys.Back && currentTextBox != null && currentTextBox.Text.Length == 0)
            {
                // Decide which TextBox to focus based on the sender
                TextBox? previousTextBox = null;
                if (currentTextBox == guessTextBox_2) previousTextBox = guessTextBox_1;
                else if (currentTextBox == guessTextBox_3) previousTextBox = guessTextBox_2;
                else if (currentTextBox == guessTextBox_4) previousTextBox = guessTextBox_3;

                if (previousTextBox != null)
                {
                    previousTextBox.Focus();
                    previousTextBox.Text = ""; // Move the cursor to the end of the text
                }
            }
        }
        private void SubmitGuessButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                guessTextBox_4.Focus();
                guessTextBox_4.Text = "";
            }
        }

        private void revealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RevealButton_Click(sender, e);
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimerButton_Click(sender, e);
        }

        private void submitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmitGuessButton_Click(sender, e);
        }

        private void newgameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGameButton_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitButton_Click(sender, e);
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

        private void pauseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TimerButton_Click(sender, e);
        }

        private void submitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SubmitGuessButton_Click(sender, e);
        }

        private void newGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewGameButton_Click(sender, e);
        }

        private void revealToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RevealButton_Click(sender, e);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExitButton_Click(sender, e);
        }
    }
}
