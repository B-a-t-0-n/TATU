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
            NavigationPanel = new Panel();
            SearchButton = new FontAwesome.Sharp.IconButton();
            PanelUpAdd = new Panel();
            AddButton = new Button();
            UpdateButton = new Button();
            textBox1 = new TextBox();
            NavigationPanel.SuspendLayout();
            PanelUpAdd.SuspendLayout();
            SuspendLayout();
            // 
            // NavigationPanel
            // 
            NavigationPanel.Controls.Add(SearchButton);
            NavigationPanel.Controls.Add(PanelUpAdd);
            NavigationPanel.Controls.Add(textBox1);
            NavigationPanel.Dock = DockStyle.Top;
            NavigationPanel.Location = new Point(0, 0);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(1089, 100);
            NavigationPanel.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.FlatAppearance.BorderSize = 0;
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.ForeColor = Color.White;
            SearchButton.IconChar = FontAwesome.Sharp.IconChar.Search;
            SearchButton.IconColor = Color.White;
            SearchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SearchButton.IconSize = 36;
            SearchButton.Location = new Point(457, 31);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(40, 40);
            SearchButton.TabIndex = 1;
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // PanelUpAdd
            // 
            PanelUpAdd.Controls.Add(AddButton);
            PanelUpAdd.Controls.Add(UpdateButton);
            PanelUpAdd.Dock = DockStyle.Right;
            PanelUpAdd.Location = new Point(789, 0);
            PanelUpAdd.Name = "PanelUpAdd";
            PanelUpAdd.Size = new Size(300, 100);
            PanelUpAdd.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(3, 135, 126);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddButton.ForeColor = Color.FromArgb(9, 36, 52);
            AddButton.Location = new Point(166, 30);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(100, 44);
            AddButton.TabIndex = 3;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            // 
            // UpdateButton
            // 
            UpdateButton.FlatAppearance.BorderSize = 2;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            UpdateButton.ForeColor = Color.FromArgb(3, 135, 126);
            UpdateButton.Location = new Point(38, 30);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(100, 44);
            UpdateButton.TabIndex = 2;
            UpdateButton.Text = "Обновить";
            UpdateButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(9, 36, 52);
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(82, 31);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 40);
            textBox1.TabIndex = 0;
            // 
            // RecordinForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 36, 52);
            ClientSize = new Size(1089, 607);
            Controls.Add(NavigationPanel);
            Name = "RecordinForm";
            Text = "RecordinForm";
            NavigationPanel.ResumeLayout(false);
            NavigationPanel.PerformLayout();
            PanelUpAdd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel NavigationPanel;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton SearchButton;
        private Button UpdateButton;
        private Panel PanelUpAdd;
        private Button AddButton;
    }
}