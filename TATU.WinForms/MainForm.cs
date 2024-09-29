using System.Runtime.InteropServices;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;


namespace TATU.WinForms
{
    public partial class MainForm : Form
    {
        bool sidebarExpand;
        private IconButton currentBtn;
        private Form activeForm;

        bool drag = false;
        Point start_point = new Point(0, 0);
        public MainForm()
        {
            InitializeComponent();
        }

        private void ActivateButton(object senderBtn, Color color) // Метод активации кнопок
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(9, 36, 52);
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;
            }
        }
        private struct RGBColors // Цвета использованые для изменения кнопок
        {
            public static Color color1 = Color.FromArgb(3, 135, 126);
        }
        private void DisableButton() // Метод Диактивации кнопок
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(8, 30, 43);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
            }
        }
        private void PanelMenuTimer_Tick(object sender, EventArgs e) // Панельное меню
        {
            if (sidebarExpand)
            {
                MenuPanel.Width -= 10;
                if (MenuPanel.Width == MenuPanel.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    PanelMenuTimer.Stop();
                }
            }
            else
            {
                MenuPanel.Width += 10;
                if (MenuPanel.Width == MenuPanel.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    PanelMenuTimer.Stop();
                }
            }
        }
        private void OpenForm(Form childForm, object btnSender) // метод открытия в панели новой формы
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.MainUniversalPanel.Controls.Add(childForm);
            this.MainUniversalPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void CounselingButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenForm(new RecordinForm(), sender);
        }

        private void ReceptionButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelMenuTimer.Start();
        }

        private void RollUpButton_Click(object sender, EventArgs e)
        {

        }

        private void ReduceButton_Click(object sender, EventArgs e)
        {

        }

        // Методы для управления формой

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MainMenuPanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
