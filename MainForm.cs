using InventoryApp.Business;
using System;
using System.Windows.Forms;

namespace InventoryApp
{
    public partial class MainForm : Form
    {
        private Inventory _inventory;

        public MainForm()
        {
            InitializeComponent();
            _inventory = new Inventory();
            dgvItems.DataSource = _inventory.Items;
        }
    }
}