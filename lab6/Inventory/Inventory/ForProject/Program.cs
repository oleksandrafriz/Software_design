using System;
using System.Configuration;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary.Controllers;

namespace Inventory
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            var productRepository = new ProductRepository(connectionString);
            var supplierRepository = new SupplierRepository(connectionString);
            var productController = new ProductController(productRepository);
            var supplierController = new SupplierController(supplierRepository);

            Application.Run(new MainForm(productController, supplierController));
        }
    }
}
