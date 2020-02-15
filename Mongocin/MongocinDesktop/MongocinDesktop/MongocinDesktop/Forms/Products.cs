using MongocinDesktop.Models;
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
    public partial class Products : Form
    {
        Warehouse _warehouse;
        public Products(Warehouse warehouse)
        {
            InitializeComponent();
            _warehouse = warehouse;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            listViewProducts.Items.Clear();
            listViewAllProducts.Items.Clear();

            foreach (ProductListElement op in _warehouse.Products)
            {
               /* 
                ListViewItem item = new ListViewItem(new string[] { op.Name.ToString() });

                listViewProducts.Items.Add(item);*/
            }
            listViewProducts.Refresh();
        }

        private void listViewAllProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
