using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Inventory
{
    public partial class ShowSuppliersForm : Form
    {
        private MainController mainController;

        public ShowSuppliersForm(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            var suppliers = mainController.GetAllSuppliers();
            dgvSuppliers.DataSource = suppliers;
            dgvSuppliers.Columns["Id"].HeaderText = "ID Постачальника";
            dgvSuppliers.Columns["Name"].HeaderText = "Ім'я Постачальника";
            dgvSuppliers.Columns["Address"].HeaderText = "Адреса";
            dgvSuppliers.Columns["PhoneNumber"].HeaderText = "Номер телефону";
            dgvSuppliers.Columns["CompanyName"].HeaderText = "Назва компанії";
        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSuppliers();
        }
    }
}
