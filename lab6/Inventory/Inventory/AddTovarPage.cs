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
            var product = new Product
            {
                Name = tovarName.Text,
                Quantity = int.Parse(quantityTovar.Text),
                Price = decimal.Parse(priceTovar.Text),
                Postachalnik = postachTovar.Text
            };

            mainController.AddProduct(product);
            MessageBox.Show("Product added successfully!");
            this.Close();
        }
    }
}
