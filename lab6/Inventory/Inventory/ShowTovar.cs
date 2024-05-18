using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace Inventory
{
    public partial class ShowTovar : Form
    {
        private MainController mainController;
        public ShowTovar(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = mainController.GetAllProducts();
            dgvProducts.DataSource = products;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var productId = (int)dgvProducts.SelectedRows[0].Cells[0].Value;
                mainController.DeleteProduct(productId);
                LoadProducts();
                MessageBox.Show("Product deleted successfully!");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var products = mainController.GetAllProducts()
                                    .Where(p => p.Name.Contains(searchTextBox.Text))
                                    .ToList();
            dgvProducts.DataSource = products;
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadProducts();
        }
    }
}
