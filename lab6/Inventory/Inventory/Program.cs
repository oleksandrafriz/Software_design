using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.Configuration;

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
            var supplierRepository = new SupplierRepository();
            var mainController = new MainController(productRepository, supplierRepository);

            Application.Run(new MainForm(mainController));
        }
    }
}
