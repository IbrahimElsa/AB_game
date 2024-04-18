namespace AB_game
{
    partial class CodeBreakerForm
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
            label1 = new Label();
            generateSecretNumberButton = new Button();
            SecretNumberTextBox = new TextBox();
            GroupLabel = new Label();
            ExitPanel = new Panel();
            ExitButton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            SecretLabel_1 = new Label();
            SecretLabel_2 = new Label();
            SecretLabel_3 = new Label();
            SecretLabel_4 = new Label();
            RevealButton = new Button();
            ExitPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 38F, FontStyle.Underline);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(332, 68);
            label1.TabIndex = 1;
            label1.Text = "Code Breaker";
            // 
            // generateSecretNumberButton
            // 
            generateSecretNumberButton.Font = new Font("Segoe UI", 18F);
            generateSecretNumberButton.Location = new Point(297, 378);
            generateSecretNumberButton.Name = "generateSecretNumberButton";
            generateSecretNumberButton.Size = new Size(201, 50);
            generateSecretNumberButton.TabIndex = 3;
            generateSecretNumberButton.Text = "Random Secret";
            generateSecretNumberButton.UseVisualStyleBackColor = true;
            generateSecretNumberButton.Click += generateSecretNumberButton_Click;
            // 
            // SecretNumberTextBox
            // 
            SecretNumberTextBox.Location = new Point(344, 276);
            SecretNumberTextBox.Name = "SecretNumberTextBox";
            SecretNumberTextBox.Size = new Size(100, 23);
            SecretNumberTextBox.TabIndex = 4;
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.Dock = DockStyle.Right;
            GroupLabel.Font = new Font("Segoe UI", 20F);
            GroupLabel.ForeColor = Color.White;
            GroupLabel.Location = new Point(937, 0);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Padding = new Padding(0, 10, 10, 0);
            GroupLabel.Size = new Size(139, 47);
            GroupLabel.TabIndex = 5;
            GroupLabel.Text = "Group 11";
            GroupLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ExitPanel
            // 
            ExitPanel.BackColor = Color.FromArgb(72, 77, 99);
            ExitPanel.Controls.Add(ExitButton);
            ExitPanel.Dock = DockStyle.Top;
            ExitPanel.Location = new Point(0, 0);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Size = new Size(1100, 40);
            ExitPanel.TabIndex = 7;
            // 
            // ExitButton
            // 
            ExitButton.Dock = DockStyle.Right;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.Font = new Font("Segoe UI", 15F);
            ExitButton.ForeColor = Color.LightGray;
            ExitButton.Location = new Point(1050, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(50, 40);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "X";
            ExitButton.TextAlign = ContentAlignment.TopCenter;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(GroupLabel);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 67);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F);
            label2.Location = new Point(21, 135);
            label2.Name = "label2";
            label2.Size = new Size(270, 47);
            label2.TabIndex = 9;
            label2.Text = "Secret Number: ";
            // 
            // SecretLabel_1
            // 
            SecretLabel_1.AutoSize = true;
            SecretLabel_1.BorderStyle = BorderStyle.FixedSingle;
            SecretLabel_1.Font = new Font("Segoe UI", 26F);
            SecretLabel_1.Location = new Point(282, 135);
            SecretLabel_1.Name = "SecretLabel_1";
            SecretLabel_1.Size = new Size(38, 49);
            SecretLabel_1.TabIndex = 10;
            SecretLabel_1.Text = "?";
            // 
            // SecretLabel_2
            // 
            SecretLabel_2.AutoSize = true;
            SecretLabel_2.BorderStyle = BorderStyle.FixedSingle;
            SecretLabel_2.Font = new Font("Segoe UI", 26F);
            SecretLabel_2.Location = new Point(326, 135);
            SecretLabel_2.Name = "SecretLabel_2";
            SecretLabel_2.Size = new Size(38, 49);
            SecretLabel_2.TabIndex = 11;
            SecretLabel_2.Text = "?";
            // 
            // SecretLabel_3
            // 
            SecretLabel_3.AutoSize = true;
            SecretLabel_3.BorderStyle = BorderStyle.FixedSingle;
            SecretLabel_3.Font = new Font("Segoe UI", 26F);
            SecretLabel_3.Location = new Point(370, 135);
            SecretLabel_3.Name = "SecretLabel_3";
            SecretLabel_3.Size = new Size(38, 49);
            SecretLabel_3.TabIndex = 12;
            SecretLabel_3.Text = "?";
            // 
            // SecretLabel_4
            // 
            SecretLabel_4.AutoSize = true;
            SecretLabel_4.BorderStyle = BorderStyle.FixedSingle;
            SecretLabel_4.Font = new Font("Segoe UI", 26F);
            SecretLabel_4.Location = new Point(414, 135);
            SecretLabel_4.Name = "SecretLabel_4";
            SecretLabel_4.Size = new Size(38, 49);
            SecretLabel_4.TabIndex = 13;
            SecretLabel_4.Text = "?";
            // 
            // RevealButton
            // 
            RevealButton.FlatAppearance.BorderColor = Color.White;
            RevealButton.FlatStyle = FlatStyle.Flat;
            RevealButton.Font = new Font("Segoe UI", 18F);
            RevealButton.ForeColor = Color.LightGray;
            RevealButton.Location = new Point(487, 135);
            RevealButton.Name = "RevealButton";
            RevealButton.Size = new Size(101, 47);
            RevealButton.TabIndex = 15;
            RevealButton.Text = "Reveal";
            RevealButton.TextAlign = ContentAlignment.TopCenter;
            RevealButton.UseVisualStyleBackColor = true;
            RevealButton.Click += RevealButton_Click;
            // 
            // CodeBreakerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1100, 600);
            Controls.Add(RevealButton);
            Controls.Add(SecretLabel_4);
            Controls.Add(SecretLabel_3);
            Controls.Add(SecretLabel_2);
            Controls.Add(SecretLabel_1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(ExitPanel);
            Controls.Add(SecretNumberTextBox);
            Controls.Add(generateSecretNumberButton);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CodeBreakerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeBreakerForm";
            ExitPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button generateSecretNumberButton;
        private TextBox SecretNumberTextBox;
        private Label GroupLabel;
        private Panel ExitPanel;
        private Button ExitButton;
        private Panel panel1;
        private Label label2;
        private Label SecretLabel_1;
        private Label SecretLabel_2;
        private Label SecretLabel_3;
        private Label SecretLabel_4;
        private Button RevealButton;
    }
}