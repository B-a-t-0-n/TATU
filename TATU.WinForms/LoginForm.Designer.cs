namespace TATU.WinForms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            SingInButton = new Button();
            RegistrButton = new Button();
            CaptionLabel1 = new Label();
            HeaderPanel = new Panel();
            RollUpButton = new Button();
            CloseButton = new Button();
            LoginFormImage = new PictureBox();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LoginFormImage).BeginInit();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.BackColor = Color.FromArgb(9, 36, 52);
            LoginTextBox.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            LoginTextBox.ForeColor = Color.White;
            LoginTextBox.Location = new Point(87, 428);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(358, 33);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.Enter += LoginTextBox_Enter;
            LoginTextBox.Leave += LoginTextBox_Leave;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.BackColor = Color.FromArgb(9, 36, 52);
            PasswordTextBox.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            PasswordTextBox.ForeColor = Color.White;
            PasswordTextBox.Location = new Point(87, 497);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(358, 33);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.Enter += PasswordTextBox_Enter;
            PasswordTextBox.Leave += PasswordTextBox_Leave;
            // 
            // SingInButton
            // 
            SingInButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SingInButton.BackColor = Color.FromArgb(3, 135, 126);
            SingInButton.FlatAppearance.BorderSize = 0;
            SingInButton.FlatStyle = FlatStyle.Flat;
            SingInButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SingInButton.ForeColor = Color.FromArgb(9, 36, 52);
            SingInButton.Location = new Point(115, 573);
            SingInButton.Name = "SingInButton";
            SingInButton.Size = new Size(128, 47);
            SingInButton.TabIndex = 4;
            SingInButton.Text = "Вход";
            SingInButton.UseVisualStyleBackColor = false;
            SingInButton.Click += SingInButton_Click;
            // 
            // RegistrButton
            // 
            RegistrButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RegistrButton.BackColor = Color.FromArgb(9, 36, 52);
            RegistrButton.FlatAppearance.BorderSize = 2;
            RegistrButton.FlatStyle = FlatStyle.Flat;
            RegistrButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegistrButton.ForeColor = Color.FromArgb(3, 135, 126);
            RegistrButton.Location = new Point(291, 573);
            RegistrButton.Name = "RegistrButton";
            RegistrButton.Size = new Size(128, 50);
            RegistrButton.TabIndex = 5;
            RegistrButton.Text = "Регестрация";
            RegistrButton.UseVisualStyleBackColor = false;
            // 
            // CaptionLabel1
            // 
            CaptionLabel1.AutoSize = true;
            CaptionLabel1.Font = new Font("Segoe UI Semilight", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CaptionLabel1.ForeColor = Color.White;
            CaptionLabel1.Location = new Point(174, 349);
            CaptionLabel1.Name = "CaptionLabel1";
            CaptionLabel1.Size = new Size(190, 38);
            CaptionLabel1.TabIndex = 6;
            CaptionLabel1.Text = "Приветствуем";
            CaptionLabel1.TextAlign = ContentAlignment.TopCenter;
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.FromArgb(8, 30, 43);
            HeaderPanel.Controls.Add(RollUpButton);
            HeaderPanel.Controls.Add(CloseButton);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(530, 40);
            HeaderPanel.TabIndex = 8;
            HeaderPanel.MouseDown += HeaderPanel_MouseDown;
            // 
            // RollUpButton
            // 
            RollUpButton.Dock = DockStyle.Right;
            RollUpButton.FlatAppearance.BorderSize = 0;
            RollUpButton.FlatStyle = FlatStyle.Flat;
            RollUpButton.Font = new Font("Trebuchet MS", 15F, FontStyle.Bold);
            RollUpButton.ForeColor = Color.White;
            RollUpButton.Location = new Point(430, 0);
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
            CloseButton.Location = new Point(480, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(50, 40);
            CloseButton.TabIndex = 4;
            CloseButton.Text = "○";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // LoginFormImage
            // 
            LoginFormImage.Image = (Image)resources.GetObject("LoginFormImage.Image");
            LoginFormImage.Location = new Point(141, 72);
            LoginFormImage.Name = "LoginFormImage";
            LoginFormImage.Size = new Size(250, 250);
            LoginFormImage.SizeMode = PictureBoxSizeMode.StretchImage;
            LoginFormImage.TabIndex = 9;
            LoginFormImage.TabStop = false;
            LoginFormImage.MouseDown += LoginFormImage_MouseDown;
            // 
            // LoginForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(9, 36, 52);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(530, 650);
            Controls.Add(LoginFormImage);
            Controls.Add(HeaderPanel);
            Controls.Add(CaptionLabel1);
            Controls.Add(RegistrButton);
            Controls.Add(SingInButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(530, 650);
            MinimumSize = new Size(530, 650);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KVDHTattoo";
            MouseDown += LoginForm_MouseDown;
            HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)LoginFormImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button SingInButton;
        private Button RegistrButton;
        private Label CaptionLabel1;
        private Panel HeaderPanel;
        private PictureBox LoginFormImage;
        private Button CloseButton;
        private Button RollUpButton;
    }
}
