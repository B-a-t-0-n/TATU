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
using TATU.Application.Accounts.Create;
using TATU.Application.DTO;
using TATU.Application.Masters.Create;
using TATU.Application.Masters.Delete;
using TATU.Application.Masters.Update;
using TATU.Application.Services.Delete;

namespace TATU.WinForms
{
    public partial class MasterEditForm : Form
    {
        public static MasterEditForm masterEditForm;
        public static MasterEditForm GetMasterEditForm
        {
            get
            {
                if (masterEditForm == null)
                { masterEditForm = new MasterEditForm(); }

                return masterEditForm;

            }
        }

        public MasterEditForm()
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
        private void HeaderPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MasterEditForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void AddButton_ClickAsync(object sender, EventArgs e)
        {
            var Name = NameTextbox.Text;
            var Surname = SurnameTextbox.Text;
            var Patronymic = Convert.ToString(PatronymicTextBox.Text);
            var WorkExperience = Convert.ToDouble(WorkExperienceTextBox.Text);
            var Description = DescriptionRichTextBox.Text;
            var IsDismissed = Convert.ToBoolean(IsDismissedTextbox.Text);
            var PhotoAvatarLink = PhotoAvatarLinkTextBox.Text;
            var PhotosWorksLink = PhotosWorksLinkTextBox.Text;

            MasterDto masterDto = new MasterDto(Name, Surname, Patronymic, WorkExperience,
                Description, IsDismissed, PhotoAvatarLink, PhotosWorksLink);

            CreateMasterCommand createMasterCommand = new CreateMasterCommand(masterDto);

            var createMasterHandler = Program.ServiceProvider.GetService<CreateMasterHandler>();
            if (createMasterHandler == null)
                MessageBox.Show("Ошибка Х002");

            var masters = await createMasterHandler.Handle(createMasterCommand);
            MessageBox.Show("Данные успешно добавлены");
        }

        private void MasterEditForm_Load(object sender, EventArgs e)
        {
            IdTextBox.Text = MastersForm.DatagridRows.Cells[0].Value.ToString();
            IdTextBox.ReadOnly = true;
            NameTextbox.Text = MastersForm.DatagridRows.Cells[1].Value.ToString();
            SurnameTextbox.Text = MastersForm.DatagridRows.Cells[2].Value.ToString();
            PatronymicTextBox.Text = MastersForm.DatagridRows.Cells[3].Value.ToString();
            WorkExperienceTextBox.Text = MastersForm.DatagridRows.Cells[4].Value.ToString();
            DescriptionRichTextBox.Text = MastersForm.DatagridRows.Cells[5].Value.ToString();
            IsDismissedTextbox.Text = MastersForm.DatagridRows.Cells[6].Value.ToString();
            PhotoAvatarLinkTextBox.Text = MastersForm.DatagridRows.Cells[7].Value.ToString();
            PhotosWorksLinkTextBox.Text = MastersForm.DatagridRows.Cells[8].Value.ToString();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(IdTextBox.Text);
            DeleteMasterCommand deleteMasterCommand = new DeleteMasterCommand(id);

            var deleteMasterHandler = Program.ServiceProvider.GetService<DeleteMasterHandler>();
            if (deleteMasterHandler == null)
                MessageBox.Show("сервис не найден");
            var delete = await deleteMasterHandler.Handle(deleteMasterCommand);
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(IdTextBox.Text);
            var Name = NameTextbox.Text;
            var Surname = SurnameTextbox.Text;
            var Patronymic = Convert.ToString(PatronymicTextBox.Text);
            var WorkExperience = Convert.ToDouble(WorkExperienceTextBox.Text);
            var Description = DescriptionRichTextBox.Text;
            var IsDismissed = Convert.ToBoolean(IsDismissedTextbox.Text);
            var PhotoAvatarLink = PhotoAvatarLinkTextBox.Text;
            var PhotosWorksLink = PhotosWorksLinkTextBox.Text;

            MasterDto masterDto = new MasterDto(Name, Surname, Patronymic, WorkExperience,
                Description, IsDismissed, PhotoAvatarLink, PhotosWorksLink);

            UpdateMasterCommand updateMasterCommand = new UpdateMasterCommand(id, masterDto);

            var updateMasterHandler = Program.ServiceProvider.GetService<UpdateMasterHandler>();
            if (updateMasterHandler == null)
                MessageBox.Show("Ошибка Х002");

            var masters = await updateMasterHandler.Handle(updateMasterCommand);
            MessageBox.Show("Данные успешно добавлены");
        }
    }
}
