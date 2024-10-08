namespace TATU.WinForms
{
    partial class RecordinForm
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
            NavigationPanel = new Panel();
            panel5 = new Panel();
            panel15 = new Panel();
            button3 = new Button();
            panel16 = new Panel();
            button4 = new Button();
            panel17 = new Panel();
            panel12 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel13 = new Panel();
            textBox1 = new TextBox();
            panel14 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            NavigationPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel15.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NavigationPanel
            // 
            NavigationPanel.Controls.Add(panel5);
            NavigationPanel.Controls.Add(panel4);
            NavigationPanel.Controls.Add(panel3);
            NavigationPanel.Dock = DockStyle.Top;
            NavigationPanel.Location = new Point(0, 0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(1089, 100);
            NavigationPanel.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel15);
            panel5.Controls.Add(panel12);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(1089, 41);
            panel5.TabIndex = 7;
            panel5.Paint += panel5_Paint;
            // 
            // panel15
            // 
            panel15.Controls.Add(button3);
            panel15.Controls.Add(panel16);
            panel15.Controls.Add(button4);
            panel15.Controls.Add(panel17);
            panel15.Dock = DockStyle.Right;
            panel15.Location = new Point(827, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(262, 41);
            panel15.TabIndex = 10;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.FromArgb(3, 135, 126);
            button3.Location = new Point(12, 0);
            button3.Name = "button3";
            button3.Size = new Size(100, 41);
            button3.TabIndex = 8;
            button3.Text = "Обновить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel16
            // 
            panel16.Dock = DockStyle.Right;
            panel16.Location = new Point(112, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(20, 41);
            panel16.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(3, 135, 126);
            button4.Dock = DockStyle.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.ForeColor = Color.FromArgb(9, 36, 52);
            button4.Location = new Point(132, 0);
            button4.Margin = new Padding(3, 30, 3, 30);
            button4.MaximumSize = new Size(100, 44);
            button4.MinimumSize = new Size(100, 44);
            button4.Name = "button4";
            button4.Size = new Size(100, 44);
            button4.TabIndex = 6;
            button4.Text = "Добавить";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel17
            // 
            panel17.Dock = DockStyle.Right;
            panel17.Location = new Point(232, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(30, 41);
            panel17.TabIndex = 5;
            // 
            // panel12
            // 
            panel12.Controls.Add(iconButton2);
            panel12.Controls.Add(panel13);
            panel12.Controls.Add(textBox1);
            panel12.Controls.Add(panel14);
            panel12.Dock = DockStyle.Left;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(544, 41);
            panel12.TabIndex = 9;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Left;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 36;
            iconButton2.Location = new Point(401, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(41, 41);
            iconButton2.TabIndex = 15;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Dock = DockStyle.Left;
            panel13.Location = new Point(390, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(11, 41);
            panel13.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(9, 36, 52);
            textBox1.Dock = DockStyle.Left;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(30, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 41);
            textBox1.TabIndex = 13;
            // 
            // panel14
            // 
            panel14.Dock = DockStyle.Left;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(30, 41);
            panel14.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 68);
            panel4.Name = "panel4";
            panel4.Size = new Size(1089, 32);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1089, 27);
            panel3.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 507);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1059, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(30, 507);
            panel2.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(9, 36, 52);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(8, 30, 43);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(8, 30, 43);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 70;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.DarkGray;
            dataGridView1.Location = new Point(30, 100);
            dataGridView1.Margin = new Padding(20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(9, 36, 52);
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 12F, FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(3, 135, 126);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1029, 507);
            dataGridView1.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Column3";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Column4";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Column5";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Column6";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // RecordinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 36, 52);
            ClientSize = new Size(1089, 607);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(NavigationPanel);
            Name = "RecordinForm";
            Text = "RecordinForm";
            NavigationPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel NavigationPanel;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel15;
        private Button button3;
        private Panel panel16;
        private Button button4;
        private Panel panel17;
        private Panel panel12;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel13;
        private TextBox textBox1;
        private Panel panel14;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}