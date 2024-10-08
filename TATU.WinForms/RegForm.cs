using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TATU.Application.Accounts.Create;
using TATU.Application.Accounts.Delete;
using TATU.Application.Accounts.GetAll;
using TATU.Application.DTO;
using TATU.Application.Masters.GetAll;

namespace TATU.WinForms
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            var Biba = textBox1.Text;
            var Boba = textBox2.Text;
            var Dolic = textBox3.Text;
            double Biber = Convert.ToDouble(textBox4.Text);

            ManagerDto managerDto = new ManagerDto(Biba, Boba, Dolic, Biber);

            var Prigozhin = textBox5.Text;
            var Shoigu = textBox6.Text;


            CreateAccountManagerCommand createAccountManagerCommand
             = new CreateAccountManagerCommand(Prigozhin, Shoigu, managerDto);

            var createAccountManagerHandler = Program.ServiceProvider.GetService<CreateAccountManagerHandler>();
            if (createAccountManagerHandler == null)
                MessageBox.Show("сервис не найден");

            var masters = await createAccountManagerHandler.Handle(createAccountManagerCommand);
            MessageBox.Show("Euf,euf");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var Vivo = Guid.Parse( textBox1.Text);

            DeleteAccountCommand deleteAccountCommand = new DeleteAccountCommand(Vivo);

            var geleteAccountCommand = Program.ServiceProvider.GetService<DeleteAccountCommand>();
            if (geleteAccountCommand == null)
                MessageBox.Show("сервис не найден");

            
        }
    }
}
