using System;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary.Controllers;

namespace Inventory
{
    public partial class EditTovarPage : Form
    {
        private readonly ProductController _productController;
        private int _productId;

        public EditTovarPage(ProductController productController, int productId)
        {
            InitializeComponent();
            _productController = productController ?? throw new ArgumentNullException(nameof(productController));
            _productId = productId;
            LoadProductData();
        }

        private void LoadProductData()
        {
            var product = _productController.GetProductById(_productId);
            if (product != null)
            {
                editedTovarName.Text = product.Name;
                editedQuantityTovar.Text = product.Quantity.ToString();
                editedPriceTovar.Text = product.Price.ToString();
                EditedPostachTovar.Text = product.Postachalnik;
            }
        }

        private void saveEditedTovar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(editedTovarName.Text) ||
                string.IsNullOrWhiteSpace(editedQuantityTovar.Text) ||
                string.IsNullOrWhiteSpace(editedPriceTovar.Text) ||
                string.IsNullOrWhiteSpace(EditedPostachTovar.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(editedQuantityTovar.Text, out int quantity))
            {
                MessageBox.Show("Кількість має бути дійсним цілим числом.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(editedPriceTovar.Text, out decimal price))
            {
                MessageBox.Show("Ціна має бути дійсним десятковим числом.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = new Product
            {
                Id = _productId,
                Name = editedTovarName.Text,
                Quantity = quantity,
                Price = price,
                Postachalnik = EditedPostachTovar.Text
            };

            _productController.UpdateProduct(product);
            MessageBox.Show("Продукт успішно оновлено!");
            this.Close();
        }
    }
}
