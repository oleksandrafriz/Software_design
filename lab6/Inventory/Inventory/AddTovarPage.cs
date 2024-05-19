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
    public partial class AddTovarPage : Form
    {
        private MainController mainController;
        public AddTovarPage(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        private void saveNewTovar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tovarName.Text) ||
               string.IsNullOrWhiteSpace(quantityTovar.Text) ||
               string.IsNullOrWhiteSpace(priceTovar.Text) ||
               string.IsNullOrWhiteSpace(postachTovar.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(quantityTovar.Text, out int quantity))
            {
                MessageBox.Show("Кількість має бути дійсним цілим числом.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(priceTovar.Text, out decimal price))
            {
                MessageBox.Show("Ціна має бути дійсним десятковим числом.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var product = new Product
            {
                Name = tovarName.Text,
                Quantity = quantity,
                Price = price,
                Postachalnik = postachTovar.Text
            };

            mainController.AddProduct(product);
            MessageBox.Show("Продукт успішно додано!");
            this.Close();
        }
    }
    }

