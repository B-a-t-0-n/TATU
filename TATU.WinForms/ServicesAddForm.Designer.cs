namespace TATU.WinForms
{
    partial class ServicesAddForm
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
            HeaderPanel = new Panel();
            RollUpButton = new Button();
            CloseButton = new Button();
            panel1 = new Panel();
            IdTextBox = new TextBox();
            DeleteButton = new Button();
            Add = new Button();
            DescriptionTextBox = new RichTextBox();
            TitleTextBox = new TextBox();
            AddButton = new Button();
            HeaderPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.FromArgb(8, 30, 43);
            HeaderPanel.Controls.Add(RollUpButton);
            HeaderPanel.Controls.Add(CloseButton);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(657, 40);
            HeaderPanel.TabIndex = 10;
            HeaderPanel.MouseDown += HeaderPanel_MouseDown;
            // 
            // RollUpButton
            // 
            RollUpButton.Dock = DockStyle.Right;
            RollUpButton.FlatAppearance.BorderSize = 0;
            RollUpButton.FlatStyle = FlatStyle.Flat;
            RollUpButton.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold);
            RollUpButton.ForeColor = Color.White;
            RollUpButton.Location = new Point(557, 0);
            RollUpButton.Name = "RollUpButton";
            RollUpButton.Size = new Size(50, 40);
            RollUpButton.TabIndex = 6;
            RollUpButton.Text = "○";
            RollUpButton.UseVisualStyleBackColor = true;
            RollUpButton.Click += RollUpButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Dock = DockStyle.Right;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold);
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(607, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(50, 40);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "○";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 36, 52);
            panel1.Controls.Add(IdTextBox);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(Add);
            panel1.Controls.Add(DescriptionTextBox);
            panel1.Controls.Add(TitleTextBox);
            panel1.Controls.Add(AddButton);
            panel1.Location = new Point(4, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 506);
            panel1.TabIndex = 14;
            // 
            // IdTextBox
            // 
            IdTextBox.BackColor = Color.White;
            IdTextBox.BorderStyle = BorderStyle.None;
            IdTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            IdTextBox.ForeColor = Color.Black;
            IdTextBox.Location = new Point(69, 38);
            IdTextBox.Multiline = true;
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(520, 38);
            IdTextBox.TabIndex = 23;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(3, 135, 126);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            DeleteButton.ForeColor = Color.FromArgb(9, 36, 52);
            DeleteButton.Location = new Point(389, 407);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(150, 50);
            DeleteButton.TabIndex = 22;
            DeleteButton.Text = "button2";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(3, 135, 126);
            Add.FlatAppearance.BorderSize = 0;
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            Add.ForeColor = Color.FromArgb(9, 36, 52);
            Add.Location = new Point(108, 407);
            Add.Name = "Add";
            Add.Size = new Size(150, 50);
            Add.TabIndex = 18;
            Add.Text = "Добавить";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.BorderStyle = BorderStyle.None;
            DescriptionTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            DescriptionTextBox.ForeColor = Color.Black;
            DescriptionTextBox.Location = new Point(69, 199);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(520, 168);
            DescriptionTextBox.TabIndex = 17;
            DescriptionTextBox.Text = "";
            // 
            // TitleTextBox
            // 
            TitleTextBox.BackColor = Color.White;
            TitleTextBox.BorderStyle = BorderStyle.None;
            TitleTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            TitleTextBox.ForeColor = Color.Black;
            TitleTextBox.Location = new Point(69, 113);
            TitleTextBox.Multiline = true;
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(520, 38);
            TitleTextBox.TabIndex = 16;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(3, 135, 126);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            AddButton.ForeColor = Color.FromArgb(9, 36, 52);
            AddButton.Location = new Point(109, 758);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(150, 50);
            AddButton.TabIndex = 12;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // ServicesAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 135, 126);
            ClientSize = new Size(657, 553);
            Controls.Add(panel1);
            Controls.Add(HeaderPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServicesAddForm";
            Text = "ServicesAddForm";
            Load += ServicesAddForm_Load;
            HeaderPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Button RollUpButton;
        private Button CloseButton;
        private Panel panel1;
        private Button AddButton;
        private TextBox TitleTextBox;
        private RichTextBox DescriptionTextBox;
        private Button Add;
        private Button DeleteButton;
        private TextBox IdTextBox;
    }
}