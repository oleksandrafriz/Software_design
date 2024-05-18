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

        private void ShowSuppliersForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            var suppliers = mainController.GetAllSuppliers();
            dgvSuppliers.DataSource = suppliers;
        }

        private void dgvSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSuppliers();
        }
    }
}
