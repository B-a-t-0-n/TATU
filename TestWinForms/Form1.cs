using Microsoft.Extensions.DependencyInjection;
using TATU.Application.Accounts.Create;
using TATU.Application.DTO;

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
    }
}
