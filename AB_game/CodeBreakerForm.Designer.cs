﻿namespace AB_game
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            TimerButton = new Button();
            TimerLabel = new Label();
            newGameBtn = new Button();
            hintTextBox_1 = new TextBox();
            hintTextBox_2 = new TextBox();
            SubmitHintButton = new Button();
            label_hint = new Label();
            label2 = new Label();
            GuessLabel_1 = new Label();
            GuessLabel_2 = new Label();
            GuessLabel_3 = new Label();
            GuessLabel_4 = new Label();
            ExitPanel = new Panel();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            pauseStripMenuItem1 = new ToolStripMenuItem();
            submitHintToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            NamePanel = new Panel();
            GroupLabel = new Label();
            ExitButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pauseToolStripMenuItem = new ToolStripMenuItem();
            submitHintToolStripMenuItem1 = new ToolStripMenuItem();
            newGameToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            CodeBreakerTimer = new System.Windows.Forms.Timer(components);
            winLabel = new Label();
            panel2 = new Panel();
            ScoreTextBox = new TextBox();
            SubmitGameButton = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            dataGridView1 = new DataGridView();
            GuessNumber = new DataGridViewTextBoxColumn();
            Guess = new DataGridViewTextBoxColumn();
            Hint = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ExitPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            NamePanel.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panel2.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(TimerButton);
            panel1.Controls.Add(TimerLabel);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 67);
            panel1.TabIndex = 8;
            // 
            // TimerButton
            // 
            TimerButton.Dock = DockStyle.Right;
            TimerButton.FlatAppearance.BorderColor = Color.White;
            TimerButton.FlatStyle = FlatStyle.Flat;
            TimerButton.Font = new Font("Segoe UI", 24F);
            TimerButton.ForeColor = Color.LightGray;
            TimerButton.ImageAlign = ContentAlignment.TopCenter;
            TimerButton.Location = new Point(872, 0);
            TimerButton.Name = "TimerButton";
            TimerButton.Size = new Size(166, 67);
            TimerButton.TabIndex = 42;
            TimerButton.Text = "Pause";
            TimerButton.UseVisualStyleBackColor = true;
            TimerButton.Visible = false;
            TimerButton.Click += TimerButton_Click;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Font = new Font("Segoe UI", 26F);
            TimerLabel.ImageAlign = ContentAlignment.BottomCenter;
            TimerLabel.Location = new Point(498, 3);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Padding = new Padding(9);
            TimerLabel.Size = new Size(226, 65);
            TimerLabel.TabIndex = 41;
            TimerLabel.Text = "Timer: 00:00";
            // 
            // newGameBtn
            // 
            newGameBtn.FlatAppearance.BorderColor = Color.White;
            newGameBtn.FlatStyle = FlatStyle.Flat;
            newGameBtn.Font = new Font("Segoe UI", 24F);
            newGameBtn.ForeColor = Color.LightGray;
            newGameBtn.ImageAlign = ContentAlignment.TopCenter;
            newGameBtn.Location = new Point(183, 553);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(204, 56);
            newGameBtn.TabIndex = 41;
            newGameBtn.Text = "New Game";
            newGameBtn.UseVisualStyleBackColor = true;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // hintTextBox_1
            // 
            hintTextBox_1.BackColor = Color.FromArgb(46, 51, 73);
            hintTextBox_1.BorderStyle = BorderStyle.FixedSingle;
            hintTextBox_1.Font = new Font("Segoe UI", 60F);
            hintTextBox_1.ForeColor = Color.White;
            hintTextBox_1.Location = new Point(195, 166);
            hintTextBox_1.MaxLength = 1;
            hintTextBox_1.Name = "hintTextBox_1";
            hintTextBox_1.Size = new Size(81, 114);
            hintTextBox_1.TabIndex = 27;
            hintTextBox_1.TextAlign = HorizontalAlignment.Center;
            hintTextBox_1.TextChanged += hintTextBox_1_TextChanged;
            hintTextBox_1.KeyDown += hintTextBox_KeyDown;
            // 
            // hintTextBox_2
            // 
            hintTextBox_2.BackColor = Color.FromArgb(46, 51, 73);
            hintTextBox_2.BorderStyle = BorderStyle.FixedSingle;
            hintTextBox_2.Font = new Font("Segoe UI", 60F);
            hintTextBox_2.ForeColor = Color.White;
            hintTextBox_2.Location = new Point(289, 166);
            hintTextBox_2.MaxLength = 1;
            hintTextBox_2.Name = "hintTextBox_2";
            hintTextBox_2.Size = new Size(81, 114);
            hintTextBox_2.TabIndex = 28;
            hintTextBox_2.TextAlign = HorizontalAlignment.Center;
            hintTextBox_2.TextChanged += hintTextBox_2_TextChanged;
            hintTextBox_2.KeyDown += hintTextBox_KeyDown;
            // 
            // SubmitHintButton
            // 
            SubmitHintButton.FlatAppearance.BorderColor = Color.White;
            SubmitHintButton.FlatStyle = FlatStyle.Flat;
            SubmitHintButton.Font = new Font("Segoe UI", 24F);
            SubmitHintButton.ForeColor = Color.LightGray;
            SubmitHintButton.ImageAlign = ContentAlignment.TopCenter;
            SubmitHintButton.Location = new Point(195, 295);
            SubmitHintButton.Name = "SubmitHintButton";
            SubmitHintButton.Size = new Size(175, 56);
            SubmitHintButton.TabIndex = 29;
            SubmitHintButton.Text = "Submit";
            SubmitHintButton.UseVisualStyleBackColor = true;
            SubmitHintButton.Click += SubmitHintButton_Click;
            SubmitHintButton.KeyDown += SubmitHintButton_KeyDown;
            // 
            // label_hint
            // 
            label_hint.AutoSize = true;
            label_hint.Font = new Font("Segoe UI", 26F);
            label_hint.Location = new Point(195, 116);
            label_hint.Name = "label_hint";
            label_hint.Size = new Size(175, 47);
            label_hint.TabIndex = 33;
            label_hint.Text = "Enter Hint";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F);
            label2.Location = new Point(185, 358);
            label2.Name = "label2";
            label2.Size = new Size(191, 47);
            label2.TabIndex = 36;
            label2.Text = "New Guess";
            // 
            // GuessLabel_1
            // 
            GuessLabel_1.AutoSize = true;
            GuessLabel_1.BorderStyle = BorderStyle.FixedSingle;
            GuessLabel_1.Font = new Font("Segoe UI", 60F);
            GuessLabel_1.Location = new Point(103, 414);
            GuessLabel_1.Name = "GuessLabel_1";
            GuessLabel_1.Padding = new Padding(8, 0, 0, 14);
            GuessLabel_1.Size = new Size(87, 122);
            GuessLabel_1.TabIndex = 0;
            GuessLabel_1.Text = "-";
            GuessLabel_1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GuessLabel_2
            // 
            GuessLabel_2.AutoSize = true;
            GuessLabel_2.BorderStyle = BorderStyle.FixedSingle;
            GuessLabel_2.Font = new Font("Segoe UI", 60F);
            GuessLabel_2.Location = new Point(196, 414);
            GuessLabel_2.Name = "GuessLabel_2";
            GuessLabel_2.Padding = new Padding(8, 0, 0, 14);
            GuessLabel_2.Size = new Size(87, 122);
            GuessLabel_2.TabIndex = 37;
            GuessLabel_2.Text = "-";
            GuessLabel_2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GuessLabel_3
            // 
            GuessLabel_3.AutoSize = true;
            GuessLabel_3.BorderStyle = BorderStyle.FixedSingle;
            GuessLabel_3.Font = new Font("Segoe UI", 60F);
            GuessLabel_3.Location = new Point(289, 414);
            GuessLabel_3.Name = "GuessLabel_3";
            GuessLabel_3.Padding = new Padding(8, 0, 0, 14);
            GuessLabel_3.Size = new Size(87, 122);
            GuessLabel_3.TabIndex = 38;
            GuessLabel_3.Text = "-";
            GuessLabel_3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GuessLabel_4
            // 
            GuessLabel_4.AutoSize = true;
            GuessLabel_4.BorderStyle = BorderStyle.FixedSingle;
            GuessLabel_4.Font = new Font("Segoe UI", 60F);
            GuessLabel_4.Location = new Point(382, 414);
            GuessLabel_4.Name = "GuessLabel_4";
            GuessLabel_4.Padding = new Padding(8, 0, 0, 14);
            GuessLabel_4.Size = new Size(87, 122);
            GuessLabel_4.TabIndex = 39;
            GuessLabel_4.Text = "-";
            GuessLabel_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitPanel
            // 
            ExitPanel.BackColor = Color.FromArgb(36, 42, 59);
            ExitPanel.Controls.Add(menuStrip1);
            ExitPanel.Controls.Add(NamePanel);
            ExitPanel.Controls.Add(ExitButton);
            ExitPanel.Dock = DockStyle.Top;
            ExitPanel.ForeColor = Color.Transparent;
            ExitPanel.Location = new Point(0, 0);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Size = new Size(1100, 40);
            ExitPanel.TabIndex = 40;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripMargin = new Padding(5);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Margin = new Padding(9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(172, 42);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pauseStripMenuItem1, submitHintToolStripMenuItem, newGameToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 42);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // pauseStripMenuItem1
            // 
            pauseStripMenuItem1.Name = "pauseStripMenuItem1";
            pauseStripMenuItem1.Size = new Size(138, 22);
            pauseStripMenuItem1.Text = "Pause";
            pauseStripMenuItem1.Click += pauseStripMenuItem1_Click;
            // 
            // submitHintToolStripMenuItem
            // 
            submitHintToolStripMenuItem.Name = "submitHintToolStripMenuItem";
            submitHintToolStripMenuItem.Size = new Size(138, 22);
            submitHintToolStripMenuItem.Text = "Submit Hint";
            submitHintToolStripMenuItem.Click += submitToolStripMenuItem_Click;
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(138, 22);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(138, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { pauseToolStripMenuItem, submitHintToolStripMenuItem1, newGameToolStripMenuItem1, exitToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(139, 92);
            // 
            // pauseToolStripMenuItem
            // 
            pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            pauseToolStripMenuItem.Size = new Size(138, 22);
            pauseToolStripMenuItem.Text = "Pause";
            pauseToolStripMenuItem.Click += pauseToolStripMenuItem_Click;
            // 
            // submitHintToolStripMenuItem1
            // 
            submitHintToolStripMenuItem1.Name = "submitHintToolStripMenuItem1";
            submitHintToolStripMenuItem1.Size = new Size(138, 22);
            submitHintToolStripMenuItem1.Text = "Submit Hint";
            submitHintToolStripMenuItem1.Click += submitHintToolStripMenuItem1_Click;
            // 
            // newGameToolStripMenuItem1
            // 
            newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            newGameToolStripMenuItem1.Size = new Size(138, 22);
            newGameToolStripMenuItem1.Text = "New Game";
            newGameToolStripMenuItem1.Click += newGameToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(138, 22);
            exitToolStripMenuItem1.Text = "Exit";
            exitToolStripMenuItem1.Click += exitToolStripMenuItem1_Click;
            // 
            // CodeBreakerTimer
            // 
            CodeBreakerTimer.Interval = 1000;
            CodeBreakerTimer.Tick += CodeBreakerTimer_Tick;
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
            panel2.Location = new Point(538, 626);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 60);
            panel2.TabIndex = 42;
            // 
            // ScoreTextBox
            // 
            ScoreTextBox.BackColor = Color.FromArgb(46, 51, 73);
            ScoreTextBox.BorderStyle = BorderStyle.FixedSingle;
            ScoreTextBox.Font = new Font("Segoe UI", 29.5F);
            ScoreTextBox.ForeColor = Color.White;
            ScoreTextBox.Location = new Point(111, 0);
            ScoreTextBox.MaxLength = 3;
            ScoreTextBox.Name = "ScoreTextBox";
            ScoreTextBox.Size = new Size(65, 60);
            ScoreTextBox.TabIndex = 45;
            ScoreTextBox.TextAlign = HorizontalAlignment.Center;
            ScoreTextBox.Visible = false;
            ScoreTextBox.TextChanged += ScoreTextBox_TextChanged;
            // 
            // SubmitGameButton
            // 
            SubmitGameButton.FlatAppearance.BorderColor = Color.White;
            SubmitGameButton.FlatStyle = FlatStyle.Flat;
            SubmitGameButton.Font = new Font("Segoe UI", 18F);
            SubmitGameButton.ForeColor = Color.LightGray;
            SubmitGameButton.ImageAlign = ContentAlignment.TopCenter;
            SubmitGameButton.Location = new Point(818, 626);
            SubmitGameButton.Name = "SubmitGameButton";
            SubmitGameButton.Size = new Size(232, 60);
            SubmitGameButton.TabIndex = 43;
            SubmitGameButton.Text = "Submit Game";
            SubmitGameButton.UseVisualStyleBackColor = true;
            SubmitGameButton.Visible = false;
            SubmitGameButton.Click += SubmitGameButton_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
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
            dataGridView1.Location = new Point(555, 129);
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
            dataGridView1.TabIndex = 44;
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
            // CodeBreakerForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1100, 700);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(dataGridView1);
            Controls.Add(SubmitGameButton);
            Controls.Add(panel2);
            Controls.Add(newGameBtn);
            Controls.Add(ExitPanel);
            Controls.Add(GuessLabel_4);
            Controls.Add(GuessLabel_3);
            Controls.Add(GuessLabel_2);
            Controls.Add(GuessLabel_1);
            Controls.Add(label2);
            Controls.Add(label_hint);
            Controls.Add(SubmitHintButton);
            Controls.Add(hintTextBox_2);
            Controls.Add(hintTextBox_1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "CodeBreakerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeBreakerForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ExitPanel.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox hintTextBox_1;
        private TextBox hintTextBox_2;
        private Button SubmitHintButton;
        private Label label_hint;
        private Label label2;
        private Label GuessLabel_1;
        private Label GuessLabel_2;
        private Label GuessLabel_3;
        private Label GuessLabel_4;
        private Panel ExitPanel;
        private Panel NamePanel;
        private Label GroupLabel;
        private Button ExitButton;
        private Button newGameBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem submitHintToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem submitHintToolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private Label TimerLabel;
        private System.Windows.Forms.Timer CodeBreakerTimer;
        private Button TimerButton;
        private ToolStripMenuItem pauseStripMenuItem1;
        private ToolStripMenuItem pauseToolStripMenuItem;
        private Label winLabel;
        private Panel panel2;
        private Button SubmitGameButton;
        private TextBox ScoreTextBox;
        private ContextMenuStrip contextMenuStrip2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn GuessNumber;
        private DataGridViewTextBoxColumn Guess;
        private DataGridViewTextBoxColumn Hint;
    }
}