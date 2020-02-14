using System.Collections.Generic;


namespace MongocinDesktop.Models
{
    public class TransferRequest:IStatefull
    {
        #region Attributes

       
        private string _id;

       
        private string _shopId;

       
        private string _storageId;

       
        private ProductListElement[] _productList;

        #endregion

        #region Properties

       
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        
        public string ShopId
        {
            get { return _shopId; }
            private set { _shopId = value; }
        }

       
        public string StorageId
        {
            get { return _storageId; }
            private set { _storageId = value; }
        }

       
        public ProductListElement[] ProductList
        {
            get { return _productList; }
            private set { _productList = value; }
        }


        public StateEnum State { get; set; }

        #endregion

    }
}