using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace MongocinAPI.Models
{

    [BsonKnownTypes(typeof(Receipt),typeof(Order))]
    public class Bill
    {
        #region Attributes

        [BsonElement("Cost")]
        private double _fullCost;

        [BsonElement("Products")]
        private ProductListElement[] _productList;

        [BsonElement("Date")]
        private DateTime _dateOfBill;

        #endregion

        #region Properties

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonIgnore]
        public double FullCost
        {
            get 
            {/*
                if (_fullCost == default(double))
                {
                    _fullCost = 0;
                    foreach (Product SingleProduct in _productList)
                    {
                        _fullCost += SingleProduct.Value;
                    }
                }*/
                return _fullCost;
            }
            set { _fullCost = value; }
        }

        [BsonIgnore]
        public ProductListElement[] ProductList
        {
            get { return _productList; }
            set { _productList = value; }
        }

        [BsonIgnore]
        public DateTime DateOfBill
        {
            get { return _dateOfBill; }
            set { _dateOfBill = value; }
        }

        #endregion

        #region Methodes

        /* public void AddProduct(Product NewProduct)
         {
             if(this._productList == null)
                 _productList = new List<Product>();

             this._productList.Add(NewProduct);
             FullCost += NewProduct.Value;
         }

         public void DeleteProduct(string ProductId)
         {
             if (this._productList == null)
                 return;
             this._productList.RemoveAt(this._productList.FindIndex(SingleProduct => SingleProduct.ID == ProductId));
         }
         */
        #endregion

    }
}