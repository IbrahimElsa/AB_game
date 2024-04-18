using CIS3433;

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AB_game
{
    public partial class CodeBreakerForm : Form
    {
        //private CodeBreakerGame codeBreakerGame;
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
            ExitPanel.MouseDown += ExitPanel_MouseDown;
            ExitPanel.MouseMove += ExitPanel_MouseMove;
            ExitPanel.MouseUp += ExitPanel_MouseUp;

            this.groupValue = groupValue;
            GroupLabel.Text += " vs. Group " + groupValue;
            //codeBreakerGame = new CodeBreakerGame(secretNumber);
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

        private void makeGuessButton_Click(object sender, EventArgs e)
        {
            // string guess = guessTextBox.Text;
            // codeBreakerGame.MakeGuess(guess);
            // Display or use the guess and score as needed
            // guessesList.Items.Add(guess);
        }

        private void calculateScoreButton_Click(object sender, EventArgs e)
        {
            //double score = codeBreakerGame.CalculateScore();
            // Display or use the calculated score as needed
            // scoreLabel.Text = score.ToString();
        }

        private void generateSecretNumberButton_Click(object sender, EventArgs e)
        {
            // string secretNumber = GenerateSecretNumber();
            // secretNumberTextBox.Text = secretNumber;
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

        private void RevealButton_Click(object sender, EventArgs e)
        {

        }
    }
}