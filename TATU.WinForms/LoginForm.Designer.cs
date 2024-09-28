namespace TATU.WinForms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textboxWhiteLinePanel1 = new Panel();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            textboxWhiteLinePanel2 = new Panel();
            SingInButton = new Button();
            RegistrButton = new Button();
            CaptionLabel1 = new Label();
            CaptionLabel2 = new Label();
            SuspendLayout();
            // 
            // textboxWhiteLinePanel1
            // 
            textboxWhiteLinePanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textboxWhiteLinePanel1.BackColor = Color.White;
            textboxWhiteLinePanel1.Location = new Point(28, 258);
            textboxWhiteLinePanel1.Name = "textboxWhiteLinePanel1";
            textboxWhiteLinePanel1.Size = new Size(317, 1);
            textboxWhiteLinePanel1.TabIndex = 0;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LoginTextBox.BackColor = Color.Black;
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            LoginTextBox.ForeColor = Color.White;
            LoginTextBox.Location = new Point(28, 230);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(317, 30);
            LoginTextBox.TabIndex = 1;
            LoginTextBox.MouseEnter += LoginTextBox_MouseEnter;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PasswordTextBox.BackColor = Color.Black;
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            PasswordTextBox.ForeColor = Color.White;
            PasswordTextBox.Location = new Point(28, 306);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(317, 30);
            PasswordTextBox.TabIndex = 2;
            PasswordTextBox.MouseEnter += PasswordTextBox_MouseEnter;
            // 
            // textboxWhiteLinePanel2
            // 
            textboxWhiteLinePanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textboxWhiteLinePanel2.BackColor = Color.White;
            textboxWhiteLinePanel2.Location = new Point(28, 334);
            textboxWhiteLinePanel2.Name = "textboxWhiteLinePanel2";
            textboxWhiteLinePanel2.Size = new Size(317, 1);
            textboxWhiteLinePanel2.TabIndex = 3;
            // 
            // SingInButton
            // 
            SingInButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SingInButton.BackColor = Color.FromArgb(39, 67, 105);
            SingInButton.FlatAppearance.BorderSize = 0;
            SingInButton.FlatStyle = FlatStyle.Flat;
            SingInButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SingInButton.ForeColor = Color.Black;
            SingInButton.Location = new Point(52, 386);
            SingInButton.Name = "SingInButton";
            SingInButton.Size = new Size(119, 42);
            SingInButton.TabIndex = 4;
            SingInButton.Text = "Вход";
            SingInButton.UseVisualStyleBackColor = false;
            SingInButton.Click += SingInButton_Click;
            // 
            // RegistrButton
            // 
            RegistrButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RegistrButton.BackColor = Color.Black;
            RegistrButton.FlatAppearance.BorderSize = 2;
            RegistrButton.FlatStyle = FlatStyle.Flat;
            RegistrButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RegistrButton.ForeColor = Color.FromArgb(39, 67, 105);
            RegistrButton.Location = new Point(198, 386);
            RegistrButton.Name = "RegistrButton";
            RegistrButton.Size = new Size(119, 42);
            RegistrButton.TabIndex = 5;
            RegistrButton.Text = "Регестрация";
            RegistrButton.UseVisualStyleBackColor = false;
            // 
            // CaptionLabel1
            // 
            CaptionLabel1.AutoSize = true;
            CaptionLabel1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CaptionLabel1.ForeColor = Color.White;
            CaptionLabel1.Location = new Point(28, 67);
            CaptionLabel1.Name = "CaptionLabel1";
            CaptionLabel1.Size = new Size(143, 50);
            CaptionLabel1.TabIndex = 6;
            CaptionLabel1.Text = "Добро\r\n";
            // 
            // CaptionLabel2
            // 
            CaptionLabel2.AutoSize = true;
            CaptionLabel2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CaptionLabel2.ForeColor = Color.FromArgb(39, 67, 105);
            CaptionLabel2.Location = new Point(28, 137);
            CaptionLabel2.Name = "CaptionLabel2";
            CaptionLabel2.Size = new Size(222, 46);
            CaptionLabel2.TabIndex = 7;
            CaptionLabel2.Text = "пожаловать";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(842, 533);
            Controls.Add(CaptionLabel2);
            Controls.Add(CaptionLabel1);
            Controls.Add(RegistrButton);
            Controls.Add(SingInButton);
            Controls.Add(textboxWhiteLinePanel1);
            Controls.Add(textboxWhiteLinePanel2);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            ForeColor = Color.White;
            MaximumSize = new Size(860, 580);
            MinimumSize = new Size(860, 580);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KVDHTattoo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel textboxWhiteLinePanel1;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Panel textboxWhiteLinePanel2;
        private Button SingInButton;
        private Button RegistrButton;
        private Label CaptionLabel1;
        private Label CaptionLabel2;
    }
}
