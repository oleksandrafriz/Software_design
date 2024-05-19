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
            chooseTovar.DisplayMember = "Name";
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
                    MessageBox.Show("Виберіть дійсний продукт.");
                }
            }
            else
            {
                MessageBox.Show("Виберіть продукт для редагування.");
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
            var searchText = searchTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Будь ласка, введіть пошуковий термін.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var products = mainController.SearchProductsByName(searchText);
            if (products.Count == 0)
            {
                MessageBox.Show("Не знайдено продуктів, що відповідають пошуковому терміну.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //chooseTovar.DataSource = products;
            //chooseTovar.DisplayMember = "Name";
            //chooseTovar.ValueMember = "Id";

            searchResultsLabel.Text = "";

            foreach (var product in products)
            {
                searchResultsLabel.Text += $"ID: {product.Id},\n" +
                                           $"Назва: {product.Name},\n" +
                                           $"Кількість: {product.Quantity},\n" +
                                           $"Ціна: {product.Price}{Environment.NewLine}";
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
                        sw.WriteLine("ID,Назва,Кількість,Ціна,Постачальник");
                        foreach (var product in products)
                        {
                            sw.WriteLine($"{product.Id},{product.Name},{product.Quantity},{product.Price},{product.Postachalnik}");
                        }
                    }
                    MessageBox.Show("Продукти успішно експортовані!");
                }
            }
        }


        private void postachalniki_Click(object sender, EventArgs e)
        {
            var showSuppliersForm = new ShowSuppliersForm(mainController);
            showSuppliersForm.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchResultsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
