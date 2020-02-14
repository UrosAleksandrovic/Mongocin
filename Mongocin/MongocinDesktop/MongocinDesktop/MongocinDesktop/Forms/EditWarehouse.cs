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
    public partial class EditWarehouse : Form
    {
        Warehouse _wareHouse;
        public EditWarehouse(Warehouse warehouse)
        {
            InitializeComponent();
            _wareHouse = warehouse;
            nameTextBox.Text = _wareHouse.Name;
            addressTextBox.Text = _wareHouse.Address;
        }

        private void EditWarehouse_Load(object sender, EventArgs e)
        {

        }

        private void saveWarehouseChangesButton_Click(object sender, EventArgs e)
        {
            _wareHouse.Address = addressTextBox.Text;
            _wareHouse.Name = nameTextBox.Text;
            
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
            WebRequest webRequest = WebRequest.Create("https://localhost:44382/warehouse/Edit/");
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";
            string postData = "{\"Name\":\"" + _wareHouse.Name + "\", \"Adress\":\"" + _wareHouse.Address + "\", \"Id\":\"" + _wareHouse.Id + "\"}";
            using (var streamW = new StreamWriter(webRequest.GetRequestStream()))
            {
                streamW.Write(postData);

                streamW.Flush();
                streamW.Close();

                var response = (HttpWebResponse)webRequest.GetResponse();
            }

        }

        private void viewProductsButton_Click(object sender, EventArgs e)
        {
            Products p = new Products(_wareHouse);
            p.ShowDialog();

        }

        private void viewOrdersButton_Click(object sender, EventArgs e)
        {
            Orders p = new Orders(_wareHouse);
            p.ShowDialog();
        }
    }
}
