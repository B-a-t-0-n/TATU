using System.Runtime.InteropServices;

namespace TATU.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoginTextBox.Text = "Логин";
            LoginTextBox.ForeColor = Color.White;

            PasswordTextBox.Text = "Пароль";
            PasswordTextBox.ForeColor = Color.White;
        }


        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);
        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        private void LoginTextBox_MouseEnter(object sender, EventArgs e)
        {
            LoginTextBox.Text = null;
            LoginTextBox.ForeColor = Color.Black;
        }

        private void PasswordTextBox_MouseEnter(object sender, EventArgs e)
        {
            PasswordTextBox.Text = null;
            PasswordTextBox.ForeColor = Color.Black;
        }
    }
}
