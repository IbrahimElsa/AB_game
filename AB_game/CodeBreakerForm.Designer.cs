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
            panel1 = new Panel();
            newGameBtn = new Button();
            hintTextBox_1 = new TextBox();
            hintTextBox_2 = new TextBox();
            SubmitHintButton = new Button();
            label_hint = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            GuessLabel_1 = new Label();
            GuessLabel_2 = new Label();
            GuessLabel_3 = new Label();
            GuessLabel_4 = new Label();
            ExitPanel = new Panel();
            NamePanel = new Panel();
            GroupLabel = new Label();
            ExitButton = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            pauseToolStripMenuItem = new ToolStripMenuItem();
            submitToolStripMenuItem = new ToolStripMenuItem();
            revealToolStripMenuItem = new ToolStripMenuItem();
            newgameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ExitPanel.SuspendLayout();
            NamePanel.SuspendLayout();
            menuStrip1.SuspendLayout();
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
            panel1.Controls.Add(newGameBtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 67);
            panel1.TabIndex = 8;
            // 
            // newGameBtn
            // 
            newGameBtn.FlatAppearance.BorderColor = Color.White;
            newGameBtn.FlatStyle = FlatStyle.Flat;
            newGameBtn.Font = new Font("Segoe UI", 24F);
            newGameBtn.ForeColor = Color.LightGray;
            newGameBtn.ImageAlign = ContentAlignment.TopCenter;
            newGameBtn.Location = new Point(869, 8);
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
            hintTextBox_1.Location = new Point(195, 185);
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
            hintTextBox_2.Location = new Point(289, 185);
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
            SubmitHintButton.Location = new Point(195, 314);
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
            label_hint.Location = new Point(195, 135);
            label_hint.Name = "label_hint";
            label_hint.Size = new Size(175, 47);
            label_hint.TabIndex = 33;
            label_hint.Text = "Enter Hint";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
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
            dataGridView1.Location = new Point(559, 135);
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
            dataGridView1.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "#";
            dataGridViewTextBoxColumn1.MinimumWidth = 75;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 191.803284F;
            dataGridViewTextBoxColumn2.HeaderText = "Guess";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.FillWeight = 8.196716F;
            dataGridViewTextBoxColumn3.HeaderText = "Hint";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F);
            label2.Location = new Point(179, 415);
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
            GuessLabel_1.Location = new Point(96, 492);
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
            GuessLabel_2.Location = new Point(189, 492);
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
            GuessLabel_3.Location = new Point(282, 492);
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
            GuessLabel_4.Location = new Point(375, 492);
            GuessLabel_4.Name = "GuessLabel_4";
            GuessLabel_4.Padding = new Padding(8, 0, 0, 14);
            GuessLabel_4.Size = new Size(87, 122);
            GuessLabel_4.TabIndex = 39;
            GuessLabel_4.Text = "-";
            GuessLabel_4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExitPanel
            // 
            ExitPanel.BackColor = Color.FromArgb(72, 77, 99);
            ExitPanel.Controls.Add(NamePanel);
            ExitPanel.Controls.Add(ExitButton);
            ExitPanel.Controls.Add(menuStrip1);
            ExitPanel.Dock = DockStyle.Top;
            ExitPanel.ForeColor = Color.Transparent;
            ExitPanel.Location = new Point(0, 0);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Size = new Size(1100, 40);
            ExitPanel.TabIndex = 40;
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
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.GripMargin = new Padding(5);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Margin = new Padding(9);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(172, 42);
            menuStrip1.TabIndex = 31;
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
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(125, 42);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(125, 42);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(125, 42);
            toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // CodeBreakerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1100, 700);
            Controls.Add(ExitPanel);
            Controls.Add(GuessLabel_4);
            Controls.Add(GuessLabel_3);
            Controls.Add(GuessLabel_2);
            Controls.Add(GuessLabel_1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label_hint);
            Controls.Add(SubmitHintButton);
            Controls.Add(hintTextBox_2);
            Controls.Add(hintTextBox_1);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CodeBreakerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CodeBreakerForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ExitPanel.ResumeLayout(false);
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
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
        private ToolStripMenuItem pauseToolStripMenuItem;
        private ToolStripMenuItem submitToolStripMenuItem;
        private ToolStripMenuItem revealToolStripMenuItem;
        private ToolStripMenuItem newgameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}