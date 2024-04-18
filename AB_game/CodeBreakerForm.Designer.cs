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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            SecretNumberTextBox = new TextBox();
            GroupLabel = new Label();
            ExitPanel = new Panel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            submitToolStripMenuItem = new ToolStripMenuItem();
            revealToolStripMenuItem = new ToolStripMenuItem();
            newgameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ExitButton = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            GuessNumber = new DataGridViewTextBoxColumn();
            Guess = new DataGridViewTextBoxColumn();
            Hint = new DataGridViewTextBoxColumn();
            hintTextBox_1 = new TextBox();
            hintTextBox_2 = new TextBox();
            SubmitHintButton = new Button();
            label_hint = new Label();
            label_guess = new Label();
            ExitPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // SecretNumberTextBox
            // 
            SecretNumberTextBox.Location = new Point(331, 201);
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
            ExitPanel.Controls.Add(menuStrip1);
            ExitPanel.Controls.Add(ExitButton);
            ExitPanel.Dock = DockStyle.Top;
            ExitPanel.Location = new Point(0, 0);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Size = new Size(1100, 40);
            ExitPanel.TabIndex = 7;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripMargin = new Padding(5);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Margin = new Padding(9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(172, 42);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pauseToolStripMenuItem, submitToolStripMenuItem, revealToolStripMenuItem, newgameToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 42);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(132, 22);
            pauseToolStripMenuItem.Text = "Pause";
            // 
            // submitToolStripMenuItem
            // 
            submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            submitToolStripMenuItem.Size = new Size(132, 22);
            submitToolStripMenuItem.Text = "Submit";
            // 
            // revealToolStripMenuItem
            // 
            revealToolStripMenuItem.Name = "revealToolStripMenuItem";
            revealToolStripMenuItem.Size = new Size(132, 22);
            revealToolStripMenuItem.Text = "Reveal";
            // 
            // newgameToolStripMenuItem
            // 
            newgameToolStripMenuItem.Name = "newgameToolStripMenuItem";
            newgameToolStripMenuItem.Size = new Size(132, 22);
            newgameToolStripMenuItem.Text = "New Game";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(132, 22);
            exitToolStripMenuItem.Text = "Exit ";
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 33.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { GuessNumber, Guess, Hint });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(46, 51, 73);
            dataGridView1.Location = new Point(615, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(473, 508);
            dataGridView1.TabIndex = 25;
            // 
            // GuessNumber
            // 
            GuessNumber.HeaderText = "#";
            GuessNumber.MinimumWidth = 75;
            GuessNumber.Name = "GuessNumber";
            GuessNumber.ReadOnly = true;
            // 
            // Guess
            // 
            Guess.FillWeight = 191.803284F;
            Guess.HeaderText = "Guess";
            Guess.Name = "Guess";
            Guess.ReadOnly = true;
            Guess.Width = 200;
            // 
            // Hint
            // 
            Hint.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Hint.FillWeight = 8.196716F;
            Hint.HeaderText = "Hint";
            Hint.Name = "Hint";
            Hint.ReadOnly = true;
            // 
            // hintTextBox_1
            // 
            hintTextBox_1.BackColor = Color.FromArgb(46, 51, 73);
            hintTextBox_1.BorderStyle = BorderStyle.FixedSingle;
            hintTextBox_1.Font = new Font("Segoe UI", 60F);
            hintTextBox_1.ForeColor = Color.White;
            hintTextBox_1.Location = new Point(21, 201);
            hintTextBox_1.MaxLength = 1;
            hintTextBox_1.Name = "hintTextBox_1";
            hintTextBox_1.Size = new Size(81, 114);
            hintTextBox_1.TabIndex = 27;
            hintTextBox_1.TextAlign = HorizontalAlignment.Center;
            // 
            // hintTextBox_2
            // 
            hintTextBox_2.BackColor = Color.FromArgb(46, 51, 73);
            hintTextBox_2.BorderStyle = BorderStyle.FixedSingle;
            hintTextBox_2.Font = new Font("Segoe UI", 60F);
            hintTextBox_2.ForeColor = Color.White;
            hintTextBox_2.Location = new Point(115, 201);
            hintTextBox_2.MaxLength = 1;
            hintTextBox_2.Name = "hintTextBox_2";
            hintTextBox_2.Size = new Size(81, 114);
            hintTextBox_2.TabIndex = 28;
            hintTextBox_2.TextAlign = HorizontalAlignment.Center;
            // 
            // SubmitHintButton
            // 
            SubmitHintButton.FlatAppearance.BorderColor = Color.White;
            SubmitHintButton.FlatStyle = FlatStyle.Flat;
            SubmitHintButton.Font = new Font("Segoe UI", 24F);
            SubmitHintButton.ForeColor = Color.LightGray;
            SubmitHintButton.ImageAlign = ContentAlignment.TopCenter;
            SubmitHintButton.Location = new Point(21, 336);
            SubmitHintButton.Name = "SubmitHintButton";
            SubmitHintButton.Size = new Size(175, 56);
            SubmitHintButton.TabIndex = 29;
            SubmitHintButton.Text = "Submit";
            SubmitHintButton.UseVisualStyleBackColor = true;
            // 
            // label_hint
            // 
            label_hint.AutoSize = true;
            label_hint.Font = new Font("Segoe UI", 26F);
            label_hint.Location = new Point(21, 135);
            label_hint.Name = "label_hint";
            label_hint.Size = new Size(175, 47);
            label_hint.TabIndex = 33;
            label_hint.Text = "Enter Hint";
            // 
            // label_guess
            // 
            label_guess.AutoSize = true;
            label_guess.Font = new Font("Segoe UI", 50F);
            label_guess.Location = new Point(12, 417);
            label_guess.Name = "label_guess";
            label_guess.Size = new Size(198, 89);
            label_guess.TabIndex = 34;
            label_guess.Text = "####";
            // 
            // CodeBreakerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1100, 600);
            Controls.Add(label_guess);
            Controls.Add(label_hint);
            Controls.Add(SubmitHintButton);
            Controls.Add(hintTextBox_2);
            Controls.Add(hintTextBox_1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(ExitPanel);
            Controls.Add(SecretNumberTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CodeBreakerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeBreakerForm";
            ExitPanel.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox SecretNumberTextBox;
        private Label GroupLabel;
        private Panel ExitPanel;
        private Button ExitButton;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem submitToolStripMenuItem;
        private ToolStripMenuItem revealToolStripMenuItem;
        private ToolStripMenuItem newgameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn GuessNumber;
        private DataGridViewTextBoxColumn Guess;
        private DataGridViewTextBoxColumn Hint;
        private TextBox hintTextBox_1;
        private TextBox hintTextBox_2;
        private Button SubmitHintButton;
        private Label label_hint;
        private Label label_guess;
    }
}