using System;
using System.Configuration;
using System.Windows.Forms;
using ClassLibrary;

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
            var mainController = new MainController(productRepository, supplierRepository);

            Application.Run(new MainForm(mainController));
        }
    }
}
