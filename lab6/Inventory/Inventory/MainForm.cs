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
    public partial class MainForm : Form
    {
        private MainController mainController;
        public MainForm(MainController mainController)
        {
            InitializeComponent();
            this.mainController = mainController;
        }

        private void addTovar_Click(object sender, EventArgs e)
        {
            var addTovarPage = new AddTovarPage(mainController);
            addTovarPage.Show();
        }
    }
}
