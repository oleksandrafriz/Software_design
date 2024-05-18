using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
            chooseTovar.DisplayMember = "Id"; // Display the product ID
            chooseTovar.ValueMember = "Id"; // Use the product ID as the value
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

            // Clear previous search results
            searchResultsTextBox.Clear();

            // Display search results
            foreach (var product in products)
            {
                searchResultsTextBox.AppendText($"ID: {product.Id}, Name: {product.Name}, Quantity: {product.Quantity}, Price: {product.Price}, Supplier: {product.Postachalnik}{Environment.NewLine}");
            }
        }
    }
}
