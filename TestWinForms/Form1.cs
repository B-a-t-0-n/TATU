using TATU.Application.Accounts.Create;
using TATU.Application.DTO;

namespace TestWinForms
{
    public partial class Form1 : Form
    {
        private readonly CreateAccountManagerHandler _createAccountManagerHandler;

        public Form1(CreateAccountManagerHandler createAccountManagerHandler)
        {
            InitializeComponent();
            _createAccountManagerHandler = createAccountManagerHandler;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var managerDto = new ManagerDto("Petr", "Petrin", "Petrowww", 1);

            var createManagerCommand = new CreateAccountManagerCommand("qwerty123", "qwerty123", managerDto);

            var id = await _createAccountManagerHandler.Handle(createManagerCommand);
            MessageBox.Show(id.ToString());
        }
    }
}
