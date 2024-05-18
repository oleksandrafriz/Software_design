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
    public partial class EditTovarPage : Form
    {
        private MainController mainController;
        private int productId;

        public EditTovarPage(MainController mainController, int productId)
        {
            InitializeComponent();
            this.mainController = mainController;
            this.productId = productId;

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
            var product = new Product
            {
                Id = productId,
                Name = editedTovarName.Text,
                Quantity = int.Parse(editedQuantityTovar.Text),
                Price = decimal.Parse(editedPriceTovar.Text),
                Postachalnik = EditedPostachTovar.Text
            };

            mainController.UpdateProduct(product);
            MessageBox.Show("Product updated successfully!");
            this.Close();
        }

        private void chooseTovar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
