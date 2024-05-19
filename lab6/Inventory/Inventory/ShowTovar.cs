using System;
using System.Linq;
using System.Windows.Forms;
using ClassLibrary;

namespace Inventory
{
    public partial class ShowTovar : Form
    {
        private readonly MainController _mainController;

        public ShowTovar(MainController mainController)
        {
            InitializeComponent();
            _mainController = mainController ?? throw new ArgumentNullException(nameof(mainController));
            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                var products = _mainController.GetAllProducts();
                dgvProducts.DataSource = products;

                dgvProducts.Columns["Id"].HeaderText = "ID товару";
                dgvProducts.Columns["Name"].HeaderText = "Назва товару";
                dgvProducts.Columns["Quantity"].HeaderText = "Кількість";
                dgvProducts.Columns["Price"].HeaderText = "Ціна";
                dgvProducts.Columns["Postachalnik"].HeaderText = "Постачальник";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження продуктів: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductsSorted(Func<Product, object> keySelector, bool ascending = true)
        {
            var products = _mainController.GetAllProducts();
            dgvProducts.DataSource = ascending
                ? products.OrderBy(keySelector).ToList()
                : products.OrderByDescending(keySelector).ToList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                var productId = (int)dgvProducts.SelectedRows[0].Cells[0].Value;
                _mainController.DeleteProduct(productId);
                LoadProducts();
                MessageBox.Show("Продукт успішно видалено!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var searchText = searchTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Будь ласка, введіть пошуковий термін.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var products = _mainController.GetAllProducts()
                                          .Where(p => p.Name.Split(' ')
                                          .Any(word => word.Contains(searchText, StringComparison.OrdinalIgnoreCase)))
                                          .ToList();

            if (products.Count == 0)
            {
                MessageBox.Show("Не знайдено продуктів, що відповідають пошуковому терміну.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvProducts.DataSource = products;
        }

        private void SortByIdButton_Click(object sender, EventArgs e)
        {
            LoadProductsSorted(p => p.Id);
        }

        private void SortByNameButton_Click(object sender, EventArgs e)
        {
            LoadProductsSorted(p => p.Name);
        }

        private void SortByQuantityButton_Click(object sender, EventArgs e)
        {
            LoadProductsSorted(p => p.Quantity);
        }

        private void SortByPriceButton_Click(object sender, EventArgs e)
        {
            LoadProductsSorted(p => p.Price);
        }
    }
}
