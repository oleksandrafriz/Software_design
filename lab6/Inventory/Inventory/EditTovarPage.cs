using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Inventory
{
    public partial class EditTovarPage : Form
    {
        private readonly MainController _mainController;
        private readonly int _productId;

        public EditTovarPage(MainController mainController, int productId)
        {
            InitializeComponent();
            _mainController = mainController ?? throw new ArgumentNullException(nameof(mainController));
            _productId = productId;
            LoadProductData();
        }

        private void LoadProductData()
        {
            var product = _mainController.GetProductById(_productId);
            if (product != null)
            {
                editedTovarName.Text = product.Name;
                editedQuantityTovar.Text = product.Quantity.ToString();
                editedPriceTovar.Text = product.Price.ToString();
                EditedPostachTovar.Text = product.Postachalnik;
            }
            else
            {
                MessageBox.Show("Продукт не знайдено.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SaveEditedTovar_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out string name, out int quantity, out decimal price, out string postachalnik))
            {
                var product = new Product
                {
                    Id = _productId,
                    Name = name,
                    Quantity = quantity,
                    Price = price,
                    Postachalnik = postachalnik
                };

                _mainController.UpdateProduct(product);
                MessageBox.Show("Продукт успішно оновлено!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool ValidateInputs(out string name, out int quantity, out decimal price, out string postachalnik)
        {
            name = editedTovarName.Text;
            postachalnik = EditedPostachTovar.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(editedQuantityTovar.Text) ||
                string.IsNullOrWhiteSpace(editedPriceTovar.Text) ||
                string.IsNullOrWhiteSpace(postachalnik))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantity = 0;
                price = 0;
                return false;
            }

            if (!int.TryParse(editedQuantityTovar.Text, out quantity))
            {
                MessageBox.Show("Кількість має бути дійсним цілим числом.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                price = 0;
                return false;
            }

            if (!decimal.TryParse(editedPriceTovar.Text, out price))
            {
                MessageBox.Show("Ціна має бути дійсним десятковим числом.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
