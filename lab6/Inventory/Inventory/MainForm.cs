using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using ClassLibrary;

namespace Inventory
{
    public partial class MainForm : Form
    {
        private MainController mainController;
        private int selectedProductId;

        public MainForm(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
            LoadProductIds();
        }

        private void LoadProductIds()
        {
            var products = mainController.GetAllProducts();
            chooseTovar.DataSource = products;
            chooseTovar.DisplayMember = "Id";
            chooseTovar.ValueMember = "Id";
        }

        private void addTovar_Click(object sender, EventArgs e)
        {
            var addTovarPage = new AddTovarPage(mainController);
            addTovarPage.Show();
        }

        private void editTovar_Click(object sender, EventArgs e)
        {
            if (chooseTovar.SelectedItem != null)
            {
                var selectedProduct = chooseTovar.SelectedItem as Product;
                if (selectedProduct != null)
                {
                    selectedProductId = selectedProduct.Id;
                    var editTovarPage = new EditTovarPage(mainController, selectedProductId);
                    editTovarPage.Show();
                }
                else
                {
                    MessageBox.Show("Please select a valid product.");
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }

        private void tovars_Click(object sender, EventArgs e)
        {
            var showTovarPage = new ShowTovar(mainController);
            showTovarPage.Show();
        }

        private void chooseTovar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseTovar.SelectedItem != null)
            {
                var selectedProduct = chooseTovar.SelectedItem as Product;
                if (selectedProduct != null)
                {
                    selectedProductId = selectedProduct.Id;
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text;
            var products = mainController.SearchProductsByName(searchText);
            chooseTovar.DataSource = products;
            chooseTovar.DisplayMember = "Name";
            chooseTovar.ValueMember = "Id";

            searchResultsTextBox.Clear();

            foreach (var product in products)
            {
                searchResultsTextBox.AppendText($"ID: {product.Id}, Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}, Postachalnik: {product.Postachalnik}{Environment.NewLine}");
            }
        }

        private void exportToCSVButton_Click(object sender, EventArgs e)
        {
            var products = mainController.GetAllProducts();
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "Products.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        sw.WriteLine("ID,Name,Quantity,Price,Supplier");
                        foreach (var product in products)
                        {
                            sw.WriteLine($"{product.Id},{product.Name},{product.Quantity},{product.Price},{product.Postachalnik}");
                        }
                    }
                    MessageBox.Show("Products exported successfully!");
                }
            }
        }
    }
}
