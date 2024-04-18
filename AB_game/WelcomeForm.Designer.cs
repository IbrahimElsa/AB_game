namespace AB_game
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ExitButton = new Label();
            label2 = new Label();
            label3 = new Label();
            CodeMakerButton = new Button();
            CodeBreakerButton = new Button();
            GroupTextBox = new TextBox();
            button1 = new Button();
            ExitPanel = new Panel();
            ExitPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            ExitButton.ForeColor = Color.White;
            ExitButton.Location = new Point(120, 42);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(263, 72);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "AB Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(191, 276);
            label2.Name = "label2";
            label2.Size = new Size(120, 64);
            label2.TabIndex = 1;
            label2.Text = "Group 11 \r\nVS.";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(138, 114);
            label3.Name = "label3";
            label3.Size = new Size(224, 111);
            label3.TabIndex = 2;
            label3.Text = "Ibrahim Elsawalhi\r\nLogan Salzman\r\nBradley Titus";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // CodeMakerButton
            // 
            CodeMakerButton.BackColor = Color.FromArgb(46, 51, 73);
            CodeMakerButton.CausesValidation = false;
            CodeMakerButton.Enabled = false;
            CodeMakerButton.FlatStyle = FlatStyle.Flat;
            CodeMakerButton.Font = new Font("Segoe UI", 18F);
            CodeMakerButton.ForeColor = Color.White;
            CodeMakerButton.Location = new Point(60, 442);
            CodeMakerButton.Name = "CodeMakerButton";
            CodeMakerButton.Size = new Size(174, 62);
            CodeMakerButton.TabIndex = 3;
            CodeMakerButton.Text = "Code Maker";
            CodeMakerButton.UseVisualStyleBackColor = false;
            CodeMakerButton.Click += CodeMakerButton_Click;
            // 
            // CodeBreakerButton
            // 
            CodeBreakerButton.BackColor = Color.FromArgb(46, 51, 73);
            CodeBreakerButton.Enabled = false;
            CodeBreakerButton.FlatStyle = FlatStyle.Flat;
            CodeBreakerButton.Font = new Font("Segoe UI", 18F);
            CodeBreakerButton.ForeColor = Color.White;
            CodeBreakerButton.Location = new Point(278, 442);
            CodeBreakerButton.Name = "CodeBreakerButton";
            CodeBreakerButton.Size = new Size(174, 62);
            CodeBreakerButton.TabIndex = 4;
            CodeBreakerButton.Text = "Code Breaker";
            CodeBreakerButton.UseVisualStyleBackColor = false;
            CodeBreakerButton.Click += CodeBreakerButton_Click;
            // 
            // GroupTextBox
            // 
            GroupTextBox.BackColor = Color.FromArgb(46, 51, 73);
            GroupTextBox.BorderStyle = BorderStyle.FixedSingle;
            GroupTextBox.Font = new Font("Segoe UI", 18F);
            GroupTextBox.ForeColor = Color.White;
            GroupTextBox.Location = new Point(158, 343);
            GroupTextBox.Name = "GroupTextBox";
            GroupTextBox.PlaceholderText = "Name or Num";
            GroupTextBox.Size = new Size(189, 39);
            GroupTextBox.TabIndex = 5;
            GroupTextBox.TextAlign = HorizontalAlignment.Center;
            GroupTextBox.TextChanged += GroupTextBox_TextChanged;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(453, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExitPanel
            // 
            ExitPanel.Controls.Add(button1);
            ExitPanel.Dock = DockStyle.Top;
            ExitPanel.Location = new Point(0, 0);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Size = new Size(503, 50);
            ExitPanel.TabIndex = 6;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(503, 555);
            Controls.Add(ExitPanel);
            Controls.Add(GroupTextBox);
            Controls.Add(CodeBreakerButton);
            Controls.Add(CodeMakerButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ExitButton);
            ForeColor = Color.Gray;
            FormBorderStyle = FormBorderStyle.None;
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ExitPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExitButton;
        private Label label2;
        private Label label3;
        private Button CodeMakerButton;
        private Button CodeBreakerButton;
        private TextBox GroupTextBox;
        private Button button1;
        private Panel ExitPanel;
    }
}