using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TATU.Application.Accounts.Create;
using TATU.Application.Accounts.GetAll;
using TATU.Application.DTO;
using TATU.Application.Masters.GetAll;
using TATU.Application.Services.GetAll;
using TATU.Infrastructure;

namespace TestWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var _createAccountManagerHandler = Program.ServiceProvider.GetService<CreateAccountManagerHandler>();
            if (_createAccountManagerHandler == null)
                MessageBox.Show("сервис не найден");

            var managerDto = new ManagerDto("Petr", "Petrin", "Petrowww", 1);

            var createManagerCommand = new CreateAccountManagerCommand("qwerty123", "qwerty123", managerDto);

            var id = await _createAccountManagerHandler!.Handle(createManagerCommand);

            MessageBox.Show(id.ToString());

            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var getAllServicesHandler = Program.ServiceProvider.GetService<GetAllMasterHandler>();
            if (getAllServicesHandler == null)
                MessageBox.Show("сервис не найден");

            var masters = await getAllServicesHandler.Handle();

            Console.WriteLine(123);
        }
    }
}
