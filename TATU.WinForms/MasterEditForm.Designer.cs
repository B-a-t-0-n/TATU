namespace TATU.WinForms
{
    partial class MasterEditForm
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
            NameTextbox = new TextBox();
            AddButton = new Button();
            panel1 = new Panel();
            IdTextBox = new TextBox();
            PhotosWorksLinkTextBox = new TextBox();
            DeleteButton = new Button();
            PhotoAvatarLinkTextBox = new TextBox();
            IsDismissedTextbox = new TextBox();
            WorkExperienceTextBox = new TextBox();
            PatronymicTextBox = new TextBox();
            DescriptionRichTextBox = new RichTextBox();
            SurnameTextbox = new TextBox();
            UpdateButton = new Button();
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
            HeaderPanel.Size = new Size(650, 40);
            HeaderPanel.TabIndex = 9;
            HeaderPanel.MouseDown += HeaderPanel_MouseDown_1;
            // 
            // RollUpButton
            // 
            RollUpButton.Dock = DockStyle.Right;
            RollUpButton.FlatAppearance.BorderSize = 0;
            RollUpButton.FlatStyle = FlatStyle.Flat;
            RollUpButton.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold);
            RollUpButton.ForeColor = Color.White;
            RollUpButton.Location = new Point(550, 0);
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
            CloseButton.Location = new Point(600, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(50, 40);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "○";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // NameTextbox
            // 
            NameTextbox.BackColor = Color.White;
            NameTextbox.BorderStyle = BorderStyle.None;
            NameTextbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameTextbox.ForeColor = Color.Black;
            NameTextbox.Location = new Point(61, 69);
            NameTextbox.Multiline = true;
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(520, 38);
            NameTextbox.TabIndex = 10;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.FromArgb(3, 135, 126);
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            AddButton.ForeColor = Color.FromArgb(9, 36, 52);
            AddButton.Location = new Point(61, 758);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(150, 50);
            AddButton.TabIndex = 12;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_ClickAsync;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(9, 36, 52);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(IdTextBox);
            panel1.Controls.Add(PhotosWorksLinkTextBox);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(PhotoAvatarLinkTextBox);
            panel1.Controls.Add(IsDismissedTextbox);
            panel1.Controls.Add(WorkExperienceTextBox);
            panel1.Controls.Add(PatronymicTextBox);
            panel1.Controls.Add(DescriptionRichTextBox);
            panel1.Controls.Add(SurnameTextbox);
            panel1.Controls.Add(NameTextbox);
            panel1.Controls.Add(AddButton);
            panel1.Location = new Point(3, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(644, 828);
            panel1.TabIndex = 13;
            // 
            // IdTextBox
            // 
            IdTextBox.BackColor = Color.White;
            IdTextBox.BorderStyle = BorderStyle.None;
            IdTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            IdTextBox.ForeColor = Color.Black;
            IdTextBox.Location = new Point(61, 16);
            IdTextBox.Multiline = true;
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(520, 38);
            IdTextBox.TabIndex = 23;
            // 
            // PhotosWorksLinkTextBox
            // 
            PhotosWorksLinkTextBox.BackColor = Color.White;
            PhotosWorksLinkTextBox.BorderStyle = BorderStyle.None;
            PhotosWorksLinkTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            PhotosWorksLinkTextBox.ForeColor = Color.Black;
            PhotosWorksLinkTextBox.Location = new Point(61, 674);
            PhotosWorksLinkTextBox.Multiline = true;
            PhotosWorksLinkTextBox.Name = "PhotosWorksLinkTextBox";
            PhotosWorksLinkTextBox.Size = new Size(520, 38);
            PhotosWorksLinkTextBox.TabIndex = 22;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.FromArgb(3, 135, 126);
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            DeleteButton.ForeColor = Color.FromArgb(9, 36, 52);
            DeleteButton.Location = new Point(447, 758);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(150, 50);
            DeleteButton.TabIndex = 21;
            DeleteButton.Text = "button2";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // PhotoAvatarLinkTextBox
            // 
            PhotoAvatarLinkTextBox.BackColor = Color.White;
            PhotoAvatarLinkTextBox.BorderStyle = BorderStyle.None;
            PhotoAvatarLinkTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            PhotoAvatarLinkTextBox.ForeColor = Color.Black;
            PhotoAvatarLinkTextBox.Location = new Point(61, 591);
            PhotoAvatarLinkTextBox.Multiline = true;
            PhotoAvatarLinkTextBox.Name = "PhotoAvatarLinkTextBox";
            PhotoAvatarLinkTextBox.Size = new Size(520, 38);
            PhotoAvatarLinkTextBox.TabIndex = 20;
            // 
            // IsDismissedTextbox
            // 
            IsDismissedTextbox.BackColor = Color.White;
            IsDismissedTextbox.BorderStyle = BorderStyle.None;
            IsDismissedTextbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            IsDismissedTextbox.ForeColor = Color.Black;
            IsDismissedTextbox.Location = new Point(61, 512);
            IsDismissedTextbox.Multiline = true;
            IsDismissedTextbox.Name = "IsDismissedTextbox";
            IsDismissedTextbox.Size = new Size(520, 38);
            IsDismissedTextbox.TabIndex = 19;
            // 
            // WorkExperienceTextBox
            // 
            WorkExperienceTextBox.BackColor = Color.White;
            WorkExperienceTextBox.BorderStyle = BorderStyle.None;
            WorkExperienceTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            WorkExperienceTextBox.ForeColor = Color.Black;
            WorkExperienceTextBox.Location = new Point(61, 309);
            WorkExperienceTextBox.Multiline = true;
            WorkExperienceTextBox.Name = "WorkExperienceTextBox";
            WorkExperienceTextBox.Size = new Size(520, 38);
            WorkExperienceTextBox.TabIndex = 18;
            // 
            // PatronymicTextBox
            // 
            PatronymicTextBox.BackColor = Color.White;
            PatronymicTextBox.BorderStyle = BorderStyle.None;
            PatronymicTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            PatronymicTextBox.ForeColor = Color.Black;
            PatronymicTextBox.Location = new Point(61, 232);
            PatronymicTextBox.Multiline = true;
            PatronymicTextBox.Name = "PatronymicTextBox";
            PatronymicTextBox.Size = new Size(520, 38);
            PatronymicTextBox.TabIndex = 17;
            // 
            // DescriptionRichTextBox
            // 
            DescriptionRichTextBox.BorderStyle = BorderStyle.None;
            DescriptionRichTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            DescriptionRichTextBox.ForeColor = Color.Black;
            DescriptionRichTextBox.Location = new Point(61, 387);
            DescriptionRichTextBox.Name = "DescriptionRichTextBox";
            DescriptionRichTextBox.Size = new Size(520, 80);
            DescriptionRichTextBox.TabIndex = 16;
            DescriptionRichTextBox.Text = "";
            // 
            // SurnameTextbox
            // 
            SurnameTextbox.BackColor = Color.White;
            SurnameTextbox.BorderStyle = BorderStyle.None;
            SurnameTextbox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            SurnameTextbox.ForeColor = Color.Black;
            SurnameTextbox.Location = new Point(61, 149);
            SurnameTextbox.Multiline = true;
            SurnameTextbox.Name = "SurnameTextbox";
            SurnameTextbox.Size = new Size(520, 38);
            SurnameTextbox.TabIndex = 13;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.FromArgb(3, 135, 126);
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            UpdateButton.ForeColor = Color.FromArgb(9, 36, 52);
            UpdateButton.Location = new Point(257, 758);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(150, 50);
            UpdateButton.TabIndex = 24;
            UpdateButton.Text = "Добавить";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // MasterEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 135, 126);
            ClientSize = new Size(650, 872);
            Controls.Add(panel1);
            Controls.Add(HeaderPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MasterEditForm";
            Text = "MasterEditForm";
            Load += MasterEditForm_Load;
            MouseDown += MasterEditForm_MouseDown;
            HeaderPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Button RollUpButton;
        private Button CloseButton;
        private TextBox NameTextbox;
        private Button AddButton;
        private Panel panel1;
        private TextBox SurnameTextbox;
        private RichTextBox DescriptionRichTextBox;
        private TextBox WorkExperienceTextBox;
        private TextBox PatronymicTextBox;
        private Button DeleteButton;
        private TextBox PhotoAvatarLinkTextBox;
        private TextBox IsDismissedTextbox;
        private TextBox PhotosWorksLinkTextBox;
        private TextBox IdTextBox;
        private Button UpdateButton;
    }
}