using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using TATU.Application.Masters.GetAll;
using TATU.Application.Services.GetAll;

namespace TATU.WinForms
{
    public partial class ServicesForm : Form
    {
        public static DataGridViewRow DatagridRows;
        public ServicesForm()
        {
            InitializeComponent();
        }

        private async void UpdateButton_Click(object sender, EventArgs e)
        {
            var getAllServicesHandler = Program.ServiceProvider.GetService<GetAllServicesHandler>();
            if (getAllServicesHandler == null)
                MessageBox.Show("сервис не найден");

            var masters = await getAllServicesHandler.Handle();
            MasterDatagrid.DataSource = masters;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ServicesAddForm servicesAddForm = new ServicesAddForm();
            servicesAddForm.ShowDialog();
            
        }

        private void MasterDatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DatagridRows = MasterDatagrid.Rows[e.RowIndex];
                ServicesAddForm.GetServicesAddForm.ShowDialog();
            }
        }
    }
}
