using System.Runtime.InteropServices;

namespace TATU.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SingInButton_Click(object sender, EventArgs e) // ������� �� ���� �����
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();

        }

        // ��� ���������� ������

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LoginFormImage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RollUpButton_Click(object sender, EventArgs e)
        {
            this.WindowState |= FormWindowState.Minimized;
        }

        // ����� ����������

        //���������� ���������� ������ � ������
        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "������")
            {
                PasswordTextBox.Clear();
                PasswordTextBox.ForeColor = Color.White;
            }
        }
        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                PasswordTextBox.Text = "������";
                PasswordTextBox.ForeColor = Color.White;
            }
        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "�����")
            {
                LoginTextBox.Clear();
                LoginTextBox.ForeColor = Color.White;
            }
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                LoginTextBox.Text = "�����";
                LoginTextBox.ForeColor = Color.White;
            }
        }
    }
}
