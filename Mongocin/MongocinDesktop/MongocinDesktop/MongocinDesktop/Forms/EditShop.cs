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

namespace MongocinDesktop.Forms
{
    public partial class EditShop : Form
    {
        Shop _shop;
        public EditShop(Shop shop)
        {
            InitializeComponent();
            this._shop = shop;
            shopNameTextBox.Text = _shop.Name;
            shopAddressTextBox.Text = _shop.Address;
        }

        private void EditShop_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            ShopProducts shopProducts = new ShopProducts(_shop);
            shopProducts.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saveShopChangesButton_Click(object sender, EventArgs e)
        {
            _shop.Address = shopAddressTextBox.Text;
            _shop.Name = shopNameTextBox.Text;

            try
            {
                SaveProduct();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            this.Close();
        }
        private void SaveProduct()
        {
            WebRequest webRequest = WebRequest.Create("https://localhost:44382/shop/Edit/");
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            string postData = "{\"Name\":\"" + _shop.Name + "\", \"Adress\":\"" + _shop.Address + "\", \"Id\":\"" + _shop.Id + "\"}";
            using (var streamW = new StreamWriter(webRequest.GetRequestStream()))
            {
                streamW.Write(postData);

                streamW.Flush();
                streamW.Close();

                var response = (HttpWebResponse)webRequest.GetResponse();
            }
        }
    }
}
