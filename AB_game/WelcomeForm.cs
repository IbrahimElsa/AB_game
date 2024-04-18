using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AB_game
{
    public partial class WelcomeForm : Form
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

        public WelcomeForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ExitPanel.MouseDown += ExitPanel_MouseDown;
            ExitPanel.MouseMove += ExitPanel_MouseMove;
            ExitPanel.MouseUp += ExitPanel_MouseUp;
            this.ActiveControl = GroupTextBox;

            // Round the buttons
            // CodeMakerButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, CodeMakerButton.Width, CodeMakerButton.Height, 15, 15));
            // CodeBreakerButton.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, CodeBreakerButton.Width, CodeBreakerButton.Height, 15, 15));
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

        

        private void CodeMakerButton_Click(object sender, EventArgs e)
        {
            string groupValue = GroupTextBox.Text.Trim().Replace(" ", "_");
            if (!string.IsNullOrEmpty(groupValue))
            {
                CodeMakerForm codeMakerForm = new CodeMakerForm(groupValue);
                codeMakerForm.Show();
                this.Hide();
            }
        }

        private void CodeBreakerButton_Click(object sender, EventArgs e)
        {
            string groupValue = GroupTextBox.Text.Trim().Replace(" ", "_");
            if (!string.IsNullOrEmpty(groupValue))
            {
                CodeBreakerForm codeBreakerForm = new CodeBreakerForm(groupValue);
                codeBreakerForm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}