using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Inventory
{
    public partial class EditTovarPage : Form
    {
        private MainController mainController;
        private int productId;

        public EditTovarPage(MainController mainController, int productId)
        {
            InitializeComponent();
            this.mainController = mainController;
            this.productId = productId;
            LoadProductData();
        }

        private void LoadProductData()
        {
            var product = mainController.GetProductById(productId);
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
                Id = productId,
                Name = editedTovarName.Text,
                Quantity = quantity,
                Price = price,
                Postachalnik = EditedPostachTovar.Text
            };

            mainController.UpdateProduct(product);
            MessageBox.Show("Продукт успішно оновлено!");
            this.Close();
        }
    }
}
