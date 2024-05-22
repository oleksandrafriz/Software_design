using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using ClassLibrary;
using ClassLibrary.Controllers;

namespace Inventory
{
    public partial class MainForm : Form
    {
        private readonly ProductController _productController;
        private readonly SupplierController _supplierController;
        private int _selectedProductId;

        public MainForm(ProductController productController, SupplierController supplierController)
        {
            InitializeComponent();
            _productController = productController ?? throw new ArgumentNullException(nameof(productController));
            _supplierController = supplierController ?? throw new ArgumentNullException(nameof(supplierController));
            LoadProductIds();
            InitializeSearchResultsGridView();
        }

        private void InitializeSearchResultsGridView()
        {
            searchResultsDataGridView.Columns.Clear();
            searchResultsDataGridView.Columns.Add("Id", "ID");
            searchResultsDataGridView.Columns.Add("Name", "Назва");
            searchResultsDataGridView.Columns.Add("Quantity", "Кількість");
            searchResultsDataGridView.Columns.Add("Price", "Ціна");
            searchResultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadProductIds()
        {
            var products = _productController.GetAllProducts();
            chooseTovar.DataSource = products;
            chooseTovar.DisplayMember = "Name";
            chooseTovar.ValueMember = "Id";
        }

        private void addTovar_Click(object sender, EventArgs e)
        {
            var addTovarPage = new AddTovarPage(_productController);
            addTovarPage.Show();
        }

        private void editTovar_Click(object sender, EventArgs e)
        {
            if (chooseTovar.SelectedItem is Product selectedProduct)
            {
                _selectedProductId = selectedProduct.Id;
                var editTovarPage = new EditTovarPage(_productController, _selectedProductId);
                editTovarPage.Show();
            }
            else
            {
                MessageBox.Show("Виберіть продукт для редагування.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tovars_Click(object sender, EventArgs e)
        {
            var showTovarPage = new ShowTovar(_productController);
            showTovarPage.Show();
        }

        private void chooseTovar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseTovar.SelectedItem is Product selectedProduct)
            {
                _selectedProductId = selectedProduct.Id;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Будь ласка, введіть пошуковий термін.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var products = _productController.SearchProductsByName(searchText);
            DisplaySearchResults(products);
        }

        private void DisplaySearchResults(List<Product> products)
        {
            searchResultsDataGridView.Rows.Clear();

            if (products.Count == 0)
            {
                MessageBox.Show("Не знайдено продуктів, що відповідають пошуковому терміну.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (var product in products)
                {
                    searchResultsDataGridView.Rows.Add(product.Id, product.Name, product.Quantity, product.Price);
                }
            }
        }

        private void exportToCSVButton_Click(object sender, EventArgs e)
        {
            var products = _productController.GetAllProducts();
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.FileName = "Products.csv";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportProductsToCsv(sfd.FileName, products);
                }
            }
        }

        private void ExportProductsToCsv(string fileName, List<Product> products)
        {
            using (var sw = new StreamWriter(fileName, false, new UTF8Encoding(true)))
            {
                sw.WriteLine("ID,Назва,Кількість,Ціна,Постачальник");
                foreach (var product in products)
                {
                    sw.WriteLine($"{product.Id},{product.Name},{product.Quantity},{product.Price},{product.Postachalnik}");
                }
            }
            MessageBox.Show("Продукти успішно експортовані!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void postachalniki_Click(object sender, EventArgs e)
        {
            var showSuppliersForm = new ShowSuppliersForm(_supplierController);
            showSuppliersForm.Show();
        }
    }
}
