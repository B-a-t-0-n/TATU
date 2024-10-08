using Microsoft.Extensions.DependencyInjection;
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
using TATU.Application.Accounts.Delete;
using TATU.Application.DTO;
using TATU.Application.Masters.Create;
using TATU.Application.Services.Create;
using TATU.Application.Services.Delete;
using TATU.Application.Services.Update;

namespace TATU.WinForms
{
    public partial class ServicesAddForm : Form
    {
        public static ServicesAddForm servicesAddForm;
        public static ServicesAddForm GetServicesAddForm
        {
            get
            {
                if (servicesAddForm == null)
                { servicesAddForm = new ServicesAddForm(); }

                return servicesAddForm;

            }
        }
        public ServicesAddForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RollUpButton_Click(object sender, EventArgs e)
        {
            this.WindowState |= FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void Add_Click(object sender, EventArgs e)
        {
            var Title = TitleTextBox.Text;
            var Description = DescriptionTextBox.Text;


            ServicesDto servicesDto = new ServicesDto(Title, Description);

            CreateServicesCommand createServicesCommand = new CreateServicesCommand(servicesDto);

            var createServicesHandler = Program.ServiceProvider.GetService<CreateServicesHandler>();
            if (createServicesHandler == null)
                MessageBox.Show("Ошибка Х002");

            var masters = await createServicesHandler.Handle(createServicesCommand);
            MessageBox.Show("Данные успешно добавлены");
        }

        private void ServicesAddForm_Load(object sender, EventArgs e)
        {
            if (Program.textboxCheck == true)
            {
                IdTextBox.Text = ServicesForm.DatagridRows.Cells[0].Value.ToString();
                TitleTextBox.Text = ServicesForm.DatagridRows.Cells[1].Value.ToString();
                DescriptionTextBox.Text = ServicesForm.DatagridRows.Cells[2].Value.ToString();
                IdTextBox.ReadOnly = true;
                IdTextBox.BackColor = Color.White;
            }
            if (Program.textboxCheck == false)
            {
                IdTextBox.BackColor = Color.FromArgb(9, 36, 52);
                IdTextBox.ReadOnly = true;
                TitleTextBox.Text = "";
                DescriptionTextBox.Text = "";
            }
        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(IdTextBox.Text);
            DeleteServicesCommand deleteServicesCommand = new DeleteServicesCommand(id);

            var deleteServicesHandler = Program.ServiceProvider.GetService<DeleteServicesHandler>();
            if (deleteServicesHandler == null)
                MessageBox.Show("сервис не найден");
            var delete = await deleteServicesHandler.Handle(deleteServicesCommand);
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            var Title = TitleTextBox.Text;
            var Description = DescriptionTextBox.Text;
            var id = Guid.Parse(IdTextBox.Text);

            ServicesDto servicesDto = new ServicesDto(Title, Description);

            UpdateServicesCommand updateServicesCommand = new UpdateServicesCommand(id, servicesDto);

            var updateServicesHandler = Program.ServiceProvider.GetService<UpdateServicesHandler>();
            if (updateServicesHandler == null)
                MessageBox.Show("Ошибка Х002");

            var masters = await updateServicesHandler.Handle(updateServicesCommand);
            MessageBox.Show("Данные успешно добавлены");


        }
    }
}
