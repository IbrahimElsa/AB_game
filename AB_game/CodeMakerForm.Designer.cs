﻿namespace AB_game
{
    partial class CodeMakerForm
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
            RevealButton = new Button();
            SecretLabel_4 = new Label();
            SecretLabel_3 = new Label();
            SecretLabel_2 = new Label();
            SecretLabel_1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            TimerButton = new Button();
            TimerLabel = new Label();
            label1 = new Label();
            GroupLabel = new Label();
            ExitPanel = new Panel();
            NamePanel = new Panel();
            ExitButton = new Button();
            menuStrip1 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pauseToolStripMenuItem1 = new ToolStripMenuItem();
            submitToolStripMenuItem1 = new ToolStripMenuItem();
            newGameToolStripMenuItem1 = new ToolStripMenuItem();
            revealToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            menuToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            submitToolStripMenuItem = new ToolStripMenuItem();
            revealToolStripMenuItem = new ToolStripMenuItem();
            newgameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            GuessNumber = new DataGridViewTextBoxColumn();
            Guess = new DataGridViewTextBoxColumn();
            Hint = new DataGridViewTextBoxColumn();
            guessTextBox_1 = new TextBox();
            NewGameButton = new Button();
            SubmitGuessButton = new Button();
            guessTextBox_2 = new TextBox();
            guessTextBox_4 = new TextBox();
            guessTextBox_3 = new TextBox();
            label3 = new Label();
            CodeMakerTimer = new System.Windows.Forms.Timer(components);
            SubmitGameButton = new Button();
            winLabel = new Label();
            panel2 = new Panel();
            ScoreTextBox = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ExitPanel.SuspendLayout();
            NamePanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // RevealButton
            // 
            RevealButton.FlatAppearance.BorderColor = Color.White;
            RevealButton.FlatStyle = FlatStyle.Flat;
            RevealButton.Font = new Font("Segoe UI", 18F);
            RevealButton.ForeColor = Color.LightGray;
            RevealButton.Location = new Point(82, 570);
            RevealButton.Name = "RevealButton";
            RevealButton.Size = new Size(167, 50);
            RevealButton.TabIndex = 23;
            RevealButton.Text = "Reveal Secret";
            RevealButton.UseVisualStyleBackColor = true;
            RevealButton.Click += RevealButton_Click;
            // 
            // SecretLabel_4
            // 
            SecretLabel_4.AutoSize = true;
            SecretLabel_4.BorderStyle = BorderStyle.FixedSingle;
            SecretLabel_4.Font = new Font("Segoe UI", 26F);
            SecretLabel_4.Location = new Point(430, 137);
            SecretLabel_4.Name = "SecretLabel_4";
            SecretLabel_4.Size = new Size(38, 49);
            SecretLabel_4.TabIndex = 22;
            SecretLabel_4.Text = "?";
            // 
            // SecretLabel_3
            // 
            SecretLabel_3.AutoSize = true;
            SecretLabel_3.BorderStyle = BorderStyle.FixedSingle;
            SecretLabel_3.Font = new Font("Segoe UI", 26F);
            SecretLabel_3.Location = new Point(386, 137);
            SecretLabel_3.Name = "SecretLabel_3";
            SecretLabel_3.Size = new Size(38, 49);
            SecretLabel_3.TabIndex = 21;
            SecretLabel_3.Text = "?";
            // 
            // SecretLabel_2
            // 
            SecretLabel_2.AutoSize = true;
            SecretLabel_2.BorderStyle = BorderStyle.FixedSingle;
            SecretLabel_2.Font = new Font("Segoe UI", 26F);
            SecretLabel_2.Location = new Point(342, 137);
            SecretLabel_2.Name = "SecretLabel_2";
            SecretLabel_2.Size = new Size(38, 49);
            SecretLabel_2.TabIndex = 20;
            SecretLabel_2.Text = "?";
            // 
            // SecretLabel_1
            // 
            SecretLabel_1.AutoSize = true;
            SecretLabel_1.BorderStyle = BorderStyle.FixedSingle;
            SecretLabel_1.Font = new Font("Segoe UI", 26F);
            SecretLabel_1.Location = new Point(298, 137);
            SecretLabel_1.Name = "SecretLabel_1";
            SecretLabel_1.Size = new Size(38, 49);
            SecretLabel_1.TabIndex = 19;
            SecretLabel_1.Text = "?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F);
            label2.Location = new Point(40, 137);
            label2.Name = "label2";
            label2.Size = new Size(252, 47);
            label2.TabIndex = 18;
            label2.Text = "Secret Number";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 67);
            panel1.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Controls.Add(TimerButton);
            panel3.Controls.Add(TimerLabel);
            panel3.Location = new Point(498, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(540, 64);
            panel3.TabIndex = 30;
            // 
            // TimerButton
            // 
            TimerButton.Dock = DockStyle.Right;
            TimerButton.FlatAppearance.BorderColor = Color.White;
            TimerButton.FlatStyle = FlatStyle.Flat;
            TimerButton.Font = new Font("Segoe UI", 24F);
            TimerButton.ForeColor = Color.LightGray;
            TimerButton.ImageAlign = ContentAlignment.TopCenter;
            TimerButton.Location = new Point(374, 0);
            TimerButton.Name = "TimerButton";
            TimerButton.Size = new Size(166, 64);
            TimerButton.TabIndex = 30;
            TimerButton.Text = "Pause";
            TimerButton.UseVisualStyleBackColor = true;
            TimerButton.Visible = false;
            TimerButton.Click += TimerButton_Click;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Dock = DockStyle.Left;
            TimerLabel.Font = new Font("Segoe UI", 26F);
            TimerLabel.ImageAlign = ContentAlignment.BottomCenter;
            TimerLabel.Location = new Point(0, 0);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Padding = new Padding(9);
            TimerLabel.Size = new Size(226, 65);
            TimerLabel.TabIndex = 29;
            TimerLabel.Text = "Timer: 00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 38F, FontStyle.Underline);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(304, 68);
            label1.TabIndex = 1;
            label1.Text = "Code Maker";
            // 
            // GroupLabel
            // 
            GroupLabel.AutoSize = true;
            GroupLabel.Dock = DockStyle.Right;
            GroupLabel.FlatStyle = FlatStyle.Flat;
            GroupLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            GroupLabel.ForeColor = Color.White;
            GroupLabel.Location = new Point(451, 0);
            GroupLabel.Name = "GroupLabel";
            GroupLabel.Padding = new Padding(0, 10, 10, 0);
            GroupLabel.Size = new Size(89, 31);
            GroupLabel.TabIndex = 5;
            GroupLabel.Text = "Group 11";
            GroupLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitPanel
            // 
            ExitPanel.BackColor = Color.FromArgb(36, 42, 59);
            ExitPanel.Controls.Add(NamePanel);
            ExitPanel.Controls.Add(ExitButton);
            ExitPanel.Controls.Add(menuStrip1);
            ExitPanel.Dock = DockStyle.Top;
            ExitPanel.ForeColor = Color.Transparent;
            ExitPanel.Location = new Point(0, 0);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Size = new Size(1100, 40);
            ExitPanel.TabIndex = 16;
            // 
            // NamePanel
            // 
            NamePanel.Controls.Add(GroupLabel);
            NamePanel.Dock = DockStyle.Right;
            NamePanel.Location = new Point(510, 0);
            NamePanel.Name = "NamePanel";
            NamePanel.Size = new Size(540, 40);
            NamePanel.TabIndex = 30;
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
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ContextMenuStrip = contextMenuStrip1;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripMargin = new Padding(5);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Margin = new Padding(9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(172, 42);
            menuStrip1.TabIndex = 31;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { pauseToolStripMenuItem1, submitToolStripMenuItem1, newGameToolStripMenuItem1, revealToolStripMenuItem1, exitToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(143, 114);
            // 
            // pauseToolStripMenuItem1
            // 
            pauseToolStripMenuItem1.Name = "pauseToolStripMenuItem1";
            pauseToolStripMenuItem1.Size = new Size(142, 22);
            pauseToolStripMenuItem1.Text = "Pause";
            pauseToolStripMenuItem1.Click += pauseToolStripMenuItem1_Click;
            // 
            // submitToolStripMenuItem1
            // 
            submitToolStripMenuItem1.Name = "submitToolStripMenuItem1";
            submitToolStripMenuItem1.Size = new Size(142, 22);
            submitToolStripMenuItem1.Text = "Submit";
            submitToolStripMenuItem1.Click += submitToolStripMenuItem1_Click;
            // 
            // newGameToolStripMenuItem1
            // 
            newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            newGameToolStripMenuItem1.Size = new Size(142, 22);
            newGameToolStripMenuItem1.Text = "New Game";
            newGameToolStripMenuItem1.Click += newGameToolStripMenuItem1_Click;
            // 
            // revealToolStripMenuItem1
            // 
            revealToolStripMenuItem1.Name = "revealToolStripMenuItem1";
            revealToolStripMenuItem1.Size = new Size(142, 22);
            revealToolStripMenuItem1.Text = "Reveal secret";
            revealToolStripMenuItem1.Click += revealToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(142, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
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
            pauseToolStripMenuItem.Click += pauseToolStripMenuItem_Click;
            // 
            // submitToolStripMenuItem
            // 
            submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            submitToolStripMenuItem.Size = new Size(132, 22);
            submitToolStripMenuItem.Text = "Submit";
            submitToolStripMenuItem.Click += submitToolStripMenuItem_Click;
            // 
            // revealToolStripMenuItem
            // 
            revealToolStripMenuItem.Name = "revealToolStripMenuItem";
            revealToolStripMenuItem.Size = new Size(132, 22);
            revealToolStripMenuItem.Text = "Reveal";
            revealToolStripMenuItem.Click += revealToolStripMenuItem_Click;
            // 
            // newgameToolStripMenuItem
            // 
            newgameToolStripMenuItem.Name = "newgameToolStripMenuItem";
            newgameToolStripMenuItem.Size = new Size(132, 22);
            newgameToolStripMenuItem.Text = "New Game";
            newgameToolStripMenuItem.Click += newgameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(132, 22);
            exitToolStripMenuItem.Text = "Exit ";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(64, 70, 86);
            dataGridView1.Location = new Point(555, 130);
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
            dataGridView1.Size = new Size(495, 480);
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
            // guessTextBox_1
            // 
            guessTextBox_1.BackColor = Color.FromArgb(46, 51, 73);
            guessTextBox_1.BorderStyle = BorderStyle.FixedSingle;
            guessTextBox_1.Font = new Font("Segoe UI", 60F);
            guessTextBox_1.ForeColor = Color.White;
            guessTextBox_1.Location = new Point(96, 316);
            guessTextBox_1.MaxLength = 1;
            guessTextBox_1.Name = "guessTextBox_1";
            guessTextBox_1.Size = new Size(81, 114);
            guessTextBox_1.TabIndex = 26;
            guessTextBox_1.TextAlign = HorizontalAlignment.Center;
            guessTextBox_1.TextChanged += guessTextBox_1_TextChanged;
            guessTextBox_1.KeyDown += GuessTextBox_KeyDown;
            // 
            // NewGameButton
            // 
            NewGameButton.FlatAppearance.BorderColor = Color.White;
            NewGameButton.FlatStyle = FlatStyle.Flat;
            NewGameButton.Font = new Font("Segoe UI", 18F);
            NewGameButton.ForeColor = Color.LightGray;
            NewGameButton.Location = new Point(287, 570);
            NewGameButton.Name = "NewGameButton";
            NewGameButton.Size = new Size(166, 50);
            NewGameButton.TabIndex = 27;
            NewGameButton.Text = "New Game";
            NewGameButton.UseVisualStyleBackColor = true;
            NewGameButton.Click += NewGameButton_Click;
            // 
            // SubmitGuessButton
            // 
            SubmitGuessButton.FlatAppearance.BorderColor = Color.White;
            SubmitGuessButton.FlatStyle = FlatStyle.Flat;
            SubmitGuessButton.Font = new Font("Segoe UI", 24F);
            SubmitGuessButton.ForeColor = Color.LightGray;
            SubmitGuessButton.ImageAlign = ContentAlignment.TopCenter;
            SubmitGuessButton.Location = new Point(185, 445);
            SubmitGuessButton.Name = "SubmitGuessButton";
            SubmitGuessButton.Size = new Size(166, 56);
            SubmitGuessButton.TabIndex = 28;
            SubmitGuessButton.Text = "Submit";
            SubmitGuessButton.UseVisualStyleBackColor = true;
            SubmitGuessButton.Click += SubmitGuessButton_Click;
            SubmitGuessButton.KeyDown += SubmitGuessButton_KeyDown;
            // 
            // guessTextBox_2
            // 
            guessTextBox_2.BackColor = Color.FromArgb(46, 51, 73);
            guessTextBox_2.BorderStyle = BorderStyle.FixedSingle;
            guessTextBox_2.Font = new Font("Segoe UI", 60F);
            guessTextBox_2.ForeColor = Color.White;
            guessTextBox_2.Location = new Point(183, 316);
            guessTextBox_2.MaxLength = 1;
            guessTextBox_2.Name = "guessTextBox_2";
            guessTextBox_2.Size = new Size(81, 114);
            guessTextBox_2.TabIndex = 29;
            guessTextBox_2.TextAlign = HorizontalAlignment.Center;
            guessTextBox_2.TextChanged += guessTextBox_2_TextChanged;
            guessTextBox_2.KeyDown += GuessTextBox_KeyDown;
            // 
            // guessTextBox_4
            // 
            guessTextBox_4.BackColor = Color.FromArgb(46, 51, 73);
            guessTextBox_4.BorderStyle = BorderStyle.FixedSingle;
            guessTextBox_4.Font = new Font("Segoe UI", 60F);
            guessTextBox_4.ForeColor = Color.White;
            guessTextBox_4.Location = new Point(357, 316);
            guessTextBox_4.MaxLength = 1;
            guessTextBox_4.Name = "guessTextBox_4";
            guessTextBox_4.Size = new Size(81, 114);
            guessTextBox_4.TabIndex = 30;
            guessTextBox_4.TextAlign = HorizontalAlignment.Center;
            guessTextBox_4.TextChanged += guessTextBox_4_TextChanged;
            guessTextBox_4.KeyDown += GuessTextBox_KeyDown;
            // 
            // guessTextBox_3
            // 
            guessTextBox_3.BackColor = Color.FromArgb(46, 51, 73);
            guessTextBox_3.BorderStyle = BorderStyle.FixedSingle;
            guessTextBox_3.Font = new Font("Segoe UI", 60F);
            guessTextBox_3.ForeColor = Color.White;
            guessTextBox_3.Location = new Point(270, 316);
            guessTextBox_3.MaxLength = 1;
            guessTextBox_3.Name = "guessTextBox_3";
            guessTextBox_3.Size = new Size(81, 114);
            guessTextBox_3.TabIndex = 31;
            guessTextBox_3.TextAlign = HorizontalAlignment.Center;
            guessTextBox_3.TextChanged += guessTextBox_3_TextChanged;
            guessTextBox_3.KeyDown += GuessTextBox_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 26F);
            label3.Location = new Point(165, 245);
            label3.Name = "label3";
            label3.Size = new Size(202, 47);
            label3.TabIndex = 32;
            label3.Text = "Enter Guess";
            // 
            // CodeMakerTimer
            // 
            CodeMakerTimer.Interval = 1000;
            CodeMakerTimer.Tick += CodeMakerTimer_Tick;
            // 
            // SubmitGameButton
            // 
            SubmitGameButton.FlatAppearance.BorderColor = Color.White;
            SubmitGameButton.FlatStyle = FlatStyle.Flat;
            SubmitGameButton.Font = new Font("Segoe UI", 18F);
            SubmitGameButton.ForeColor = Color.LightGray;
            SubmitGameButton.Location = new Point(818, 626);
            SubmitGameButton.Name = "SubmitGameButton";
            SubmitGameButton.Size = new Size(232, 60);
            SubmitGameButton.TabIndex = 28;
            SubmitGameButton.Text = "Submit Game";
            SubmitGameButton.UseVisualStyleBackColor = true;
            SubmitGameButton.Visible = false;
            SubmitGameButton.Click += SubmitGameButton_Click;
            // 
            // winLabel
            // 
            winLabel.AutoSize = true;
            winLabel.BorderStyle = BorderStyle.FixedSingle;
            winLabel.Dock = DockStyle.Left;
            winLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            winLabel.Location = new Point(0, 0);
            winLabel.Name = "winLabel";
            winLabel.Padding = new Padding(0, 5, 0, 6);
            winLabel.Size = new Size(116, 60);
            winLabel.TabIndex = 0;
            winLabel.Text = "Score:";
            winLabel.Visible = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(ScoreTextBox);
            panel2.Controls.Add(winLabel);
            panel2.Location = new Point(555, 626);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 60);
            panel2.TabIndex = 33;
            // 
            // ScoreTextBox
            // 
            ScoreTextBox.BackColor = Color.FromArgb(46, 51, 73);
            ScoreTextBox.BorderStyle = BorderStyle.FixedSingle;
            ScoreTextBox.Font = new Font("Segoe UI", 29.5F);
            ScoreTextBox.ForeColor = Color.White;
            ScoreTextBox.Location = new Point(122, 0);
            ScoreTextBox.MaxLength = 3;
            ScoreTextBox.Name = "ScoreTextBox";
            ScoreTextBox.Size = new Size(90, 60);
            ScoreTextBox.TabIndex = 46;
            ScoreTextBox.TextAlign = HorizontalAlignment.Center;
            ScoreTextBox.Visible = false;
            ScoreTextBox.TextChanged += ScoreTextBox_TextChanged;
            // 
            // CodeMakerForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1100, 700);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panel2);
            Controls.Add(SubmitGameButton);
            Controls.Add(label3);
            Controls.Add(guessTextBox_3);
            Controls.Add(guessTextBox_4);
            Controls.Add(guessTextBox_2);
            Controls.Add(SubmitGuessButton);
            Controls.Add(NewGameButton);
            Controls.Add(guessTextBox_1);
            Controls.Add(dataGridView1);
            Controls.Add(RevealButton);
            Controls.Add(SecretLabel_4);
            Controls.Add(SecretLabel_3);
            Controls.Add(SecretLabel_2);
            Controls.Add(SecretLabel_1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(ExitPanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CodeMakerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeMakerForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ExitPanel.ResumeLayout(false);
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RevealButton;
        private Label SecretLabel_4;
        private Label SecretLabel_3;
        private Label SecretLabel_2;
        private Label SecretLabel_1;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label GroupLabel;
        private Panel ExitPanel;
        private Button ExitButton;
        private DataGridView dataGridView1;
        private TextBox guessTextBox_1;
        private Button NewGameButton;
        private Button SubmitGuessButton;
        private Panel NamePanel;
        private Panel panel3;
        private Button TimerButton;
        private TextBox guessTextBox_2;
        private TextBox guessTextBox_4;
        private TextBox guessTextBox_3;
        private Label label3;
        private System.Windows.Forms.Timer CodeMakerTimer;
        private Label TimerLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem submitToolStripMenuItem;
        private ToolStripMenuItem revealToolStripMenuItem;
        private ToolStripMenuItem newgameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem pauseToolStripMenuItem1;
        private ToolStripMenuItem submitToolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem1;
        private ToolStripMenuItem revealToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Button SubmitGameButton;
        private Label winLabel;
        private Panel panel2;
        private TextBox ScoreTextBox;
        private DataGridViewTextBoxColumn GuessNumber;
        private DataGridViewTextBoxColumn Guess;
        private DataGridViewTextBoxColumn Hint;
    }
}