namespace AB_game
{
    partial class GameHistoryForm
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
            ExitPanel = new Panel();
            NamePanel = new Panel();
            GroupLabel = new Label();
            ExitButton = new Button();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pauseToolStripMenuItem1 = new ToolStripMenuItem();
            submitToolStripMenuItem1 = new ToolStripMenuItem();
            newGameToolStripMenuItem1 = new ToolStripMenuItem();
            revealToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
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
            ExitPanel.Dock = DockStyle.Top;
            ExitPanel.ForeColor = Color.Transparent;
            ExitPanel.Location = new Point(0, 0);
            ExitPanel.Name = "ExitPanel";
            ExitPanel.Size = new Size(1100, 40);
            ExitPanel.TabIndex = 17;
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
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 42);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(96, 22);
            exitToolStripMenuItem.Text = "Exit ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 38F, FontStyle.Underline);
            label1.ForeColor = Color.White;
            label1.Location = new Point(333, 43);
            label1.Name = "label1";
            label1.Size = new Size(388, 68);
            label1.TabIndex = 1;
            label1.Text = "Game Summary";
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
            // 
            // submitToolStripMenuItem1
            // 
            submitToolStripMenuItem1.Name = "submitToolStripMenuItem1";
            submitToolStripMenuItem1.Size = new Size(142, 22);
            submitToolStripMenuItem1.Text = "Submit";
            // 
            // newGameToolStripMenuItem1
            // 
            newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            newGameToolStripMenuItem1.Size = new Size(142, 22);
            newGameToolStripMenuItem1.Text = "New Game";
            // 
            // revealToolStripMenuItem1
            // 
            revealToolStripMenuItem1.Name = "revealToolStripMenuItem1";
            revealToolStripMenuItem1.Size = new Size(142, 22);
            revealToolStripMenuItem1.Text = "Reveal secret";
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(142, 22);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(46, 51, 73);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 51, 73);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(70, 77, 111);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1076, 553);
            dataGridView1.TabIndex = 18;
            // 
            // GameHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1100, 700);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(ExitPanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GameHistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GameHistoryForm";
            Load += GameHistoryForm_Load;
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
        private Panel NamePanel;
        private Label GroupLabel;
        private Button ExitButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem pauseToolStripMenuItem1;
        private ToolStripMenuItem submitToolStripMenuItem1;
        private ToolStripMenuItem newGameToolStripMenuItem1;
        private ToolStripMenuItem revealToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private DataGridView dataGridView1;
    }
}