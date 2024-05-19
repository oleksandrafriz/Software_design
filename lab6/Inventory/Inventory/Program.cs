using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            var productRepository = new ProductRepository();
            var supplierRepository = new SupplierRepository(); // ������� ��
            var mainController = new MainController(productRepository, supplierRepository); // ��������� ���� supplierRepository

            Application.Run(new MainForm(mainController));
        }
    }
}
