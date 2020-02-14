using MongocinDesktop.Models;
using Newtonsoft.Json;
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

namespace MongocinDesktop.Forms
{
    public partial class ShopProducts : Form
    {
        Shop shop;

        List<Product> _allProducts = new List<Product>();
        public ShopProducts(Shop shop)
        {
            InitializeComponent();
            this.shop = shop;

        }

        private void ShopProducts_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            GetAllProducts();
            listViewProducts.Items.Clear();
            listViewAllProducts.Items.Clear();

            foreach (Product op in shop.Products)
            {

                ListViewItem item = new ListViewItem(new string[] { op.Name.ToString() });

                listViewProducts.Items.Add(item);
            }
            listViewProducts.Refresh();
        }
        private void GetAllProducts()
        {
            var webRequest = WebRequest.Create("https://localhost:44382/product/") as HttpWebRequest;
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
    }
}
