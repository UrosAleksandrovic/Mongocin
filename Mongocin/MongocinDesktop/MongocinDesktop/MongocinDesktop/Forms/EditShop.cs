using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongocinDesktop.Forms
{
    public partial class EditShop : Form
    {
        Shop _shop;
        public EditShop(Shop myShop)
        {
            InitializeComponent();
            _shop = myShop;
            textbox1.text = _shop.Name;

        }

        private void EditShop_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = listViewShop.SelectedItems[0].SubItems[0].Id;
                Warehouse myShop = _warehouses.Find(item => item.Id == id);

                ShopProducts editWarehouse = new ShopProducts(_shop.ProductList);
                editWarehouse.ShowDialog();
                PopulateInfos();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Select a warewhouse");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
