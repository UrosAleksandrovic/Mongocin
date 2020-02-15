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
    public partial class ViewTransferRequest : Form
    {
        Shop shop;
        List<TransferRequest> transfers = new List<TransferRequest>();
        string selectedTransferID;
        public ViewTransferRequest(Shop shop)
        {
            InitializeComponent();
            this.shop = shop;
        }

        private void ViewTransferRequest_Load(object sender, EventArgs e)
        {
            PopulateInfos();
        }

        private void PopulateInfos()
        {
            GetAllTransfers();

        }
        private void GetAllTransfers()
        {
            var webRequest = WebRequest.Create("https://localhost:44382/TransferRequest/GetAllRequests/5") as HttpWebRequest;
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
                    transfers = JsonConvert.DeserializeObject<List<TransferRequest>>(contributorsAsJson);


                }
            }
        }
    }
}
