using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace TATU.WinForms
{
    public partial class MainForm : Form
    {
        bool sidebarExpand;
        private IconButton currentBtn;

        bool drag = false;
        Point start_point = new Point(0, 0);
        public MainForm()
        {
            InitializeComponent();
        }
        private void ActivateButton(object senderBtn, Color color)
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
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(3, 135, 126);
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(8, 30, 43);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
            }
        }
        private void PanelMenuTimer_Tick(object sender, EventArgs e)
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
        private void CounselingButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
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

        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();

        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage (System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
