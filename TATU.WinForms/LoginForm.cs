using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;
using System.Threading;
using TATU.Application.Accounts.GetAll;
using TATU.Application.Accounts.GetById;
using TATU.Application.Masters.GetAll;
using TATU.Application.Providers;
using TATU.Infrastructure.Providers;
namespace TATU.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        Thread transition;
        private async void SingInButton_ClickAsync(object sender, EventArgs e) // ������� �� ���� �����
        {
            var logins = LoginTextBox.Text;
            var passwords = PasswordTextBox.Text;


            var getAllAccountHandler = Program.ServiceProvider.GetService<GetAllAccountHandler>();
            if (getAllAccountHandler == null)
                MessageBox.Show("������ �� ������");
            
            var accounts = await getAllAccountHandler.Handle();
            var passwordHasher = Program.ServiceProvider.GetService<IPasswordHasher>();


            var user = accounts.FirstOrDefault(x => x.Login == logins && passwordHasher.Verefy(passwords, x.PasswordHash));
            if (user == null)
            {
                MessageBox.Show("������, ������������ ����� ��� ������");
                return;
            }

            this.Close();
            transition = new Thread(open);
            transition.SetApartmentState(ApartmentState.STA);
            transition.Start();


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
        private void open(object sender)
        {
            System.Windows.Forms.Application.Run(new MainForm());
        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();    
            regForm.ShowDialog();
        }
    }
}
