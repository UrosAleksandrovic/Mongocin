﻿using MongocinAPI.App_Start;
using MongoDB.Driver;
using MongocinAPI.Models;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace MongocinAPI.Services
{
    public class TransferService
    {
        private MongoDBContext _dbContext;
        private IMongoCollection<TransferRequest> _transferRequestCollection;

        public TransferService()
        {
            _dbContext = new MongoDBContext();
            _transferRequestCollection = _dbContext.Database.GetCollection<TransferRequest>
                (ConfigurationManager.AppSettings["RequestCollectionName"]);
        }

        public TransferRequest GetTransferRequest(string transferRequestId)
        {
            try
            {
                FilterDefinition<TransferRequest> Filer = Builders<TransferRequest>.Filter.Eq("Id", transferRequestId);
                List<TransferRequest> Results = _transferRequestCollection.Find(Filer).ToList();
                if (Results.Count == 0)
                    return null;

                return Results.First();
            }
            catch
            {
                return null;
            }
        }

        public bool InsertTransferRequest(TransferRequest transferRequest)
        {
            try
            {
                if (_transferRequestCollection == null)
                    return false;

                transferRequest.Id = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
                TransferRequest prevTransferRequest = GetTransferRequest(transferRequest.Id.ToString());
                if (prevTransferRequest == null)
                {
                    _transferRequestCollection.InsertOne(transferRequest);
                    return true;
                }
                else return false;
            }
            catch
            {
                return false;
            }

        }

        public bool DeleteTransfer(string transferRequestId)
        {
            try
            {
                if (_transferRequestCollection == null || GetTransferRequest(transferRequestId) == null)
                    return false;
                _transferRequestCollection.DeleteOne(Builders<TransferRequest>.Filter.Eq("Id", transferRequestId));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateTransferRequest(TransferRequest transferRequest)
        {
            try
            {
                if (_transferRequestCollection == null || GetTransferRequest(transferRequest.Id.ToString()) == null)
                    return false;
                UpdateDefinition<TransferRequest> UpdateTransferRequest = Builders<TransferRequest>.Update
                    .Set("ShopId", transferRequest.ShopId)
                    .Set("StorageId", transferRequest.StorageId)
                    .Set("State",transferRequest.State);
                _transferRequestCollection.UpdateOne(Builders<TransferRequest>.Filter.Eq("Id", transferRequest.Id.ToString()), UpdateTransferRequest);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}