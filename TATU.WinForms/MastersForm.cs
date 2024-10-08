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
using TATU.Application.Masters;
using TATU.Application.Masters.GetAll;
using TATU.Domain;

namespace TATU.WinForms
{
    public partial class MastersForm : Form
    {
        public static DataGridViewRow DatagridRows;
        public MastersForm()
        {
            InitializeComponent();
        }

        private async void UpdateButton_ClickAsync(object sender, EventArgs e)
        {
            var getAllMasterHandler = Program.ServiceProvider.GetService<GetAllMasterHandler>();
            if (getAllMasterHandler == null)
                MessageBox.Show("сервис не найден");

            var masters = await getAllMasterHandler.Handle();
            MasterDatagrid.DataSource = masters;

            //MasterDatagrid.Columns[0].HeaderText = "ID";
            //MasterDatagrid.Columns[1].HeaderText = "Имя";
            //MasterDatagrid.Columns[2].HeaderText = "Фамилия";
            //MasterDatagrid.Columns[3].HeaderText = "Телефон";
            //MasterDatagrid.Columns[4].HeaderText = "Ф.И.О. Доктора";
            //MasterDatagrid.Columns[5].HeaderText = "Дата приёма";
            //MasterDatagrid.Columns[6].HeaderText = "Время приёма";
            //MasterDatagrid.Columns[7].HeaderText = "Дата приёма";
            //MasterDatagrid.Columns[8].HeaderText = "Время приёма";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MasterEditForm masterEditForm = new MasterEditForm();
            masterEditForm.ShowDialog();
        }

        private void MasterDatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DatagridRows = MasterDatagrid.Rows[e.RowIndex];
                MasterEditForm.GetMasterEditForm.ShowDialog();
            }
        }
    }
}
