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
            try
            {
                var suppliers = mainController.GetAllSuppliers();
                DisplaySuppliers(suppliers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading suppliers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplaySuppliers(object suppliers)
        {
            dgvSuppliers.DataSource = suppliers;
            SetColumnHeaders();
        }

        private void SetColumnHeaders()
        {
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
