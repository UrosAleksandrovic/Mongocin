using MongocinDesktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace MongocinDesktop.Forms
{
    public partial class Products : Form
    {
        int quantity;
        string selectedID;
        Warehouse warehouse;
        List<Product> warehouseProducts = new List<Product>();
        List<Product> _allProducts = new List<Product>();
        public Products(Warehouse warehouse)
        {
            InitializeComponent();
            warehouse = warehouse;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            GetAllProducts();
            GetWarehouseProducts();
            PopulateInfos();
           
        }

        private void GetWarehouseProducts()
        {
            var webRequest = WebRequest.Create("https://localhost:44382/Warehouse/ReturnAllProductsOfShop/" + warehouse.Id + "/") as HttpWebRequest;
            if (webRequest == null)
            {
                return;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    warehouseProducts = JsonConvert.DeserializeObject<List<Product>>(contributorsAsJson);


                }
            }
        }

        private void GetAllProducts()
        {
            var webRequest = WebRequest.Create("https://localhost:44382/Product/GetAllProducts/20") as HttpWebRequest;
            if (webRequest == null)
            {
                return;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    _allProducts = JsonConvert.DeserializeObject<List<Product>>(contributorsAsJson);


                }
            }
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
