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
    public partial class MainForm : Form
    {
        List<Shop> _shops;
        List<Warehouse> _warehouses;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            listViewShop.Items.Clear();
            _shops = //pribavi shops
            foreach (Shop op in _shops)
            {
                ListViewItem item = new ListViewItem(new string[] { op.Name.ToString()});

                listViewShop.Items.Add(item);
            }
            listViewShop.Refresh();

            listViewWarehouse.Items.Clear();
            _warehouses = //pribavi
            foreach (Warehouse op in _warehouses)
            {
                ListViewItem item = new ListViewItem(new string[] {op.Name.ToString() });

                listViewWarehouse.Items.Add(item);
            }
            listViewWarehouse.Refresh();
        }

        private void buttonShop_Click(object sender, EventArgs e)
        {
            try
            {
                string id = listViewShop.SelectedItems[0].SubItems[0].Id;
                Shop myShop = _shops.Find(item => item.Id == id);

                EditShop editShop = new EditShop(myShop);
                editShop.ShowDialog();
                PopulateInfos();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Select a shop");
            }
        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            try
            {
                string id = listViewShop.SelectedItems[0].SubItems[0].Id;
                Warehouse myShop = _warehouses.Find(item => item.Id == id);

                EditWarehouse editWarehouse = new EditWarehouse(myShop);
                editWarehouse.ShowDialog();
                PopulateInfos();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Select a warewhouse");
            }
        }
    }
}
