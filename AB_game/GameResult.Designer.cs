namespace AB_game
{
    partial class GameResult
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            ExitPanel = new Panel();
            NamePanel = new Panel();
            GroupLabel = new Label();
            ExitButton = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            GameMode = new Label();
            Date = new Label();
            Time = new Label();
            TotalSeconds = new Label();
            SecretNumber = new Label();
            GameScore = new Label();
            label1 = new Label();
            GroupName = new Label();
            dataGridView1 = new DataGridView();
            GuessNumber = new DataGridViewTextBoxColumn();
            Guess = new DataGridViewTextBoxColumn();
            Hint = new DataGridViewTextBoxColumn();
            ExitPanel.SuspendLayout();
            NamePanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ExitPanel
            // 
            ExitPanel.BackColor = Color.FromArgb(36, 42, 59);
            ExitPanel.Controls.Add(NamePanel);
            ExitPanel.Controls.Add(ExitButton);
            ExitPanel.Controls.Add(menuStrip1);
            ExitPanel.Location = new Point(0, 0);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Size = new Size(1100, 40);
            ExitPanel.TabIndex = 0;
            // 
            // NamePanel
            // 
            NamePanel.Controls.Add(GroupLabel);
            NamePanel.Dock = DockStyle.Right;
            NamePanel.Location = new Point(510, 0);
            NamePanel.Name = "NamePanel";
            NamePanel.Size = new Size(540, 40);
            NamePanel.TabIndex = 33;
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.Dock = DockStyle.Right;
            GroupLabel.FlatStyle = FlatStyle.Flat;
            GroupLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GroupLabel.ForeColor = Color.White;
            GroupLabel.Location = new Point(530, 0);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Padding = new Padding(0, 10, 10, 0);
            GroupLabel.Size = new Size(10, 31);
            GroupLabel.TabIndex = 5;
            GroupLabel.TextAlign = ContentAlignment.MiddleCenter;
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
            ExitButton.TabIndex = 1;
            ExitButton.Text = "X";
            ExitButton.TextAlign = ContentAlignment.TopCenter;
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripMargin = new Padding(5);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Margin = new Padding(9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(172, 42);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(50, 42);
            toolStripMenuItem1.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(96, 22);
            exitToolStripMenuItem.Text = "Exit ";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(94, 26);
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(93, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // GameMode
            // 
            GameMode.AutoSize = true;
            GameMode.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameMode.ForeColor = Color.White;
            GameMode.Location = new Point(48, 235);
            GameMode.Name = "GameMode";
            GameMode.Size = new Size(201, 40);
            GameMode.TabIndex = 2;
            GameMode.Text = "Game Mode: ";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Date.ForeColor = Color.White;
            Date.Location = new Point(48, 290);
            Date.Name = "Date";
            Date.Size = new Size(97, 40);
            Date.TabIndex = 3;
            Date.Text = "Date: ";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Time.ForeColor = Color.White;
            Time.Location = new Point(48, 352);
            Time.Name = "Time";
            Time.Size = new Size(101, 40);
            Time.TabIndex = 4;
            Time.Text = "Time: ";
            // 
            // TotalSeconds
            // 
            TotalSeconds.AutoSize = true;
            TotalSeconds.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalSeconds.ForeColor = Color.White;
            TotalSeconds.Location = new Point(48, 416);
            TotalSeconds.Name = "TotalSeconds";
            TotalSeconds.Size = new Size(221, 40);
            TotalSeconds.TabIndex = 6;
            TotalSeconds.Text = "Total Seconds: ";
            // 
            // SecretNumber
            // 
            SecretNumber.AutoSize = true;
            SecretNumber.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SecretNumber.ForeColor = Color.White;
            SecretNumber.Location = new Point(48, 475);
            SecretNumber.Name = "SecretNumber";
            SecretNumber.Size = new Size(241, 40);
            SecretNumber.TabIndex = 7;
            SecretNumber.Text = "Secret Number: ";
            // 
            // GameScore
            // 
            GameScore.AutoSize = true;
            GameScore.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameScore.ForeColor = Color.White;
            GameScore.Location = new Point(48, 538);
            GameScore.Name = "GameScore";
            GameScore.Size = new Size(197, 40);
            GameScore.TabIndex = 8;
            GameScore.Text = "Game Score: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 38.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(377, 43);
            label1.Name = "label1";
            label1.Size = new Size(312, 68);
            label1.TabIndex = 10;
            label1.Text = "Game Result";
            // 
            // GroupName
            // 
            GroupName.AutoSize = true;
            GroupName.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupName.ForeColor = Color.White;
            GroupName.Location = new Point(48, 177);
            GroupName.Name = "GroupName";
            GroupName.Size = new Size(210, 40);
            GroupName.TabIndex = 1;
            GroupName.Text = "Group Name: ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(64, 70, 86);
            dataGridView1.Location = new Point(510, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(501, 480);
            dataGridView1.TabIndex = 24;
            // 
            // GuessNumber
            // 
            GuessNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            GuessNumber.FillWeight = 20F;
            GuessNumber.HeaderText = "#";
            GuessNumber.MinimumWidth = 150;
            GuessNumber.Name = "GuessNumber";
            GuessNumber.ReadOnly = true;
            GuessNumber.Width = 150;
            // 
            // Guess
            // 
            Guess.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Guess.FillWeight = 40F;
            Guess.HeaderText = "Guess";
            Guess.MinimumWidth = 180;
            Guess.Name = "Guess";
            Guess.ReadOnly = true;
            Guess.Width = 180;
            // 
            // Hint
            // 
            Hint.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Hint.FillWeight = 40F;
            Hint.HeaderText = "Hint";
            Hint.MinimumWidth = 180;
            Hint.Name = "Hint";
            Hint.ReadOnly = true;
            Hint.Width = 180;
            // 
            // GameResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1100, 700);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(GameScore);
            Controls.Add(SecretNumber);
            Controls.Add(TotalSeconds);
            Controls.Add(Time);
            Controls.Add(Date);
            Controls.Add(GameMode);
            Controls.Add(GroupName);
            Controls.Add(ExitPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameResult";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameResult";
            ExitPanel.ResumeLayout(false);
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ExitPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button ExitButton;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Label GameMode;
        private Label Date;
        private Label Time;
        private Label TotalSeconds;
        private Label SecretNumber;
        private Label GameScore;
        private Label label1;
        private Panel NamePanel;
        private Label GroupLabel;
        private Label GroupName;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn GuessNumber;
        private DataGridViewTextBoxColumn Guess;
        private DataGridViewTextBoxColumn Hint;
    }
}