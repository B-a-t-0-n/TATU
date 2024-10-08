namespace TATU.WinForms
{
    partial class MastersForm
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
            MasterDatagrid = new DataGridView();
            panel2 = new Panel();
            panel1 = new Panel();
            NavigationPanel = new Panel();
            panel5 = new Panel();
            panel15 = new Panel();
            UpdateButton = new Button();
            panel16 = new Panel();
            AddButton = new Button();
            panel17 = new Panel();
            panel12 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel13 = new Panel();
            textBox1 = new TextBox();
            panel14 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)MasterDatagrid).BeginInit();
            NavigationPanel.SuspendLayout();
            panel5.SuspendLayout();
            panel15.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // MasterDatagrid
            // 
            MasterDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MasterDatagrid.BackgroundColor = Color.FromArgb(9, 36, 52);
            MasterDatagrid.BorderStyle = BorderStyle.None;
            MasterDatagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(8, 30, 43);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(8, 30, 43);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MasterDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MasterDatagrid.ColumnHeadersHeight = 70;
            MasterDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            MasterDatagrid.Dock = DockStyle.Fill;
            MasterDatagrid.EnableHeadersVisualStyles = false;
            MasterDatagrid.GridColor = Color.DarkGray;
            MasterDatagrid.Location = new Point(30, 100);
            MasterDatagrid.Margin = new Padding(20);
            MasterDatagrid.Name = "MasterDatagrid";
            MasterDatagrid.RowHeadersVisible = false;
            MasterDatagrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(9, 36, 52);
            dataGridViewCellStyle2.Font = new Font("Trebuchet MS", 12F, FontStyle.Italic);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(3, 135, 126);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            MasterDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            MasterDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MasterDatagrid.Size = new Size(1005, 459);
            MasterDatagrid.TabIndex = 16;
            MasterDatagrid.CellDoubleClick += MasterDatagrid_CellDoubleClick;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1035, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(30, 459);
            panel2.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 459);
            panel1.TabIndex = 14;
            // 
            // NavigationPanel
            // 
            NavigationPanel.Controls.Add(panel5);
            NavigationPanel.Controls.Add(panel4);
            NavigationPanel.Controls.Add(panel3);
            NavigationPanel.Dock = DockStyle.Top;
            NavigationPanel.Location = new Point(0, 0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(1065, 100);
            NavigationPanel.TabIndex = 13;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel15);
            panel5.Controls.Add(panel12);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 27);
            panel5.Name = "panel5";
            panel5.Size = new Size(1065, 41);
            panel5.TabIndex = 7;
            // 
            // panel15
            // 
            panel15.Controls.Add(UpdateButton);
            panel15.Controls.Add(panel16);
            panel15.Controls.Add(AddButton);
            panel15.Controls.Add(panel17);
            panel15.Dock = DockStyle.Right;
            panel15.Location = new Point(803, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(262, 41);
            panel15.TabIndex = 10;
            // 
            // UpdateButton
            // 
            UpdateButton.Dock = DockStyle.Right;
            UpdateButton.FlatAppearance.BorderSize = 2;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            UpdateButton.ForeColor = Color.FromArgb(3, 135, 126);
            UpdateButton.Location = new Point(12, 0);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(100, 41);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "Обновить";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_ClickAsync;
            // 
            // panel16
            // 
            panel16.Dock = DockStyle.Right;
            panel16.Location = new Point(112, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(20, 41);
            panel16.TabIndex = 7;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(3, 135, 126);
            AddButton.Dock = DockStyle.Right;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddButton.ForeColor = Color.FromArgb(9, 36, 52);
            AddButton.Location = new Point(132, 0);
            AddButton.Margin = new Padding(3, 30, 3, 30);
            AddButton.MaximumSize = new Size(100, 44);
            AddButton.MinimumSize = new Size(100, 44);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 44);
            AddButton.TabIndex = 6;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
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
            panel4.Size = new Size(1065, 32);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1065, 27);
            panel3.TabIndex = 4;
            // 
            // MastersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 36, 52);
            ClientSize = new Size(1065, 559);
            Controls.Add(MasterDatagrid);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(NavigationPanel);
            ForeColor = Color.White;
            Name = "MastersForm";
            Text = "MastersForm";
            ((System.ComponentModel.ISupportInitialize)MasterDatagrid).EndInit();
            NavigationPanel.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView MasterDatagrid;
        private Panel panel2;
        private Panel panel1;
        private Panel NavigationPanel;
        private Panel panel5;
        private Panel panel15;
        private Button UpdateButton;
        private Panel panel16;
        private Button AddButton;
        private Panel panel17;
        private Panel panel12;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel13;
        private TextBox textBox1;
        private Panel panel14;
        private Panel panel4;
        private Panel panel3;
    }
}