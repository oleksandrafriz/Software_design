using System;
using System.Windows.Forms;
using ClassLibrary;

namespace Inventory
{
    public partial class AddTovarPage : Form
    {
        private readonly MainController _mainController;

        public AddTovarPage(MainController mainController)
        {
            InitializeComponent();
            _mainController = mainController ?? throw new ArgumentNullException(nameof(mainController));
        }

        private void saveNewTovar_Click(object sender, EventArgs e)
        {
            if (ValidateInputs(out string name, out int quantity, out decimal price, out string postachalnik))
            {
                var product = new Product
                {
                    Name = name,
                    Quantity = quantity,
                    Price = price,
                    Postachalnik = postachalnik
                };

                _mainController.AddProduct(product);
                MessageBox.Show("Продукт успішно додано!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool ValidateInputs(out string name, out int quantity, out decimal price, out string postachalnik)
        {
            name = tovarName.Text;
            postachalnik = postachTovar.Text;

            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(quantityTovar.Text) ||
                string.IsNullOrWhiteSpace(priceTovar.Text) ||
                string.IsNullOrWhiteSpace(postachalnik))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                quantity = 0;
                price = 0;
                return false;
            }

            if (!int.TryParse(quantityTovar.Text, out quantity))
            {
                MessageBox.Show("Кількість має бути дійсним цілим числом.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                price = 0;
                return false;
            }

            if (!decimal.TryParse(priceTovar.Text, out price))
            {
                MessageBox.Show("Ціна має бути дійсним десятковим числом.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
